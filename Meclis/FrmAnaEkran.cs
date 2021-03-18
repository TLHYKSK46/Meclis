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

        private void dönemTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDonemTanim = new FrmDonemTanim();
            frmDonemTanim.Show();
        }

        private void dostlukGrupTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDoslukGrupTanim = new FrmDostlukGrupTanim();
            frmDoslukGrupTanim.Show();

        }

        private void genelMerkezGörevTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGenelMerkezGorev = new FrmGenelMerkezGorev();
            frmGenelMerkezGorev.Show();
        }

        private void grupPersonelTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGrupPersonelTanim = new FrmGrupPersonelTanim();
            frmGrupPersonelTanim.Show();
        }

        private void hatırlatmaTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHatirlatmaTanim = new FrmHatirlatmaTanim();
            frmHatirlatmaTanim.Show();
        }

        private void ilTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmIlTanim = new FrmIlTanim();
            frmIlTanim.Show();
        }

        private void komisyonTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmKomisyonTanim = new FrmKomisyonTanim();
            frmKomisyonTanim.Show();

        }

        private void mazeretTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMazeretTanim = new FrmMazeretTanim();
            frmMazeretTanim.Show();
        }

        private void meclisGörevTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMeclisGorevTanim = new FrmMeclisGorevTanim();
            frmMeclisGorevTanim.Show();
        }

        private void meslekTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMeslekTanim = new FrmMeslekTanim();
            frmMeslekTanim.Show();
        }

        private void partiTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPartiTanim = new FrmPartiTanim();
            frmPartiTanim.Show();
        }

        private void vekilDanışmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVekilDanisman = new FrmVekilDanisman();
            frmVekilDanisman.Show();
        }

        private void danismanTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDanismanTanim = new FrmDanismanTanim();
            frmDanismanTanim.Show();
                }
    }
}
