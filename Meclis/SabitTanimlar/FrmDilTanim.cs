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
    public partial class FrmDilTanim : Form
    {
        private IDilTanimService _dilTanimService;
        IVekilTanimService _vekilTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IVekilDetayService _vekilDetayService;
        private IVekilDilTanimService _vekilDilTanim;
        public FrmDilTanim()
        {
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();

            InitializeComponent();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _vekilDetayService = InstanceFactory.GetInstance<IVekilDetayService>();
            _vekilDilTanim = InstanceFactory.GetInstance<IVekilDilTanimService>();
        }

        private void FrmDilTanim_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string dilAdi = txtDilAdi.Text;
                if ((!dilAdi.Equals("") || dilAdi != null))
                {
                    _vekilDilTanim.Ekle(new VekilDilTanim
                    {
                        DilTanimId = Convert.ToInt32(cbDil.SelectedValue),
                        DilSeviyeId = Convert.ToInt32(cbDilSeviye.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekil.SelectedValue)

                    });
                    MessageBox.Show("Dil Eklendi!", "Admin");
                    TumunuListele();
                    txtDilAdi.Text = "";

                }
            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Admin");

             
            }
          

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _vekilDilTanim.Guncelle(new VekilDilTanim
                {
                    Id = Convert.ToInt32(dgDilListe.CurrentRow.Cells[0].Value),
                    DilTanimId = Convert.ToInt32(cbDil.SelectedValue),
                    DilSeviyeId = 1,//Convert.ToInt32(cbDilSeviye.SelectedValue),
                    VekilTanimId = Convert.ToInt32(cbVekil.SelectedValue)

                }); ;
                MessageBox.Show("Dil Güncellendi!", "Admin");
                TumunuListele();
                txtDilAdi.Text = "";
            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Admin");


            }
          

        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgDilListe.DataSource = _dilTanimService.AdGoreGetir(txtAra.Text);
            }
            else
            {
                TumunuListele();
            }
        }
        private void TumunuListele()
        {
            DilDoldur();
            VekilDoldur();
            dgDilListe.DataSource = (from vdt in _vekilDilTanim.ListeGetir() 
                                     join vt in _vekilTanim.ListeGetir() on vdt.VekilTanimId equals vt.Id
                                     join vd in _vekilDetayService.ListeGetir() on vt.Id equals vd.VekilTanimId
                                     join dt in _dilTanimService.ListeGetir() on vdt.DilTanimId equals dt.Id
                                    
                                     select new
                                     {
                                         vdt.Id,
                                         vt.TcKimlikNo,
                                         AdSoyad = vt.Ad + " " + vt.Soyad,
                                         Dil = dt.DilAdi,
                                     }
                        ).ToList();
        }
        private void cbDilSeviyesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDilAdi_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgDilListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbDil.Text = dgDilListe.CurrentRow.Cells[3].Value.ToString();
            cbVekil.Text = dgDilListe.CurrentRow.Cells[2].Value.ToString();
           
            //cbDil.DisplayMember = "DilAdi";
            //cbDil.ValueMember = "Id";

            //cbVekil.DisplayMember = "Adi";
            //cbVekil.ValueMember = "Id";
        }

        private void DilDoldur()
        {
            cbDil.DataSource = _dilTanimService.ListeGetir();
            cbDil.DisplayMember = "DilAdi";
            cbDil.ValueMember = "Id";

        }
        private void VekilDoldur()
        {
     
            //dgDilListe.Columns.Add("Ad","Soyad");
            cbVekil.DataSource = _vekilTanim.ListeGetir();
            cbVekil.DisplayMember = "Ad";
            cbVekil.DisplayMember += "Soyad";
            cbVekil.ValueMember = "Id";
        }
        private void DilSeviyeDoldur()
        {
            cbDil.DataSource = _dilTanimService.ListeGetir();
            cbDil.DisplayMember = "DilAdi";
            cbDil.ValueMember = "Id";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgDilListe.CurrentRow != null)
            {

                try
                {
                    _vekilDilTanim.Sil(Convert.ToInt32(dgDilListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!","Program",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }

        private void cbVekil_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((VekilTanim)e.ListItem).Ad;
            string firstname = ((VekilTanim)e.ListItem).Soyad;
            e.Value = lastname + " " + firstname;
        }

      
    }
}
