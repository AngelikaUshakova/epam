namespace InformationSystem.PL
{
    partial class CustomerForm
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dCustomers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCustomer.Location = new System.Drawing.Point(458, 14);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(162, 40);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Добавить заказчика";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(458, 60);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(162, 40);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Изменить информацию о заказчике";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(458, 106);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(162, 40);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Удалить заказчика";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(458, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dCustomers
            // 
            this.dCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameCustomer,
            this.Address,
            this.email,
            this.Phone,
            this.Inn,
            this.CheckAcc,
            this.CorAcc,
            this.Bank,
            this.Bic});
            this.dCustomers.Location = new System.Drawing.Point(12, 12);
            this.dCustomers.MultiSelect = false;
            this.dCustomers.Name = "dCustomers";
            this.dCustomers.Size = new System.Drawing.Size(440, 244);
            this.dCustomers.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // NameCustomer
            // 
            this.NameCustomer.HeaderText = "ФИО";
            this.NameCustomer.Name = "NameCustomer";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            // 
            // Inn
            // 
            this.Inn.HeaderText = "ИНН";
            this.Inn.Name = "Inn";
            // 
            // CheckAcc
            // 
            this.CheckAcc.HeaderText = "Расчетный счёт";
            this.CheckAcc.Name = "CheckAcc";
            // 
            // CorAcc
            // 
            this.CorAcc.HeaderText = "Кор. счёт";
            this.CorAcc.Name = "CorAcc";
            // 
            // Bank
            // 
            this.Bank.HeaderText = "Банк";
            this.Bank.Name = "Bank";
            // 
            // Bic
            // 
            this.Bic.HeaderText = "БИК";
            this.Bic.Name = "Bic";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 268);
            this.Controls.Add(this.dCustomers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "CustomerForm";
            this.Text = "Заказчики";
            ((System.ComponentModel.ISupportInitialize)(this.dCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bic;
    }
}