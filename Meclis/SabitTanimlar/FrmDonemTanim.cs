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
    public partial class FrmDonemTanim : Form
    {
        private IDonemTanimService _donemService;
       
        public FrmDonemTanim()
        {
            _donemService = InstanceFactory.GetInstance<IDonemTanimService>();
       

            InitializeComponent();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string donem = txtDonemAdi.Text;
            if (donem != null || donem != "")
            {
                _donemService.Ekle(new DonemTanim { 
                DonemAdi=donem
                });

            }
            else {
                MessageBox.Show("Lütfen Bir Dönem Giriniz!","Program");
            }

        }
    }
}
