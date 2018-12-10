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
    public partial class takeorder_uc : UserControl
    {

        private static takeorder_uc _instance;

        public static takeorder_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new takeorder_uc();
                }
                return _instance;

            }
        }
        public takeorder_uc()
        {
            InitializeComponent();


        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");
        private void takeorder_uc_Load(object sender, EventArgs e)
        {
            panel1.Hide();

        }

        //submit orders
        private void SUBMIT_Click(object sender, EventArgs e)
        {
           
            orders_uc o = new orders_uc();
           
            SqlCommand cmd = new SqlCommand("take_orders_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;


           
            cmd.Parameters.AddWithValue("@bill_no",bill_txt.Text);
            cmd.Parameters.AddWithValue("@date", date_txt.Text);
            cmd.Parameters.AddWithValue("@gal_id", gal_txt.Text);
            cmd.Parameters.AddWithValue("@item_no", itemno_txt.Text);
            cmd.Parameters.AddWithValue("@item_name", itemnm_txt.Text);
            cmd.Parameters.AddWithValue("@quantity", quan_txt.Text);
            cmd.Parameters.AddWithValue("@cost", cost_txt.Text);
            cmd.Parameters.AddWithValue("@pay_mode", pay_txt.Text);
            if (yes.Checked)
            {
                
                cmd.Parameters.AddWithValue("@transport","y");
            }
            else if(no.Checked)
            {
                
                cmd.Parameters.AddWithValue("@transport", "n");
            }
            cmd.Parameters.AddWithValue("@buyer_name", bn_txt.Text);
            cmd.Parameters.AddWithValue("@buyer_contact", bp_txt.Text);
            
            

            con.Open();


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("                <<INVALID SQL OPERATION>>:  \n" + ex);
            }

            con.Close();

            o.refresh_data();

            int amount = int.Parse(cost_txt.Text);


            MessageBox.Show("BILL AMOUNT IS:" + amount);

            bill_txt.Clear();
            date_txt.Clear();
           
            itemno_txt.Clear();
            itemnm_txt.Clear();
            quan_txt.Clear();
            cost_txt.Clear();
            pay_txt.Clear();
            
            bn_txt.Clear();
            bp_txt.Clear();

            

           

        }


        //enter transport
        private void no_CheckedChanged(object sender, EventArgs e)
        {
            if (no.Checked)
            {
                panel1.Hide();
            }
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
            if (yes.Checked)
                panel1.Show();

        }
        private void enter_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("transport_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            


            cmd.Parameters.AddWithValue("@trans_no", tano_txt.Text);
            cmd.Parameters.AddWithValue("@gal_id", gal_txt.Text);
            cmd.Parameters.AddWithValue("@tracking_no", track_txt.Text);
            cmd.Parameters.AddWithValue("@bill_no", textBox4.Text);
            cmd.Parameters.AddWithValue("@trans_charges", tc_txt.Text);
            cmd.Parameters.AddWithValue("@trans_mode", mode_txt.Text);
            cmd.Parameters.AddWithValue("@drop_address", drop_txt.Text);

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

            MessageBox.Show("TRANSPORT CHARGES ARE:" + tc_txt.Text);

            
            /*tano_txt.Clear();
            textBox4.Clear();
            track_txt.Clear();
            bill_txt.Clear();
            tc_txt.Clear();
            mode_txt.Clear();
            drop_txt.Clear();*/
        }


        //miscelaneous
       

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void drop_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tra_txt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
