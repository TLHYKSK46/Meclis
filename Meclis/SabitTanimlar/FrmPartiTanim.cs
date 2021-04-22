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
    public partial class FrmPartiTanim : Form
    {
        private IPartiTanimService _partiTanim;
        public FrmPartiTanim()
        {
            InitializeComponent();
            _partiTanim = InstanceFactory.GetInstance<IPartiTanimService>();
            TumunuListele();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string partiAdi = txtPartiAdi.Text;
            if (partiAdi != null && partiAdi != "")
            {
                try
                {
                    _partiTanim.Ekle(new PartiTanim
                    {
                      PartiAdi=partiAdi
                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtPartiAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Parti Adı Giriniz!", "Sistem");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string partiAdi = txtPartiAdi.Text;
            if (partiAdi != null && partiAdi != "")
            {
                try
                {
                    _partiTanim.Guncelle(new PartiTanim
                    {
                        Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        PartiAdi = partiAdi
                    });
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtPartiAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Parti Adı Giriniz!", "Sistem");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _partiTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            dgListe.DataSource=_partiTanim.ListeGetir().Select(p=>new { 
            p.Id,
            p.PartiAdi,
            }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPartiAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
