namespace WindowsFormsApp4
{
    partial class introduction
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
            this.components = new System.ComponentModel.Container();
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.titlebar = new System.Windows.Forms.Panel();
            this.logoff = new System.Windows.Forms.Button();
            this.minimise = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.worker = new System.Windows.Forms.Button();
            this.transport = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toggle_button = new System.Windows.Forms.Button();
            this.sliding_panel_timer = new System.Windows.Forms.Timer(this.components);
            this.content_panel = new System.Windows.Forms.Panel();
            this.titlebar.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_timer
            // 
            this.login_timer.Interval = 20;
            this.login_timer.Tick += new System.EventHandler(this.login_timer_Tick);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.White;
            this.titlebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlebar.Controls.Add(this.logoff);
            this.titlebar.Controls.Add(this.minimise);
            this.titlebar.Controls.Add(this.close_button);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.ForeColor = System.Drawing.Color.Black;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1300, 24);
            this.titlebar.TabIndex = 6;
            this.titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.titlebar_Paint);
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            // 
            // logoff
            // 
            this.logoff.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.logout;
            this.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoff.ForeColor = System.Drawing.Color.Teal;
            this.logoff.Location = new System.Drawing.Point(1221, 4);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(19, 17);
            this.logoff.TabIndex = 8;
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // minimise
            // 
            this.minimise.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.minimize;
            this.minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimise.ForeColor = System.Drawing.Color.Teal;
            this.minimise.Location = new System.Drawing.Point(1246, 4);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(16, 17);
            this.minimise.TabIndex = 7;
            this.minimise.UseVisualStyleBackColor = true;
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // close_button
            // 
            this.close_button.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.if_cross_circle_frame_11739;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.Teal;
            this.close_button.Location = new System.Drawing.Point(1268, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(19, 19);
            this.close_button.TabIndex = 8;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // sliding_panel
            // 
            this.sliding_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliding_panel.BackColor = System.Drawing.Color.Transparent;
            this.sliding_panel.Controls.Add(this.worker);
            this.sliding_panel.Controls.Add(this.transport);
            this.sliding_panel.Controls.Add(this.events);
            this.sliding_panel.Controls.Add(this.orders);
            this.sliding_panel.Controls.Add(this.button1);
            this.sliding_panel.Controls.Add(this.toggle_button);
            this.sliding_panel.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.sliding_panel.Location = new System.Drawing.Point(0, 24);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(58, 558);
            this.sliding_panel.TabIndex = 8;
            this.sliding_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sliding_panel_Paint);
            // 
            // worker
            // 
            this.worker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worker.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker.Image = global::WindowsFormsApp4.Properties.Resources.worker1;
            this.worker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.worker.Location = new System.Drawing.Point(0, 454);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(162, 89);
            this.worker.TabIndex = 5;
            this.worker.Text = "        WORKERS";
            this.worker.UseVisualStyleBackColor = true;
            this.worker.Click += new System.EventHandler(this.worker_Click);
            // 
            // transport
            // 
            this.transport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transport.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transport.Image = global::WindowsFormsApp4.Properties.Resources.trans5;
            this.transport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transport.Location = new System.Drawing.Point(0, 276);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(162, 89);
            this.transport.TabIndex = 4;
            this.transport.Text = "        TRANSPORT";
            this.transport.UseVisualStyleBackColor = true;
            this.transport.Click += new System.EventHandler(this.transport_Click);
            // 
            // events
            // 
            this.events.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.events.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.events.Image = global::WindowsFormsApp4.Properties.Resources.events;
            this.events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.events.Location = new System.Drawing.Point(0, 368);
            this.events.Name = "events";
            this.events.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.events.Size = new System.Drawing.Size(162, 89);
            this.events.TabIndex = 3;
            this.events.Text = "    EVENTS";
            this.events.UseVisualStyleBackColor = true;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // orders
            // 
            this.orders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.Image = global::WindowsFormsApp4.Properties.Resources.orders;
            this.orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders.Location = new System.Drawing.Point(0, 92);
            this.orders.Name = "orders";
            this.orders.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.orders.Size = new System.Drawing.Size(162, 86);
            this.orders.TabIndex = 2;
            this.orders.Text = "      ORDERS";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp4.Properties.Resources.seller;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 184);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(162, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "       PRODUCTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toggle_button
            // 
            this.toggle_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.toggle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggle_button.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle_button.Image = global::WindowsFormsApp4.Properties.Resources.menu;
            this.toggle_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggle_button.Location = new System.Drawing.Point(0, 0);
            this.toggle_button.Name = "toggle_button";
            this.toggle_button.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.toggle_button.Size = new System.Drawing.Size(169, 86);
            this.toggle_button.TabIndex = 0;
            this.toggle_button.Text = " MENU";
            this.toggle_button.UseVisualStyleBackColor = true;
            this.toggle_button.Click += new System.EventHandler(this.toggle_button_Click);
            // 
            // sliding_panel_timer
            // 
            this.sliding_panel_timer.Tick += new System.EventHandler(this.sliding_panel_timer_Tick);
            // 
            // content_panel
            // 
            this.content_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content_panel.BackColor = System.Drawing.Color.White;
            this.content_panel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._17;
            this.content_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.content_panel.Location = new System.Drawing.Point(168, 24);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1132, 648);
            this.content_panel.TabIndex = 7;
            this.content_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.content_panel_Paint);
            // 
            // introduction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.titlebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.introduction_Load);
            this.titlebar.ResumeLayout(false);
            this.sliding_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Button minimise;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Panel sliding_panel;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Timer sliding_panel_timer;
        private System.Windows.Forms.Button toggle_button;
        private System.Windows.Forms.Button transport;
        private System.Windows.Forms.Button worker;
    }
}