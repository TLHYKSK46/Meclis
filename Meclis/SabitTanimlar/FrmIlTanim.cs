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
    public partial class FrmIlTanim : Form
    {
        private IIlTanimService _iltanim;
        public FrmIlTanim()
        {
            InitializeComponent();
            _iltanim = InstanceFactory.GetInstance<IIlTanimService>();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int ilKodu =Convert.ToInt32(txtIlKodu.Text);
            string ilAdi = txtIlAdi.Text;
            string ilBolgesi = cbIlBolgesi.Text;
            if (ilAdi!=null &&ilKodu!=0 &&ilBolgesi!=null)
            {
                _iltanim.Ekle(new IlTanim { 
                IlAdi=ilAdi,
                IlBolgesi=ilBolgesi,
                IlKodu=ilKodu
                });
                MessageBox.Show("Kayıt Başarıyla Eklendi.","Program");
                txtIlAdi.Text = "";
                txtIlKodu.Text = "";
                cbIlBolgesi.Text = "";
            }

        }
    }
}
