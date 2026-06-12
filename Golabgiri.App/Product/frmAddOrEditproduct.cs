using Golabgiri.BLL.IServices;
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

        private void btnsabt_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

            }
        }
    }
}
