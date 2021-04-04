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
    public partial class FrmGenelMerkezGorevListe : Form
    {
        private IGenelMerkezGorevService _genelMerkez;
        public FrmGenelMerkezGorevListe()
        {
            InitializeComponent();
            _genelMerkez = InstanceFactory.GetInstance<IGenelMerkezGorevService>();
        }

        private void FrmGenelMerkezGorevListe_Load(object sender, EventArgs e)
        {
            TumunuListele();

        }

        private void TumunuListele()
        {
            var liste = _genelMerkez.ListeGetir().Select(x=> new { 
            x.Id,
            x.GenelMerkezGorevAdi,
            x.EklenmeTarihi,
            x.GuncellemeTarihi
            }).ToList();
            
            dgGenelMerkezListe.DataSource = liste;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgGenelMerkezListe.DataSource = _genelMerkez.AdGoreGetir(txtAra.Text);
                
            }
            else
            {
                TumunuListele();
            }
        }
    }
}
