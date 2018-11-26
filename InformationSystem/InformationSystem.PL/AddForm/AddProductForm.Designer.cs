namespace InformationSystem.PL.AddForm
{
    partial class AddProductForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLeadTime = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 151);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(162, 40);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(211, 151);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(162, 40);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(120, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Название";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(153, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Цена";
            // 
            // lblLeadTime
            // 
            this.lblLeadTime.AutoSize = true;
            this.lblLeadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeadTime.Location = new System.Drawing.Point(62, 96);
            this.lblLeadTime.Name = "lblLeadTime";
            this.lblLeadTime.Size = new System.Drawing.Size(132, 16);
            this.lblLeadTime.TabIndex = 4;
            this.lblLeadTime.Text = "Время выволнения";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(200, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(200, 62);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Location = new System.Drawing.Point(200, 92);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(100, 20);
            this.txtLeadTime.TabIndex = 7;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 204);
            this.Controls.Add(this.txtLeadTime);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblLeadTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLeadTime;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLeadTime;
    }
}