﻿using MeclisDao.Exceptions;
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
        IVekilTanimService _vekilTanim;
        public FrmGenelMerkezGorevListe()
        {
            InitializeComponent();
            _genelMerkez = InstanceFactory.GetInstance<IGenelMerkezGorevService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
           
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
            }).ToList();

            dgGenelMerkezListe.DataSource = (from gm in _genelMerkez.ListeGetir()
                                             join vt in _vekilTanim.ListeGetir() on gm.Id equals vt.GenelMerkezGorevId
                                             select new
                                             {
                                                 gm.Id,
                                                 vt.TcKimlikNo,
                                                 AdSoyad=vt.Ad+""+vt.Soyad,
                                                 gm.GenelMerkezGorevAdi,
                                                 vt.KurumsalTelNo,
                                                 vt.KurumsalMail,
                                             }
                                             ).ToList();
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

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                _genelMerkez.ExceleAktar(dgGenelMerkezListe);
                MessageBox.Show("Excele Aktarım İşlemi Başarıyla Tamamlandı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
