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
    public partial class FrmDanismanTanim : Form
    {
        private IDanismanTanimService _danismanTanim;
        private IIlTanimService _ilTanimService;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IVekilTanimService _Vekil;
        public FrmDanismanTanim()
        {
            InitializeComponent();
            _danismanTanim = InstanceFactory.GetInstance<IDanismanTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();
            _Vekil = InstanceFactory.GetInstance<IVekilTanimService>();
        }

        private void FrmDanismanTanim_Load(object sender, EventArgs e)
        {
            VekilDoldur();
            SehirDoldur();
            CinsiyetDoldur();
          



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //try
            //{

            //}
            //catch (DaoException ex)
            //{
            //    MessageBox.Show(ex.ToString(), "");
            //}
            string tcKimlik = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string mail = txtMail.Text;
            string telNo = txtTelNo.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            int il = Convert.ToInt32(cbIl.SelectedValue);
            int vekil = Convert.ToInt32(cbVekilTanim.SelectedValue);
            bool aktif = chkAktif.Checked;
         

            if ((tcKimlik != null) && (ad != null) && (soyad != null)
                && !(cinsiyet < 0) && !(cinsiyet>1) && (il!=0)) {

                if (tcKimlik.Length != 11 )
                    MessageBox.Show("Lütfen Tc Kimlik No alanını kontrol ediniz..(11 karekterden oluşması gerekir!)");
              
                _danismanTanim.Ekle(new DanismanTanim { 
                    TcKimlikNo=tcKimlik,
                Ad=ad,
                Soyad=soyad,
                Mail=mail,
                TelNo=telNo,
                CinsiyetTanimId=cinsiyet,
                IlTanimId=il,
                VekilTanimId=vekil,
                Aktif=aktif,
                EklenmeTarihi=DateTime.Now
                
                
                });
            }
        
            else {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Ve Bilgileri Doğru Girdiğinizden Emin Olunuz..","Program");
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
        private void VekilDoldur() {
            cbVekilTanim.DataSource = _Vekil.ListeGetir();
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.DisplayMember += "Soyad";
            cbVekilTanim.ValueMember = "Id";


        }

    }
}
