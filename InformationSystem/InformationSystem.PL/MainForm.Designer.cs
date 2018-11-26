namespace InformationSystem.PL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.Location = new System.Drawing.Point(172, 86);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 50);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomers.Location = new System.Drawing.Point(387, 86);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(200, 50);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Заказчики";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProducts.Location = new System.Drawing.Point(172, 152);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 50);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnServices
            // 
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnServices.Location = new System.Drawing.Point(387, 152);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(200, 50);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Услуги";
            this.btnServices.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 287);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrders);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт продукции";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnServices;
    }
}

