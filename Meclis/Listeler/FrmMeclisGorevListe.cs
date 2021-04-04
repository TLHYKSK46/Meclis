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
    public partial class FrmMeclisGorevListe : Form
    {
        private IMeclisGorevTanimService _meclisGorev;
        public FrmMeclisGorevListe()
        {
            InitializeComponent();
            _meclisGorev = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
        }

        private void FrmMeclisGorevListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = _meclisGorev.ListeGetir().Select(x=>new { 
            x.Id,
            x.MeclisGorevAdi
            
            });
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgList.DataSource = _meclisGorev.AdGoreGetir(txtAra.Text);

            }
            else
            {
                TumunuListele();
            }
        }
    }
}
