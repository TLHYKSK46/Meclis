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
    public partial class FrmMazeretTanim : Form
    {
        private IMazeretTanimService _mazeretTanim;
        private IVekilTanimService _vekilTanim;
        private IMazeretKodService _mazeretKod;
        public FrmMazeretTanim()
        {
            InitializeComponent();
            _mazeretTanim = InstanceFactory.GetInstance<IMazeretTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _mazeretKod = InstanceFactory.GetInstance<IMazeretKodService>();

            cbVekilDoldur();
            cbMazeretKodDoldur();
        }

   
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int vekilTanimId= Convert.ToInt32(cbVekilTanım.SelectedValue);
            int mazeretKodu = Convert.ToInt32(cbMazeretKod.SelectedValue);
            string mazeretNedini= txtMazeretNedeni.Text;
            DateTime basTarih = dtBaslamaTarihi.Value;
            DateTime bitisTarih = dtBitisTarihi.Value;

            if ((vekilTanimId>0) && (mazeretKodu >0))
            {
                try
                {
                    var data = new MazeretTanim()
                    {
                        MazeretKodId=mazeretKodu,
                        VekilTanimId=vekilTanimId,
                        BaslamaTarihi=basTarih,
                        BitisTarihi=bitisTarih,
                        MazeretNedeni=mazeretNedini,
                       
                    };
                    _mazeretTanim.Ekle(data);
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı.", "Sistem");
                    txtMazeretNedeni.Text = "";
                    cbVekilDoldur();
                    cbMazeretKodDoldur();
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
       
        private void cbVekilDoldur()
        {
            cbVekilTanım.DataSource = _vekilTanim.ListeGetir();
            cbVekilTanım.DisplayMember = "ad";
            cbVekilTanım.ValueMember = "Id";
        }
        private void cbMazeretKodDoldur()
        {
            cbMazeretKod.DataSource = _mazeretKod.ListeGetir();
            cbMazeretKod.DisplayMember = "MazeretKodu";
            cbMazeretKod.ValueMember = "Id";
        }


    }
}
