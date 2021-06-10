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
    public partial class FrmVekilDetay : Form
    {
       
        private IDonemTanimService _donemTanim;
        private IDostlukGrupTanimService _dostlukGrupTanim;
        private IIlTanimService _ilTanim;
        private IKomisyonDurumService _komisyonDurum;
        private IMeclisGorevTanimService _meclisGorevTanim;
        private IMeslekTanimService _meslekTanim;
        private IPartiGrupTanimService _PartiGrupTanim;
        private IPartiTanimService _partiTanim;
        private IVekilTanimService _vekilTanim;
        public FrmVekilDetay()
        {
      
            _donemTanim= InstanceFactory.GetInstance<IDonemTanimService>();
            _dostlukGrupTanim = InstanceFactory.GetInstance<IDostlukGrupTanimService>();
            _ilTanim = InstanceFactory.GetInstance<IIlTanimService>();
            _komisyonDurum = InstanceFactory.GetInstance<IKomisyonDurumService>();
            _meclisGorevTanim = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _meslekTanim = InstanceFactory.GetInstance<IMeslekTanimService>();
            _PartiGrupTanim = InstanceFactory.GetInstance<IPartiGrupTanimService>();
            _partiTanim = InstanceFactory.GetInstance<IPartiTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();

            InitializeComponent();

        }

        private void FrmVekilDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           // int vekilId = Convert.ToInt32(cbVekil.SelectedValue);
          //  int danismanId = Convert.ToInt32(cbDanisman.SelectedValue);
            //int sira = Convert.ToInt32(txtSira.Text);

            if ((Convert.ToInt32(vekilId.Text)> 0))
            {
                try
                {
                   

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                  

                
                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Sistem");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!.", "Sistem");
            }
        }
        #region combo doldur metotları
        

        #endregion
    }
}
