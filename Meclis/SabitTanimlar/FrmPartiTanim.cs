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
    public partial class FrmPartiTanim : Form
    {
        private IPartiTanimService _partiTanim;
        public FrmPartiTanim()
        {
            InitializeComponent();
            _partiTanim = InstanceFactory.GetInstance<IPartiTanimService>();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string partiAdi = txtPartiAdi.Text;
            if (partiAdi != null && partiAdi != "")
            {
                try
                {
                    _partiTanim.Ekle(new PartiTanim
                    {
                      PartiAdi=partiAdi
                    });
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");

                    txtPartiAdi.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Parti Adı Giriniz!", "Sistem");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
