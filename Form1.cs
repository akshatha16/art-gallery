using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Hide();
            
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void LOGIN_Click(object sender, EventArgs e)
        {
            try
            { 
                if (!(textBox1.Text == string.Empty))
                {
                    if (!(textBox2.Text == string.Empty))
                    {
                        String query = "select * from worker where username = '" + textBox1.Text + "'and password = '" + this.textBox2.Text + "'" + "and allow_access='y'";
                        cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;

                        while (dbr.Read())
                        {
                            count = count + 1;
                        }

                        if (count == 1)
                        {
                            label4.Hide();
                            introduction obj = new introduction();
                            this.Hide();
                            obj.Show();
                        }

                        else
                        {
                            label4.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }

                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }

                con.Close();

            }

            catch (Exception es)
            {

                MessageBox.Show(es.Message);

            }

        }


        //miscellaneous
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
















