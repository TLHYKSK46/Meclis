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
    public partial class FrmKomisyonTanim : Form
    {
        private IKomisyonTanimService _komisyonTanim;
        public FrmKomisyonTanim()
        {
            InitializeComponent();
            _komisyonTanim = InstanceFactory.GetInstance<IKomisyonTanimService>();
            TumunuListele();
            KomisyonTuruDoldur();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            //KOmisyon türü enumdan gelecek

            if (txtKomisyonAdi.Text != null && cbKomisyonTuru.Text != null)
            {
                try
                {
                    var data = new KomisyonTanim() { 
                    KomisyonAdi= txtKomisyonAdi.Text,
                    KomisyonTuru= cbKomisyonTuru.Text
                    };
                    _komisyonTanim.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.","Sistem");
                    TumunuListele();
                    txtKomisyonAdi.Text = "";
                    cbKomisyonTuru.Text = "";

                }
                catch (DaoException  ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
     

            if (txtKomisyonAdi.Text != null && cbKomisyonTuru.Text != null)
            {
                try
                {
                    var data = new KomisyonTanim()
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        KomisyonAdi = txtKomisyonAdi.Text,
                        KomisyonTuru = cbKomisyonTuru.Text
                    };
                    _komisyonTanim.Guncelle(data);
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();
                    txtKomisyonAdi.Text = "";
                    cbKomisyonTuru.Text = "";
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
                    _komisyonTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            dgListe.DataSource = _komisyonTanim.ListeGetir();
        }
        private void KomisyonTuruDoldur()
        {
            cbKomisyonTuru.DataSource = Enum.GetValues(typeof(KomisyonTuru));
        }
        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKomisyonAdi.Text = dgListe.CurrentRow.Cells[0].Value.ToString();
            cbKomisyonTuru.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void FrmKomisyonTanim_Load(object sender, EventArgs e)
        {

        }
    }
}
