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
    public partial class FrmMeslekTanim : Form
    {
        private IMeslekTanimService _meslekTanim;
        public FrmMeslekTanim()
        {
            InitializeComponent();
            _meslekTanim = InstanceFactory.GetInstance<IMeslekTanimService>();
            TumunuListele();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string meslekAdi = txtMeslekAdi.Text;
            if (meslekAdi != null && meslekAdi != "")
            {
                try
                {
                    _meslekTanim.Ekle(new MeslekTanim
                    {
                        MeslekAdi = meslekAdi
                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtMeslekAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Meslek Adı Giriniz!", "Sistem");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string meslekAdi = txtMeslekAdi.Text;
            if (meslekAdi != null && meslekAdi != "")
            {
                try
                {
                    _meslekTanim.Guncelle(new MeslekTanim
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        MeslekAdi = meslekAdi
                    });
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtMeslekAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Meslek Adı Giriniz!", "Sistem");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _meslekTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            dgListe.DataSource = _meslekTanim.ListeGetir().Select(p=>new { 
            p.Id,
            p.MeslekAdi
            }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMeslekAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
