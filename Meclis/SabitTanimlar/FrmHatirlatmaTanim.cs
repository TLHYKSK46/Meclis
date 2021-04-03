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
    public partial class FrmHatirlatmaTanim : Form
    {
        private IHatirlatmaTanimService _hatirlatmaTanimService;
        private IVekilTanimService _vekilTanim;
        public FrmHatirlatmaTanim()
        {
         
            InitializeComponent();
            _hatirlatmaTanimService = InstanceFactory.GetInstance<IHatirlatmaTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();

            cbVekilDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text;
            string aciklama = txtAciklama.Text;
            DateTime hatirlatmaTarihi = dtHatirlatmaTarihi.Value;
            int vekilTanimId = Convert.ToInt32(cbVekilTanim.SelectedValue);
            try
            {
             
            }
            catch (Exception )
            {

                throw;
            }
          


            if (baslik!=null&& aciklama!=null &&hatirlatmaTarihi !=null && vekilTanimId!=0 && vekilTanimId!=-1)
            {
                try
                {
                    
                    var data = new HatirlatmaTanim()
                    {
                        Baslik = baslik,
                        Aciklama = aciklama,
                        HatirlatmaTarihi = hatirlatmaTarihi,
                        VekilTanimId = vekilTanimId,
                        OlusturmaTarihi = DateTime.Now
                    };
                    //var kontrol = data.HatirlatmaTarihi.Date != DateTime.Now.Date && !(data.HatirlatmaTarihi.Date < DateTime.Now.Date);
                    
                    //if(!kontrol)
                    //    throw new DaoException("Bugün veya Eski Bir Tarihe Hatırlatma Ekleyemezsiniz!");
                    _hatirlatmaTanimService.Ekle(data);

                    MessageBox.Show("Hatırlatma Başarıyla Eklendi.","Sistem");
                    txtBaslik.Text = "";
                    txtAciklama.Text = "";
                }
                catch (DaoException ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
                
            }

        }


        private void cbVekilDoldur() {
            cbVekilTanim.DataSource = _vekilTanim.ListeGetir();
            cbVekilTanim.DisplayMember = "Ad";
            cbVekilTanim.ValueMember = "Id";
        
        }
        //private Boolean kontrol(HatirlatmaTanim data) {

        //    if (data.HatirlatmaTarihi.Date == DateTime.Now.Date && data.HatirlatmaTarihi.Date < DateTime.Now.Date)
        //    {
        //        MessageBox.Show("Bugün veya Eski Bir Tarihe Hatırlatma Ekleyemezsiniz!");
        //        return false;
        //    }
        //    return true;
        //  }
    }
}
