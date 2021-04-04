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
            var illiste = _ilTanim.ListeGetir();
            var cinsiyetList = _cinsiyetTanim.ListeGetir();
            var meclisGorevList = _meclisGorevTanim.ListeGetir();
            var grupPersonelliste = _grupPersonel.ListeGetir();

            var liste = (from grupPer in grupPersonelliste
                         join il in illiste on grupPer.IlTanimId equals il.Id
                         join cinsiyet in cinsiyetList on grupPer.CinsiyetTanimId equals cinsiyet.Id
                         join meclisgorev in meclisGorevList on grupPer.MeclisGorevId equals meclisgorev.Id
                         select new {
                             grupPer.Id,
                             grupPer.TcKimlikNo,
                             AdSoyad=grupPer.Ad+""+grupPer.Soyad,
                             grupPer.TelNo,
                             grupPer.Mail,
                             il.IlAdi,
                             cinsiyet.CinsiyetAdi,
                             meclisgorev.MeclisGorevAdi,
                             grupPer.Aktif


                         }).ToList();
            //var list = grupPersonelliste.GroupJoin(illiste,meclisGorevList,cinsiyetList);


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
