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

namespace Meclis.SabitTanimlar
{
    public partial class FrmMasaTanim : Form
    {
        IMasaTanimService _masaTanimService;
        public FrmMasaTanim()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            _masaTanimService = InstanceFactory.GetInstance<IMasaTanimService>();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FrmMasaTanim_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!txtKacKisilik.Text.Equals(null) && !txtKisaKenar1.Text.Equals(null)&& !txtKisaKenar2.Text.Equals(null) 
                && !txtUzunKenar1.Text.Equals(null) && !txtUzunKenar2.Text.Equals(null))
            {
                int kisakenar1 = Convert.ToInt32(txtKisaKenar1.Text);
                int kisakenar2 = Convert.ToInt32(txtKisaKenar2.Text);
                int uzunkenar1 = Convert.ToInt32(txtUzunKenar1.Text);
                int uzunkenar2 = Convert.ToInt32(txtUzunKenar2.Text);
                int toplam = kisakenar1 + kisakenar2 + uzunkenar1 + uzunkenar2;

                if (Convert.ToInt32(txtKacKisilik.Text).Equals(toplam))
                {
                    _masaTanimService.Ekle(new MeclisEntities.Entities.MasaTanim { 
                    KacKisilik= Convert.ToInt32(txtKacKisilik.Text),
                    KisaKenar1=kisakenar1,
                    KisaKenar2=kisakenar2,
                    UzunKenar1=uzunkenar1,
                    UzunKenar2=uzunkenar2,
                    Tarih=dtTarih.Value
                    });
                }

            }
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
          dgListe.DataSource= _masaTanimService.ListeGetir().ToList();
        }
    }
}
