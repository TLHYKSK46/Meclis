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

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ihtisasAdi = txtIhtisasAdi.Text;
            string uluslararasiAdi = txtUluslararasiAdi.Text;

            if (ihtisasAdi!=null && uluslararasiAdi!=null)
            {
                try
                {
                    var data = new KomisyonTanim() { 
                    KomisyonAdi=ihtisasAdi,
                    KomisyonTuru=uluslararasiAdi
                    };
                    _komisyonTanim.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.","Sistem");
                    TumunuListele();
                    txtIhtisasAdi.Text = "";
                    txtUluslararasiAdi.Text = "";
                }
                catch (DaoException  ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ihtisasAdi = txtIhtisasAdi.Text;
            string uluslararasiAdi = txtUluslararasiAdi.Text;

            if (ihtisasAdi != null && uluslararasiAdi != null)
            {
                try
                {
                    var data = new KomisyonTanim()
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        KomisyonAdi = ihtisasAdi,
                        KomisyonTuru = uluslararasiAdi
                    };
                    _komisyonTanim.Guncelle(data);
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();
                    txtIhtisasAdi.Text = "";
                    txtUluslararasiAdi.Text = "";
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

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIhtisasAdi.Text = dgListe.CurrentRow.Cells[0].Value.ToString();
            txtUluslararasiAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
           
        }
    }
}
