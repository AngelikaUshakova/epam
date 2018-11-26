namespace InformationSystem.PL
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dOrders = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrder.Location = new System.Drawing.Point(603, 12);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(162, 40);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Добавить заказ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(603, 58);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(162, 40);
            this.btnUpdateOrder.TabIndex = 7;
            this.btnUpdateOrder.Text = "Изменить информацию о заказе";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(603, 104);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(162, 40);
            this.btnDeleteOrder.TabIndex = 6;
            this.btnDeleteOrder.Text = "Удалить заказ";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(603, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dOrders
            // 
            this.dOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.Id,
            this.IdCustomer,
            this.DateOrder,
            this.DateDeparture,
            this.Delivery,
            this.Status});
            this.dOrders.Location = new System.Drawing.Point(3, 12);
            this.dOrders.MultiSelect = false;
            this.dOrders.Name = "dOrders";
            this.dOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dOrders.Size = new System.Drawing.Size(594, 263);
            this.dOrders.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(603, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Счёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "IdCustomer";
            this.Customer.HeaderText = "Номер заказчика";
            this.Customer.Name = "Customer";
            this.Customer.Visible = false;
            this.Customer.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // IdCustomer
            // 
            this.IdCustomer.DataPropertyName = "IdCustomer";
            this.IdCustomer.HeaderText = "Заказчик";
            this.IdCustomer.Name = "IdCustomer";
            // 
            // DateOrder
            // 
            this.DateOrder.DataPropertyName = "DateOrder";
            this.DateOrder.HeaderText = "Дата заказа";
            this.DateOrder.Name = "DateOrder";
            // 
            // DateDeparture
            // 
            this.DateDeparture.DataPropertyName = "DateDeparture";
            this.DateDeparture.HeaderText = "Дата выполнения";
            this.DateDeparture.Name = "DateDeparture";
            // 
            // Delivery
            // 
            this.Delivery.DataPropertyName = "Delivery";
            this.Delivery.HeaderText = "Доставка";
            this.Delivery.Name = "Delivery";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dOrders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}