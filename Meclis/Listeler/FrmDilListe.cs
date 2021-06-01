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
    public partial class FrmDilListe : Form
    {
        IDilTanimService _dilTanimService;
        IVekilTanimService _vekilTanim;
        
        private IVekilDetayService _vekilDetayService;
        public FrmDilListe()
        {
            InitializeComponent();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            
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
            //dgDilListe.DataSource = (from vt in _vekilTanim.ListeGetir()
            //                         join vd in _vekilDetayService.ListeGetir() on vt.Id equals vd.VekilTanimId
            //                         join dt in _dilTanimService on vt.Id equals dt.
            //                         select new
            //                         {
            //                             vt.Id,
            //                             vt.TcKimlikNo,
            //                             AdSoyad = vt.Ad + "" + vt.Soyad,
            //                             Dil = dt.DilAdi,
            //                         }
            //            ).ToList();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                _dilTanimService.ExceleAktar(dgDilListe);
                MessageBox.Show("Excele Aktarım İşlemi Başarıyla Tamamlandı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //dgDilListe.DataSource = (from vt in _vekilTanim.FiltreleGetir(cmbFiltre.SelectedItem.ToString(),txtAra.Text)
            //                         join vd in _vekilDetayService.ListeGetir() on vt.Id equals vd.VekilTanimId
            //                         join dt in _dilTanimService.ListeGetir() on vd.DilTanimId equals dt.Id
            //                         select new
            //                         {
            //                             vt.Id,
            //                             vt.TcKimlikNo,
            //                             AdSoyad = vt.Ad + " " + vt.Soyad,
            //                             Dil = dt.DilAdi,
            //                         }
            //        ).ToList();
           
        }
    }
}
