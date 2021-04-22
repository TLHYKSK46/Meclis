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
    public partial class FrmVekilDanisman : Form
    {
        private IVekilTanimService _vekilTanim;
        private IDanismanTanimService _danismanTanim;
        private IVekilDanismanService _vekilDanisman;
        public FrmVekilDanisman()
        {
            InitializeComponent();
            _vekilDanisman = InstanceFactory.GetInstance<IVekilDanismanService>();
            _danismanTanim = InstanceFactory.GetInstance<IDanismanTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();

            cbDanismanDoldur();
            cbVekilDoldur();
            TumunuListele();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int vekilId=Convert.ToInt32(cbVekil.SelectedValue);
            int danismanId = Convert.ToInt32(cbDanisman.SelectedValue);
            int sira = Convert.ToInt32(txtSira.Text);

            if ((vekilId > 0) && (danismanId > 0) && sira!=0)
            {
                try
                {
                    var data = new VekilDanisman()
                    {
                       DanismanTanimId=danismanId,
                       VekilTanimId=vekilId,
                       Sira=sira
                    };
                    _vekilDanisman.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtSira.Text = "";
                    cbDanisman.Refresh();
                    cbVekil.Refresh();
                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!.", "Sistem");
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int vekilId = Convert.ToInt32(cbVekil.SelectedValue);
            int danismanId = Convert.ToInt32(cbDanisman.SelectedValue);
            int sira = Convert.ToInt32(txtSira.Text);

            if ((vekilId > 0) && (danismanId > 0) && sira != 0)
            {
                try
                {
                    var data = new VekilDanisman()
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        DanismanTanimId = danismanId,
                        VekilTanimId = vekilId,
                        Sira = sira
                    };
                    _vekilDanisman.Guncelle(data);
                    MessageBox.Show("Kayıt Güncellem İşlemi Başarılı.", "Sistem");
                    TumunuListele();

                    txtSira.Text = "";
                    cbDanisman.Refresh();
                    cbVekil.Refresh();
                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!.", "Sistem");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _danismanTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            dgListe.DataSource = (from vd in _vekilDanisman.ListeGetir()
                                  join dt in _danismanTanim.ListeGetir() on vd.DanismanTanimId equals dt.Id
                                  join vt in _vekilTanim.ListeGetir() on vd.VekilTanimId equals vt.Id
                                  select new {
                                      vd.Id,
                                      dt.TcKimlikNo,
                                     adSoyad= dt.Ad+" "+dt.Soyad,
                                      vd.Sira,
                                      vekilTc=vt.TcKimlikNo,
                                     vekilAdSoyad= vt.Ad+""+vt.Soyad,
                                  }).ToList();
        }

        private void cbDanismanDoldur()
        {
            cbDanisman.DataSource = _danismanTanim.ListeGetir();
            cbDanisman.DisplayMember = "Ad";
            cbDanisman.ValueMember = "Id";
        }

        private void cbVekilDoldur()
        {
            cbVekil.DataSource = _vekilTanim.ListeGetir();
            cbVekil.DisplayMember = "ad";
            cbVekil.ValueMember = "Id";
        }

        private void FrmVekilDanisman_Load(object sender, EventArgs e)
        {

        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbVekil.Text = dgListe.CurrentRow.Cells[5].Value.ToString();
            cbDanisman.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            txtSira.Text = dgListe.CurrentRow.Cells[3].Value.ToString();
         
        }
    }
}
