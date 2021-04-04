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
    public partial class FrmDilListe : Form
    {
        IDilTanimService _dilTanimService;
        public FrmDilListe()
        {
            InitializeComponent();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();
        }

       

        private void FrmDilListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgDilListe.DataSource = _dilTanimService.AdGoreGetir(txtAra.Text);
            }
            else
            {
                TumunuListele();
            }
        }

        private void TumunuListele() {
            var liste = _dilTanimService.ListeGetir().Select(x=>new { 
            x.Id,
            x.DilAdi
            }).ToList();
            dgDilListe.DataSource = liste;
        }
    }
}
