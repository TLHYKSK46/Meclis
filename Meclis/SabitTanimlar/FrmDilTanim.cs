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
        private IDilTanimService _dilService;
        public FrmDilTanim()
        {
            _dilService = InstanceFactory.GetInstance<IDilTanimService>();

            InitializeComponent();
        }
        
        private void FrmDilTanim_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dilAdi= txtDilAdi.Text;
            string dilSeviyesi = cbDilSeviyesi.Text;
            if ((!dilAdi.Equals("") || dilAdi!=null)&&(!dilSeviyesi.Equals("")||dilSeviyesi!=null))
            {
                _dilService.Ekle(new DilTanim { 
                DilAdi=dilAdi,
                DilSeviye=dilSeviyesi,
                EklenmeTarihi=DateTime.Now
                
                });
                MessageBox.Show("Dil Eklendi!","Admin");
            }

        }
    }
}
