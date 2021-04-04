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
    public partial class FrmGrupPersonelListe : Form
    {
        private IGrupPersonelTanimService _grupPersonel;
        public FrmGrupPersonelListe()
        {
            InitializeComponent();
            _grupPersonel = InstanceFactory.GetInstance<IGrupPersonelTanimService>();
        }

        private void FrmGrupPersonelListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            var liste = _grupPersonel.ListeGetir().Select(x=> new {
            x.Id,
            x.TcKimlikNo,
           AdSoyad= x.Ad+""+x.Soyad,
           x.MeclisGorevId,
           x.TelNo,
           x.Mail,
           x.IlTanimId,
           x.CinsiyetTanimId,
           x.Aktif
           
            }).ToList();
            dgList.DataSource = liste;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgList.DataSource = _grupPersonel.AdGoreGetir(txtAra.Text).Select(x=>new {
                    x.Id,
                    x.TcKimlikNo,
                    AdSoyad = x.Ad + "" + x.Soyad,
                    x.MeclisGorevId,
                    x.TelNo,
                    x.Mail,
                    x.IlTanimId,
                    x.CinsiyetTanimId,
                    x.Aktif
                }).ToList();
            }
            else
            {
                TumunuListele();
            }
        }
    }
}
