using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystem.BLL;

namespace InformationSystem.PL
{
    public partial class MainForm : Form
    {
        private ILogic logic;

        public MainForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(logic);
            this.Hide();
            form.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(logic);
            this.Hide();
            form.Show();
        }
    }
}
