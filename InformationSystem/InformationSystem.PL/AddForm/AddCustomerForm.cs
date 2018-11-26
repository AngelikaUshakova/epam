using Entities;
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
    public partial class AddCustomerForm : Form
    {
        public string name;
        public string address;
        public string email;
        public string phone;
     

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            address = textBox2.Text;
            email = textBox3.Text;
            phone = textBox4.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
