using Meclis.SabitTanimlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meclis
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void dilTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDilTanim = new FrmDilTanim();
            frmDilTanim.Show();
        }

        private void vekilTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVekilTanim = new FrmVekilTanim();
            frmVekilTanim.Show();
        }
    }
}
