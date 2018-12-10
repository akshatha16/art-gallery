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
    public partial class workers_uc : UserControl
    {
        private static workers_uc _instance;
        public static workers_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new workers_uc();
                }
                return _instance;

            }
        }


        public workers_uc()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");


        private void workers_uc_Load(object sender, EventArgs e)
        {
            
            worker_grid.Hide();
            add_worker.Hide();
           
        }

        private void worker_data_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="akshu" && textBox2.Text=="abcd1234")
            {
                add_worker.Hide();
                refresh_data();
                worker_grid.Show();
            }
            else
            {
                MessageBox.Show("NO ACCESS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allow.Hide();

            if (textBox1.Text == "akshu" && textBox2.Text == "abcd1234")
            {
                worker_grid.Hide();
                add_worker.Show();
            }
            else
            {
                MessageBox.Show("NO ACCESS");
            }

            
           
        
        }

        
        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("add_worker", con);
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("@id", id_txt.Text);
            cmd.Parameters.AddWithValue("@name", name_txt.Text);
            cmd.Parameters.AddWithValue("@age", age_txt.Text);
            cmd.Parameters.AddWithValue("@address", textBox5.Text);
            cmd.Parameters.AddWithValue("@ph_no", ph_txt.Text);
            if (yes.Checked)
            {

                cmd.Parameters.AddWithValue("@allow_access", "y");
                cmd.Parameters.AddWithValue("@username", textBox3.Text);
                cmd.Parameters.AddWithValue("@password", pass_txt.Text);
            }

            else if(no.Checked)
            {
                
                cmd.Parameters.AddWithValue("@allow_access", "n");
                cmd.Parameters.AddWithValue("@username", "NULL");
                cmd.Parameters.AddWithValue("@password", "NULL");

            }

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
            refresh_data();

            id_txt.Clear();
            name_txt.Clear();
            age_txt.Clear();
            textBox5.Clear();
            textBox3.Clear();
            pass_txt.Clear();
            



        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
            if (yes.Checked)
            {
                allow.Show();
            }
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            if (no.Checked)
            {
                allow.Hide();
            }
        }

        public void refresh_data()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("workers_list", con);
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
                worker_grid.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            worker_grid.Hide();
            add_worker.Hide();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_worker_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void allow_Paint(object sender, PaintEventArgs e)
        {
        }

       
       
    }
}
