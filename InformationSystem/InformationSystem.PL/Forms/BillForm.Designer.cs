namespace InformationSystem.PL
{
    partial class BillForm
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
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.dOrderBill = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dOrderBill)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderNumber.Location = new System.Drawing.Point(247, 18);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(85, 20);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Заказ № ";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderNum.Location = new System.Drawing.Point(328, 18);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(18, 20);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "1";
            // 
            // dOrderBill
            // 
            this.dOrderBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOrderBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Amount,
            this.Length,
            this.Width,
            this.TypeForm,
            this.IdService,
            this.Cost});
            this.dOrderBill.Location = new System.Drawing.Point(12, 48);
            this.dOrderBill.Name = "dOrderBill";
            this.dOrderBill.Size = new System.Drawing.Size(574, 159);
            this.dOrderBill.TabIndex = 2;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "IdProduct";
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Кол-во";
            this.Amount.Name = "Amount";
            this.Amount.Width = 50;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Длина";
            this.Length.Name = "Length";
            this.Length.Width = 50;
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Ширина";
            this.Width.Name = "Width";
            this.Width.Width = 50;
            // 
            // TypeForm
            // 
            this.TypeForm.DataPropertyName = "TypeForm";
            this.TypeForm.HeaderText = "Тип формы";
            this.TypeForm.Name = "TypeForm";
            // 
            // IdService
            // 
            this.IdService.DataPropertyName = "IdService";
            this.IdService.HeaderText = "Услуга";
            this.IdService.Name = "IdService";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.Width = 80;
            // 
            // lblAllCost
            // 
            this.lblAllCost.AutoSize = true;
            this.lblAllCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllCost.Location = new System.Drawing.Point(12, 239);
            this.lblAllCost.Name = "lblAllCost";
            this.lblAllCost.Size = new System.Drawing.Size(63, 20);
            this.lblAllCost.TabIndex = 3;
            this.lblAllCost.Text = "Итого:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(423, 219);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(162, 40);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "Назад";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 268);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllCost);
            this.Controls.Add(this.dOrderBill);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblOrderNumber);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dOrderBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.DataGridView dOrderBill;
        private System.Windows.Forms.Label lblAllCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button btnCancle;
    }
}