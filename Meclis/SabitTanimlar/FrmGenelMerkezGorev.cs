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
    public partial class FrmGenelMerkezGorev : Form
    {
        private IGenelMerkezGorevService _genelMerkez;
        public FrmGenelMerkezGorev()
        {
            InitializeComponent();
            _genelMerkez = InstanceFactory.GetInstance<IGenelMerkezGorevService>();
            TumunuListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string genelMerkez = txtGenelMerkezGorevAdi.Text;
            if (genelMerkez != null && genelMerkez != "")
            {
                try
                {

                    _genelMerkez.Ekle(new GenelMerkezGorev
                    {
                        GenelMerkezGorevAdi = genelMerkez
                    });
                    MessageBox.Show("Genel Merkez Görevi başarıyla Eklendi.");
                    txtGenelMerkezGorevAdi.Text = "";
                    TumunuListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");
                   
                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }

            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string genelMerkez = txtGenelMerkezGorevAdi.Text;
            if (genelMerkez != null && genelMerkez != "")
            {
                try
                {

                    _genelMerkez.Guncelle(new GenelMerkezGorev
                    {
                        Id = Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value),
                        GenelMerkezGorevAdi = genelMerkez
                    });
                    MessageBox.Show("Genel Merkez Görevi başarıyla Güncellendi.");
                    txtGenelMerkezGorevAdi.Text = "";
                    TumunuListele();

                }
                catch (DaoException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Program");

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Silmek İstediğinizden Eminmisiniz?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && dgListe.CurrentRow != null)
            {

                try
                {
                    _genelMerkez.Sil(Convert.ToInt32(dgListe.CurrentRow.Cells[0].Value));
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
            dgListe.DataSource = _genelMerkez.ListeGetir().Select(p => new
            {
                p.Id,
                p.GenelMerkezGorevAdi
            }).ToList();
        }

        private void dgListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGenelMerkezGorevAdi.Text = dgListe.CurrentRow.Cells[1].Value.ToString();

        }

        private void FrmGenelMerkezGorev_Load(object sender, EventArgs e)
        {

        }
    }
}
