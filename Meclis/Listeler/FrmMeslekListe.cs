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
    public partial class FrmMeslekListe : Form
    {
        private IMeslekTanimService _meslekTanimService;
        public FrmMeslekListe()
        {
            InitializeComponent();
            _meslekTanimService = InstanceFactory.GetInstance<IMeslekTanimService>();
        }

        private void MeslekListe_Load(object sender, EventArgs e)
        {
            TumMeslekListele();
        }

        private void TumMeslekListele()
        {
            dgMeslekList.DataSource = _meslekTanimService.ListeGetir();
        }

      

        private void txtListeAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtListeAra.Text))
            {
                dgMeslekList.DataSource = _meslekTanimService.MeslekAdiGetir(txtListeAra.Text);
            }
            else
            {
                TumMeslekListele();
            }
        }
    }
}
