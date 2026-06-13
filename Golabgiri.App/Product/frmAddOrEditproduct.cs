using Golabgiri.BLL.IServices;
using Golabgiri.BLL.Services;
using Golabgiri.Utility.NumberOnly;
using Golabgiri.ViewModel.DTO.ProductDTO;
using Golabgiri.ViewModel.DTO.UnitDTo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Golabgiri.App.Product
{
    public partial class frmAddOrEditproduct : Form
    {
        private readonly IProductService _productservice;
        private readonly IUnitService _unitservice;
        private readonly IServiceProvider _serviceprovider;
        public frmAddOrEditproduct(IServiceProvider serviceprovider,IProductService productService,IUnitService unitService)
        {
            InitializeComponent();
            _serviceprovider = serviceprovider;
            _productservice = productService;
            _unitservice = unitService;
        }

        private void frmAddOrEditproduct_Load(object sender, EventArgs e)
        {
            frm_Load();
        }
        async void frm_Load()
        {
            List<UnitDTO> list=new List<UnitDTO>();
            list.Add(new UnitDTO
            {
                Id = 0,
                Name="واحد را انتخاب کنید"
            });
            list.AddRange(await _unitservice.GetUnit());
            cmbunit.DataSource = list;
            cmbunit.DisplayMember = "Name";
            cmbunit.ValueMember = "Id";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public decimal price = 0;
        private async void btnsabt_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (cmbunit.SelectedIndex != 0)
                {
                    ProductDTO productDTO = new ProductDTO();
                    productDTO.Name = txtname.Text;
                    productDTO.Value=decimal.Parse(txtvalue.Text);
                    productDTO.description = txtdescription.Text;
                    productDTO.UnitId = 1;
                    if(price==0)
                    {
                        productDTO.price = 0;
                        await _productservice.InsertProductAsync(productDTO);
                    }
                    else
                    {
                        productDTO.price = price;
                        await _productservice.UpdateProductAsync(productDTO);
                    }
                    await _productservice.SaveAsync();
                    DialogResult = DialogResult.OK;
                }
                else
                    RtlMessageBox.Show("ابتدا واحد محصول را انتخاب کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=NumberOnly.Only(e.KeyChar);
        }
    }
}
