using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace Test
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(Properties.Settings.Default.dbConnection);
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Excel Dosyası Seçiniz";
            f.FileName = txtDosya.Text;
            f.Filter = "Excel Sheet (*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
                txtDosya.Text = f.FileName;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + txtDosya.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter thDataAdapter = new OleDbDataAdapter("Select * from [Sayfa1$]", theConnection);
            DataSet thSd = new DataSet();
            DataTable dt = new DataTable();
            thDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            theConnection.Close();

            int oturumId = -1;

            string query = @"Insert into Oturum(OturumAdi,OturumZamani)values(@OturumAdi,@OturumTarihi);
                            SELECT SCOPE_IDENTITY();";

            using (var objCMD = new OleDbCommand(query, con))
            {
                objCMD.Parameters.Add("@OturumTarihi", OleDbType.Date).Value = dtOturum.Value.Date;
                objCMD.Parameters.Add("@OturumAdi", OleDbType.VarChar).Value = txtOturum.Text;

                con.Open();
                object returnObj = objCMD.ExecuteScalar();

                if (returnObj != null)
                {
                    int.TryParse(returnObj.ToString(), out oturumId);
                }
                con.Close();
            }

            con.Open();
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                var il = dataGridView1.Rows[i].Cells[0].Value ?? "";
                var soyad = dataGridView1.Rows[i].Cells[1].Value ?? "";
                var ad = dataGridView1.Rows[i].Cells[2].Value ?? "";
                var parti = dataGridView1.Rows[i].Cells[3].Value ?? "";
                var katildiStr = dataGridView1.Rows[i].Cells[6].Value;
                bool katildi = false;
                if (katildiStr != null)
                {
                    katildiStr = katildiStr.ToString().ToLower();
                    if (katildiStr.Equals("anwesend"))
                        katildi = true;
                } 
                var pusulali = dataGridView1.Rows[i].Cells[9].Value?.Equals("1");
                if (parti.Equals("Adalet ve Kalkınma Partisi"))
                {

                    query = @"Insert into Yoklama(OturumId,Il,AdSoyad,Katildi,Pusulali)values(@OturumId,@Il,@AdSoyad,@Katildi,@Pusulali);";
                    using (var cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("@OturumId", OleDbType.BigInt).Value = oturumId;
                        cmd.Parameters.Add("@Il", OleDbType.VarChar).Value = il;
                        cmd.Parameters.Add("@AdSoyad", OleDbType.VarChar).Value = ad + " " + soyad;
                        cmd.Parameters.Add("@Katildi", OleDbType.Boolean).Value = (pusulali??false) || katildi; 
                        cmd.Parameters.Add("@Pusulali", OleDbType.Boolean).Value = pusulali;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            con.Close();
            FillOturum();
            FillOturum1();
            FillOturum2();
            MessageBox.Show("İşlem Başarılı", "Sonuç", MessageBoxButtons.OK);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var oturum1 = cmbOturum1.SelectedValue;
            var oturum2 = cmbOturum2.SelectedValue;
            //var query = "select s1.Il,s1.AdSoyad,v.CepNo,s1.Mazeret,(case when s1.Pusulali=1 then 'Pusulalı Katıldı' else '' end) Pusulalı from Yoklama s1 " +
            //             " left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il " +
            //             " where s1.OturumId = " + oturum2 + " and s1.Katildi = 1 and exists(select* from Yoklama m where m.AdSoyad= s1.AdSoyad and m.Il= s1.Il and m.Katildi= 0 and m.OturumId= " + oturum1 + ")";
            var query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Pusulali=1 then 'Pusulalı Katıldı' else '' end) Pusulalı from Yoklama s1  "
                        + "  join Oturum o on s1.OturumId = o.Id "
                        + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il  "
                        + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih  "
                        + "  where s1.OturumId = " + oturum2 + "  and s1.Katildi = 1 "
                        + "  and exists(select* from Yoklama m where m.AdSoyad= s1.AdSoyad and m.Il= s1.Il and m.Katildi= 0 and m.OturumId= " + oturum1 + ")  ";

            var dataAdapter = new OleDbDataAdapter(query, con);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }
        void FillOturum2()
        {
            string date = dtOturum.Value.Date.ToString("yyyy-MM-dd");
            var query = "select OturumAdi, Id from Oturum where CAST(OturumZamani AS DATE) = cast('" + date + "' as DATE)";
            OleDbDataAdapter da = new OleDbDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Oturum");
            cmbOturum.DisplayMember = "OturumAdi";
            cmbOturum.ValueMember = "Id";
            cmbOturum.DataSource = ds.Tables["Oturum"];
            con.Close();
        }
        void FillOturum()
        {
            string connetionString = null;
            OleDbConnection cnn;
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=meclis.mdb;";
            cnn = new OleDbConnection(connetionString);

            string date = dtOturum.Value.Date.ToString("yyyy-MM-dd");
            var query = "select OturumAdi, Id from Oturum where CAST(OturumZamani AS DATE) = cast('"+ date + "' as DATE)";
            cnn.Open();   
           // OleDbDataAdapter da = new OleDbDataAdapter(query, con);

            OleDbDataAdapter da = new OleDbDataAdapter(new OleDbCommand(query, cnn));
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbOturum1.DisplayMember = "OturumAdi";
            cmbOturum1.ValueMember = "Id";
            cmbOturum1.DataSource = ds.Tables["Oturum"];
            cnn.Close();
        }
        void FillOturum1()
        {
            string date = dtOturum.Value.Date.ToString("yyyy-MM-dd");
            var query = "select OturumAdi, Id from Oturum where CAST(OturumZamani AS DATE) = cast('" + date + "' as DATE)";
            con.Open(); 
            OleDbDataAdapter da = new OleDbDataAdapter(query, con);
          
            DataSet ds = new DataSet();
            da.Fill(ds, "Oturum");

            cmbOturum2.DisplayMember = "OturumAdi";
            cmbOturum2.ValueMember = "Id";
            cmbOturum2.DataSource = ds.Tables["Oturum"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillOturum();
            FillOturum1();
            FillOturum2();
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard(dataGridView2);
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard(DataGridView dg)
        {
            dg.SelectAll();
            DataObject dataObj = dg.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnSabit_Click(object sender, EventArgs e)
        {
            //OpenFileDialog f = new OpenFileDialog();
            //f.Title = "Excel Dosyası Seçiniz";
            //f.FileName = txtDosya.Text;
            //f.Filter = "Excel Sheet (*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            //f.FilterIndex = 1;
            //f.RestoreDirectory = true;
            //if (f.ShowDialog() == DialogResult.OK)
            //    txtSabit.Text = f.FileName;
        }

        private void btnSabitKaydet_Click(object sender, EventArgs e)
        {
            //OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + txtSabit.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            //theConnection.Open();
            //OleDbDataAdapter thDataAdapter = new OleDbDataAdapter("Select * from [Sayfa1$]", theConnection);
            //DataSet thSd = new DataSet();
            //DataTable dt = new DataTable();
            //thDataAdapter.Fill(dt);
            //dataGridView3.DataSource = dt.DefaultView;
            //theConnection.Close(); 

            //con.Open();
            //for (int i = 1; i < dataGridView3.Rows.Count; i++)
            //{
            //    var il = dataGridView3.Rows[i].Cells[0].Value ?? "";
            //    var soyad = dataGridView3.Rows[i].Cells[1].Value ?? "";
            //    var ad = dataGridView3.Rows[i].Cells[2].Value ?? "";
            //    var cep = dataGridView3.Rows[i].Cells[3].Value ?? ""; 


            //     var   query = @"Insert into Vekil (Il,AdSoyad,CepNo) values (@Il,@AdSoyad,@Cep);";
            //        using (var cmd = new SqlCommand(query, con))
            //        { 
            //            cmd.Parameters.Add("@Il", SqlDbType.NVarChar).Value = il;
            //            cmd.Parameters.Add("@AdSoyad", SqlDbType.NVarChar).Value = ad + " " + soyad; 
            //            cmd.Parameters.Add("@Cep", SqlDbType.BigInt).Value = cep;

            //            cmd.ExecuteNonQuery();
            //        } 
            //}
            //con.Close();
        }

        private void btnMazeretSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Excel Dosyası Seçiniz";
            f.FileName = txtDosya.Text;
            f.Filter = "Excel Sheet (*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
                txtMazeret.Text = f.FileName;
        }

        private void btnMazeretKaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + txtMazeret.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
            theConnection.Open();
            OleDbDataAdapter thDataAdapter = new OleDbDataAdapter("Select * from [Sayfa1$]", theConnection);
            DataSet thSd = new DataSet();
            DataTable dt = new DataTable();
            thDataAdapter.Fill(dt);
            dataGridView3.DataSource = dt.DefaultView;
            theConnection.Close();

            con.Open();
            for (int i = 1; i < dataGridView3.Rows.Count; i++)
            {
                var adsoyad = dataGridView3.Rows[i].Cells[0].Value ?? "";
                var il = dataGridView3.Rows[i].Cells[1].Value ?? "";
                var mazeret = dataGridView3.Rows[i].Cells[2].Value ?? "";


                var query = @"Insert into Mazeret(Il,AdSoyad,Mazaret,Tarih)values(@Il,@AdSoyad,@Mazaret,@Tarih);";
                using (var cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.Add("@Il", OleDbType.VarChar).Value = il;
                    cmd.Parameters.Add("@AdSoyad", OleDbType.VarChar).Value = adsoyad;
                    cmd.Parameters.Add("@Tarih", OleDbType.Date).Value = dtOturum.Value.Date;
                    cmd.Parameters.Add("@Mazaret", OleDbType.VarChar).Value = mazeret;
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();

        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {

            var query = "";
            if (cmbDurum.Text.Equals("Katılanlar"))
            {
                query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Katildi=1 then 'Katıldı' else 'Katılmadı' end) Katılım,(case when s1.Pusulali=1 then 'Evet' else 'Hayır' end) Pusulalı from Yoklama s1 "
                          + "  join Oturum o on s1.OturumId = o.Id "
                          + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il "
                          + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih "
                          + "  where s1.OturumId = " + cmbOturum.SelectedValue + " and s1.Katildi = 1 ";
            }
            else if (cmbDurum.Text.Equals("Katılmayanlar"))
            {
                query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Katildi=1 then 'Katıldı' else 'Katılmadı' end) Katılım from Yoklama s1 "
                        + "  join Oturum o on s1.OturumId = o.Id "
                        + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il "
                        + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih "
                        + "  where s1.OturumId = " + cmbOturum.SelectedValue + " and s1.Katildi = 0 and not exists(select * from Mazeret m1 where m1.AdSoyad=s1.AdSoyad and s1.Il = m1.Il   and o.OturumZamani = m1.Tarih ) ";
            }
            else if (cmbDurum.Text.Equals("Mazeretli"))
            {
                query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Katildi=1 then 'Katıldı' else 'Katılmadı' end) Katılım from Yoklama s1 "
                        + "  join Oturum o on s1.OturumId = o.Id "
                        + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il "
                        + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih "
                        + "  where s1.OturumId = " + cmbOturum.SelectedValue + " and s1.Katildi = 0 and exists(select * from Mazeret m1 where m1.AdSoyad=s1.AdSoyad and s1.Il = m1.Il   and o.OturumZamani = m1.Tarih ) ";
            }

            var dataAdapter = new OleDbDataAdapter(query, con);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView4.ReadOnly = true;
            dataGridView4.DataSource = ds.Tables[0];
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard(dataGridView4);
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void dtOturum_ValueChanged(object sender, EventArgs e)
        {
            FillOturum();
            FillOturum1();
            FillOturum2();
        }
    }
}
