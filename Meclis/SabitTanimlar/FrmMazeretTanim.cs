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
using MeclisDao.Enums;
using MeclisDao.Json;

namespace Meclis.SabitTanimlar
{
    public partial class FrmMazeretTanim : Form
    {
        private IMazeretTanimService _mazeretTanim;
        private IVekilTanimService _vekilTanim;
        private IMazeretKodService _mazeretKod;
        private IBelgeNoService _belgNoService;
        public FrmMazeretTanim()
        {
            InitializeComponent();
            _mazeretTanim = InstanceFactory.GetInstance<IMazeretTanimService>();
            _vekilTanim = InstanceFactory.GetInstance<IVekilTanimService>();
            _mazeretKod = InstanceFactory.GetInstance<IMazeretKodService>();
            _belgNoService = InstanceFactory.GetInstance<IBelgeNoService>();

            cbVekilDoldur();
            cbMazeretKodDoldur();
            TumunuListele();

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
                    TumunuListele();
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
        private void cbBelgeNoGetir()
        {
           
        }
        private void cbMazeretKodDoldur()
        {
            cbMazeretKod.DataSource = Enum.GetValues(typeof(MeclisDao.Enums.MazeretKod));

            //    cbMazeretKod.DataSource = _mazeretKod.ListeGetir();
            //    cbMazeretKod.DisplayMember = "MazeretKodu";
            //    cbMazeretKod.ValueMember = "Id";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int vekilTanimId = Convert.ToInt32(cbVekilTanım.SelectedValue);
            int mazeretKodu = Convert.ToInt32(cbMazeretKod.SelectedValue);
            string mazeretNedini = txtMazeretNedeni.Text;
            DateTime basTarih = dtBaslamaTarihi.Value;
            DateTime bitisTarih = dtBitisTarihi.Value;

            if ((vekilTanimId > 0) && (mazeretKodu > 0))
            {
                try
                {
                    var data = new MazeretTanim()
                    {
                        Id= Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        MazeretKodId = mazeretKodu,
                        VekilTanimId = vekilTanimId,
                        BaslamaTarihi = basTarih,
                        BitisTarihi = bitisTarih,
                        MazeretNedeni = mazeretNedini,

                    };
                    _mazeretTanim.Guncelle(data);
                    MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı.", "Sistem");
                    TumunuListele();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _mazeretTanim.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
                    TumunuListele();
                    MessageBox.Show("Kayıt Başarıyla  Silindi!", "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu! \n");
                }
            }
        }

        private void TumunuListele()
        {
            dgListe.DataSource = (from mt in _mazeretTanim.ListeGetir()
                                  join mk in Enum.GetValues(typeof(MeclisDao.Enums.MazeretKod)).Cast<MeclisDao.Enums.MazeretKod>() on mt.MazeretKodId equals mk.GetHashCode()

                                  join vt in _vekilTanim.ListeGetir() on mt.VekilTanimId equals vt.Id
                                  select new { 
                                  mt.Id,
                                  vt.TcKimlikNo,
                                 VekilAdSoyad= vt.Ad+" "+ vt.Soyad,
                                  MazeretKod=mk.ToString(),
                                  mt.MazeretNedeni,
                                  mt.BaslamaTarihi,
                                  mt.BitisTarihi,
                                  
                                  }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbVekilTanım.Text = dgListe.CurrentRow.Cells[2].Value.ToString();
            cbMazeretKod.Text = dgListe.CurrentRow.Cells[3].Value.ToString();
            txtMazeretNedeni.Text = dgListe.CurrentRow.Cells[4].Value.ToString();
            dtBaslamaTarihi.Text = dgListe.CurrentRow.Cells[5].Value.ToString();
            dtBitisTarihi.Text = dgListe.CurrentRow.Cells[6].Value.ToString();
        }

        private void cbVekilTanım_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((VekilTanim)e.ListItem).Ad;
            string firstname = ((VekilTanim)e.ListItem).Soyad;
            e.Value = lastname + " " + firstname;
        }

        private void FrmMazeretTanim_Load(object sender, EventArgs e)
        {
            var no = new BelgeNo {
            BelgeNo1=1,
            };
            JsonParse.JsonSave(no);

        }
    }
}
