using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisDao.MessageDialogs;
using MeclisDao.Utils;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
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
        IVekilYoklamaService _vekilYoklama;
        IIlTanimService _ilTanimService;
        public FrmYoklama()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            _oturumService = InstanceFactory.GetInstance<IOturumService>();
            _yoklamaService = InstanceFactory.GetInstance<IYoklamaService>();
            _mazeretTanimService = InstanceFactory.GetInstance<IMazeretTanimService>();
            _mazeretService = InstanceFactory.GetInstance<IMazeretService>();
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _vekilYoklama = InstanceFactory.GetInstance<IVekilYoklamaService>();
            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();

        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            YoklamaGridDoldur();
            MazeretGridDoldur();
            oturumVekilDoldur();
            cbOturum1Doldur();
          

        }
        private void FrmYoklama_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }



        #region Oturumlar
        private void BtnYoklamaSec_Click(object sender, EventArgs e)
        {
            var file = OpenFileSvc.OpenFileToExcel(txtDosya.Text);
            txtDosya.Text = file.FileName;

            //if (file.ShowDialog() == DialogResult.OK)

            // dtGridYoklama.DataSource=file;
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
                var pusulali = dtGridYoklama.Rows[i].Cells[9].Value?.Equals("1");
                if (parti.Equals("Adalet ve Kalkınma Partisi"))
                {
                    var vekil = _vekilTanimService.AdveSoyadGoreGetir(ad.ToString(), soyad.ToString());
                    //var ildata = _ilTanimService.Getir(vekil.IlTanimId);
                    //string iladi = ildata.IlAdi.ToUpper();
                    //var kontrolil = ildata.IlAdi.ToUpper() == il.ToString() && !(vekil.Id <= 0) ? true : throw new DaoException(ad + " " + soyad + " Vekil Bulunamadı!");
                    if (vekil!=null)
                    {
                        _vekilYoklama.Ekle(new VekilYoklama
                        {
                            VekilTanimId = vekil.Id,
                            OturumId = oturumid,
                            Katildimi = katildi = (pusulali ?? false) || katildi,
                            Pusulali = (bool)pusulali
                        });
                    }
                

                    //_yoklamaService.Ekle(new MeclisEntities.Entities.Yoklama { 
                    //    OturumId=oturumid,
                    //AdSoyad=ad+" "+soyad,
                    //Il= (string)il,
                    //Katildi=katildi=(pusulali??false) ||katildi,
                    //Pusulali= (bool)pusulali,
                    //});
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
            //var a = _vekilYoklama.ListeGetir();
            //var b = _vekilTanimService.ListeGetir();
            //var ss = _oturumService.ListeGetir();
            //var tt = _ilTanimService.ListeGetir();
            dtGridYoklama.DataSource = (from vy in _vekilYoklama.ListeGetir()
                                        join vt in _vekilTanimService.ListeGetir() on vy.VekilTanimId equals vt.Id
                                        join o in _oturumService.ListeGetir() on vy.OturumId equals o.Id
                                        join il in _ilTanimService.ListeGetir() on vt.IlTanimId equals il.Id
                                        select new
                                        {
                                            vy.Id,
                                            AdSoyad = vt.Ad + " " + vt.Soyad,
                                            il.IlAdi,
                                            vy.Katildimi,
                                            vy.Pusulali,
                                            o.OturumAdi,
                                        }
                                        ).ToList();


            //dtGridYoklama.DataSource = _yoklamaService.FiltreleGetir(oturumid).Select(p=> new {
            //p.Id,
            //Oturum=oturum.OturumAdi,
            //p.AdSoyad,
            //p.Il,
            //p.Katildi,
            //p.Pusulali,
            //p.Mazeret,
            //}).ToList();


        }
        #endregion
        #region Mazeret
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
                // var il = dtGridMazeret.Rows[i].Cells[0].Value ?? "";
                var adsoyad = dtGridMazeret.Rows[i].Cells[1].Value ?? "";
                string soyad = ""; /*dtGridMazeret.Rows[i].Cells[1].Value ?? "";*/
                string ad = "";/*dtGridMazeret.Rows[i].Cells[2].Value ?? "";*/
                var mazeret = dtGridMazeret.Rows[i].Cells[3].Value ?? "";
                DateTime basTarih = Convert.ToDateTime(dtGridMazeret.Rows[i].Cells[4].Value.ToString());
                DateTime bitTarih = Convert.ToDateTime(dtGridMazeret.Rows[i].Cells[5].Value);
                var mazeretKodId = dtGridMazeret.Rows[i].Cells[6].Value ?? "";

                mazeretKodId = dtGridMazeret.Rows[i].Cells[7].Value;
                string[] metin = adsoyad.ToString().Split(' ');
                for (int j = 0; j < metin.Length; j++)
                {
                    if (j != metin.Length - 1)
                    {
                        ad += metin[j]+" ";
                    }
                    else
                    {
                        soyad += metin[j];
                    }
                }

                var vekil = _vekilTanimService.AdveSoyadGoreGetir(ad.ToString(), soyad.ToString());
                int id = (int)vekil.Id;
                int mKod = Convert.ToInt32(mazeretKodId);

                _mazeretTanimService.Ekle(new MazeretTanim
                {
                    VekilTanimId = id,
                    MazeretNedeni = mazeret.ToString(),
                    BaslamaTarihi = basTarih,
                    BitisTarihi = bitTarih,
                    MazeretKodId = mKod,

                });

            }
            MesajGoster.Basarili("Excel Aktarım Başarılı!");
            MazeretGridDoldur();
        }
        private void MazeretGridDoldur()
        {
            dtGridMazeret.DataSource = (from m in _mazeretTanimService.ListeGetir()
                                        join vt in _vekilTanimService.ListeGetir() on m.VekilTanimId equals vt.Id
                                        where m.BitisTarihi > DateTime.Now
                                        select new
                                        {
                                            AdSoyad = vt.Ad + " " + vt.Soyad,
                                            vt.KisiselTelNo,
                                            m.MazeretKodId,
                                            m.MazeretNedeni,
                                            m.BaslamaTarihi,
                                            m.BitisTarihi,
                                        }).ToList();
        }
        #endregion
        #region iki oturumdan ilkinde olmayıp ikincisinde olanlar

        private void btn2OturumKarsilastirListele_Click(object sender, EventArgs e)
        {
            var oturum1 = cbOturum1.SelectedValue;
            var oturum2 = cbOturum2.SelectedValue;
            if (oturum1!=null && oturum2 !=null)
            {
                var data = (from y in _vekilYoklama.ListeGetir()
                            join vt in _vekilTanimService.ListeGetir() on y.VekilTanimId equals vt.Id
                            join m in _mazeretTanimService.ListeGetir() on vt.Id equals m.VekilTanimId
                            join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                             where y.OturumId==Convert.ToInt32(oturum2) && y.Katildimi==true && (y.OturumId!=Convert.ToInt32(oturum1) && y.Katildimi==false)
                            select new
                            {
                                AdSoyad = vt.Ad + " " + vt.Soyad,
                                vt.KisiselTelNo,
                                m.MazeretNedeni,
                                y.Katildimi,
                                Katılım = (
                        y.Katildimi.Equals(true) ? "Katıldı" :
                        y.Katildimi.Equals(false) ? "Katılmadı" : "Hatalı"
                            ),
                                y.Pusulali,
                                Pusulalı = (
                            y.Pusulali.Equals(true) ? "Evet" :
                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                            )
                            }).ToList();

                dg2OturumKarsilastir.ReadOnly = true;
                dg2OturumKarsilastir.DataSource=data;

            }
        }
        private void btn2OturumArasiKarsilastirExceleAktar_Click(object sender, EventArgs e)
        {
            ExcelExport.ExcelAktar(dg2OturumKarsilastir);
        }
        private void cbOturum1Doldur() {
            var data = _oturumService.ListeGetir();
            var liste = new List<Oturum>();
            foreach (var item in data)
            {
                //if (item.Id != Convert.ToInt32(cbOturum2.SelectedValue) || cbOturum2.SelectedValue==null)
                //{
                //}

                liste.Add(item);

            }
            cbOturum1.DataSource = liste;
            cbOturum1.DisplayMember = "OturumAdi";
            cbOturum1.ValueMember = "Id";
        }
        private void cbOturum2Doldur() {
            var data= _oturumService.ListeGetir();
           var liste = new List<Oturum>();
            foreach (var item in data)
            {
                liste.Add(item);

                //if (item.Id != Convert.ToInt32(cbOturum1.SelectedValue))
                //{
                //}

             
            }
            cbOturum2.DataSource = liste;
            cbOturum2.DisplayMember = "OturumAdi";
            cbOturum2.ValueMember = "Id";

        }
        private void cbOturum1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbOturum1_SelectedValueChanged(object sender, EventArgs e)
        {
            cbOturum2Doldur();

        }
        #endregion

        #region Vekil Listesi
        private void btnVekilSonucListe_Click(object sender, EventArgs e)
        {
            var data = dgGridVekilList.DataSource;

            if (cbDurumVekil.Text.Equals("Katılanlar"))
            {
                data = (from y in _vekilYoklama.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join vt in _vekilTanimService.ListeGetir() on y.VekilTanimId equals vt.Id
                        join m in _mazeretTanimService.ListeGetir() on y.VekilTanimId equals m.VekilTanimId
                        where y.Katildimi.Equals(true)
                        select new
                        {
                            AdSoyad = vt.Ad + " " + vt.Soyad,
                            vt.KisiselTelNo,
                            m.MazeretNedeni,
                            y.Katildimi,
                            Katılım = (
                        y.Katildimi.Equals(true) ? "Katıldı" :
                        y.Katildimi.Equals(false) ? "Katılmadı" : "Hatalı"
                            ),
                            y.Pusulali,
                            Pusulalı = (
                            y.Pusulali.Equals(true) ? "Evet" :
                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                            )
                        }
                            ).ToList();

            }
            else if (cbDurumVekil.Text.Equals("Katılmayanlar"))
            {
                data = (from y in _vekilYoklama.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join m in _mazeretTanimService.ListeGetir() on y.VekilTanimId equals m.VekilTanimId
                        join vt in _vekilTanimService.ListeGetir() on y.VekilTanimId equals vt.Id

                        where (y.Katildimi.Equals(false))

                        select new
                        {
                            AdSoyad = vt.Ad + " " + vt.Soyad,
                            vt.KisiselTelNo,
                            m.MazeretNedeni,
                            y.Katildimi,
                            Katılım = (
                        y.Katildimi.Equals(true) ? "Katıldı" :
                        y.Katildimi.Equals(false) ? "Katılmadı" : "Hatalı"
                            ),
                            y.Pusulali,
                            Pusulalı = (
                            y.Pusulali.Equals(true) ? "Evet" :
                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                            ),

                        }

                 ).ToList();
            }
            else if (cbDurumVekil.Text.Equals("Mazeretli"))
            {
                data = (from y in _vekilYoklama.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join vt in _vekilTanimService.ListeGetir() on y.VekilTanimId equals vt.Id
                        join m in _mazeretTanimService.ListeGetir() on y.VekilTanimId equals m.VekilTanimId
                        where y.Katildimi.Equals(false) && m.MazeretNedeni != null
                        select new
                        {
                            AdSoyad = vt.Ad + " " + vt.Soyad,
                            vt.KisiselTelNo,
                            m.MazeretNedeni,
                            y.Katildimi,
                            Katılım = (
                        y.Katildimi.Equals(true) ? "Katıldı" :
                        y.Katildimi.Equals(false) ? "Katılmadı" : "Hatalı"
                            ),
                            y.Pusulali,
                            Pusulalı = (
                            y.Pusulali.Equals(true) ? "Evet" :
                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                            )
                        }).ToList();
            }
            else {
                data = (from y in _vekilYoklama.ListeGetir()
                        join o in _oturumService.ListeGetir() on y.OturumId equals o.Id
                        join vt in _vekilTanimService.ListeGetir() on y.VekilTanimId equals vt.Id
                        join m in _mazeretTanimService.ListeGetir() on y.VekilTanimId equals m.VekilTanimId
                      //  where y.Katildimi.Equals(false) && m.MazeretNedeni != null
                        select new
                        {
                            AdSoyad = vt.Ad + " " + vt.Soyad,
                            vt.KisiselTelNo,
                            m.MazeretNedeni,
                            y.Katildimi,
                            Katılım = (
                        y.Katildimi.Equals(true) ? "Katıldı" :
                        y.Katildimi.Equals(false) ? "Katılmadı" : "Hatalı"
                            ),
                            y.Pusulali,
                            Pusulalı = (
                            y.Pusulali.Equals(true) ? "Evet" :
                            y.Pusulali.Equals(false) ? "Hayır" : "Hatalı"
                            )
                        }).ToList();
            }
            dgGridVekilList.ReadOnly = true;
            dgGridVekilList.DataSource = data;
            dgGridVekilList.Columns[3].Visible = false;
            dgGridVekilList.Columns[5].Visible = false;
        }

        private void btnVekilExcelAktar_Click(object sender, EventArgs e)
        {
            ExcelExport.ExcelAktar(dgGridVekilList);

        }
        private void oturumVekilDoldur()
        {
            cbOturumVekil.DataSource = _oturumService.ListeGetir();
            cbOturumVekil.DisplayMember = "OturumAdi";
            cbOturumVekil.ValueMember = "Id";

        }





        #endregion

     
    }
}
