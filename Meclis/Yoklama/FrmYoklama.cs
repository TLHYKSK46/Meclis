using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisDao.MessageDialogs;
using MeclisDao.Utils;
using MeclisEntities.Entities;
using System;

using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Meclis.Yoklama
{
    public partial class FrmYoklama : Form
    {
        IOturumService _oturumService;
        IYoklamaService _yoklamaService;
        IMazeretTanimService _mazeretTanimService;
        IMazeretService _mazeretService;
        IVekilTanimService _vekilTanimService;
        public FrmYoklama()
        {
            InitializeComponent();
            _oturumService = InstanceFactory.GetInstance<IOturumService>();
            _yoklamaService = InstanceFactory.GetInstance<IYoklamaService>();
            _mazeretTanimService = InstanceFactory.GetInstance<IMazeretTanimService>();
            _mazeretService = InstanceFactory.GetInstance<IMazeretService>();
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();

        }

        private void FrmYoklamaEski_Load(object sender, EventArgs e)
        {
            oturumVekilDoldur();
            YoklamaGridDoldur();
        }


        #region Oturumlar

        #endregion
        private void btnSistemdenIsle_Click(object sender, EventArgs e)
        {

        }
        private void btnMazeretSec_Click(object sender, EventArgs e)
        {
            var file = OpenFileSvc.OpenFileToExcel(txtMazeret.Text);
            txtMazeret.Text = file.FileName;
           
        }
        private void btnMazeretKaydet_Click(object sender, EventArgs e)
        {
            dtGridMazeret.DataSource = ExcelImport.ExcelYukle(txtMazeret.Text).DataSource;

            for (int i = 1; i < dtGridMazeret.Rows.Count; i++)
            {
                var il = dtGridMazeret.Rows[i].Cells[0].Value ?? "";
                var soyad = dtGridMazeret.Rows[i].Cells[1].Value ?? "";
                var ad = dtGridMazeret.Rows[i].Cells[2].Value ?? "";
                var mazeret = dtGridMazeret.Rows[i].Cells[3].Value ?? "";


                _mazeretService.Ekle(new Mazeret
                {
                    AdSoyad = ad + " " + soyad,
                    Il = (string)il,
                    MazeretNedeni = (string)mazeret,
                });

                //var query = @"Insert into Mazeret(Il,AdSoyad,Mazaret,Tarih)values(@Il,@AdSoyad,@Mazaret,@Tarih);";
                //using (var cmd = new SqlCommand(query, con))
                //{
                //    cmd.Parameters.Add("@Il", SqlDbType.NVarChar).Value = il;
                //    cmd.Parameters.Add("@AdSoyad", SqlDbType.NVarChar).Value = ad + " " + soyad;
                //    cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = dtOturum.Value.Date;
                //    cmd.Parameters.Add("@Mazaret", SqlDbType.NVarChar).Value = mazeret;
                //    cmd.ExecuteNonQuery();
                //}
            }
        }
        private void BtnYoklamaKaydet_Click(object sender, EventArgs e)
        {

            dtGridYoklama.DataSource = ExcelImport.ExcelYukle(txtDosya.Text).DataSource;
            int oturumid = -1;
            _oturumService.Ekle(new Oturum
            {
                OturumAdi = txtOturum.Text,
                OturumZamani = dtOturum.Value.Date
            });
            oturumid = (_oturumService.SonKayitId());
            for (int i = 1; i < dtGridYoklama.Rows.Count; i++)
            {
                var il = dtGridYoklama.Rows[i].Cells[0].Value ?? "";
                var soyad = dtGridYoklama.Rows[i].Cells[1].Value ?? "";
                var ad = dtGridYoklama.Rows[i].Cells[2].Value ?? "";
                var parti = dtGridYoklama.Rows[i].Cells[3].Value ?? "";
                var katildiStr = dtGridYoklama.Rows[i].Cells[4].Value;
                bool katildi = false;
                if (katildiStr != null)
                {
                    katildiStr = katildiStr.ToString().ToLower();
                    if (katildiStr.Equals("kabul"))
                        katildi = true;
                    //if (katildiStr.Equals("anwesend"))
                    //    katildi = true;
                }
                var pusulali = dtGridYoklama.Rows[i].Cells[5].Value ?.Equals("1");
                if (parti.Equals("Adalet ve Kalkınma Partisi"))
                {
                    // query = @"Insert into Yoklama(OturumId,Il,AdSoyad,Katildi,Pusulali)values(@OturumId,@Il,@AdSoyad,@Katildi,@Pusulali);";
                    _yoklamaService.Ekle(new MeclisEntities.Entities.Yoklama { 
                        OturumId=oturumid,
                    AdSoyad=ad+" "+soyad,
                    Il= (string)il,
                    Katildi=katildi,
                    Pusulali= (bool)pusulali,
                    });
                }
            
            }
            oturumVekilDoldur();
            YoklamaGridDoldur();
            MesajGoster.Basarili("Excel Aktarım Başarılı!");
        }
        private void YoklamaGridDoldur()
        {
            var oturumid = _oturumService.SonKayitId();
            var oturum = _oturumService.Getir(oturumid);
            dtGridYoklama.DataSource = _yoklamaService.FiltreleGetir(oturumid).Select(p=> new {
            p.Id,
            Oturum=oturum.OturumAdi,
            p.AdSoyad,
            p.Il,
            p.Katildi,
            p.Pusulali,
            p.Mazeret,
            }).ToList();
    

        }
        private void oturumVekilDoldur() {
            cbOturumVekil.DataSource = _oturumService.ListeGetir();
            cbOturumVekil.DisplayMember = "OturumAdi";
            cbOturumVekil.ValueMember = "Id";
        
        }
        private void BtnYoklamaSec_Click(object sender, EventArgs e)
        {
            var file = OpenFileSvc.OpenFileToExcel(txtDosya.Text);
            txtDosya.Text = file.FileName;
       
            //if (file.ShowDialog() == DialogResult.OK)
     
           // dtGridYoklama.DataSource=file;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            var data=dgGridVekilList.DataSource;
            //  string oturumid =cbOturumVekil;
            if (cbDurumVekil.Text.Equals("Katılanlar"))
            {
                data = (from y in _yoklamaService.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join vt in _vekilTanimService.ListeGetir() on y.AdSoyad equals vt.Ad + " " + vt.Soyad
                        where y.Katildi == true && o.Id == Convert.ToInt32(cbOturumVekil.SelectedValue)
                        select new
                        {

                            y.Id,
                            y.AdSoyad,
                            vt.KisiselTelNo,
                            y.Katildi,
                            Katılım = (
                           y.Katildi.Equals(true) ? "Katıldı" :
                           y.Katildi.Equals(false) ? "Katılmadı" : "Hatalı"
                           ),
                            y.Pusulali,
                            Pusulalı = (
                                            y.Pusulali.Equals(true) ? "Evet" :
                                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                                            )


                        }).ToList();


            }
            else if (cbDurumVekil.Text.Equals("Katılmayanlar"))
            {
                data = (from y in _yoklamaService.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join vt in _vekilTanimService.ListeGetir() on y.AdSoyad equals vt.Ad + " " + vt.Soyad
                        where y.Katildi == false && o.Id == Convert.ToInt32(cbOturumVekil.SelectedValue)
                        select new
                        {

                            y.Id,
                            y.AdSoyad,
                            vt.KisiselTelNo,
                            y.Katildi,
                            Katılım = (
                           y.Katildi.Equals(true) ? "Katıldı" :
                           y.Katildi.Equals(false) ? "Katılmadı" : "Hatalı"
                           ),
                            y.Pusulali,
                            Pusulalı = (
                                            y.Pusulali.Equals(true) ? "Evet" :
                                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                                            )


                        }).ToList();
            }
            else if (cbDurumVekil.Text.Equals("Tümü"))
            {
                data = (from y in _yoklamaService.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join vt in _vekilTanimService.ListeGetir() on y.AdSoyad equals vt.Ad + " " + vt.Soyad
                        where o.Id == Convert.ToInt32(cbOturumVekil.SelectedValue)
                        select new
                        {

                            y.Id,
                            y.AdSoyad,
                            vt.KisiselTelNo,
                            y.Katildi,
                            Katılım = (
                           y.Katildi.Equals(true) ? "Katıldı" :
                           y.Katildi.Equals(false) ? "Katılmadı" : "Hatalı"
                           ),
                            y.Pusulali,
                            Pusulalı = (
                                            y.Pusulali.Equals(true) ? "Evet" :
                                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                                            )


                        }).ToList();
            }

            else if (cbDurumVekil.Text.Equals("Mazeretli"))
            {
                //data = (from y in _yoklamaService.ListeGetir()
                //        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                //        join m in _mazeretService.ListeGetir() on y.AdSoyad equals m.AdSoyad 
                //        //join vt in _vekilTanimService.ListeGetir() on y.AdSoyad equals vt.Ad+" "+vt.Soyad
                //        where y.OturumId.Equals(cbOturumVekil.SelectedValue) && y.Katildi.Equals(false) && 
                //        (from m1 in _mazeretService.ListeGetir() where m1.AdSoyad==y.AdSoyad && y.Il==m1.Il && o.OturumZamani==m1.EklenmeTarihi ).ToList()
                //        select new
                //        {
                //            y.Il,
                //            y.AdSoyad,
                //            // vt.KisiselTelNo,
                //            m.MazeretNedeni,
                //            y.Katildi,
                //            Katılım = (
                //        y.Katildi.Equals(true) ? "Katıldı" :
                //        y.Katildi.Equals(false) ? "Katılmadı" : "Hatalı"
                //            ),
                //            y.Pusulali,
                //            Pusulalı = (
                //            y.Pusulali.Equals(true) ? "Evet" :
                //            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                //            )
                //        }
                //           ).ToList();
            }

            dgGridVekilList.DataSource = data;
            //dgGridVekilList.Columns[3].Visible = false;
            //dgGridVekilList.Columns[5].Visible = false;

            //var query = "";
            //if (cmbDurum.Text.Equals("Katılanlar"))
            //{
            //    query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Katildi=1 then 'Katıldı' else 'Katılmadı' end) Katılım,
            //    (case when s1.Pusulali=1 then 'Evet' else 'Hayır' end) Pusulalı
            //    from Yoklama s1 "
            //              + "  join Oturum o on s1.OturumId = o.Id "
            //              + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il "
            //              + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih "
            //              + "  where s1.OturumId = " + cmbOturum.SelectedValue + " and s1.Katildi = 1 ";
            //}
            //else if (cmbDurum.Text.Equals("Katılmayanlar"))
            //{
            //    query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Katildi=1 then 'Katıldı' else 'Katılmadı' end) Katılım from Yoklama s1 "
            //            + "  join Oturum o on s1.OturumId = o.Id "
            //            + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il "
            //            + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih "
            //            + "  where s1.OturumId = " + cmbOturum.SelectedValue + " and s1.Katildi = 0 and not exists(select * from Mazeret m1 where m1.AdSoyad=s1.AdSoyad and s1.Il = m1.Il   and o.OturumZamani = m1.Tarih ) ";
            //}
            //else if (cmbDurum.Text.Equals("Mazeretli"))
            //{
            //    query = "select s1.Il,s1.AdSoyad,v.CepNo,m.Mazaret Mazeret,(case when s1.Katildi=1 then 'Katıldı' else 'Katılmadı' end) Katılım from Yoklama s1 "
            //            + "  join Oturum o on s1.OturumId = o.Id "
            //            + "  left join Vekil v on s1.AdSoyad = v.AdSoyad and s1.Il = v.Il "
            //            + "  left join Mazeret m on s1.AdSoyad = m.AdSoyad and s1.Il = m.Il   and o.OturumZamani = m.Tarih "
            //            + "  where s1.OturumId = " + cmbOturum.SelectedValue + " and s1.Katildi = 0 and exists(select * from Mazeret m1 where m1.AdSoyad=s1.AdSoyad and s1.Il = m1.Il   and o.OturumZamani = m1.Tarih ) ";
            //}

            //var dataAdapter = new SqlDataAdapter(query, con);

            //var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //var ds = new DataSet();
            //dataAdapter.Fill(ds);
            //dataGridView4.ReadOnly = true;
            //dataGridView4.DataSource = ds.Tables[0];
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            ExcelExport.ExcelAktar(dgGridVekilList);
        }
    }
}
