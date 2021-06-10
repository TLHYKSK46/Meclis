using MeclisDao.Exceptions;
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
        private IVekilTanimService _vekilTanim;
        private IKomisyonDurumService _komisyonDurumService;
        public FrmKomisyonListe()
        {
            InitializeComponent();
            _komisyonTanim = InstanceFactory.GetInstance<IKomisyonTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
         
            _komisyonDurumService = InstanceFactory.GetInstance<IKomisyonDurumService>();
        }

        private void FrmKomisyonListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = (from kt in _komisyonTanim.ListeGetir()
                                 join kd in _komisyonDurumService.ListeGetir() on kt.Id equals kd.KomisyonTanimId
                                 join vt in _vekilTanim.ListeGetir() on kd.VekilTanimId equals vt.Id
                                 select new { 
                                 kd.Id,
                                     vt.TcKimlikNo,
                                     AdSoyad = vt.Ad + "" + vt.Soyad,
                                     kt.KomisyonAdi,
                                 kt.KomisyonTuru,
                                
                                 
                                 }
                                 ).ToList();
                
            //    komisyonTanim.ListeGetir().Select(x=>new { 
            //x.Id,
            //x.IhtisasAdi,
            //x.UluslararasiAdi
            //}).ToList();
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

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                _komisyonDurumService.ExceleAktar(dgList);
                MessageBox.Show("Excele Aktarım İşlemi Başarıyla Tamamlandı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
