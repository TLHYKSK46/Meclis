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
    public partial class FrmVekilTanim : Form
    {
        private IVekilTanimService _vekilTanimService;
        public FrmVekilTanim()
        {
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcKimlikNo= txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string kurumsalTel = txtKurumsalTelNo.Text;
            string kisiselTel = txtKisiselTelNo.Text;
            string kurumsalMail = txtKurumsalMail.Text;
            string kisiselMail = txtKisiselMail.Text;
            string aciklama = txtAciklama.Text;
            string ozgecmis = txtOzGecmis.Text;
            bool aktif=chkAktif.Checked;

            _vekilTanimService.Ekle(new VekilTanim { 
            TcKimlikNo=tcKimlikNo,
            Ad=ad,
            Soyad=soyad,
            KurumsalTelNo=kurumsalTel,
            KurumsalMail=kurumsalMail,
            Kisiselmail=kisiselMail,
            KisiselTelNo=kisiselTel,
            Aciklama=aciklama,
            Aktif=aktif,
            Ozgecmis=ozgecmis
            
            });
        }

        private void FrmVekilTanim_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
