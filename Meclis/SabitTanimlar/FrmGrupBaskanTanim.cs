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
    public partial class FrmGrupBaskanTanim : Form
    {
        private IGrupBaskanTanimService _grupBaskanTanimService;
        private IGrupBaskanVekilTanimService _grupBaskanVekilTanimService;
        private IGrupYonetimKurulUyesiService _grupYonetimKurulUyesiService;
        private IVekilTanimService _vekilTanimService;
        public FrmGrupBaskanTanim()
        {
            _grupBaskanTanimService = InstanceFactory.GetInstance<IGrupBaskanTanimService>();
            _grupBaskanVekilTanimService = InstanceFactory.GetInstance<IGrupBaskanVekilTanimService>();
            _grupYonetimKurulUyesiService = InstanceFactory.GetInstance<IGrupYonetimKurulUyesiService>();
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            InitializeComponent();

        }
        #region Grup Başkan Tanım
        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            if (cbVekilBaskan.SelectedValue != null)
            {
                try
                {

                    _grupBaskanTanimService.Ekle(new GrupBaskanTanim
                    {
                        VekilTanimId = Convert.ToInt32(cbVekilBaskan.SelectedValue)
                    });
                    MessageBox.Show("Kayıt başarıyla Eklendi.", "Program");

                    GrupBaskanListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }

        }

        private void btnGuncelle1_Click(object sender, EventArgs e)
        {
            if (cbVekilBaskan.SelectedValue != null)
            {
                try
                {

                    _grupBaskanTanimService.Guncelle(new GrupBaskanTanim
                    {
                        VekilTanimId = Convert.ToInt32(cbVekilBaskan.SelectedValue)
                    });
                    MessageBox.Show("Kayıt başarıyla Eklendi.", "Program");

                    GrupBaskanListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListeBaskan.CurrentRow != null)
            {

                try
                {
                    _grupBaskanTanimService.Sil(Convert.ToInt32(dgListeBaskan.CurrentRow.Cells[0].Value));
                    GrupBaskanListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }

        private void GrupBaskanListele()
        {
            dgListeBaskan.DataSource = _grupBaskanTanimService.ListeGetir().Select(p => new
            {
                p.Id,
                p.VekilTanimId
            }).ToList();
        }

        #endregion
        #region Grup Başkan Vekil
        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            if (cbGrupBaskan.SelectedValue != null && cbVekilBaskanVekil.SelectedValue != null)
            {
                try
                {

                    _grupBaskanVekilTanimService.Ekle(new GrupBaskanVekilTanim
                    {
                        GrupBaskanTanimId = Convert.ToInt32(cbGrupBaskan.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekilBaskanVekil.SelectedValue)
                    });
                    MessageBox.Show("Kayıt başarıyla Eklendi.", "Program");

                    GrupBaskanListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            if (cbGrupBaskan.SelectedValue != null && cbVekilBaskanVekil.SelectedValue != null)
            {
                try
                {

                    _grupBaskanVekilTanimService.Guncelle(new GrupBaskanVekilTanim
                    {
                        GrupBaskanTanimId = Convert.ToInt32(cbGrupBaskan.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekilBaskanVekil.SelectedValue)
                    });
                    MessageBox.Show("Kayıt başarıyla Eklendi.", "Program");

                    GrupBaskanListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgBaskanVekilListe.CurrentRow != null)
            {

                try
                {
                    _grupBaskanTanimService.Sil(Convert.ToInt32(dgBaskanVekilListe.CurrentRow.Cells[0].Value));
                    GrupBaskanListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }
        #endregion
        #region Grup Başkan Yonetim Kurul Uyesi
        private void btnKaydet3_Click(object sender, EventArgs e)
        {
            if (cbGrupBaskanYonetim.SelectedValue != null && cbGrupBaskanYonetimVekil.SelectedValue != null && cbVekilYonetim!=null)
            {
                try
                {

                    _grupYonetimKurulUyesiService.Ekle(new GrupYonetimKurulUyesi
                    {
                        GrupBaskanTanimId = Convert.ToInt32(cbGrupBaskanYonetim.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekilYonetim.SelectedValue),
                        GrupBaskanVekilTanimId=Convert.ToInt32(cbGrupBaskanYonetimVekil.SelectedValue)
                        
                    });
                    MessageBox.Show("Kayıt başarıyla Eklendi.", "Program");

                    GrupBaskanListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
        }

        private void btnGuncelle3_Click(object sender, EventArgs e)
        {
            if (cbGrupBaskanYonetim.SelectedValue != null && cbGrupBaskanYonetimVekil.SelectedValue != null && cbVekilYonetim != null)
            {
                try
                {

                    _grupYonetimKurulUyesiService.Guncelle(new GrupYonetimKurulUyesi
                    {
                        GrupBaskanTanimId = Convert.ToInt32(cbGrupBaskanYonetim.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekilYonetim.SelectedValue),
                        GrupBaskanVekilTanimId = Convert.ToInt32(cbGrupBaskanYonetimVekil.SelectedValue)

                    });
                    MessageBox.Show("Kayıt başarıyla Eklendi.", "Program");

                    GrupBaskanListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
        }

        private void btnSil3_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgBaskanVekilListe.CurrentRow != null)
            {

                try
                {
                    _grupBaskanTanimService.Sil(Convert.ToInt32(dgBaskanVekilListe.CurrentRow.Cells[0].Value));
                    GrupBaskanListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }
        #endregion
    }
}


