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
    public partial class FrmGrupPersonelTanim : Form
    {
        private IGrupPersonelTanimService _grupPersonel;
        private IMeclisGorevTanimService _meclisGorevTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IIlTanimService _ilTanim;
        public FrmGrupPersonelTanim()
        {
            InitializeComponent();
            _grupPersonel = InstanceFactory.GetInstance<IGrupPersonelTanimService>();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _ilTanim = InstanceFactory.GetInstance<IIlTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            TumunuListele();
            cbMeclisGorevDoldur();
            cbSehirDoldur();
            cbCinsiyetDoldur();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string sifre = txtSifre.Text;
            string telNo = txtTelNo.Text;
            string mail = txtMail.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            int il = Convert.ToInt32(cbIl.SelectedValue);
            int meclisGorev = Convert.ToInt32(cbMeclisGorev.SelectedValue);
            bool aktif = chkAktif.Checked;
            if (tcKimlikNo != null && ad != null & soyad != null && (cinsiyet > -1) && (cinsiyet < 2) && (!(il < 1) && !(il > 81)) && meclisGorev != 0 && sifre!=null)
            {
                try
                {
                    _grupPersonel.Ekle(new GrupPersonelTanim { 
                    Ad=ad,
                    Aktif=aktif,
                     CinsiyetTanimId=cinsiyet,
                     IlTanimId=il,
                     Mail=mail,
                     MeclisGorevId=meclisGorev,
                     Soyad=soyad,
                     TcKimlikNo=tcKimlikNo,
                     TelNo=telNo,
                     Sifre=sifre
                    });
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(),"Program");
                }
                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.","Sistem");
                TumunuListele();

                textBoşalt();

            }
            else {
                MessageBox.Show("Lütfen Doldurulması Zorunlu Alanların Boş Olmadığından Emin Olunuz!", "Sistem");
            }
        }

        private void cbMeclisGorevDoldur() {
            cbMeclisGorev.DataSource = _meclisGorevTanim.ListeGetir();
            cbMeclisGorev.DisplayMember = "MeclisGorevAdi";
            cbMeclisGorev.ValueMember = "Id";

        }
        private void cbSehirDoldur()
        {
            cbIl.DataSource = _ilTanim.ListeGetir();
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "Id";
        }
        private void cbCinsiyetDoldur() {
            cbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            //cbCinsiyet.DisplayMember = "CinsiyetAdi";
            //cbCinsiyet.ValueMember = "Id";
        }
        private void textBoşalt() {
            txtAd.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            txtSoyad.Text = "";
            txtTcKimlikNo.Text = "";
            txtTelNo.Text = "";
           
        }

        private void FrmGrupPersonelTanim_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string sifre = txtSifre.Text;
            string telNo = txtTelNo.Text;
            string mail = txtMail.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            int il = Convert.ToInt32(cbIl.SelectedValue);
            int meclisGorev = Convert.ToInt32(cbMeclisGorev.SelectedValue);
            bool aktif = chkAktif.Checked;
            if (tcKimlikNo != null && ad != null & soyad != null && (cinsiyet > -1) && (cinsiyet < 2) && (!(il < 1) && !(il > 81)) && meclisGorev != 0 && sifre != null)
            {
                try
                {

                    _grupPersonel.Guncelle(new GrupPersonelTanim
                    {
                        Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        Ad = ad,
                        Aktif = aktif,
                        CinsiyetTanimId = cinsiyet,
                        IlTanimId = il,
                        Mail = mail,
                        MeclisGorevId = meclisGorev,
                        Soyad = soyad,
                        TcKimlikNo = tcKimlikNo,
                        TelNo = telNo,
                        Sifre = sifre
                    });
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Program");
                }
                MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                TumunuListele();
                textBoşalt();

            }
            else
            {
                MessageBox.Show("Lütfen Doldurulması Zorunlu Alanların Boş Olmadığından Emin Olunuz!", "Sistem");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _grupPersonel.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }

        }

        private void TumunuListele()
        {
            dgListe.DataSource = (from p in _grupPersonel.ListeGetir()
                                  join i in _ilTanim.ListeGetir() on p.IlTanimId equals i.Id
                                  join c in _cinsiyetTanim.ListeGetir() on p.CinsiyetTanimId equals c.Id
                                  join m in _meclisGorevTanim.ListeGetir() on p.MeclisGorevId equals m.Id
                                  select new { 
                                  p.Id,
                                  p.TcKimlikNo,
                                    p.Ad,
                                    p.Soyad,
                                      p.TelNo,
                                      p.Mail,
                                      c.CinsiyetAdi,
                                   i.IlAdi,
                                    m.MeclisGorevAdi,
                                    p.Aktif
                                  }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTcKimlikNo.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgListe.CurrentRow.Cells[3].Value.ToString();
            txtTelNo.Text = dgListe.CurrentRow.Cells[4].Value.ToString();
            txtMail.Text = dgListe.CurrentRow.Cells[5].Value.ToString();
            //cbVekilTanim.Text = dgListe.CurrentRow.Cells[6].Value.ToString();
            cbCinsiyet.Text = dgListe.CurrentRow.Cells[6].Value.ToString();
            cbIl.Text = dgListe.CurrentRow.Cells[7].Value.ToString();
            chkAktif.Checked = Convert.ToBoolean(dgListe.CurrentRow.Cells[9].Value);
            cbCinsiyet.DisplayMember = "CinsiyetAdi";
            cbCinsiyet.ValueMember = "Id";
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "Id";
            //cbMeclisGorev.DataSource = _meclisGorevTanim.ListeGetir();
            cbMeclisGorev.DisplayMember = "MeclisGorevAdi";
            cbMeclisGorev.ValueMember = "Id";
            //cbVekilTanim.DisplayMember = "Ad";
            //cbVekilTanim.DisplayMember += "Soyad";
            //cbVekilTanim.ValueMember = "Id";
        }
    }
}
