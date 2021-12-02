namespace WindowsFormsApplication2
{
    partial class lrt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lrt));
            this.from = new System.Windows.Forms.Label();
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.grpdestination = new System.Windows.Forms.GroupBox();
            this.btnkatipunan = new System.Windows.Forms.Button();
            this.btnanonas = new System.Windows.Forms.Button();
            this.btnjruiz = new System.Windows.Forms.Button();
            this.btncubao = new System.Windows.Forms.Button();
            this.btnbettygo = new System.Windows.Forms.Button();
            this.btngilmore = new System.Windows.Forms.Button();
            this.btnvmapa = new System.Windows.Forms.Button();
            this.btnpureza = new System.Windows.Forms.Button();
            this.btnlegarda = new System.Windows.Forms.Button();
            this.btnrecto = new System.Windows.Forms.Button();
            this.btnsantolan = new System.Windows.Forms.Button();
            this.grpprice = new System.Windows.Forms.GroupBox();
            this.lbldestination = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltot = new System.Windows.Forms.Label();
            this.lblchange = new System.Windows.Forms.Label();
            this.lblchang = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.lblcash = new System.Windows.Forms.Label();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpdestination.SuspendLayout();
            this.grpprice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(21, 28);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(33, 13);
            this.from.TabIndex = 0;
            this.from.Text = "From:";
            // 
            // cbfrom
            // 
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Items.AddRange(new object[] {
            "",
            "Recto",
            "Legarda",
            "Pureza",
            "V. Mapa",
            "J. Ruiz",
            "Gilmore",
            "Betty-Go",
            "Cubao",
            "Anonas",
            "Katipunan",
            "Santolan"});
            this.cbfrom.Location = new System.Drawing.Point(60, 25);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(121, 21);
            this.cbfrom.TabIndex = 1;
            this.cbfrom.SelectedIndexChanged += new System.EventHandler(this.cbfrom_SelectedIndexChanged);
            // 
            // grpdestination
            // 
            this.grpdestination.BackColor = System.Drawing.Color.Silver;
            this.grpdestination.Controls.Add(this.btnkatipunan);
            this.grpdestination.Controls.Add(this.btnanonas);
            this.grpdestination.Controls.Add(this.btnjruiz);
            this.grpdestination.Controls.Add(this.btncubao);
            this.grpdestination.Controls.Add(this.btnbettygo);
            this.grpdestination.Controls.Add(this.btngilmore);
            this.grpdestination.Controls.Add(this.btnvmapa);
            this.grpdestination.Controls.Add(this.btnpureza);
            this.grpdestination.Controls.Add(this.btnlegarda);
            this.grpdestination.Controls.Add(this.btnrecto);
            this.grpdestination.Controls.Add(this.btnsantolan);
            this.grpdestination.Location = new System.Drawing.Point(24, 65);
            this.grpdestination.Name = "grpdestination";
            this.grpdestination.Size = new System.Drawing.Size(193, 243);
            this.grpdestination.TabIndex = 4;
            this.grpdestination.TabStop = false;
            this.grpdestination.Text = "Destination";
            // 
            // btnkatipunan
            // 
            this.btnkatipunan.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkatipunan.Location = new System.Drawing.Point(104, 130);
            this.btnkatipunan.Name = "btnkatipunan";
            this.btnkatipunan.Size = new System.Drawing.Size(83, 31);
            this.btnkatipunan.TabIndex = 15;
            this.btnkatipunan.Text = "Katipunan";
            this.btnkatipunan.UseVisualStyleBackColor = true;
            this.btnkatipunan.Visible = false;
            this.btnkatipunan.Click += new System.EventHandler(this.btnkatipunan_Click);
            // 
            // btnanonas
            // 
            this.btnanonas.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanonas.Location = new System.Drawing.Point(104, 93);
            this.btnanonas.Name = "btnanonas";
            this.btnanonas.Size = new System.Drawing.Size(83, 31);
            this.btnanonas.TabIndex = 14;
            this.btnanonas.Text = "Anonas";
            this.btnanonas.UseVisualStyleBackColor = true;
            this.btnanonas.Visible = false;
            this.btnanonas.Click += new System.EventHandler(this.btnanonas_Click);
            // 
            // btnjruiz
            // 
            this.btnjruiz.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjruiz.Location = new System.Drawing.Point(6, 167);
            this.btnjruiz.Name = "btnjruiz";
            this.btnjruiz.Size = new System.Drawing.Size(83, 31);
            this.btnjruiz.TabIndex = 13;
            this.btnjruiz.Text = "J. Ruiz";
            this.btnjruiz.UseVisualStyleBackColor = true;
            this.btnjruiz.Visible = false;
            this.btnjruiz.Click += new System.EventHandler(this.btnjruiz_Click);
            // 
            // btncubao
            // 
            this.btncubao.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncubao.Location = new System.Drawing.Point(104, 56);
            this.btncubao.Name = "btncubao";
            this.btncubao.Size = new System.Drawing.Size(83, 31);
            this.btncubao.TabIndex = 12;
            this.btncubao.Text = "Cubao";
            this.btncubao.UseVisualStyleBackColor = true;
            this.btncubao.Visible = false;
            this.btncubao.Click += new System.EventHandler(this.btncubao_Click);
            // 
            // btnbettygo
            // 
            this.btnbettygo.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbettygo.Location = new System.Drawing.Point(104, 19);
            this.btnbettygo.Name = "btnbettygo";
            this.btnbettygo.Size = new System.Drawing.Size(83, 31);
            this.btnbettygo.TabIndex = 11;
            this.btnbettygo.Text = "Betty-Go";
            this.btnbettygo.UseVisualStyleBackColor = true;
            this.btnbettygo.Visible = false;
            this.btnbettygo.Click += new System.EventHandler(this.btnbettygo_Click);
            // 
            // btngilmore
            // 
            this.btngilmore.AllowDrop = true;
            this.btngilmore.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngilmore.Location = new System.Drawing.Point(6, 204);
            this.btngilmore.Name = "btngilmore";
            this.btngilmore.Size = new System.Drawing.Size(83, 31);
            this.btngilmore.TabIndex = 10;
            this.btngilmore.Text = "Gilmore";
            this.btngilmore.UseVisualStyleBackColor = true;
            this.btngilmore.Visible = false;
            this.btngilmore.Click += new System.EventHandler(this.btngilmore_Click);
            // 
            // btnvmapa
            // 
            this.btnvmapa.AllowDrop = true;
            this.btnvmapa.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvmapa.Location = new System.Drawing.Point(6, 130);
            this.btnvmapa.Name = "btnvmapa";
            this.btnvmapa.Size = new System.Drawing.Size(83, 31);
            this.btnvmapa.TabIndex = 9;
            this.btnvmapa.Text = "V. Mapa";
            this.btnvmapa.UseVisualStyleBackColor = true;
            this.btnvmapa.Visible = false;
            this.btnvmapa.Click += new System.EventHandler(this.btnvmapa_Click);
            // 
            // btnpureza
            // 
            this.btnpureza.AllowDrop = true;
            this.btnpureza.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpureza.Location = new System.Drawing.Point(6, 93);
            this.btnpureza.Name = "btnpureza";
            this.btnpureza.Size = new System.Drawing.Size(83, 31);
            this.btnpureza.TabIndex = 8;
            this.btnpureza.Text = "Pureza";
            this.btnpureza.UseVisualStyleBackColor = true;
            this.btnpureza.Visible = false;
            this.btnpureza.Click += new System.EventHandler(this.btnpureza_Click);
            // 
            // btnlegarda
            // 
            this.btnlegarda.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlegarda.Location = new System.Drawing.Point(6, 56);
            this.btnlegarda.Name = "btnlegarda";
            this.btnlegarda.Size = new System.Drawing.Size(83, 31);
            this.btnlegarda.TabIndex = 7;
            this.btnlegarda.Text = "Legarda";
            this.btnlegarda.UseVisualStyleBackColor = true;
            this.btnlegarda.Visible = false;
            this.btnlegarda.Click += new System.EventHandler(this.btnlegarda_Click);
            // 
            // btnrecto
            // 
            this.btnrecto.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecto.Location = new System.Drawing.Point(6, 19);
            this.btnrecto.Name = "btnrecto";
            this.btnrecto.Size = new System.Drawing.Size(83, 31);
            this.btnrecto.TabIndex = 6;
            this.btnrecto.Text = "Recto";
            this.btnrecto.UseVisualStyleBackColor = true;
            this.btnrecto.Visible = false;
            this.btnrecto.Click += new System.EventHandler(this.btnrecto_Click);
            // 
            // btnsantolan
            // 
            this.btnsantolan.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsantolan.Location = new System.Drawing.Point(104, 168);
            this.btnsantolan.Name = "btnsantolan";
            this.btnsantolan.Size = new System.Drawing.Size(83, 33);
            this.btnsantolan.TabIndex = 5;
            this.btnsantolan.Text = "Santolan";
            this.btnsantolan.UseVisualStyleBackColor = true;
            this.btnsantolan.Visible = false;
            this.btnsantolan.Click += new System.EventHandler(this.btnsantolan_Click);
            // 
            // grpprice
            // 
            this.grpprice.BackColor = System.Drawing.Color.Tan;
            this.grpprice.Controls.Add(this.lbldestination);
            this.grpprice.Controls.Add(this.destination);
            this.grpprice.Controls.Add(this.lbltotal);
            this.grpprice.Controls.Add(this.lbltot);
            this.grpprice.Controls.Add(this.lblchange);
            this.grpprice.Controls.Add(this.lblchang);
            this.grpprice.Controls.Add(this.txtcash);
            this.grpprice.Controls.Add(this.lblcash);
            this.grpprice.Controls.Add(this.btnminus);
            this.grpprice.Controls.Add(this.btnplus);
            this.grpprice.Controls.Add(this.txtqty);
            this.grpprice.Controls.Add(this.label2);
            this.grpprice.Controls.Add(this.lblprice);
            this.grpprice.Controls.Add(this.label1);
            this.grpprice.Location = new System.Drawing.Point(223, 65);
            this.grpprice.Name = "grpprice";
            this.grpprice.Size = new System.Drawing.Size(239, 280);
            this.grpprice.TabIndex = 5;
            this.grpprice.TabStop = false;
            this.grpprice.Enter += new System.EventHandler(this.grp_Enter);
            // 
            // lbldestination
            // 
            this.lbldestination.AutoSize = true;
            this.lbldestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldestination.ForeColor = System.Drawing.Color.DarkRed;
            this.lbldestination.Location = new System.Drawing.Point(102, 64);
            this.lbldestination.Name = "lbldestination";
            this.lbldestination.Size = new System.Drawing.Size(113, 15);
            this.lbldestination.TabIndex = 14;
            this.lbldestination.Text = "<Destination Here>";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(6, 64);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(90, 16);
            this.destination.TabIndex = 13;
            this.destination.Text = "Destination:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltotal.Location = new System.Drawing.Point(102, 240);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(108, 16);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "<TOTAL here>";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.Location = new System.Drawing.Point(34, 240);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(61, 16);
            this.lbltot.TabIndex = 11;
            this.lbltot.Text = "TOTAL:";
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblchange.Location = new System.Drawing.Point(105, 212);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(94, 15);
            this.lblchange.TabIndex = 10;
            this.lblchange.Text = "<Change Here>";
            this.lblchange.Click += new System.EventHandler(this.lblchange_Click);
            // 
            // lblchang
            // 
            this.lblchang.AutoSize = true;
            this.lblchang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchang.Location = new System.Drawing.Point(34, 212);
            this.lblchang.Name = "lblchang";
            this.lblchang.Size = new System.Drawing.Size(65, 16);
            this.lblchang.TabIndex = 9;
            this.lblchang.Text = "Change:";
            // 
            // txtcash
            // 
            this.txtcash.Location = new System.Drawing.Point(91, 153);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(62, 20);
            this.txtcash.TabIndex = 8;
            this.txtcash.TextChanged += new System.EventHandler(this.txtcash_TextChanged);
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Location = new System.Drawing.Point(34, 154);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(47, 16);
            this.lblcash.TabIndex = 7;
            this.lblcash.Text = "Cash:";
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(159, 116);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(19, 23);
            this.btnminus.TabIndex = 6;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(91, 116);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(21, 23);
            this.btnplus.TabIndex = 5;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(118, 118);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(35, 20);
            this.txtqty.TabIndex = 4;
            this.txtqty.Text = "1";
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblprice.Location = new System.Drawing.Point(105, 27);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(79, 15);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "<Price Here>";
            this.lblprice.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price:";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(279, 362);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(103, 38);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 428);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.grpprice);
            this.Controls.Add(this.grpdestination);
            this.Controls.Add(this.cbfrom);
            this.Controls.Add(this.from);
            this.Name = "lrt";
            this.Text = " ";
            this.grpdestination.ResumeLayout(false);
            this.grpprice.ResumeLayout(false);
            this.grpprice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from;
        private System.Windows.Forms.ComboBox cbfrom;
        private System.Windows.Forms.GroupBox grpprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Label lblchang;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Button btnok;
        public System.Windows.Forms.GroupBox grpdestination;
        private System.Windows.Forms.Label lbldestination;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsantolan;
        private System.Windows.Forms.Button btnjruiz;
        private System.Windows.Forms.Button btncubao;
        private System.Windows.Forms.Button btnbettygo;
        private System.Windows.Forms.Button btngilmore;
        private System.Windows.Forms.Button btnvmapa;
        private System.Windows.Forms.Button btnpureza;
        private System.Windows.Forms.Button btnlegarda;
        private System.Windows.Forms.Button btnrecto;
        private System.Windows.Forms.Button btnkatipunan;
        private System.Windows.Forms.Button btnanonas;
    }
}

