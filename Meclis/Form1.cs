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

namespace Meclis
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            _productService = InstanceFactory.GetInstance<IProductService>();
            InitializeComponent();
        }
        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();

        }
        void LoadProduct()
        {
            dataGridView1.DataSource = _productService.ListeGetir();
        }
    }
}
