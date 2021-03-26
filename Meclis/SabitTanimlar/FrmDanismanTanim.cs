using MeclisDao.IDaoServis;
using MeclisDao.Instances;
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
    public partial class FrmDanismanTanim : Form
    {
        private IDanismanTanimService _danismanTanim;
        private IIlTanimService _ilTanimService;
        private ICinsiyetTanimService _cinsiyetTanim;
        public FrmDanismanTanim()
        {
            InitializeComponent();
            _danismanTanim = InstanceFactory.GetInstance<IDanismanTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();
        }

        private void FrmDanismanTanim_Load(object sender, EventArgs e)
        {
            SehirDoldur();
            CinsiyetDoldur();
          



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcKimlik = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string mail = txtMail.Text;
            string telNo = txtTelNo.Text;
            int cinsiyet = cbCinsiyet.SelectedIndex;
            int il = cbIl.SelectedIndex;
            if ((tcKimlik != null) && (ad != null) && (soyad != null)
                && (cinsiyet != null) && (cbCinsiyet.SelectedItem!=null) && (cbIl.SelectedItem!=null)) {
       
                MessageBox.Show("Lütfe", "Program");
            }
        
            else {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olunuz..","Program");
            }
        }

        private void CinsiyetDoldur() {

           cbCinsiyet.DataSource= _cinsiyetTanim.ListeGetir();
            cbCinsiyet.DisplayMember = "CinsiyetAdi";
            cbCinsiyet.ValueMember = "Id";
           
        }
        private void SehirDoldur()
        {
            cbIl.DataSource=_ilTanimService.ListeGetir();
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "Id";
        }

    }
}
