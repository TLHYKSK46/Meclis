using MeclisDao.Enums;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisDao.MessageDialogs;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meclis.SabitTanimlar
{
    public partial class FrmVekilTanim : Form
    {
        private IVekilTanimService _vekilTanimService;
        private IDilTanimService _dilTanimService;
        private IVekilDilTanimService _vekilDilTanimService;
        private IIlTanimService _ilTanimService;
        private IPartiTanimService _partiTanimService;
        private IPartiGrupTanimService _partiGrupTanimService;
        private IDonemTanimService _donemTanimService;
        private IDostlukGrupTanimService _dostlukGrupTanimService;
        private IMeclisGorevTanimService _meclisGorevTanimService;
        private IGenelMerkezGorevService _genelMerkezGorevService;
        private IMeslekTanimService _meslekTanimService;
        
        public FrmVekilTanim()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

           
         
          
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();
            _partiTanimService = InstanceFactory.GetInstance<IPartiTanimService>();
            _partiGrupTanimService = InstanceFactory.GetInstance<IPartiGrupTanimService>();
            _donemTanimService = InstanceFactory.GetInstance<IDonemTanimService>();
            _dostlukGrupTanimService = InstanceFactory.GetInstance<IDostlukGrupTanimService>();
            _meclisGorevTanimService = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _genelMerkezGorevService = InstanceFactory.GetInstance<IGenelMerkezGorevService>();
            _meslekTanimService = InstanceFactory.GetInstance<IMeslekTanimService>();


            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();
             // TumunuListele();
            cbDogumYeriDoldur();
            CinsiyetDoldur();
            cbMeslekDoldur();
            cbilDoldur();
            cbMeclisGorevDoldur();
            cbGenelMerkezGorevDoldur();
            cbDostlukGrupDoldur();
            cbPartiDoldur();
            cbPartiGrupDoldur();
            cbDonemDoldur();
            bindingSource1.DataSource = dgListe.DataSource;
            //bindingNavigator1.BindingSource = bindingSource1;
            dgListe.AllowUserToAddRows = false;



        }
        private void FrmVekilTanim_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //  await Task.WaitAll(TumunuListele(), cbDogumYeriDoldur(), CinsiyetDoldur());
        }
        #region CRUD
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Form frm = new FrmVekilDetay();
         
            string tcKimlikNo = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);

            string kurumsalTel = txtKurumsalTelNo.Text;
            string kisiselTel = txtKisiselTelNo.Text;
            string kurumsalMail = txtKurumsalMail.Text;
            string kisiselMail = txtKisiselMail.Text;
            string aciklama = txtAciklama.Text;
            string ozgecmis = txtOzGecmis.Text;
            bool aktif = chkAktif.Checked;
            DateTime dogumtarihi = dtDogumTarihi.Value;
            string dogumyeri = cbDogumYeri.SelectedText;
            dogumtarihi.ToString("MMM/dd/yyy");


            if (tcKimlikNo != null && ad != null & soyad != null)
            {
                try
                {
                    _vekilTanimService.Ekle(new VekilTanim
                    {
                        Foto=ConvertImageToBaytes(pbFoto.Image),
                        TcKimlikNo = tcKimlikNo,
                        Ad = ad,
                        Soyad = soyad,
                        CinsiyetTanimId = cinsiyet,
                        KurumsalTelNo = kurumsalTel,
                        KurumsalMail = kurumsalMail,
                        Kisiselmail = kisiselMail,
                        KisiselTelNo = kisiselTel,
                        Aciklama = aciklama,
                        Aktif = aktif,
                        Ozgecmis = ozgecmis,
                        DogumTarihi = dogumtarihi,
                        DogumYeri = dogumyeri,

                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    //frm.vekilId = _vekilTanimService.Getir(5);
                   //    frm.Show();
                    
                    TumunuListele();
                    txtTemizle();

                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Program");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Doldurulması Zorunlu Alanların Boş Olmadığından Emin Olunuz!", "Sistem");
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool msg = MesajGoster.Uyari("Güncellemek İstediğinizden Eminmisiniz?");

            string tcKimlikNo = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            string kurumsalTel = txtKurumsalTelNo.Text;
            string kisiselTel = txtKisiselTelNo.Text;
            string kurumsalMail = txtKurumsalMail.Text;
            string kisiselMail = txtKisiselMail.Text;
            string aciklama = txtAciklama.Text;
            string ozgecmis = txtOzGecmis.Text;
            DateTime dogumtarihi = dtDogumTarihi.Value;
            string dogumyeri = cbDogumYeri.SelectedText;
            dogumtarihi.ToString("MMM/dd/yyy");
            bool aktif = chkAktif.Checked;
            if (msg == true)
            {
                if (tcKimlikNo != null && ad != null && soyad != null && Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value) > 0)
                {
                    try
                    {
                        _vekilTanimService.Guncelle(new VekilTanim
                        {
                            Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                            Foto = ConvertImageToBaytes(pbFoto.Image),
                            TcKimlikNo = tcKimlikNo,
                            Ad = ad,
                            Soyad = soyad,
                            CinsiyetTanimId = cinsiyet,
                            KurumsalTelNo = kurumsalTel,
                            KurumsalMail = kurumsalMail,
                            Kisiselmail = kisiselMail,
                            KisiselTelNo = kisiselTel,
                            Aciklama = aciklama,
                            Aktif = aktif,
                            Ozgecmis = ozgecmis,
                            DogumTarihi = dogumtarihi,
                            DogumYeri = dogumyeri,

                        });
                        MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                        TumunuListele();
                        txtTemizle();
                    }
                    catch (DaoException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Program");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz veya bir kayıt seçiniz !", "Sistem");
                }
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
             bool msg= MesajGoster.Uyari("Silmek İstediğinizden Eminmisiniz?");
            if (msg ==true && dgListe.CurrentRow != null)
            {
                try
                {
                    _vekilTanimService.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                         MesajGoster.Bilgi("Kayıt Başarıyla  Silindi!");

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }
        #endregion
        #region Listeler
        private void TumunuListele()
        {
           dgListe.DataSource = (from vt in _vekilTanimService.ListeGetir()
                                   join il in _ilTanimService.ListeGetir() on vt.IlTanimId equals il.Id
                                   join p in _partiTanimService.ListeGetir() on vt.PartiTanimId equals p.Id
                                   join pg in _partiGrupTanimService.ListeGetir() on  vt.PartiGrupTanimId equals pg.Id
                                   join d in _donemTanimService.ListeGetir() on vt.DonemTanimId equals d.Id
                                   join dg in _dostlukGrupTanimService.ListeGetir() on vt.DostlukGrupTanimId equals dg.Id
                                   join mg in _meclisGorevTanimService.ListeGetir() on vt.MeclisGorevId equals mg.Id
                                   join gm in _genelMerkezGorevService.ListeGetir() on vt.GenelMerkezGorevId equals gm.Id
                                   join mt in _meslekTanimService.ListeGetir() on  vt.MeslekTanimId equals mt.Id
                                   join c in Enum.GetValues(typeof(Cinsiyet)).Cast<Cinsiyet>() on vt.CinsiyetTanimId equals c.GetHashCode()
                                  select new
                                  {
                                      vt.Id,
                                      vt.TcKimlikNo,
                                      vt.Ad,
                                      vt.Soyad,
                                      Cinsiyet=c.ToString(),
                                      vt.KurumsalTelNo,
                                      vt.KisiselTelNo,
                                      vt.KurumsalMail,
                                      vt.Kisiselmail,
                                      DoğumTarihi = vt.DogumTarihi.ToString("MMM/dd/yyy"),
                                      vt.DogumYeri,
                                      vt.Ozgecmis,
                                      vt.Aciklama,
                                      vt.Aktif,
                                      Il=il.IlAdi,
                                      p.PartiAdi,
                                      pg.PartiGrupAdi,
                                      d.DonemAdi,
                                      dg.DostlukGrupAdi,
                                      mg.MeclisGorevAdi,
                                      gm.GenelMerkezGorevAdi,
                                      mt.MeslekAdi,
                                      mt.UzmanlikAlani,
                                      vt.Foto
                                  }
                                 ).ToList();
            dgListe.Columns[22].Visible = false;


            for (int i = 0; i < dgListe.Columns.Count; i++)
                if (dgListe.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgListe.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTcKimlikNo.Text = dgListe.CurrentRow.Cells[1].Value.ToString()?? " ";
                txtAd.Text = dgListe.CurrentRow.Cells[2].Value.ToString() ?? " ";
                txtSoyad.Text = dgListe.CurrentRow.Cells[3].Value.ToString() ?? " ";
                cbCinsiyet.Text = dgListe.CurrentRow.Cells[4].Value.ToString() ?? " ";
                txtKurumsalTelNo.Text = dgListe.CurrentRow.Cells[5].Value.ToString() ??  "  ";
                txtKisiselTelNo.Text = dgListe.CurrentRow.Cells[6].Value.ToString() ?? " ";
                txtKurumsalMail.Text = dgListe.CurrentRow.Cells[7].Value.ToString() ?? " ";
                txtKisiselMail.Text = dgListe.CurrentRow.Cells[8].Value.ToString() ?? " ";
                dtDogumTarihi.Value = Convert.ToDateTime(dgListe.CurrentRow.Cells[9].Value);
                cbDogumYeri.Text = dgListe.CurrentRow.Cells[10].Value.ToString() ?? " ";
                txtOzGecmis.Text = dgListe.CurrentRow.Cells[11].Value.ToString() ?? " ";
                txtAciklama.Text = dgListe.CurrentRow.Cells[12].Value.ToString() ?? " ";
                chkAktif.Checked = Convert.ToBoolean(dgListe.CurrentRow.Cells[13].Value);
                cbil.Text = dgListe.CurrentRow.Cells[14].Value.ToString() ?? " ";
                cbParti.Text = dgListe.CurrentRow.Cells[15].Value.ToString() ?? " ";
                cbPartiGrup.Text = dgListe.CurrentRow.Cells[16].Value.ToString() ?? " ";
                cbDostlukGrup.Text = dgListe.CurrentRow.Cells[17].Value.ToString() ?? " ";
                cbMeclisGorev.Text = dgListe.CurrentRow.Cells[18].Value.ToString() ?? " ";
                cbGenelMerkezGorev.Text = dgListe.CurrentRow.Cells[19].Value.ToString() ?? " ";
                cbMeslek.Text = dgListe.CurrentRow.Cells[20].Value.ToString() ?? "";
                txtMeslekUzmanlikAlani.Text = dgListe.CurrentRow.Cells[21].Value.ToString() ?? " ";
                if (dgListe.CurrentRow.Cells[22].Value==null || dgListe.CurrentRow.Cells[22].Value==" ")
                {
                    pbFoto.Image = ConvertByteArrayImage((byte[])dgListe.CurrentRow.Cells[22].Value);

                }
            }
            catch (DaoException ex)
            {
                MessageBox.Show("Bazı Veriler eksik yada hatalı! Hata mesajı:"+ex.Message.ToString(), "Program");


            }




        }
        private  void cbMeslekDoldur()
        {
            cbMeslek.DataSource = _meslekTanimService.ListeGetir();
            cbMeslek.DisplayMember = "MeslekAdi";
            cbMeslek.ValueMember = "Id";

        }
        private  void cbGenelMerkezGorevDoldur()
        {
            cbGenelMerkezGorev.Text=("Seçiniz");
            cbGenelMerkezGorev.DataSource = _genelMerkezGorevService.ListeGetir();
            cbGenelMerkezGorev.DisplayMember = "GenelMerkezGorevAdi";
            cbGenelMerkezGorev.ValueMember = "Id";

        }
        private  void cbMeclisGorevDoldur()
        {
            cbMeclisGorev.DataSource = _meclisGorevTanimService.ListeGetir();
            cbMeclisGorev.DisplayMember = "MeclisGorevAdi";
            cbMeclisGorev.ValueMember = "Id";

        }
        private  void cbDostlukGrupDoldur()
        {
            cbDostlukGrup.DataSource = _dostlukGrupTanimService.ListeGetir();
            cbDostlukGrup.DisplayMember = "DostlukGrupAdi";
            cbDostlukGrup.ValueMember = "Id";

        }
        private  void cbDonemDoldur()
        {
            cbDonem.DataSource = _donemTanimService.ListeGetir();
            cbDonem.DisplayMember = "DonemAdi";
            cbDonem.ValueMember = "Id";

        }
        private  void cbPartiGrupDoldur()
        {
            cbPartiGrup.DataSource = _partiGrupTanimService.ListeGetir();
            cbPartiGrup.DisplayMember = "PartiGrupAdi";
            cbPartiGrup.ValueMember = "Id";

        }
        private  void cbPartiDoldur()
        {
            cbParti.DataSource = _partiTanimService.ListeGetir();
            cbParti.DisplayMember = "PartiAdi";
            cbParti.ValueMember = "Id";

        }
        private  void cbilDoldur()
        {
            cbil.DataSource = _ilTanimService.ListeGetir();
            cbil.DisplayMember = "IlAdi";
            cbil.ValueMember = "Id";

        }
        private  void cbDogumYeriDoldur()
        {
            cbDogumYeri.DataSource = _ilTanimService.ListeGetir();
            cbDogumYeri.DisplayMember = "IlAdi";
            cbDogumYeri.ValueMember = "Id";

        }
        private void CinsiyetDoldur()
        {

            cbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            //cbCinsiyet.DisplayMember = "Key";
            //cbCinsiyet.ValueMember = "Value";

        }
        #endregion
        private void txtTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKisiselMail.Text = "";
            txtKurumsalMail.Text = "";
            txtKisiselTelNo.Text = "";
            txtKurumsalTelNo.Text = "";
            txtOzGecmis.Text = "";
            txtTcKimlikNo.Text = "";
            cbDogumYeri.Text = "";
            dtDogumTarihi.Text = "";


        }
        #region fotograf yükleme işlemleri
        Byte[] ConvertImageToBaytes(Image img) {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        
        }
        public  Image ConvertByteArrayImage(byte[] data) {

            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }

        private  void btnFotoYukle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(ofd.FileName);
                   // txtDosyaAdi.Text = ofd.FileName;// textbox içerisine dosya yolunu yazması için.
                }
            }
        }
        #endregion
        private void btnListele_Click(object sender, EventArgs e)
        {
             TumunuListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
          
                dgListe.DataSource=_vekilTanimService.AdGoreGetir(txtAra.Text.ToString());
                //TumunuListele();
            }
            else
            {
                TumunuListele();
            }
        }


        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
