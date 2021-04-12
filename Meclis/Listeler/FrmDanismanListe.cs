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
        IVekilTanimService _vekilTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IIlTanimService _ilTanim;
        public FrmDanismanListe()
        {
            InitializeComponent();
            _danismanTanimService = InstanceFactory.GetInstance<IDanismanTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _ilTanim = InstanceFactory.GetInstance<IIlTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
        }

        private void FrmDanismanListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgDanismanListe.DataSource = (from dts in _danismanTanimService.ListeGetir()
                                          join c in _cinsiyetTanim.ListeGetir() on dts.CinsiyetTanimId equals c.Id
                                          join vt in _vekilTanim.ListeGetir() on dts.VekilTanimId equals vt.Id
                                          join i in _ilTanim.ListeGetir() on dts.IlTanimId equals i.Id
                                          select new
                                          {
                                              dts.Id,
                                              dts.TcKimlikNo,
                                              AdSoyad = dts.Ad + "" + dts.Soyad,
                                              dts.TelNo,
                                              dts.Mail,
                                              c.CinsiyetAdi,
                                              i.IlAdi,
                                              VekilAdSoyad = vt.Ad + "" + vt.Soyad,
                                              VekilTcKimlikNo = vt.TcKimlikNo,
                                              dts.Aktif,
                                          }).ToList();

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
