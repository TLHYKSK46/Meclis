using MeclisDao.Enums;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisDao.MessageDialogs;
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
    public partial class FrmVekilDilTanim : Form
    {
        private IDilTanimService _dilTanimService;
        IVekilTanimService _vekilTanim;
     
        private IVekilDilTanimService _vekilDilTanim;
        public FrmVekilDilTanim()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _vekilDilTanim = InstanceFactory.GetInstance<IVekilDilTanimService>();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();


        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            TumunuListele();
            DilSeviyeDoldur();
        }
        private void FrmDilTanim_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string dilAdi = cbDilAdi.Text;
                if ((!dilAdi.Equals("") || dilAdi != null))
                {
                    _vekilDilTanim.Ekle(new VekilDilTanim
                    {
                        DilTanimId = Convert.ToInt32(cbDilAdi.SelectedValue),
                        DilSeviyeId = Convert.ToInt32(cbDilSeviye.SelectedValue),
                        VekilTanimId = Convert.ToInt32(cbVekil.SelectedValue)
                    });
                    MessageBox.Show("Dil Eklendi!", "Admin");
                    MesajGoster.Bilgi("Kayıt İşlemi Başarılı.");
                    TumunuListele();
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
                    DilTanimId = Convert.ToInt32(cbDilAdi.SelectedValue),
                    DilSeviyeId = Convert.ToInt32(cbDilSeviye.SelectedValue),
                    VekilTanimId = Convert.ToInt32(cbVekil.SelectedValue)

                }); ;
                MessageBox.Show("Dil Güncellendi!", "Admin");
                MesajGoster.Basarili("Güncelleme işlemi başarılı!");
                TumunuListele();
            }
            catch (DaoException ex)
            {
                MesajGoster.Hata("Güncelleme işlemi başarısız!",ex.Message.ToString());

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
                                    // join vd in _vekilDetayService.ListeGetir() on vt.Id equals vd.VekilTanimId
                                     join dt in _dilTanimService.ListeGetir() on vdt.DilTanimId equals dt.Id
                                  join ds in Enum.GetValues(typeof(DilSeviye)).Cast<DilSeviye>() on vdt.DilSeviyeId equals ds.GetHashCode()

                                     select new
                                     {
                                         vdt.Id,
                                         vt.TcKimlikNo,
                                         AdSoyad = vt.Ad + " " + vt.Soyad,
                                         Dil = dt.DilAdi,
                                         DilSeviyesi=ds.ToString()
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
            cbDilAdi.Text = dgDilListe.CurrentRow.Cells[3].Value.ToString();
            cbVekil.Text = dgDilListe.CurrentRow.Cells[2].Value.ToString();
           
            //cbDil.DisplayMember = "DilAdi";
            //cbDil.ValueMember = "Id";

            //cbVekil.DisplayMember = "Adi";
            //cbVekil.ValueMember = "Id";
        }

        private void DilDoldur()
        {
            cbDilAdi.DataSource = _dilTanimService.ListeGetir();
            cbDilAdi.DisplayMember = "DilAdi";
            cbDilAdi.ValueMember = "Id";

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
            cbDilSeviye.DataSource = Enum.GetValues(typeof(DilSeviye));
            //cbDilAdi.DisplayMember = "DilAdi";
            //cbDilAdi.ValueMember = "Id";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool msg = MesajGoster.Uyari("Silmek İstediğinizden Eminmisiniz?");
            if (msg ==true && dgDilListe.CurrentRow != null)
            {

                try
                {
                    _vekilDilTanim.Sil(Convert.ToInt32(dgDilListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MesajGoster.Basarili("Kayıt Başarıyla  Silindi!");

                }
                catch (DaoException ex)
                {
                    MesajGoster.Hata("Silerken bir hata ile karşılaşıldı! Silme işlemi başarısız.",ex.Message.ToString());
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
