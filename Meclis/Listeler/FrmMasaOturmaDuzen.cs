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
    public partial class FrmMasaOturmaDuzen : Form
    {
        IVekilTanimService _vekilTanimService;
        IMasaTanimService _masaTanimService;
        IMasaOturumDuzenService _masaOturumDuzenService;
        public FrmMasaOturmaDuzen()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _masaOturumDuzenService = InstanceFactory.GetInstance<IMasaOturumDuzenService>();
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _masaTanimService = InstanceFactory.GetInstance<IMasaTanimService>();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vekilListele();
        }

        private void FrmMasaOturmaDuzen_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void vekilListele() {

            var liste = new List<VekilTanim>();
            foreach (var item in _vekilTanimService.ListeGetir().ToList())
            {
                chkListVekil.Items.Add(item.Id+" "+item.Ad+" "+item.Soyad);
            }
        }
    }
}
