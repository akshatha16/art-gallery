using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp4
{
    public partial class events_uc : UserControl

    {
        private static events_uc _instance;
        public static events_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new events_uc();
                }
                return _instance;

            }
        }
        public events_uc()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");

        private void events_uc_Load(object sender, EventArgs e)
        {
            events.SendToBack();
            panel3.SendToBack();
        }

        //EVENT
        private void button2_Click(object sender, EventArgs e)
        {
            panel3.SendToBack();
            events.SendToBack();

            if (!panel1.Controls.Contains(event_data))
            {
                event_data.BringToFront();
            }
            else
            {
                event_data.BringToFront();
            }

            refresh_data1();

        }

        //add event
        private void add_e_Click(object sender, EventArgs e)
        {
            panel3.SendToBack();
            panel2.Hide();

            if (!panel1.Controls.Contains(events))
            {
                panel1.Controls.Add(events);
                events.Dock = DockStyle.Fill;
                events.BringToFront();
            }
            else
            {
                events.BringToFront();
            }




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (!events.Controls.Contains(e_worker_data))
            {
                events.Controls.Add(e_worker_data);
                e_worker_data.Dock = DockStyle.Fill;
                e_worker_data.BringToFront();
            }
            else
            {
                e_worker_data.BringToFront();
            }

            refresh_data4();

        }

        private void add_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("add_event", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@event_no", eve_no_txt.Text);
            cmd.Parameters.AddWithValue("@event_name", eve_name_txt.Text);
            cmd.Parameters.AddWithValue("@date", date_txt.Text);
            cmd.Parameters.AddWithValue("@venue", venue_txt.Text);
            cmd.Parameters.AddWithValue("@worker_id", wk_id_txt.Text);
            cmd.Parameters.AddWithValue("@worker_name", wk_name_txt.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("                <<INVALID SQL OPERATION>>:  \n" + ex);
            }

            if (a_yes.Checked)
            {
                panel2.Show();
            }


            con.Close();
            refresh_data1();

            eve_name_txt.Clear();
            date_txt.Clear();
            venue_txt.Clear();
            wk_id_txt.Clear();
            wk_name_txt.Clear();



            
        }

        private void a_enter_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("add_auction", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@event_no", eve_no_txt.Text);
            cmd.Parameters.AddWithValue("@auc_no", auc_no_txt.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("                <<INVALID SQL OPERATION>>:  \n" + ex);
            }

            con.Close();



            refresh_data2();
            eve_no_txt.Clear();
            auc_no_txt.Clear();

        }
           //delete event

        private void delete_e_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(panel3))
            {
                panel3.BringToFront();
            }
            else
            {
                panel3.BringToFront();
            }


        }

        private void delete_Click(object sender, EventArgs e)
        {

            try
            {


                SqlCommand cmd = new SqlCommand("del_event", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@event_no", del_txt.Text);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                <<INVALID SQL OPERATION>>:  \n" + ex);
                }

                con.Close();
                refresh_data1();
                refresh_data2();
                MessageBox.Show("DELETED");
            }
            catch (Exception ec)
            {
                MessageBox.Show("" + ec);
            }

        }

        //AUCTIONS
        private void auction_Click(object sender, EventArgs e)
        {
            events.SendToBack();
            panel3.SendToBack();

            if (!panel1.Controls.Contains(auction_data))
            {
                auction_data.BringToFront();
            }
            else
            {
                auction_data.BringToFront();
            }

            refresh_data2();

        }


        //AUCTION BILL
        private void auc_bill_Click(object sender, EventArgs e)
        {
            panel3.SendToBack();
            if (!panel1.Controls.Contains(auc_bill_data))
            {
                auc_bill_data.BringToFront();
            }
            else
            {
                auc_bill_data.BringToFront();
            }

            refresh_data3();
        }





        //REFRESH DATA
        public void refresh_data1()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("events_list", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("                 <<INVALID SQL COMMAND>>:\n" + ex);
                }


                event_data.DataSource = DS.Tables[0];
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        public void refresh_data2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("auction_list", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("                 <<INVALID SQL COMMAND>>:\n" + ex);
                }


                auction_data.DataSource = DS.Tables[0];
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void refresh_data3()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("auc_bill_list", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("                 <<INVALID SQL COMMAND>>:\n" + ex);
                }


                auc_bill_data.DataSource = DS.Tables[0];
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        public void refresh_data4()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("worker_list", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("                 <<INVALID SQL COMMAND>>:\n" + ex);
                }


                e_worker_data.DataSource = DS.Tables[0];
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }



        //micellaneous
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void work_name_Click(object sender, EventArgs e)
        {

        }

       
        private void add_auc_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
