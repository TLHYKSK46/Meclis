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
    }
}
