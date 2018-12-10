namespace WindowsFormsApp4
{
    partial class orders_uc
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
            this.orders = new System.Windows.Forms.Label();
            this.VIEW = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OKAY = new System.Windows.Forms.Button();
            this.billno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.takeorder = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.BackColor = System.Drawing.Color.Transparent;
            this.orders.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.Location = new System.Drawing.Point(19, 13);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(217, 50);
            this.orders.TabIndex = 2;
            this.orders.Text = "ORDERS";
            this.orders.Click += new System.EventHandler(this.label1_Click);
            // 
            // VIEW
            // 
            this.VIEW.BackColor = System.Drawing.Color.Transparent;
            this.VIEW.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VIEW.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIEW.Location = new System.Drawing.Point(968, 30);
            this.VIEW.Name = "VIEW";
            this.VIEW.Size = new System.Drawing.Size(128, 37);
            this.VIEW.TabIndex = 29;
            this.VIEW.Text = "VIEW ORDERS";
            this.VIEW.UseVisualStyleBackColor = false;
            this.VIEW.Click += new System.EventHandler(this.VIEW_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 489);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.OKAY);
            this.panel2.Controls.Add(this.billno);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 489);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // OKAY
            // 
            this.OKAY.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKAY.Location = new System.Drawing.Point(528, 241);
            this.OKAY.Name = "OKAY";
            this.OKAY.Size = new System.Drawing.Size(92, 23);
            this.OKAY.TabIndex = 2;
            this.OKAY.Text = "OKAY";
            this.OKAY.UseVisualStyleBackColor = true;
            this.OKAY.Click += new System.EventHandler(this.OKAY_Click);
            // 
            // billno
            // 
            this.billno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billno.Location = new System.Drawing.Point(584, 178);
            this.billno.Name = "billno";
            this.billno.Size = new System.Drawing.Size(147, 35);
            this.billno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER BILL NO :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1131, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // takeorder
            // 
            this.takeorder.BackColor = System.Drawing.Color.Transparent;
            this.takeorder.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.takeorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takeorder.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeorder.Location = new System.Drawing.Point(648, 30);
            this.takeorder.Name = "takeorder";
            this.takeorder.Size = new System.Drawing.Size(128, 37);
            this.takeorder.TabIndex = 32;
            this.takeorder.Text = "TAKE ORDER";
            this.takeorder.UseVisualStyleBackColor = false;
            this.takeorder.Click += new System.EventHandler(this.takeorder_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(809, 30);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 37);
            this.search.TabIndex = 33;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // orders_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.search);
            this.Controls.Add(this.takeorder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VIEW);
            this.Controls.Add(this.orders);
            this.Name = "orders_uc";
            this.Size = new System.Drawing.Size(1134, 602);
            this.Load += new System.EventHandler(this.orders_uc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Button VIEW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button takeorder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox billno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKAY;
    }
}
