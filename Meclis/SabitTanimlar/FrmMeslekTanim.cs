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
    public partial class FrmMeslekTanim : Form
    {
        private IMeslekTanimService _meslekTanim;
        public FrmMeslekTanim()
        {
            InitializeComponent();
            _meslekTanim = InstanceFactory.GetInstance<IMeslekTanimService>();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string meslekAdi = txtMeslekAdi.Text;
            if (meslekAdi != null && meslekAdi != "")
            {
                try
                {
                    _meslekTanim.Ekle(new MeslekTanim
                    {
                        MeslekAdi = meslekAdi
                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");

                    txtMeslekAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Meslek Adı Giriniz!", "Sistem");
            }

        }
    }
}
