using InformationSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem.PL.AddForm
{
    public partial class AddProductForm : Form
    {
        public string title;
        public decimal price;
        public int leadTime;
        private ILogic logic;
        private object id;

        public AddProductForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        public AddProductForm(ILogic logic, int id) : this(logic)
        {
            this.id = id;
            txtTitle.Text = logic.GetProducts().Where(u => u.Id == id).Select(u => u.Title).ToArray()[0].ToString();
            txtPrice.Text = logic.GetProducts().Where(u => u.Id == id).Select(u => u.Price).ToArray()[0].ToString();
            txtLeadTime.Text = logic.GetProducts().Where(u => u.Id == id).Select(u => u.LeadTime).ToArray()[0].ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            price =  decimal.Parse(txtPrice.Text);
            leadTime = int.Parse(txtLeadTime.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(logic);
            form.Show();
            Close();
        }
    }
}
