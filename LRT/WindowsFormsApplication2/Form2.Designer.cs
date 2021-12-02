namespace WindowsFormsApplication2
{
    partial class receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receipt));
            this.labelfrom = new System.Windows.Forms.Label();
            this.labelto = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.lbltprice = new System.Windows.Forms.Label();
            this.resibo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.BackColor = System.Drawing.Color.Transparent;
            this.labelfrom.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfrom.Location = new System.Drawing.Point(22, 19);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(60, 21);
            this.labelfrom.TabIndex = 0;
            this.labelfrom.Text = "From:";
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.BackColor = System.Drawing.Color.Transparent;
            this.labelto.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelto.Location = new System.Drawing.Point(44, 68);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(38, 21);
            this.labelto.TabIndex = 1;
            this.labelto.Text = "To:";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.BackColor = System.Drawing.Color.Transparent;
            this.labeltotal.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(34, 186);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(58, 21);
            this.labeltotal.TabIndex = 2;
            this.labeltotal.Text = "Total:";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.BackColor = System.Drawing.Color.Transparent;
            this.lblfrom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.Color.Red;
            this.lblfrom.Location = new System.Drawing.Point(107, 19);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(126, 20);
            this.lblfrom.TabIndex = 3;
            this.lblfrom.Text = "<Where u from>";
            this.lblfrom.Click += new System.EventHandler(this.lblfrom_Click);
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.Transparent;
            this.lblto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.Red;
            this.lblto.Location = new System.Drawing.Point(107, 68);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(119, 20);
            this.lblto.TabIndex = 4;
            this.lblto.Text = "<Where to go>";
            // 
            // lbltprice
            // 
            this.lbltprice.AutoSize = true;
            this.lbltprice.BackColor = System.Drawing.Color.Transparent;
            this.lbltprice.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltprice.ForeColor = System.Drawing.Color.Red;
            this.lbltprice.Location = new System.Drawing.Point(98, 186);
            this.lbltprice.Name = "lbltprice";
            this.lbltprice.Size = new System.Drawing.Size(116, 23);
            this.lbltprice.TabIndex = 5;
            this.lbltprice.Text = "<Total Price>";
            // 
            // resibo
            // 
            this.resibo.Location = new System.Drawing.Point(102, 226);
            this.resibo.Name = "resibo";
            this.resibo.Size = new System.Drawing.Size(75, 23);
            this.resibo.TabIndex = 6;
            this.resibo.Text = "OK";
            this.resibo.UseVisualStyleBackColor = true;
            this.resibo.Click += new System.EventHandler(this.resibo_Click);
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 271);
            this.ControlBox = false;
            this.Controls.Add(this.resibo);
            this.Controls.Add(this.lbltprice);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.labelfrom);
            this.Name = "receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.Label labeltotal;
        public System.Windows.Forms.Label lblfrom;
        public System.Windows.Forms.Label lblto;
        public System.Windows.Forms.Label lbltprice;
        private System.Windows.Forms.Button resibo;
    }
}