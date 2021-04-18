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
        public FrmMeclisGorevTanim()
        {
            InitializeComponent();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
        }

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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
