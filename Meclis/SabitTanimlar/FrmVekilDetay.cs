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
       private IVekilDetayService _vekilDetay;
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
            _vekilDetay = InstanceFactory.GetInstance<IVekilDetayService>();
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

            combolariDoldur();
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
                    var data = new VekilDetay()
                    {
                        DonemTanimId = Convert.ToInt32(cbDonem.SelectedValue),
                        DostlukGrupTanimId=Convert.ToInt32(cbDostlukGrup.SelectedValue),
                        IlTanimId = Convert.ToInt32(cbIl.SelectedValue),
                        KomisyonDurumId = Convert.ToInt32(cbKomisyonDurum.SelectedValue),
                        //MazeretTanimId = Convert.ToInt32(cbm.SelectedValue),
                        MeclisGorevTanimId = Convert.ToInt32(cbGenelMerkezGorev.SelectedValue),
                        MeslekTanimId = Convert.ToInt32(cbMeslek.SelectedValue),
                        OdaNoId = Convert.ToInt32(cbOdaNo.SelectedValue),
                        PartiGrupTanimId = Convert.ToInt32(cbPartiGrup.SelectedValue),
                        PartiTanimId = Convert.ToInt32(cbParti.SelectedValue),
                        VekilTanimId = Convert.ToInt32(vekilId.Text),

                    };
                    _vekilDetay.Ekle(data);

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
        private void combolariDoldur() {
            cbMeslekDoldur();
            cbKomisyonDurumDoldur();
            cbMeclisGorevDoldur();
            cbPartiDoldur();
            cbPartiGrupDoldur();
            cbDonemDoldur();
            cbDostlukGrupDoldur();
            cbIlDoldur();
        }
        private void cbDonemDoldur()
        {
            cbDonem.DataSource = _donemTanim.ListeGetir();
            cbDonem.DisplayMember = "ad";
            cbDonem.ValueMember = "Id";
        }
        private void cbDostlukGrupDoldur()
        {
            cbDostlukGrup.DataSource = _dostlukGrupTanim.ListeGetir();
            cbDostlukGrup.DisplayMember = "ad";
            cbDostlukGrup.ValueMember = "Id";
        }
        private void cbIlDoldur()
        {
            cbIl.DataSource = _ilTanim.ListeGetir();
            cbIl.DisplayMember = "ad";
            cbIl.ValueMember = "Id";
        }
        private void cbKomisyonDurumDoldur()
        {
            cbKomisyonDurum.DataSource = _komisyonDurum.ListeGetir();
            cbKomisyonDurum.DisplayMember = "ad";
            cbKomisyonDurum.ValueMember = "Id";
        }
        private void cbMeclisGorevDoldur()
        {
            cbMeclisGorev.DataSource = _meclisGorevTanim.ListeGetir();
            cbMeclisGorev.DisplayMember = "ad";
            cbMeclisGorev.ValueMember = "Id";
        }
        private void cbMeslekDoldur()
        {
            cbMeslek.DataSource = _meslekTanim.ListeGetir();
            cbMeslek.DisplayMember = "ad";
            cbMeslek.ValueMember = "Id";
        }
        private void cbPartiGrupDoldur()
        {
            cbPartiGrup.DataSource = _PartiGrupTanim.ListeGetir();
            cbPartiGrup.DisplayMember = "ad";
            cbPartiGrup.ValueMember = "Id";
        }
        private void cbPartiDoldur()
        {
            cbParti.DataSource = _partiTanim.ListeGetir();
            cbParti.DisplayMember = "ad";
            cbParti.ValueMember = "Id";
        }

        #endregion
    }
}
