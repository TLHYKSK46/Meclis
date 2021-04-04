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
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = _komisyonTanim.ListeGetir().Select(x=>new { 
            x.Id,
            x.IhtisasAdi,
            x.UluslararasiAdi
            }).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgList.DataSource = _komisyonTanim.AdGoreGetir(txtAra.Text);

            }
            else
            {
                TumunuListele();
            }
        }
    }
}
