using MeclisDao.Enums;
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

namespace Meclis.Listeler
{
    public partial class FrmDanismanListe : Form
    {
        private IDanismanTanimService _danismanTanimService;
        IVekilTanimService _vekilTanim;
      
        private IIlTanimService _ilTanim;
        public FrmDanismanListe()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            _danismanTanimService = InstanceFactory.GetInstance<IDanismanTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _ilTanim = InstanceFactory.GetInstance<IIlTanimService>();
      
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            cmbFiltre.SelectedItem = "Tümü";
          //  TumunuListele();
        }
        private void FrmDanismanListe_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }

        private void TumunuListele()
        {
            dgDanismanListe.DataSource = (from dts in _danismanTanimService.ListeGetir()
                                          join c in Enum.GetValues(typeof(Cinsiyet)).Cast<Cinsiyet>() on dts.CinsiyetTanimId equals c.GetHashCode()

                                          join vt in _vekilTanim.ListeGetir() on dts.VekilTanimId equals vt.Id
                                          join i in _ilTanim.ListeGetir() on dts.IlTanimId equals i.Id
                                          select new
                                          {
                                              dts.Id,
                                              dts.TcKimlikNo,
                                              AdSoyad = dts.Ad + "" + dts.Soyad,
                                              dts.TelNo,
                                              dts.Mail,
                                              Cinsiyet = c.ToString(),
                                              i.IlAdi,
                                              VekilAdSoyad = vt.Ad + "" + vt.Soyad,
                                              VekilTcKimlikNo = vt.TcKimlikNo,
                                              dts.Aktif,
                                          }).ToList();

        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                _danismanTanimService.ExceleAktar(dgDanismanListe);
                MessageBox.Show("Excele Aktarım İşlemi Başarıyla Tamamlandı.", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (DaoException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
            dgDanismanListe.DataSource = (from dts in _danismanTanimService.FiltreleGetir(cmbFiltre.SelectedItem.ToString(), txtAra.Text)
                                          join c in Enum.GetValues(typeof(Cinsiyet)).Cast<Cinsiyet>() on dts.CinsiyetTanimId equals c.GetHashCode()
                                          join vt in _vekilTanim.ListeGetir() on dts.VekilTanimId equals vt.Id
                                          join i in _ilTanim.ListeGetir() on dts.IlTanimId equals i.Id
                                          select new {
                                              dts.Id,
                                              dts.TcKimlikNo,
                                              AdSoyad = dts.Ad + "" + dts.Soyad,
                                              dts.TelNo,
                                              dts.Mail,
                                              Cinsiyet = c.ToString(),
                                              i.IlAdi,
                                              VekilAdSoyad = vt.Ad + "" + vt.Soyad,
                                              VekilTcKimlikNo = vt.TcKimlikNo,
                                              dts.Aktif,
                                          }).ToList();
        }

      
    }
}
