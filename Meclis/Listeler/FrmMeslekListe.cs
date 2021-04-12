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
    public partial class FrmMeslekListe : Form
    {
        private IMeslekTanimService _meslekTanimService;
       private IVekilTanimService _vekilTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IVekilDetayService _vekilDetayService;
        public FrmMeslekListe()
        {
            InitializeComponent();
            _meslekTanimService = InstanceFactory.GetInstance<IMeslekTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _vekilDetayService = InstanceFactory.GetInstance<IVekilDetayService>();
        }

        private void MeslekListe_Load(object sender, EventArgs e)
        {
            TumMeslekListele();
        }

        private void TumMeslekListele()
        {
            //dgMeslekList.DataSource = _meslekTanimService.ListeGetir();
            dgMeslekList.DataSource = (from mt in _meslekTanimService.ListeGetir()
                                 join vd in _vekilDetayService.ListeGetir() on mt.Id equals vd.MeslekTanimId
                                 join vt in _vekilTanim.ListeGetir() on vd.VekilTanimId equals vt.Id
                                 select new
                                 {
                                     mt.Id,
                                     vt.TcKimlikNo,
                                     AdSoyad = vt.Ad + "" + vt.Soyad,
                                     mt.MeslekAdi,
                                     

                                 }).ToList();
        }

      

        private void txtListeAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtListeAra.Text))
            {
                dgMeslekList.DataSource = _meslekTanimService.MeslekAdiGetir(txtListeAra.Text);
            }
            else
            {
                TumMeslekListele();
            }
        }

        private void dgMeslekList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
