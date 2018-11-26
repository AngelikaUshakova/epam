using Entities;
using InformationSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem.PL.AddForm
{
    public partial class AddOrderForm : Form
    {
        public int idCustomer;
        public DateTime dateOrder;
        public DateTime dateDepartument;
        public string delivery;
        public string status;
        ILogic logic;
        public List<OrderProduct> orderProducts;

        public AddOrderForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;

            cbCustomer.Items.AddRange(logic.GetCustomers().Select(u => u.Name).ToArray());
            Product.Items.AddRange(logic.GetProducts().Select(u => u.Title).ToArray());
            IdService.Items.AddRange(logic.GetServices().Select(u => u.Title).ToArray());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int idCustom = cbCustomer.SelectedIndex + 1;
            int[] listIdCustomer = logic.GetCustomers().Select(u => u.Id).ToArray();
            idCustomer = listIdCustomer[idCustom];

            dateOrder = dtOrder.Value;
            dateDepartument = dtDep.Value;
            delivery = txtDelivery.Text;
            status = cbStatus.Text;
        
            for (int i = 0; i < dgProduct.RowCount-1; i++)
            {
                int selectedProduct = new DataGridViewComboBoxCell().Items.IndexOf(dgProduct.Rows[i].Cells[0].Value) + 1;
                int[] listindex = logic.GetProducts().Select(u => u.Id).ToArray();
                selectedProduct = listindex[selectedProduct];

                string amount = dgProduct.Rows[i].Cells[1].Value.ToString();
                string length = dgProduct.Rows[i].Cells[2].Value.ToString();
                string width =  dgProduct.Rows[i].Cells[3].Value.ToString(); 
                string typeForm = dgProduct.Rows[i].Cells[4].Value.ToString();

                int idService = new DataGridViewComboBoxCell().Items.IndexOf(dgProduct.Rows[i].Cells[5].Value) + 1;
                int[] listindex1 = logic.GetServices().Select(u => u.Id).ToArray();
                idService = listindex1[idService];

                orderProducts = new List<OrderProduct>();
                orderProducts.Add(new OrderProduct(2,selectedProduct,int.Parse(amount),float.Parse(length)
                    ,float.Parse(width),typeForm,idService));
            }
           
            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(logic);
            form.Show();
            Close();
        }
    }
}
