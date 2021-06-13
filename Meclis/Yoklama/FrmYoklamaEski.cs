using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisDao.Utils;
using MeclisEntities.Entities;
using System;

using System.Data;
using System.Data.OleDb;

using System.Windows.Forms;

namespace Meclis.Yoklama
{
    public partial class FrmYoklamaEski : Form
    {
        IOturumService _oturumService;
        IYoklamaService _yoklamaService;
        public FrmYoklamaEski()
        {
            InitializeComponent();
            _oturumService = InstanceFactory.GetInstance<IOturumService>();
            _yoklamaService = InstanceFactory.GetInstance<IYoklamaService>();
        }

        private void FrmYoklamaEski_Load(object sender, EventArgs e)
        {

        }

       
        #region Oturumlar

        #endregion

        private void btnMazeretSec_Click(object sender, EventArgs e)
        {

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
                var katildiStr = dtGridYoklama.Rows[i].Cells[6].Value;
                bool katildi = false;
                if (katildiStr != null)
                {
                    katildiStr = katildiStr.ToString().ToLower();
                    if (katildiStr.Equals("anwesend"))
                        katildi = true;
                }
                  var pusulali = dtGridYoklama.Rows[i].Cells[9].Value ?.Equals("1");
                if (parti.Equals("Adalet ve Kalkınma Partisi"))
                {
                    // query = @"Insert into Yoklama(OturumId,Il,AdSoyad,Katildi,Pusulali)values(@OturumId,@Il,@AdSoyad,@Katildi,@Pusulali);";
                    _yoklamaService.Ekle(new MeclisEntities.Entities.Yoklama { 
                        OturumId=oturumid,
                    AdSoyad=ad+" "+soyad,
                    Il= (string)il,
                    Katildi=katildi=(pusulali??false) ||katildi,
                    Pusulali= (bool)pusulali,
                    });
                }
            }
        }

        private void BtnYoklamaSec_Click(object sender, EventArgs e)
        {
            var file = OpenFileSvc.OpenFileToExcel(txtDosya.Text);
            txtDosya.Text = file.FileName;
       
            //if (file.ShowDialog() == DialogResult.OK)
     
           // dtGridYoklama.DataSource=file;
        }
    }
}
