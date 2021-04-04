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

namespace Meclis.Listeler
{
    public partial class FrmMazeretListe : Form
    {
        private IMazeretTanimService _mazeretTanim;
        public FrmMazeretListe()
        {
            InitializeComponent();
            _mazeretTanim = InstanceFactory.GetInstance<IMazeretTanimService>();
        }

        private void FrmMazeretListe_Load(object sender, EventArgs e)
        {

        }
    }
}
