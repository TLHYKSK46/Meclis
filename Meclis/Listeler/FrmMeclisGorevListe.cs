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
    public partial class FrmMeclisGorevListe : Form
    {
        private IMeclisGorevTanimService _meclisGorev;
        IVekilTanimService _vekilTanim;
        private ICinsiyetTanimService _cinsiyetTanim;
        private IVekilDetayService _vekilDetayService;
        public FrmMeclisGorevListe()
        {
            InitializeComponent();
            _meclisGorev = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _cinsiyetTanim = InstanceFactory.GetInstance<ICinsiyetTanimService>();
            _vekilDetayService = InstanceFactory.GetInstance<IVekilDetayService>();
        }

        private void FrmMeclisGorevListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = (from mg in _meclisGorev.ListeGetir()
                                 join vd in _vekilDetayService.ListeGetir() on mg.Id equals vd.MeclisGorevTanimId
                                 join vt in _vekilTanim.ListeGetir() on vd.VekilTanimId equals vt.Id
                                 select new { 
                                 mg.Id,
                                     vt.TcKimlikNo,
                                     AdSoyad = vt.Ad + "" + vt.Soyad,
                                     mg.MeclisGorevAdi,
                                    
                                 }).ToList(); 
            //    _meclisGorev.ListeGetir().Select(x=>new { 
            //x.Id,
            //x.MeclisGorevAdi
            
            //});
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgList.DataSource = _meclisGorev.AdGoreGetir(txtAra.Text);

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
                _meclisGorev.ExceleAktar(dgList);
                MessageBox.Show("Excele Aktarım İşlemi Başarıyla Tamamlandı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
