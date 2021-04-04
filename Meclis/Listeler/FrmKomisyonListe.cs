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
    public partial class FrmKomisyonListe : Form
    {
        private IKomisyonTanimService _komisyonTanim;
        public FrmKomisyonListe()
        {
            InitializeComponent();
            _komisyonTanim = InstanceFactory.GetInstance<IKomisyonTanimService>();
        }

        private void FrmKomisyonListe_Load(object sender, EventArgs e)
        {

        }
    }
}
