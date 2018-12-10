namespace WindowsFormsApp4
{
    partial class seller_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sellerdata = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.gal_txt = new System.Windows.Forms.TextBox();
            this.cpp_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.mrp_txt = new System.Windows.Forms.TextBox();
            this.qt_txt = new System.Windows.Forms.TextBox();
            this.ina_txt = new System.Windows.Forms.TextBox();
            this.in_txt = new System.Windows.Forms.TextBox();
            this.ph_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.add_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellerdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sellerdata
            // 
            this.sellerdata.BackgroundColor = System.Drawing.Color.White;
            this.sellerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerdata.Location = new System.Drawing.Point(86, 128);
            this.sellerdata.Name = "sellerdata";
            this.sellerdata.Size = new System.Drawing.Size(960, 350);
            this.sellerdata.TabIndex = 0;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Transparent;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(977, 15);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(142, 67);
            this.show.TabIndex = 1;
            this.show.Text = "SHOW PRODUCTS";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // add_product
            // 
            this.add_product.BackColor = System.Drawing.Color.Transparent;
            this.add_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_product.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product.Location = new System.Drawing.Point(17, 15);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(142, 67);
            this.add_product.TabIndex = 2;
            this.add_product.Text = "ADD   PRODUCT";
            this.add_product.UseVisualStyleBackColor = false;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.add_txt);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.ph_txt);
            this.panel1.Controls.Add(this.in_txt);
            this.panel1.Controls.Add(this.ina_txt);
            this.panel1.Controls.Add(this.qt_txt);
            this.panel1.Controls.Add(this.mrp_txt);
            this.panel1.Controls.Add(this.tc_txt);
            this.panel1.Controls.Add(this.cpp_txt);
            this.panel1.Controls.Add(this.gal_txt);
            this.panel1.Controls.Add(this.date_txt);
            this.panel1.Controls.Add(this.id_txt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(86, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 350);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLER ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELLER NAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SELLER CONTACT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "GALLERY ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ITEM NUBMER :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "ITEM NAME :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(697, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "QUANTITY :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "COST PER PIECE :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "TOTAL COST :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(779, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "DATE :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(734, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "MRP :";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(137, 35);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 12;
            // 
            // date_txt
            // 
            this.date_txt.Location = new System.Drawing.Point(834, 35);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(100, 20);
            this.date_txt.TabIndex = 13;
            // 
            // gal_txt
            // 
            this.gal_txt.Location = new System.Drawing.Point(137, 271);
            this.gal_txt.Name = "gal_txt";
            this.gal_txt.Size = new System.Drawing.Size(100, 20);
            this.gal_txt.TabIndex = 14;
            this.gal_txt.Text = "100001";
            // 
            // cpp_txt
            // 
            this.cpp_txt.Location = new System.Drawing.Point(137, 201);
            this.cpp_txt.Name = "cpp_txt";
            this.cpp_txt.Size = new System.Drawing.Size(100, 20);
            this.cpp_txt.TabIndex = 15;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(462, 201);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(100, 20);
            this.tc_txt.TabIndex = 16;
            // 
            // mrp_txt
            // 
            this.mrp_txt.Location = new System.Drawing.Point(782, 201);
            this.mrp_txt.Name = "mrp_txt";
            this.mrp_txt.Size = new System.Drawing.Size(100, 20);
            this.mrp_txt.TabIndex = 17;
            // 
            // qt_txt
            // 
            this.qt_txt.Location = new System.Drawing.Point(782, 121);
            this.qt_txt.Name = "qt_txt";
            this.qt_txt.Size = new System.Drawing.Size(100, 20);
            this.qt_txt.TabIndex = 18;
            // 
            // ina_txt
            // 
            this.ina_txt.Location = new System.Drawing.Point(462, 121);
            this.ina_txt.Name = "ina_txt";
            this.ina_txt.Size = new System.Drawing.Size(100, 20);
            this.ina_txt.TabIndex = 19;
            // 
            // in_txt
            // 
            this.in_txt.Location = new System.Drawing.Point(137, 121);
            this.in_txt.Name = "in_txt";
            this.in_txt.Size = new System.Drawing.Size(100, 20);
            this.in_txt.TabIndex = 20;
            // 
            // ph_txt
            // 
            this.ph_txt.Location = new System.Drawing.Point(640, 35);
            this.ph_txt.Name = "ph_txt";
            this.ph_txt.Size = new System.Drawing.Size(100, 20);
            this.ph_txt.TabIndex = 21;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(377, 35);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 22;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MintCream;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(782, 271);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 38);
            this.add.TabIndex = 23;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(327, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "SELLER ADDRESS :";
            // 
            // add_txt
            // 
            this.add_txt.Location = new System.Drawing.Point(462, 268);
            this.add_txt.Multiline = true;
            this.add_txt.Name = "add_txt";
            this.add_txt.Size = new System.Drawing.Size(100, 41);
            this.add_txt.TabIndex = 25;
            // 
            // seller_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Rush_Band_Background_HD__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.show);
            this.Controls.Add(this.sellerdata);
            this.Name = "seller_uc";
            this.Size = new System.Drawing.Size(1132, 598);
            this.Load += new System.EventHandler(this.seller_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellerdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sellerdata;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox ph_txt;
        private System.Windows.Forms.TextBox in_txt;
        private System.Windows.Forms.TextBox ina_txt;
        private System.Windows.Forms.TextBox qt_txt;
        private System.Windows.Forms.TextBox mrp_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.TextBox cpp_txt;
        private System.Windows.Forms.TextBox gal_txt;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add_txt;
        private System.Windows.Forms.Label label13;
    }
}
