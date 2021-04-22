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
    public partial class FrmHatirlatmaTanim : Form
    {
        private IHatirlatmaTanimService _hatirlatmaTanimService;
        private IVekilTanimService _vekilTanim;
        public FrmHatirlatmaTanim()
        {
         
            InitializeComponent();
            _hatirlatmaTanimService = InstanceFactory.GetInstance<IHatirlatmaTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            TumunuListele();
            cbVekilDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string aciklama = txtAciklama.Text;
            DateTime hatirlatmaTarihi = dtHatirlatmaTarihi.Value;
            int vekilTanimId = Convert.ToInt32(cbVekilTanim.SelectedValue);
            if (baslik!=null&& aciklama!=null &&hatirlatmaTarihi !=null && vekilTanimId!=0 && vekilTanimId!=-1)
            {
                try
                {
                    
                    var data = new HatirlatmaTanim()
                    {
                        Baslik = baslik,
                        Aciklama = aciklama,
                        HatirlatmaTarihi = hatirlatmaTarihi,
                        VekilTanimId = vekilTanimId,
                        OlusturmaTarihi = DateTime.Now
                    };
                    //var kontrol = data.HatirlatmaTarihi.Date != DateTime.Now.Date && !(data.HatirlatmaTarihi.Date < DateTime.Now.Date);
                    
                    //if(!kontrol)
                    //    throw new DaoException("Bugün veya Eski Bir Tarihe Hatırlatma Ekleyemezsiniz!");
                    _hatirlatmaTanimService.Ekle(data);

                    MessageBox.Show("Hatırlatma Başarıyla Eklendi.","Sistem");
                    TumunuListele();

                    txtBaslik.Text = "";
                    txtAciklama.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
                
            }

        }


        private void cbVekilDoldur() {
            cbVekilTanim.DataSource = _vekilTanim.ListeGetir();
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.ValueMember = "Id";
        
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string aciklama = txtAciklama.Text;
            DateTime hatirlatmaTarihi = dtHatirlatmaTarihi.Value;
            int vekilTanimId = Convert.ToInt32(cbVekilTanim.SelectedValue);
            if (baslik != null && aciklama != null && hatirlatmaTarihi != null && vekilTanimId != 0 && vekilTanimId != -1)
            {
                try
                {

                    var data = new HatirlatmaTanim()
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        Baslik = baslik,
                        Aciklama = aciklama,
                        HatirlatmaTarihi = hatirlatmaTarihi,
                        VekilTanimId = vekilTanimId,
                        OlusturmaTarihi = DateTime.Now
                    };
                    //var kontrol = data.HatirlatmaTarihi.Date != DateTime.Now.Date && !(data.HatirlatmaTarihi.Date < DateTime.Now.Date);

                    //if(!kontrol)
                    //    throw new DaoException("Bugün veya Eski Bir Tarihe Hatırlatma Ekleyemezsiniz!");
                    _hatirlatmaTanimService.Guncelle(data);

                    MessageBox.Show("Hatırlatma Başarıyla Güncellendi!.", "Sistem");
                    TumunuListele();

                    txtBaslik.Text = "";
                    txtAciklama.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString());
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
                    _hatirlatmaTanimService.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            cbVekilDoldur();
            dgListe.DataSource = (from h in _hatirlatmaTanimService.ListeGetir()
                                  join v in _vekilTanim.ListeGetir() on h.VekilTanimId equals v.Id 
                                  select new { 
                                  h.Id,
                                  v.TcKimlikNo,
                                  VekilAdSoyad=v.Ad+""+v.Soyad,
                                  h.Baslik,
                                  h.Aciklama,
                                  h.HatirlatmaTarihi,
                                  h.OlusturmaTarihi
                                  }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBaslik.Text = dgListe.CurrentRow.Cells[3].Value.ToString();
            txtAciklama.Text = dgListe.CurrentRow.Cells[4].Value.ToString();
            dtHatirlatmaTarihi.Text = dgListe.CurrentRow.Cells[5].Value.ToString();
            cbVekilTanim.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.ValueMember = "Id";
        }
      
    }
}
