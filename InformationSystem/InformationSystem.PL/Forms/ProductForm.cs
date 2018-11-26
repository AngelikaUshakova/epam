using InformationSystem.BLL;
using InformationSystem.PL.AddForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem.PL
{
    public partial class ProductForm : Form
    {
        private ILogic logic;

        public ProductForm(ILogic logic )
        {
            InitializeComponent();
            this.logic = logic;
            dProducts.AutoGenerateColumns = false;
            dProducts.DataSource = logic.GetProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm(logic);
            form.Text = "Добавление товара";
            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.AddProduct(new Entities.Product(0, form.title, form.price, form.leadTime));
                dProducts.DataSource = logic.GetProducts();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MainForm(logic);
            form.Show();
            Close();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            logic.DeleteProduct((int)dProducts.SelectedCells[0].Value);
            dProducts.DataSource = logic.GetProducts();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id =(int)dProducts.SelectedCells[0].Value;
            var form = new AddProductForm(logic, id);
            form.Text = "Изменение товара";
            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.UpdateProduct(new Entities.Product(id, form.title, form.price, form.leadTime));
                dProducts.DataSource = logic.GetProducts();
            }
           
        }
    }
}
