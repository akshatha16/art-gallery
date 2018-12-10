namespace WindowsFormsApp4
{
    partial class events_uc
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.auction = new System.Windows.Forms.Button();
            this.event_data = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.auc_bill_data = new System.Windows.Forms.DataGridView();
            this.auction_data = new System.Windows.Forms.DataGridView();
            this.auc_bill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_e = new System.Windows.Forms.Button();
            this.delete_e = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.a_enter = new System.Windows.Forms.Button();
            this.auc_no_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a_yes = new System.Windows.Forms.RadioButton();
            this.a_no = new System.Windows.Forms.RadioButton();
            this.e_worker_data = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.eve_no_txt = new System.Windows.Forms.TextBox();
            this.eve_name_txt = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.wk_id_txt = new System.Windows.Forms.TextBox();
            this.wk_name_txt = new System.Windows.Forms.TextBox();
            this.venue_txt = new System.Windows.Forms.TextBox();
            this.work_name = new System.Windows.Forms.Label();
            this.venue = new System.Windows.Forms.Label();
            this.work_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.ev_name = new System.Windows.Forms.Label();
            this.event_no = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.del_txt = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.event_data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auc_bill_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auction_data)).BeginInit();
            this.events.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_worker_data)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 11, 14, 0, 0, 0, 0),
        new System.DateTime(2018, 11, 18, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 2, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 16, 0, 0, 0, 0),
        new System.DateTime(2018, 12, 30, 0, 0, 0, 0),
        new System.DateTime(2019, 1, 13, 0, 0, 0, 0),
        new System.DateTime(2019, 1, 27, 0, 0, 0, 0)};
            this.monthCalendar1.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.monthCalendar1.Location = new System.Drawing.Point(31, 86);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "EVENT LIST";
            // 
            // auction
            // 
            this.auction.BackColor = System.Drawing.Color.Transparent;
            this.auction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auction.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auction.ForeColor = System.Drawing.Color.AliceBlue;
            this.auction.Location = new System.Drawing.Point(832, 65);
            this.auction.Name = "auction";
            this.auction.Size = new System.Drawing.Size(141, 45);
            this.auction.TabIndex = 2;
            this.auction.Text = "VIEW AUCTION SCHEDULE";
            this.auction.UseVisualStyleBackColor = false;
            this.auction.Click += new System.EventHandler(this.auction_Click);
            // 
            // event_data
            // 
            this.event_data.BackgroundColor = System.Drawing.Color.White;
            this.event_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_data.Location = new System.Drawing.Point(0, 0);
            this.event_data.Name = "event_data";
            this.event_data.Size = new System.Drawing.Size(1077, 294);
            this.event_data.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.auc_bill_data);
            this.panel1.Controls.Add(this.auction_data);
            this.panel1.Controls.Add(this.event_data);
            this.panel1.Location = new System.Drawing.Point(31, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 294);
            this.panel1.TabIndex = 4;
            // 
            // auc_bill_data
            // 
            this.auc_bill_data.BackgroundColor = System.Drawing.Color.White;
            this.auc_bill_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auc_bill_data.Location = new System.Drawing.Point(0, 0);
            this.auc_bill_data.Name = "auc_bill_data";
            this.auc_bill_data.Size = new System.Drawing.Size(1077, 294);
            this.auc_bill_data.TabIndex = 7;
            // 
            // auction_data
            // 
            this.auction_data.BackgroundColor = System.Drawing.Color.White;
            this.auction_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auction_data.Location = new System.Drawing.Point(0, 0);
            this.auction_data.Name = "auction_data";
            this.auction_data.Size = new System.Drawing.Size(1077, 294);
            this.auction_data.TabIndex = 7;
            // 
            // auc_bill
            // 
            this.auc_bill.BackColor = System.Drawing.Color.Transparent;
            this.auc_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auc_bill.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auc_bill.ForeColor = System.Drawing.Color.AliceBlue;
            this.auc_bill.Location = new System.Drawing.Point(979, 65);
            this.auc_bill.Name = "auc_bill";
            this.auc_bill.Size = new System.Drawing.Size(141, 45);
            this.auc_bill.TabIndex = 5;
            this.auc_bill.Text = "VIEW AUCTION BILLS";
            this.auc_bill.UseVisualStyleBackColor = false;
            this.auc_bill.Click += new System.EventHandler(this.auc_bill_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(698, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "VIEW EVENT LIST";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_e
            // 
            this.add_e.BackColor = System.Drawing.Color.Transparent;
            this.add_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_e.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_e.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.add_e.Location = new System.Drawing.Point(774, 121);
            this.add_e.Name = "add_e";
            this.add_e.Size = new System.Drawing.Size(114, 31);
            this.add_e.TabIndex = 7;
            this.add_e.Text = "ADD EVENT";
            this.add_e.UseVisualStyleBackColor = false;
            this.add_e.Click += new System.EventHandler(this.add_e_Click);
            // 
            // delete_e
            // 
            this.delete_e.BackColor = System.Drawing.Color.Transparent;
            this.delete_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_e.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_e.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.delete_e.Location = new System.Drawing.Point(923, 121);
            this.delete_e.Name = "delete_e";
            this.delete_e.Size = new System.Drawing.Size(114, 31);
            this.delete_e.TabIndex = 8;
            this.delete_e.Text = "DELETE EVENT";
            this.delete_e.UseVisualStyleBackColor = false;
            this.delete_e.Click += new System.EventHandler(this.delete_e_Click);
            // 
            // events
            // 
            this.events.Controls.Add(this.panel2);
            this.events.Controls.Add(this.label2);
            this.events.Controls.Add(this.a_yes);
            this.events.Controls.Add(this.a_no);
            this.events.Controls.Add(this.e_worker_data);
            this.events.Controls.Add(this.add);
            this.events.Controls.Add(this.eve_no_txt);
            this.events.Controls.Add(this.eve_name_txt);
            this.events.Controls.Add(this.date_txt);
            this.events.Controls.Add(this.wk_id_txt);
            this.events.Controls.Add(this.wk_name_txt);
            this.events.Controls.Add(this.venue_txt);
            this.events.Controls.Add(this.work_name);
            this.events.Controls.Add(this.venue);
            this.events.Controls.Add(this.work_id);
            this.events.Controls.Add(this.label5);
            this.events.Controls.Add(this.date);
            this.events.Controls.Add(this.ev_name);
            this.events.Controls.Add(this.event_no);
            this.events.Location = new System.Drawing.Point(31, 278);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(1077, 294);
            this.events.TabIndex = 9;
            this.events.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.a_enter);
            this.panel2.Controls.Add(this.auc_no_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(857, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 102);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // a_enter
            // 
            this.a_enter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.a_enter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.a_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_enter.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_enter.ForeColor = System.Drawing.Color.Navy;
            this.a_enter.Location = new System.Drawing.Point(63, 58);
            this.a_enter.Name = "a_enter";
            this.a_enter.Size = new System.Drawing.Size(68, 30);
            this.a_enter.TabIndex = 3;
            this.a_enter.Text = "ENETR";
            this.a_enter.UseVisualStyleBackColor = false;
            this.a_enter.Click += new System.EventHandler(this.a_enter_Click);
            // 
            // auc_no_txt
            // 
            this.auc_no_txt.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auc_no_txt.Location = new System.Drawing.Point(100, 22);
            this.auc_no_txt.Name = "auc_no_txt";
            this.auc_no_txt.Size = new System.Drawing.Size(71, 19);
            this.auc_no_txt.TabIndex = 2;
            this.auc_no_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "AUCTION NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(717, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "AUCTION ?";
            // 
            // a_yes
            // 
            this.a_yes.AutoSize = true;
            this.a_yes.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_yes.ForeColor = System.Drawing.Color.Crimson;
            this.a_yes.Location = new System.Drawing.Point(801, 150);
            this.a_yes.Name = "a_yes";
            this.a_yes.Size = new System.Drawing.Size(47, 18);
            this.a_yes.TabIndex = 12;
            this.a_yes.TabStop = true;
            this.a_yes.Text = "YES";
            this.a_yes.UseVisualStyleBackColor = true;
            // 
            // a_no
            // 
            this.a_no.AutoSize = true;
            this.a_no.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_no.ForeColor = System.Drawing.Color.Crimson;
            this.a_no.Location = new System.Drawing.Point(801, 174);
            this.a_no.Name = "a_no";
            this.a_no.Size = new System.Drawing.Size(40, 18);
            this.a_no.TabIndex = 13;
            this.a_no.TabStop = true;
            this.a_no.Text = "NO";
            this.a_no.UseVisualStyleBackColor = true;
            // 
            // e_worker_data
            // 
            this.e_worker_data.BackgroundColor = System.Drawing.Color.White;
            this.e_worker_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.e_worker_data.Location = new System.Drawing.Point(26, 145);
            this.e_worker_data.Name = "e_worker_data";
            this.e_worker_data.Size = new System.Drawing.Size(367, 130);
            this.e_worker_data.TabIndex = 10;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(545, 243);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 32);
            this.add.TabIndex = 10;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // eve_no_txt
            // 
            this.eve_no_txt.Location = new System.Drawing.Point(117, 90);
            this.eve_no_txt.Name = "eve_no_txt";
            this.eve_no_txt.Size = new System.Drawing.Size(119, 20);
            this.eve_no_txt.TabIndex = 22;
            // 
            // eve_name_txt
            // 
            this.eve_name_txt.Location = new System.Drawing.Point(386, 90);
            this.eve_name_txt.Name = "eve_name_txt";
            this.eve_name_txt.Size = new System.Drawing.Size(153, 20);
            this.eve_name_txt.TabIndex = 21;
            this.eve_name_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // date_txt
            // 
            this.date_txt.Location = new System.Drawing.Point(654, 90);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(137, 20);
            this.date_txt.TabIndex = 20;
            // 
            // wk_id_txt
            // 
            this.wk_id_txt.Location = new System.Drawing.Point(523, 148);
            this.wk_id_txt.Name = "wk_id_txt";
            this.wk_id_txt.Size = new System.Drawing.Size(137, 20);
            this.wk_id_txt.TabIndex = 19;
            // 
            // wk_name_txt
            // 
            this.wk_name_txt.Location = new System.Drawing.Point(523, 188);
            this.wk_name_txt.Name = "wk_name_txt";
            this.wk_name_txt.Size = new System.Drawing.Size(137, 20);
            this.wk_name_txt.TabIndex = 18;
            // 
            // venue_txt
            // 
            this.venue_txt.Location = new System.Drawing.Point(909, 90);
            this.venue_txt.Name = "venue_txt";
            this.venue_txt.Size = new System.Drawing.Size(141, 20);
            this.venue_txt.TabIndex = 17;
            // 
            // work_name
            // 
            this.work_name.AutoSize = true;
            this.work_name.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_name.ForeColor = System.Drawing.Color.Navy;
            this.work_name.Location = new System.Drawing.Point(435, 190);
            this.work_name.Name = "work_name";
            this.work_name.Size = new System.Drawing.Size(82, 15);
            this.work_name.TabIndex = 16;
            this.work_name.Text = "INCHARGE :";
            this.work_name.Click += new System.EventHandler(this.work_name_Click);
            // 
            // venue
            // 
            this.venue.AutoSize = true;
            this.venue.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venue.ForeColor = System.Drawing.Color.Navy;
            this.venue.Location = new System.Drawing.Point(844, 92);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(59, 15);
            this.venue.TabIndex = 15;
            this.venue.Text = "VENUE :";
            // 
            // work_id
            // 
            this.work_id.AutoSize = true;
            this.work_id.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_id.ForeColor = System.Drawing.Color.Navy;
            this.work_id.Location = new System.Drawing.Point(417, 150);
            this.work_id.Name = "work_id";
            this.work_id.Size = new System.Drawing.Size(100, 15);
            this.work_id.TabIndex = 14;
            this.work_id.Text = "INCHARGE ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "ENTER NEW EVENT";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Navy;
            this.date.Location = new System.Drawing.Point(599, 92);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(49, 15);
            this.date.TabIndex = 12;
            this.date.Text = "DATE :";
            // 
            // ev_name
            // 
            this.ev_name.AutoSize = true;
            this.ev_name.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ev_name.ForeColor = System.Drawing.Color.Navy;
            this.ev_name.Location = new System.Drawing.Point(280, 92);
            this.ev_name.Name = "ev_name";
            this.ev_name.Size = new System.Drawing.Size(100, 15);
            this.ev_name.TabIndex = 11;
            this.ev_name.Text = "EVENT NAME :";
            // 
            // event_no
            // 
            this.event_no.AutoSize = true;
            this.event_no.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_no.ForeColor = System.Drawing.Color.Navy;
            this.event_no.Location = new System.Drawing.Point(32, 92);
            this.event_no.Name = "event_no";
            this.event_no.Size = new System.Drawing.Size(79, 15);
            this.event_no.TabIndex = 10;
            this.event_no.Text = "EVENT NO :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.del_txt);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Location = new System.Drawing.Point(31, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 294);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(444, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "ENTER EVENT NO TO DELETE";
            // 
            // del_txt
            // 
            this.del_txt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_txt.Location = new System.Drawing.Point(480, 135);
            this.del_txt.Name = "del_txt";
            this.del_txt.Size = new System.Drawing.Size(157, 30);
            this.del_txt.TabIndex = 12;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Navy;
            this.delete.Location = new System.Drawing.Point(492, 224);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(128, 33);
            this.delete.TabIndex = 13;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // events_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.event1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.events);
            this.Controls.Add(this.delete_e);
            this.Controls.Add(this.add_e);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.auc_bill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.auction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "events_uc";
            this.Size = new System.Drawing.Size(1132, 600);
            this.Load += new System.EventHandler(this.events_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.event_data)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auc_bill_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auction_data)).EndInit();
            this.events.ResumeLayout(false);
            this.events.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_worker_data)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button auction;
        private System.Windows.Forms.DataGridView event_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button auc_bill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView auction_data;
        private System.Windows.Forms.DataGridView auc_bill_data;
        private System.Windows.Forms.Button add_e;
        private System.Windows.Forms.Button delete_e;
        private System.Windows.Forms.Panel events;
        private System.Windows.Forms.Label work_name;
        private System.Windows.Forms.Label venue;
        private System.Windows.Forms.Label work_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label ev_name;
        private System.Windows.Forms.Label event_no;
        private System.Windows.Forms.TextBox eve_no_txt;
        private System.Windows.Forms.TextBox eve_name_txt;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.TextBox wk_id_txt;
        private System.Windows.Forms.TextBox wk_name_txt;
        private System.Windows.Forms.TextBox venue_txt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView e_worker_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton a_yes;
        private System.Windows.Forms.RadioButton a_no;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button a_enter;
        private System.Windows.Forms.TextBox auc_no_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox del_txt;
        private System.Windows.Forms.Button delete;
    }
}
