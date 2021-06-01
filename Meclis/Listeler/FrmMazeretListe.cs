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
    public partial class FrmMazeretListe : Form
    {
        private IMazeretTanimService _mazeretTanim;
        private IVekilTanimService _vekilTanim;
       
        private IVekilDetayService _vekilDetayService;
        private IMazeretKodService _mazeretKodService;
        public FrmMazeretListe()
        {
            InitializeComponent();
            _mazeretTanim = InstanceFactory.GetInstance<IMazeretTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
          
            _vekilDetayService = InstanceFactory.GetInstance<IVekilDetayService>();
           _mazeretKodService = InstanceFactory.GetInstance<IMazeretKodService>();
        }

        private void FrmMazeretListe_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void TumunuListele()
        {
            dgList.DataSource = (from mt in _mazeretTanim.ListeGetir()
                                 join mk in _mazeretKodService.ListeGetir() on mt.MazeretKodId equals mk.Id
                                 //join vd in _vekilDetayService.ListeGetir() on mt.Id equals vd.MazeretTanimId
                                 join vt in  _vekilTanim.ListeGetir() on mt.VekilTanimId equals vt.Id
                                 select new { 
                                 mt.Id,
                                     vt.TcKimlikNo,
                                     AdSoyad = vt.Ad + "" + vt.Soyad,
                                     mk.MazeretKodu,
                                     mt.MazeretNedeni,
                                     mt.BaslamaTarihi,
                                     mt.BitisTarihi
                                 }).ToList();
                
            //    _mazeretTanim.ListeGetir().Select(x=>new { 
            //x.Id,
            //    x.VekilTanimId,
            //    x.MazeretKodId,
            //x.MazeretNedeni,
            //x.BaslamaTarihi,
            //x.BitisTarihi,
          
            //});
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                dgList.DataSource = _mazeretTanim.AdGoreGetir(txtAra.Text);

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
                _mazeretTanim.ExceleAktar(dgList);
                MessageBox.Show("Excele Aktarım İşlemi Başarıyla Tamamlandı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
