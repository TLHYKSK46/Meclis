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
        private IVekilTanimService _vekilTanim;
        public FrmMeclisGorevTanim()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
    

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CbVekilDoldur();
        }

        private void FrmMeclisGorevTanim_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
        #region crud

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
        private void btnListele_Click(object sender, EventArgs e)
        {
            TumunuListele();
        }
        #endregion
        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMeclisGorevAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void CbVekilDoldur() {

            cbVekilTanim.DataSource = _vekilTanim.ListeGetir();
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.DisplayMember += "Soyad";
            cbVekilTanim.ValueMember = "Id";
        }
        private void TumunuListele()
        {
            dgListe.DataSource = (from m in _meclisGorevTanim.ListeGetir()
                                join vt in _vekilTanim.ListeGetir() on m.Id equals vt.MeclisGorevId
                                  select new
                                  {
                                      m.Id,
                                      vt.TcKimlikNo,
                                      vekilAdSoyad=vt.Ad+" "+vt.Soyad,
                                      m.MeclisGorevAdi,
                                      vt.KisiselTelNo,
                                     vt.KurumsalTelNo,
                                     vt.KurumsalMail,
                                     vt.Kisiselmail,
                                  }).ToList();
        }

        private void cbVekilTanim_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((VekilTanim)e.ListItem).Ad;
            string firstname = ((VekilTanim)e.ListItem).Soyad;
            e.Value = lastname + " " + firstname;
        }
    }
}
