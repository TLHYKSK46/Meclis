using Meclis.Listeler;
using Meclis.SabitTanimlar;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
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
        private IVekilDetayService _vekilDetayService;
    
        public FrmAnaEkran()
        {
            InitializeComponent();
         
            _vekilDetayService = InstanceFactory.GetInstance<IVekilDetayService>();
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
           

            dgwVekilDetay.DataSource = _vekilDetayService.ListeGetir();

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void meslekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMeslekList = new FrmMeslekListe();
            frmMeslekList.Show();
        }

        private void danismanListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDanismanListe();
            frm.Show();
        }

        private void dilListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDilListe();
            frm.Show();
        }

        private void genelMerkezGörevListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGenelMerkezGorevListe();
            frm.Show();
        }

        private void grupPersonelListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGrupPersonelListe();
            frm.Show();
        }

        private void komisyonListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKomisyonListe();
            frm.Show();
        }

        private void meclisGörevListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMeclisGorevListe();
            frm.Show();
        }

        private void mazeretListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMazeretListe();
            frm.Show();
        }
    }
}
