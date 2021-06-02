using MeclisDao.Enums;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisEntities.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Meclis.SabitTanimlar
{
    public partial class FrmDanismanTanim : Form
    {
        private IDanismanTanimService _danismanTanim;
        private IIlTanimService _ilTanimService;
        private IVekilTanimService _Vekil;
        public FrmDanismanTanim()
        {
            InitializeComponent();
            _danismanTanim = InstanceFactory.GetInstance<IDanismanTanimService>();

            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();
            _Vekil = InstanceFactory.GetInstance<IVekilTanimService>();
        }

        private void FrmDanismanTanim_Load(object sender, EventArgs e)
        {
            TumunuListele();
            VekilDoldur();
            SehirDoldur();
            CinsiyetDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string mail = txtMail.Text;
            string telNo = txtTelNo.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            int il = Convert.ToInt32(cbIl.SelectedValue);
            int vekil = Convert.ToInt32(cbVekilTanim.SelectedValue);
            bool aktif = chkAktif.Checked;

            if ((tcKimlik != null) && (ad != null) && (soyad != null)
                && !(cinsiyet < 0) && !(cinsiyet > 1) && (il != 0))
            {
                try
                {
                    if (tcKimlik.Length != 11)
                        MessageBox.Show("Lütfen Tc Kimlik No alanını kontrol ediniz..(11 karekterden oluşması gerekir!)", "Sistem");

                    _danismanTanim.Ekle(new DanismanTanim
                    {
                        Id=0,
                        TcKimlikNo = tcKimlik,
                        Ad = ad,
                        Soyad = soyad,
                        Mail = mail,
                        TelNo = telNo,
                        CinsiyetTanimId = cinsiyet,
                        IlTanimId = il,
                        VekilTanimId = vekil,
                        Aktif = aktif,
                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Sistem");

                    TumunuListele();
                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Ve Bilgileri Doğru Girdiğinizden Emin Olunuz..", "Sistem");
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string mail = txtMail.Text;
            string telNo = txtTelNo.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            int il = Convert.ToInt32(cbIl.SelectedValue);
            int vekil = Convert.ToInt32(cbVekilTanim.SelectedValue);
            bool aktif = chkAktif.Checked;
            if ((tcKimlik != null) && (ad != null) && (soyad != null)&& !(cinsiyet < 0) && !(cinsiyet > 1) && (il != 0))
            {
                try
                {
                    if (tcKimlik.Length != 11)
                        MessageBox.Show("Lütfen Tc Kimlik No alanını kontrol ediniz..(11 karekterden oluşması gerekir!)", "Sistem");
                    _danismanTanim.Guncelle(new DanismanTanim
                    {
                        Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        TcKimlikNo = tcKimlik,
                        Ad = ad,
                        Soyad = soyad,
                        Mail = mail,
                        TelNo = telNo,
                        CinsiyetTanimId = cinsiyet,
                        IlTanimId = il,
                        VekilTanimId = vekil,
                        Aktif = aktif,
                    });
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı!", "Sistem");
                    TumunuListele();
                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Ve Bilgileri Doğru Girdiğinizden Emin Olunuz..", "Sistem");
            }
        }

        private void txtBosalt()
        {
          txtTcKimlikNo.Text="";
             txtAd.Text="";
             txtSoyad.Text="";
            txtMail.Text="";
            txtTelNo.Text="";
            cbCinsiyet.Text = "";
            cbIl.Text = "";
            cbVekilTanim.Text="";
            chkAktif.Checked=false;
            btnKaydet.Text="Kaydet";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _danismanTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }
        #region Listeler
        //to do Enum Linq Kullanımı
        private void TumunuListele()
        {
        
            dgListe.DataSource = (from dt in _danismanTanim.ListeGetir()
                                  join vt in _Vekil.ListeGetir() on dt.VekilTanimId equals vt.Id
                                  join c in Enum.GetValues(typeof(Cinsiyet)).Cast<Cinsiyet>() on dt.CinsiyetTanimId equals c.GetHashCode()
                                  join i in _ilTanimService.ListeGetir() on dt.IlTanimId equals i.Id
                                  select new
                                  {
                                      dt.Id,
                                      dt.TcKimlikNo,
                                      dt.Ad,
                                      dt.Soyad,
                                      dt.TelNo,
                                      dt.Mail,
                                      VekilTanim = vt.Ad + " " + vt.Soyad,
                                      VekilTanimTC = vt.TcKimlikNo,
                                      cinsiyet=c.ToString(),
                                      i.IlAdi,
                                      dt.Aktif
                                  }).ToList();

        }
        private void CinsiyetDoldur()
        {
            cbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            //cbCinsiyet.DisplayMember = "Key";
            //cbCinsiyet.ValueMember = "Value";
        }
        private void SehirDoldur()
        {
            cbIl.DataSource = _ilTanimService.ListeGetir();
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "Id";
        }
        private void VekilDoldur()
        {
            cbVekilTanim.DataSource = _Vekil.ListeGetir();
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.DisplayMember += "Soyad";
            cbVekilTanim.ValueMember = "Id";


        }
        #endregion
        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTcKimlikNo.Text=dgListe.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text= dgListe.CurrentRow.Cells[3].Value.ToString();
            txtTelNo.Text= dgListe.CurrentRow.Cells[4].Value.ToString();
            txtMail.Text= dgListe.CurrentRow.Cells[5].Value.ToString();
            cbVekilTanim.Text= dgListe.CurrentRow.Cells[6].Value.ToString();
            cbCinsiyet.Text= dgListe.CurrentRow.Cells[8].Value.ToString();
            cbIl.Text= dgListe.CurrentRow.Cells[9].Value.ToString();
            chkAktif.Checked= Convert.ToBoolean(dgListe.CurrentRow.Cells[10].Value);
            cbCinsiyet.DisplayMember = "CinsiyetAdi";
            cbCinsiyet.ValueMember = "Id";
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "Id";
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.DisplayMember += "Soyad";
            cbVekilTanim.ValueMember = "Id";
        }

        private void cbVekilTanim_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((VekilTanim)e.ListItem).Ad;
            string firstname = ((VekilTanim)e.ListItem).Soyad;
            e.Value = lastname + " " + firstname;
        }
    }
}
