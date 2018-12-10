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
    public partial class orders_uc : UserControl
    {
        private static orders_uc _instance;
        public static orders_uc Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new orders_uc();
                }
                return _instance;

            }
        }
          
        public orders_uc()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");
        private void orders_uc_Load(object sender, EventArgs e)
        {
            panel2.SendToBack();
        }


        //take order
        private void takeorder_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(takeorder_uc.Instance))
            {
                panel1.Controls.Add(takeorder_uc.Instance);
                takeorder_uc.Instance.Dock = DockStyle.Fill;
                takeorder_uc.Instance.BringToFront();
            }
            else
            {
                takeorder_uc.Instance.BringToFront();
            }
        }


        //view orders
        private void VIEW_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(dataGridView1))
            {
                dataGridView1.BringToFront();
            }
            else
            {
                dataGridView1.BringToFront();
            }

            refresh_data();
        }


        //search order
        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.SendToBack();
            takeorder_uc.Instance.SendToBack();

            if (!panel1.Controls.Contains(panel2))
            {
                panel2.BringToFront();
            }
            else
            {
                panel2.BringToFront();
            }
        }

        private void OKAY_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("searchess_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bill_no", billno.Text);


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

                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.BringToFront();


            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

            billno.Clear();
        }



        //refresh data
        public void refresh_data()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("show_orders", con);
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

                
                dataGridView1.DataSource = DS.Tables[0];
                con.Close();
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
        private void BUYER_PHONE_Click(object sender, EventArgs e)
        {

        }
        private void TRANSPORT_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}






