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
        private IIlTanimService _ilTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IMeclisGorevTanimService _meclisGorevTanim;
        public FrmGrupPersonelListe()
        {
            InitializeComponent();
            _grupPersonel = InstanceFactory.GetInstance<IGrupPersonelTanimService>();
            _ilTanim = InstanceFactory.GetInstance<IIlTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
        }

        private void FrmGrupPersonelListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = (from grupPer in _grupPersonel.ListeGetir()
                         join il in _ilTanim.ListeGetir() on grupPer.IlTanimId equals il.Id
                         join cinsiyet in _cinsiyetTanim.ListeGetir() on grupPer.CinsiyetTanimId equals cinsiyet.Id
                         join meclisgorev in _meclisGorevTanim.ListeGetir() on grupPer.MeclisGorevId equals meclisgorev.Id
                         select new
                         {
                             grupPer.Id,
                             grupPer.TcKimlikNo,
                             AdSoyad = grupPer.Ad + "" + grupPer.Soyad,
                             grupPer.TelNo,
                             grupPer.Mail,
                             il.IlAdi,
                             cinsiyet.CinsiyetAdi,
                             meclisgorev.MeclisGorevAdi,
                             grupPer.Aktif
                         }).ToList();
      
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgList.DataSource = _grupPersonel.AdGoreGetir(txtAra.Text).Select(x => new
                {
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
