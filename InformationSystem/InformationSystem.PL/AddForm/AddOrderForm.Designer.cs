namespace InformationSystem.PL.AddForm
{
    partial class AddOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.dtDep = new System.Windows.Forms.DateTimePicker();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeForm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказчик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата выполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(61, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Доставка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(77, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Статус";
            // 
            // dtOrder
            // 
            this.dtOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrder.Location = new System.Drawing.Point(137, 85);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(125, 20);
            this.dtOrder.TabIndex = 6;
            // 
            // dtDep
            // 
            this.dtDep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDep.Location = new System.Drawing.Point(137, 111);
            this.dtDep.Name = "dtDep";
            this.dtDep.Size = new System.Drawing.Size(125, 20);
            this.dtDep.TabIndex = 7;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(137, 137);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(125, 20);
            this.txtDelivery.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Выполняется",
            "Выполнен",
            "Отменен"});
            this.cbStatus.Location = new System.Drawing.Point(137, 163);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(125, 21);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.Text = "Выполняется";
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Amount,
            this.Length,
            this.Width,
            this.TypeForm,
            this.IdService});
            this.dgProduct.Location = new System.Drawing.Point(268, 32);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.Size = new System.Drawing.Size(495, 177);
            this.dgProduct.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(488, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Товары";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(397, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(162, 40);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(596, 232);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(137, 54);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(125, 21);
            this.cbCustomer.TabIndex = 15;
            this.cbCustomer.Text = "Иван";
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Кол-во";
            this.Amount.Name = "Amount";
            this.Amount.Width = 50;
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина";
            this.Length.Name = "Length";
            this.Length.Width = 50;
            // 
            // Width
            // 
            this.Width.HeaderText = "Ширина";
            this.Width.Name = "Width";
            this.Width.Width = 50;
            // 
            // TypeForm
            // 
            this.TypeForm.HeaderText = "Тип формы";
            this.TypeForm.Items.AddRange(new object[] {
            "Прямоугольный",
            "Криволинейный"});
            this.TypeForm.Name = "TypeForm";
            this.TypeForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeForm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IdService
            // 
            this.IdService.HeaderText = "Услуга";
            this.IdService.Name = "IdService";
            this.IdService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 287);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.dtDep);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.DateTimePicker dtDep;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeForm;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdService;
    }
}