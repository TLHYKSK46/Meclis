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
    public partial class FrmKomisyonUye : Form
    {
        private IKomisyonTanimService _komisyonTanim;
        private IVekilTanimService _vekilTanimService;
        private IKomisyonUyeService _komisyonUyeService;
        public FrmKomisyonUye()
        {
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _komisyonTanim = InstanceFactory.GetInstance<IKomisyonTanimService>();
            _komisyonUyeService = InstanceFactory.GetInstance<IKomisyonUyeService>();
            InitializeComponent();
            TumunuListele();
            KomisyonTuruDoldur();
            VekilDoldur();
            KomisyonDoldur();
        }

        private void FrmKomisyonUye_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbVekilTanim.Text != null && cbKomisyonUye.Text != null && cbKomisyonTanim.Text!=null)
            {
                try
                {
                    var data = new KomisyonUye()
                    {
                        KomisyonTanimId= Convert.ToInt32(cbKomisyonTanim.SelectedValue),
                        KomisyonUyeTuru= Convert.ToInt32(cbKomisyonUye.SelectedValue),
                        VekilTanimId= Convert.ToInt32(cbVekilTanim.SelectedValue),
                        BaslamaTarihi=dtBasTarihi.Value,
                        BitisTarih=dtBitisTarihi.Value,
                        
                };
                    _komisyonUyeService.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();
                    
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }

            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cbVekilTanim.Text != null && cbKomisyonUye.Text != null && cbKomisyonTanim.Text != null)
            {
                try
                {
                    var data = new KomisyonUye()
                    {
                        Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        KomisyonTanimId = Convert.ToInt32(cbKomisyonTanim.SelectedValue),
                        KomisyonUyeTuru = Convert.ToInt32(cbKomisyonUye.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekilTanim.SelectedValue),
                        BaslamaTarihi = dtBasTarihi.Value,
                        BitisTarih = dtBitisTarihi.Value,

                    };
                    _komisyonUyeService.Guncelle(data);
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }

            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _komisyonUyeService.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
        private void TumunuListele()
        {
            dgListe.DataSource = (from ktu in _komisyonUyeService.ListeGetir()
                                  join kt in _komisyonTanim.ListeGetir() on ktu.KomisyonTanimId equals kt.Id
                                  join vt in _vekilTanimService.ListeGetir() on ktu.VekilTanimId equals vt.Id
                                  select new
                                  {
                                      vt.Id,
                                      vt.TcKimlikNo,
                                      vt.Ad,
                                      vt.Soyad,
                                      kt.KomisyonAdi,
                                      kt.KomisyonTuru,
                                      vt.Aktif

                                  }
                                 ).ToList();
        }
        private void KomisyonTuruDoldur()
        {
            cbKomisyonUye.DataSource = Enum.GetValues(typeof(KomisyonUyeTuru));
        }
        private void KomisyonDoldur()
        {
            cbKomisyonUye.DataSource = _komisyonTanim.ListeGetir();
        }
        private void VekilDoldur()
        {
            cbKomisyonUye.DataSource = _vekilTanimService.ListeGetir();
        }


        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
