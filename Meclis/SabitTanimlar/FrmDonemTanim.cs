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
    public partial class FrmDonemTanim : Form
    {
        private IDonemTanimService _donemService;
       
        public FrmDonemTanim()
        {
            _donemService = InstanceFactory.GetInstance<IDonemTanimService>();
       

            InitializeComponent();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string donem = txtDonemAdi.Text;
            if (donem != null || donem != "")
            {
                _donemService.Ekle(new DonemTanim
                {
                    DonemAdi = donem,
                    EklenmeTarihi = DateTime.Now

                }) ;
                MessageBox.Show("Ekleme İşlemi Başarılı!", "Program");
                txtDonemAdi.Text = "";
                TumunuListele();
            }
            else {
                MessageBox.Show("Lütfen Bir Dönem Giriniz!","Program");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string donem = txtDonemAdi.Text;
            if (donem != null || donem != "")
            {
                _donemService.Guncelle(new DonemTanim
                {
                    Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                    DonemAdi = donem
                });
                MessageBox.Show("Güncelleme İşlemi Başarılı!", "Program");
                txtDonemAdi.Text = "";
                TumunuListele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Dönem Giriniz!", "Program");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _donemService.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            dgListe.DataSource =_donemService.ListeGetir().Select(p=> new { 
            p.Id,
            p.DonemAdi
            //buraya aktif dönem eklenecek
            }).ToList();


        }

        private void FrmDonemTanim_Load(object sender, EventArgs e)
        {
            TumunuListele();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDonemAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();
            //cbVekil.Text = dgDilListe.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
