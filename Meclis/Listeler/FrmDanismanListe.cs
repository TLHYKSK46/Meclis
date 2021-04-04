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
    public partial class FrmDanismanListe : Form
    {
        private IDanismanTanimService _danismanTanimService;
        public FrmDanismanListe()
        {
            InitializeComponent();
            _danismanTanimService = InstanceFactory.GetInstance<IDanismanTanimService>();
        }

        private void FrmDanismanListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            var liste = _danismanTanimService.ListeGetir().Select(x => new {
                x.Id,
                x.TcKimlikNo,
                AdSoyad =x.Ad+""+x.Soyad,
            x.TelNo,
            x.Mail,
            x.Aktif,
            x.CinsiyetTanimId,
            x.IlTanimId,
            x.VekilTanimId
            }).ToList();
            dgDanismanListe.DataSource = liste;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgDanismanListe.DataSource = _danismanTanimService.AdGoreGetir(txtAra.Text);
            }
            else
            {
                TumunuListele();
            }
        }
    }
}
