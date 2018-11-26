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

namespace InformationSystem.PL
{
    public partial class BillForm : Form
    {
        private ILogic logic;

        public BillForm(ILogic logic, int index)
        {
            InitializeComponent();
            this.logic = logic;
            dOrderBill.AutoGenerateColumns = false;
            var source = logic.GetOrderProducts().Where(u => u.IdOrder == index);
            dOrderBill.DataSource = source.ToList();
            lblOrderNum.Text = index.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(logic);
            form.Show();
            Close();
        }
    }
}
