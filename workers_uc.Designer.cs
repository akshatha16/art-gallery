namespace WindowsFormsApp4
{
    partial class workers_uc
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
            this.worker_data = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.worker_grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_worker = new System.Windows.Forms.Panel();
            this.allow = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.un_txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ph_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_txt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worker_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.add_worker.SuspendLayout();
            this.allow.SuspendLayout();
            this.SuspendLayout();
            // 
            // worker_data
            // 
            this.worker_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.worker_data.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker_data.ForeColor = System.Drawing.Color.DodgerBlue;
            this.worker_data.Location = new System.Drawing.Point(413, 73);
            this.worker_data.Name = "worker_data";
            this.worker_data.Size = new System.Drawing.Size(131, 42);
            this.worker_data.TabIndex = 0;
            this.worker_data.Text = "SHOW WORKERS";
            this.worker_data.UseVisualStyleBackColor = true;
            this.worker_data.Click += new System.EventHandler(this.worker_data_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(68, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "ADD WORKER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // worker_grid
            // 
            this.worker_grid.BackgroundColor = System.Drawing.Color.White;
            this.worker_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worker_grid.Location = new System.Drawing.Point(29, 343);
            this.worker_grid.Name = "worker_grid";
            this.worker_grid.Size = new System.Drawing.Size(1077, 256);
            this.worker_grid.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.worker_data);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(282, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 166);
            this.panel1.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Gray;
            this.logout.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(272, 78);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 32);
            this.logout.TabIndex = 5;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(427, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(319, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(176, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME :";
            // 
            // add_worker
            // 
            this.add_worker.Controls.Add(this.allow);
            this.add_worker.Controls.Add(this.no);
            this.add_worker.Controls.Add(this.yes);
            this.add_worker.Controls.Add(this.age_txt);
            this.add_worker.Controls.Add(this.name_txt);
            this.add_worker.Controls.Add(this.textBox5);
            this.add_worker.Controls.Add(this.ph_txt);
            this.add_worker.Controls.Add(this.label8);
            this.add_worker.Controls.Add(this.label7);
            this.add_worker.Controls.Add(this.add_txt);
            this.add_worker.Controls.Add(this.label5);
            this.add_worker.Controls.Add(this.label4);
            this.add_worker.Controls.Add(this.label3);
            this.add_worker.Controls.Add(this.id_txt);
            this.add_worker.Controls.Add(this.add);
            this.add_worker.Location = new System.Drawing.Point(29, 343);
            this.add_worker.Name = "add_worker";
            this.add_worker.Size = new System.Drawing.Size(1077, 256);
            this.add_worker.TabIndex = 4;
            this.add_worker.Paint += new System.Windows.Forms.PaintEventHandler(this.add_worker_Paint);
            // 
            // allow
            // 
            this.allow.Controls.Add(this.textBox3);
            this.allow.Controls.Add(this.pass_txt);
            this.allow.Controls.Add(this.un_txt);
            this.allow.Controls.Add(this.label6);
            this.allow.Location = new System.Drawing.Point(773, 145);
            this.allow.Name = "allow";
            this.allow.Size = new System.Drawing.Size(218, 100);
            this.allow.TabIndex = 21;
            this.allow.Paint += new System.Windows.Forms.PaintEventHandler(this.allow_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(104, 69);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(100, 20);
            this.pass_txt.TabIndex = 23;
            // 
            // un_txt
            // 
            this.un_txt.AutoSize = true;
            this.un_txt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un_txt.Location = new System.Drawing.Point(12, 26);
            this.un_txt.Name = "un_txt";
            this.un_txt.Size = new System.Drawing.Size(86, 15);
            this.un_txt.TabIndex = 20;
            this.un_txt.Text = "USERNAME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "PASSWORD :";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.Color.DarkRed;
            this.no.Location = new System.Drawing.Point(878, 120);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 19);
            this.no.TabIndex = 18;
            this.no.TabStop = true;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            this.no.CheckedChanged += new System.EventHandler(this.no_CheckedChanged);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.DarkRed;
            this.yes.Location = new System.Drawing.Point(824, 120);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(48, 19);
            this.yes.TabIndex = 17;
            this.yes.TabStop = true;
            this.yes.Text = "YES";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.CheckedChanged += new System.EventHandler(this.yes_CheckedChanged);
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(891, 41);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(100, 20);
            this.age_txt.TabIndex = 16;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(535, 41);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 109);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 125);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ph_txt
            // 
            this.ph_txt.Location = new System.Drawing.Point(535, 120);
            this.ph_txt.Name = "ph_txt";
            this.ph_txt.Size = new System.Drawing.Size(100, 20);
            this.ph_txt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "WORKER NAME :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(844, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "AGE :";
            // 
            // add_txt
            // 
            this.add_txt.AutoSize = true;
            this.add_txt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_txt.Location = new System.Drawing.Point(55, 122);
            this.add_txt.Name = "add_txt";
            this.add_txt.Size = new System.Drawing.Size(73, 15);
            this.add_txt.TabIndex = 10;
            this.add_txt.Text = "ADDRESS :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(699, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "ALLOW_ACCESS ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CONTACT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "WORKER ID:";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(147, 39);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 22);
            this.id_txt.TabIndex = 6;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Control;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(511, 174);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(124, 60);
            this.add.TabIndex = 7;
            this.add.Text = "ADD WORKER";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // workers_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.workers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.add_worker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.worker_grid);
            this.Name = "workers_uc";
            this.Size = new System.Drawing.Size(1132, 648);
            this.Load += new System.EventHandler(this.workers_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worker_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.add_worker.ResumeLayout(false);
            this.add_worker.PerformLayout();
            this.allow.ResumeLayout(false);
            this.allow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button worker_data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView worker_grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel add_worker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label add_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox ph_txt;
        private System.Windows.Forms.Panel allow;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label un_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Button logout;
    }
}
