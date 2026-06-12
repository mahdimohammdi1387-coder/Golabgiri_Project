using Golabgiri.BLL.IServices;
using Golabgiri.Utility.Seperators;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golabgiri.App.Product
{
    public partial class frmProduct : Form
    {
        private IServiceProvider _serviceProvider;
        private IProductService _productservice;
        public frmProduct(IServiceProvider serviceProvider,IProductService productService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _productservice = productService;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            product_Load();
            var frm = _serviceProvider.GetRequiredService<mainform>();
            frm.i = 0;
        }
        async void product_Load()
        {
            dgvProduct.Rows.Clear();
            var product=await _productservice.GetProductAsync();
            foreach (var item in product)
            {
                var price = PointSeprator.RemoveTrailingZeros(item.price);
                var value=PointSeprator.RemoveTrailingZeros(item.Value);
                dgvProduct.Rows.Add(item.ID,item.Name,SepCama.Cama(value),item.Unit,SepCama.Cama(price)
                    ,"ریال",item.description);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnewProduct_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<frmAddOrEditproduct>();
            if (frm.ShowDialog() == DialogResult.OK)
                product_Load();
        }
    }
}
