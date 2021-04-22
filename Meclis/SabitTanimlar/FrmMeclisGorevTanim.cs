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
    public partial class FrmMeclisGorevTanim : Form
    {
        private IMeclisGorevTanimService _meclisGorevTanim;
        public FrmMeclisGorevTanim()
        {
            InitializeComponent();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            TumunuListele();

        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string meclisGorev= txtMeclisGorevAdi.Text;
            if (meclisGorev != null && meclisGorev != "")
            {
                try
                {
                    _meclisGorevTanim.Ekle(new MeclisGorevTanim { 
                    MeclisGorevAdi=meclisGorev
                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtMeclisGorevAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(),"Sistem");
                }
            }
            else {
                MessageBox.Show("Lütfen Meclis Görev Adı Giriniz!","Sistem");
            }
       

        }

       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string meclisGorev = txtMeclisGorevAdi.Text;
            if (meclisGorev != null && meclisGorev != "")
            {
                try
                {
                    _meclisGorevTanim.Guncelle(new MeclisGorevTanim
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        MeclisGorevAdi = meclisGorev
                    });
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();
                    txtMeclisGorevAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Meclis Görev Adı Giriniz!", "Sistem");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _meclisGorevTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMeclisGorevAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void TumunuListele()
        {
            dgListe.DataSource = (from m in _meclisGorevTanim.ListeGetir()
                                 
                                
                                  select new
                                  {
                                      m.Id,
                                      m.MeclisGorevAdi,
                                      
                                     
                                  }).ToList();
        }
    }
}
