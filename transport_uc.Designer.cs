namespace WindowsFormsApp4
{
    partial class transport_uc
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
            this.transport = new System.Windows.Forms.Button();
            this.trans_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trans_data)).BeginInit();
            this.SuspendLayout();
            // 
            // transport
            // 
            this.transport.BackColor = System.Drawing.Color.Transparent;
            this.transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transport.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transport.Location = new System.Drawing.Point(68, 33);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(171, 54);
            this.transport.TabIndex = 0;
            this.transport.Text = "SHOW TRANSPORT DETAILS";
            this.transport.UseVisualStyleBackColor = false;
            this.transport.Click += new System.EventHandler(this.transport_Click);
            // 
            // trans_data
            // 
            this.trans_data.BackgroundColor = System.Drawing.Color.White;
            this.trans_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trans_data.Location = new System.Drawing.Point(68, 211);
            this.trans_data.Name = "trans_data";
            this.trans_data.Size = new System.Drawing.Size(1017, 306);
            this.trans_data.TabIndex = 1;
            // 
            // transport_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.trs2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.trans_data);
            this.Controls.Add(this.transport);
            this.Name = "transport_uc";
            this.Size = new System.Drawing.Size(1132, 598);
            this.Load += new System.EventHandler(this.transport_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trans_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transport;
        private System.Windows.Forms.DataGridView trans_data;
    }
}
