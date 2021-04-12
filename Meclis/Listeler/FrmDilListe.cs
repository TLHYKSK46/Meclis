﻿using MeclisDao.IDaoServis;
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
        IVekilTanimService _vekilTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IVekilDetayService _vekilDetayService;
        public FrmDilListe()
        {
            InitializeComponent();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _vekilDetayService = InstanceFactory.GetInstance<IVekilDetayService>();
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
        private void TumunuListele()
        {
            dgDilListe.DataSource = (from vt in _vekilTanim.ListeGetir()
                                     join vd in _vekilDetayService.ListeGetir() on vt.Id equals vd.VekilTanimId
                                     join dt in _dilTanimService.ListeGetir() on vd.DilTanimId equals dt.Id
                                     select new
                                     {
                                         vt.Id,
                                         vt.TcKimlikNo,
                                         AdSoyad = vt.Ad + "" + vt.Soyad,
                                         Dil = dt.DilAdi,
                                     }
                        ).ToList();
        }
    }
}
