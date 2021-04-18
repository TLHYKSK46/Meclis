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
    public partial class FrmVekilDanisman : Form
    {
        private IVekilTanimService _vekilTanim;
        private IDanismanTanimService _danismanTanim;
        private IVekilDanismanService _vekilDanisman;
        public FrmVekilDanisman()
        {
            InitializeComponent();
            _vekilDanisman = InstanceFactory.GetInstance<IVekilDanismanService>();
            _danismanTanim = InstanceFactory.GetInstance<IDanismanTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();

            cbDanismanDoldur();
            cbVekilDoldur();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int vekilId=Convert.ToInt32(cbVekil.SelectedValue);
            int danismanId = Convert.ToInt32(cbDanisman.SelectedValue);
            int sira = Convert.ToInt32(txtSira.Text);

            if ((vekilId > 0) && (danismanId > 0) && sira!=0)
            {
                try
                {
                    var data = new VekilDanisman()
                    {
                       DanismanTanimId=danismanId,
                       VekilTanimId=vekilId,
                       Sira=sira
                    };
                    _vekilDanisman.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    txtSira.Text = "";
                    cbDanisman.Refresh();
                    cbVekil.Refresh();
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
        private void cbDanismanDoldur()
        {
            cbDanisman.DataSource = _danismanTanim.ListeGetir();
            cbDanisman.DisplayMember = "Ad";
            cbDanisman.ValueMember = "Id";
        }

        private void cbVekilDoldur()
        {
            cbVekil.DataSource = _vekilTanim.ListeGetir();
            cbVekil.DisplayMember = "ad";
            cbVekil.ValueMember = "Id";
        }

        private void FrmVekilDanisman_Load(object sender, EventArgs e)
        {

        }
    }
}
