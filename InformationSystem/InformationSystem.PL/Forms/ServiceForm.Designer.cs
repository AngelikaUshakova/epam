namespace InformationSystem.PL
{
    partial class ServiceForm
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
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dServices = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateService.Location = new System.Drawing.Point(596, 58);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(162, 40);
            this.btnUpdateService.TabIndex = 11;
            this.btnUpdateService.Text = "Изменить информацию об услуге";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteService.Location = new System.Drawing.Point(596, 104);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(162, 40);
            this.btnDeleteService.TabIndex = 10;
            this.btnDeleteService.Text = "Удалить услугу";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddService.Location = new System.Drawing.Point(596, 12);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(162, 40);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Добавить услугу";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(596, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dServices
            // 
            this.dServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Type,
            this.Price,
            this.LeadTime});
            this.dServices.Location = new System.Drawing.Point(30, 12);
            this.dServices.Name = "dServices";
            this.dServices.Size = new System.Drawing.Size(543, 263);
            this.dServices.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            this.Title.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // LeadTime
            // 
            this.LeadTime.HeaderText = "Время выполнения";
            this.LeadTime.Name = "LeadTime";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 287);
            this.Controls.Add(this.dServices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Name = "ServiceForm";
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.dServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTime;
    }
}