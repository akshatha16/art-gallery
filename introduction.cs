using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace WindowsFormsApp4
{

    public partial class introduction : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWn, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        seller_uc s = new seller_uc();


        public introduction()
        {
            InitializeComponent();
        }

        

        private void introduction_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_timer.Start();
        }

        private void login_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                login_timer.Stop();
            }

        }

        //title bar
        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void logoff_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void titlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

       //sliding panel
        public void expandSlidingPanelGUI()
        {
         
            orders.Text = "  ORDERS";
            button1.Text = "   PRODUCTS";
            transport.Text = "     TRANSPORT";
            events.Text = " EVENTS";
            worker.Text = "    WORKERS";
            
            toggle_button.Image = Properties.Resources.menu;
            orders.Image = Properties.Resources.orders;
            button1.Image = Properties.Resources.seller;
            transport.Image = Properties.Resources.trans5;
            events.Image = Properties.Resources.events;
            worker.Image = Properties.Resources.worker1;
        }

        public void retractlidingPanelGUI()
        {

            orders.Text ="";
            button1.Text ="";
            transport.Text = "";
            events.Text = "";
            worker.Text = "";
            toggle_button.Image = Properties.Resources.menu;
            orders.Image = Properties.Resources.orders;
            button1.Image = Properties.Resources.seller;
            transport.Image = Properties.Resources.trans5;
            events.Image = Properties.Resources.events;
            worker.Image = Properties.Resources.worker1;

        }


        bool isSlidingpanelExpanded;
        const int max_slider_width=162;
        const int min_slider_width=60;

        private void toggle_button_Click(object sender, EventArgs e)
        {
            if(isSlidingpanelExpanded)
            {
                retractlidingPanelGUI();
            }
            sliding_panel_timer.Start();
        }


        private void sliding_panel_timer_Tick(object sender, EventArgs e)
        {
            if(isSlidingpanelExpanded)
            {
                sliding_panel.Width -= 20;
                if(sliding_panel.Width<=min_slider_width)
                {
                    isSlidingpanelExpanded = false;
                    sliding_panel_timer.Stop();
                    this.Refresh();
                }


            }
            else
            {
                sliding_panel.Width += 20;
                if (sliding_panel.Width >=max_slider_width)
                {
                    isSlidingpanelExpanded = true;
                    sliding_panel_timer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }


        //orders
        private void orders_Click(object sender, EventArgs e)
        {
            if(! content_panel.Controls.Contains(orders_uc.Instance))
            {
                content_panel.Controls.Add(orders_uc.Instance);
                orders_uc.Instance.Dock = DockStyle.Fill;
                orders_uc.Instance.BringToFront();
            }
            else
            {
                orders_uc.Instance.BringToFront();
            }
        }

        //products
        private void button1_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(seller_uc.Instance))
            {
                content_panel.Controls.Add(seller_uc.Instance);
                seller_uc.Instance.Dock = DockStyle.Fill;
                seller_uc.Instance.BringToFront();
            }
            else
            {
                seller_uc.Instance.BringToFront();
            }

           
        }

        //transport
        private void transport_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(transport_uc.Instance))
            {
                content_panel.Controls.Add(transport_uc.Instance);
                transport_uc.Instance.Dock = DockStyle.Fill;
                transport_uc.Instance.BringToFront();
            }
            else
            {
                transport_uc.Instance.BringToFront();
            }
        }


        //events
        private void events_Click(object sender, EventArgs e)
        {

            if (!content_panel.Controls.Contains(events_uc.Instance))
            {
                content_panel.Controls.Add(events_uc.Instance);
                events_uc.Instance.Dock = DockStyle.Fill;
                events_uc.Instance.BringToFront();
            }
            else
            {
                events_uc.Instance.BringToFront();
            }
        }

        //workers
        private void worker_Click(object sender, EventArgs e)
        {

            if (!content_panel.Controls.Contains(workers_uc.Instance))
            {
                content_panel.Controls.Add(workers_uc.Instance);
                workers_uc.Instance.Dock = DockStyle.Fill;
                workers_uc.Instance.BringToFront();
            }
            else
            {
                workers_uc.Instance.BringToFront();
            }
        }

        //miscellaneous
        private void content_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sliding_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maximize_Click(object sender, EventArgs e)
        {

        }

       
    }
}
