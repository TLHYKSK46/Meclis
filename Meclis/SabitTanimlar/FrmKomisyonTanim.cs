using MeclisDao.Exceptions;
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
    public partial class FrmKomisyonTanim : Form
    {
        private IKomisyonTanimService _komisyonTanim;
        public FrmKomisyonTanim()
        {
            InitializeComponent();
            _komisyonTanim = InstanceFactory.GetInstance<IKomisyonTanimService>();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ihtisasAdi = txtIhtisasAdi.Text;
            string uluslararasiAdi = txtUluslararasiAdi.Text;

            if (ihtisasAdi!=null && uluslararasiAdi!=null)
            {
                try
                {
                    var data = new KomisyonTanim() { 
                    IhtisasAdi=ihtisasAdi,
                    UluslararasiAdi=uluslararasiAdi
                    };
                    _komisyonTanim.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.","Sistem");
                    txtIhtisasAdi.Text = "";
                    txtUluslararasiAdi.Text = "";
                }
                catch (DaoException  ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }

            }

        }
    }
}
