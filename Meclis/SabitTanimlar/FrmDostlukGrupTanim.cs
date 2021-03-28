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
    public partial class FrmDostlukGrupTanim : Form
    {
        private IDostlukGrupTanimService _dostlukGrupTanim; 
        public FrmDostlukGrupTanim()
        {
            _dostlukGrupTanim = InstanceFactory.GetInstance<IDostlukGrupTanimService>();
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dgAdi = txtDostlukGrupAdi.Text;
            if (dgAdi != null && dgAdi != "")
            {
                _dostlukGrupTanim.Ekle(new DostlukGrupTanim
                {
                    DostlukGrupAdi = dgAdi,
                    EklenmeTarihi = DateTime.Now

                });
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Program");
                txtDostlukGrupAdi.Text = "";
            }
            else { 
                MessageBox.Show("Lütfen bir Dostluk Grup Adı giriniz!.","Program");

            }
        }
    }
}
