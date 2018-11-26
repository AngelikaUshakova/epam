using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystem.BLL;
using InformationSystem.PL.AddForm;

namespace InformationSystem.PL
{
    public partial class OrderForm : Form
    {
        private ILogic logic;

        public OrderForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            dOrders.AutoGenerateColumns = false;
            {
                //BindingSource s = new BindingSource();
                //var listIndex = logic.GetOrders().Select(u => u.IdCustomer);
                //s.Add(logic.GetOrders());
                //s.Add(logic.GetCustomers().Where(u => listIndex.Contains(u.Id)).Select(u => u.Name));
            }
            dOrders.DataSource = logic.GetOrders();
            {
                //DataTable table = new DataTable();
                //table.Columns.Add("IdCustomer");
                //table.Columns.Add("Id");
                //table.Columns.Add("Name");
                //table.Columns.Add("DateOrder");
                //table.Columns.Add("DateDeparture");
                //table.Columns.Add("Delivery");
                //table.Columns.Add("Status");

                //for (int row = 0; row < logic.GetOrders().Count; row++)
                //{
                //    table.Rows.Add();
                //    table.Rows[table.Rows.Count - 1]["IdCustomer"] = logic.GetOrders().Select(u => u.IdCustomer).ToArray()[row];
                //    table.Rows[table.Rows.Count - 1]["Id"] = logic.GetOrders();
                //    table.Rows[table.Rows.Count - 1]["Name"] = logic.GetCustomers().Where(u => listIndex.Contains(u.Id)).Select(u => u.Name).ToString();
                //    table.Rows[table.Rows.Count - 1]["DateOrder"] = logic.GetOrders();
                //    table.Rows[table.Rows.Count - 1]["DateDeparture"] = logic.GetOrders();
                //    table.Rows[table.Rows.Count - 1]["Delivery"] = logic.GetOrders();
                //    table.Rows[table.Rows.Count - 1]["Status"] = logic.GetOrders();

                //  dOrders.DataSource = logic.GetCustomers().Where(u => listIndex.Contains(u.Id)).Select(u => u.Name);
                //}
                //dOrders.DataSource = table;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var form = new AddOrderForm(logic);

            if (form.ShowDialog() == DialogResult.OK)
            {
                logic.AddOrder(new Entities.Order(0,form.idCustomer,form.dateOrder,form.dateDepartument,
                    form.delivery,form.status));
                foreach(var orderProduct in form.orderProducts)
                {
                    logic.AddOrderProduct(orderProduct);
                }
                dOrders.DataSource = logic.GetOrders();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MainForm(logic);
            form.Show();
            Close();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            logic.DeleteOrder((int)dOrders.SelectedCells[1].Value);
            dOrders.DataSource = logic.GetOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dOrders.SelectedCells[1].Value.ToString());
            var form = new BillForm(logic,index);
            this.Hide();
            form.Show();
        }
    }
}
