﻿using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meclis.SabitTanimlar
{
    public partial class FrmGrupPersonelTanim : Form
    {
        private IGrupPersonelTanimService _grupPersonel;
        private IMeclisGorevTanimService _meclisGorevTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IIlTanimService _ilTanim;
        public FrmGrupPersonelTanim()
        {
            InitializeComponent();
            _grupPersonel = InstanceFactory.GetInstance<IGrupPersonelTanimService>();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _ilTanim = InstanceFactory.GetInstance<IIlTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();

            cbMeclisGorevDoldur();
            cbSehirDoldur();
            cbCinsiyetDoldur();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTcKimlikNo.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string sifre = txtSifre.Text;
            string telNo = txtTelNo.Text;
            string mail = txtMail.Text;
            int cinsiyet = Convert.ToInt32(cbCinsiyet.SelectedValue);
            int il = Convert.ToInt32(cbIl.SelectedValue);
            int meclisGorev = Convert.ToInt32(cbMeclisGorev.SelectedValue);
            bool aktif = chkAktif.Checked;
            if (tcKimlikNo != null && ad != null & soyad != null && (cinsiyet > -1) && (cinsiyet < 2) && (!(il < 1) && !(il > 81)) && meclisGorev != 0 && sifre!=null)
            {
                try
                {

                    _grupPersonel.Ekle(new GrupPersonelTanim { 
                    Ad=ad,
                    Aktif=aktif,
                     CinsiyetTanimId=cinsiyet,
                     IlTanimId=il,
                     Mail=mail,
                     MeclisGorevId=meclisGorev,
                     Soyad=soyad,
                     TcKimlikNo=tcKimlikNo,
                     TelNo=telNo,
                     Sifre=sifre
                    
                    
                    });
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString(),"Program");
                }
                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.","Sistem");
                textBoşalt();

            }
            else {
                MessageBox.Show("Lütfen Doldurulması Zorunlu Alanların Boş Olmadığından Emin Olunuz!", "Sistem");
            }
        }

        private void cbMeclisGorevDoldur() {
            cbMeclisGorev.DataSource = _meclisGorevTanim.ListeGetir();
            cbMeclisGorev.DisplayMember = "MeclisGorevAdi";
            cbMeclisGorev.ValueMember = "Id";

        }
        private void cbSehirDoldur()
        {
            cbIl.DataSource = _ilTanim.ListeGetir();
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "Id";
        }
        private void cbCinsiyetDoldur() {
            cbCinsiyet.DataSource = _cinsiyetTanim.ListeGetir();
            cbCinsiyet.DisplayMember = "CinsiyetAdi";
            cbCinsiyet.ValueMember = "Id";
        }
        private void textBoşalt() {
            txtAd.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            txtSoyad.Text = "";
            txtTcKimlikNo.Text = "";
            txtTelNo.Text = "";
           
        }

        private void FrmGrupPersonelTanim_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
