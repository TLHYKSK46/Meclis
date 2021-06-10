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
    public partial class FrmDostlukGrupTanim : Form
    {
        private IDostlukGrupTanimService _dostlukGrupTanim; 
        public FrmDostlukGrupTanim()
        {
            _dostlukGrupTanim = InstanceFactory.GetInstance<IDostlukGrupTanimService>();
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            

        }
        private void FrmDostlukGrupTanim_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
           
        }
        #region Crud
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dgAdi = txtDostlukGrupAdi.Text;
            if (dgAdi != null && dgAdi != "")
            {
                _dostlukGrupTanim.Ekle(new DostlukGrupTanim
                {
                    DostlukGrupAdi = dgAdi,
                    EklenmeTarihi = DateTime.Now

                });
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Program");
                txtDostlukGrupAdi.Text = "";
                TumunuListele();
            }
            else { 
                MessageBox.Show("Lütfen bir Dostluk Grup Adı giriniz!.","Program");

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string dgAdi = txtDostlukGrupAdi.Text;
            if (dgAdi != null && dgAdi != "")
            {
                _dostlukGrupTanim.Guncelle(new DostlukGrupTanim
                {
                    Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                    DostlukGrupAdi = dgAdi,
                  

                });
                MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Program");
                txtDostlukGrupAdi.Text = "";
                TumunuListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir Dostluk Grup Adı giriniz!.", "Program");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _dostlukGrupTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }
        #endregion
        private void TumunuListele()
        {
            dgListe.DataSource = _dostlukGrupTanim.ListeGetir().Select(p => new {
            p.Id,
            p.DostlukGrupAdi
            
            }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDostlukGrupAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
        }

      

        private void btnListe_Click(object sender, EventArgs e)
        {
            TumunuListele();
        }

     
    }
}
