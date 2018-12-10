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
    public partial class seller_uc : UserControl
    {
        private static seller_uc _instance;
        public static seller_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new seller_uc();
                }
                return _instance;

            }
        }

        public seller_uc()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");
        private void seller_uc_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            sellerdata.Hide();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            sellerdata.Hide();
            panel1.Show();
        }


        private void show_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            sellerdata.Show();
            refresh_data1();
        }

        private void add_Click(object sender, EventArgs e)
        {
            sellerdata.Hide();
            panel1.Show();

            SqlCommand cmd = new SqlCommand("add_product", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id_txt.Text);
            cmd.Parameters.AddWithValue("@name", name_txt.Text);
            cmd.Parameters.AddWithValue("@phone", ph_txt.Text);
            cmd.Parameters.AddWithValue("@address", add_txt.Text);
            cmd.Parameters.AddWithValue("@gal_id", gal_txt.Text);
            cmd.Parameters.AddWithValue("@item_no", in_txt.Text);
            cmd.Parameters.AddWithValue("@item_name", ina_txt.Text);
            cmd.Parameters.AddWithValue("@quantity", qt_txt.Text);
            cmd.Parameters.AddWithValue("@cost_per_piece", cpp_txt.Text);
            cmd.Parameters.AddWithValue("@total_charge", tc_txt.Text);
            cmd.Parameters.AddWithValue("@purchase_date", date_txt.Text);
            cmd.Parameters.AddWithValue("@mrp", mrp_txt.Text);



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

            MessageBox.Show("PRODUCT ADDED");
            refresh_data1();
            id_txt.Clear();
            name_txt.Clear();
            add_txt.Clear();
            ph_txt.Clear();
            ina_txt.Clear();
            in_txt.Clear();
            qt_txt.Clear();
            cpp_txt.Clear();
            tc_txt.Clear();
            date_txt.Clear();
            mrp_txt.Clear();
        }




        

        public void refresh_data1()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("seller_sp", con);
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

                con.Close();
                sellerdata.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //miscellaneous
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
    
    }
}
