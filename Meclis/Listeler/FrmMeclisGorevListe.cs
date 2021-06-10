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
        public FrmMeclisGorevListe()
        {
            InitializeComponent();
            _meclisGorev = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
       
        }

        private void FrmMeclisGorevListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = (from mg in _meclisGorev.ListeGetir()
                                 join vt in _vekilTanim.ListeGetir() on mg.Id equals vt.MeclisGorevId
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
