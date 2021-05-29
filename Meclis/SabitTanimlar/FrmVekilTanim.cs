using MeclisDao.Enums;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private IDilSeviyeTanimService _dilSeviyeTanimService;
        private IIlTanimService _ilTanimService;

        public FrmVekilTanim()
        {
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();
            _vekilDilTanimService = InstanceFactory.GetInstance<IVekilDilTanimService>();
            _dilSeviyeTanimService = InstanceFactory.GetInstance<IDilSeviyeTanimService>();
            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();
            InitializeComponent();
            TumunuListele();
            cbDogumYeriDoldur();
            CinsiyetDoldur();
        }

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
                        frm.Show();
                    
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


        private void FrmVekilTanim_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
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
            if (tcKimlikNo != null && ad != null & soyad != null)
            {
                try
                {
                    _vekilTanimService.Guncelle(new VekilTanim
                    {
                        Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        TcKimlikNo = tcKimlikNo,
                        Ad = ad,
                        Soyad = soyad,
                        CinsiyetTanimId=cinsiyet,
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
                MessageBox.Show("Lütfen Doldurulması Zorunlu Alanların Boş Olmadığından Emin Olunuz!", "Sistem");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
        private void TumunuListele()
        {
            dgListe.DataSource = (from vt in _vekilTanimService.ListeGetir()
                                  join vdt in _vekilDilTanimService.ListeGetir() on vt.Id equals vdt.VekilTanimId
                                  join dt in _dilTanimService.ListeGetir() on vdt.DilTanimId equals dt.Id
                                  join ds in _dilSeviyeTanimService.ListeGetir() on vdt.DilSeviyeId equals ds.Id
                                  select new
                                  {
                                      vt.Id,
                                      vt.TcKimlikNo,
                                      vt.Ad,
                                      vt.Soyad,
                                      vt.KurumsalTelNo,
                                      vt.KisiselTelNo,
                                      vt.KurumsalMail,
                                      vt.Kisiselmail,
                                      dt.DilAdi,
                                      ds.DilSeviye,
                                     DoğumTarihi= vt.DogumTarihi.ToString("MMM/dd/yyy"),
                                      vt.DogumYeri,
                                      vt.Ozgecmis,
                                      vt.Aciklama,
                                      vt.Aktif
                                  }
                                 ).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTcKimlikNo.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgListe.CurrentRow.Cells[3].Value.ToString();
            txtKurumsalTelNo.Text = dgListe.CurrentRow.Cells[4].Value.ToString();
            txtKisiselTelNo.Text = dgListe.CurrentRow.Cells[5].Value.ToString();
            txtKurumsalMail.Text = dgListe.CurrentRow.Cells[6].Value.ToString();
            txtKisiselMail.Text = dgListe.CurrentRow.Cells[7].Value.ToString();

            dtDogumTarihi.Text = dgListe.CurrentRow.Cells[10].Value.ToString();
            cbDogumYeri.Text = dgListe.CurrentRow.Cells[11].Value.ToString();
            txtOzGecmis.Text = dgListe.CurrentRow.Cells[12].Value.ToString();
            txtAciklama.Text = dgListe.CurrentRow.Cells[13].Value.ToString();
            chkAktif.Checked = Convert.ToBoolean(dgListe.CurrentRow.Cells[14].Value);



        }
    
       
        private void cbDogumYeriDoldur()
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
    }
}
