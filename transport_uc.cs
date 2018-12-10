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
    public partial class transport_uc : UserControl
    {
        private static transport_uc _instance;
        public static transport_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new transport_uc();
                }
                return _instance;

            }
        }
        public transport_uc()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aksha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1.mdf;Integrated Security=True");
        private void transport_uc_Load(object sender, EventArgs e)
        {
            trans_data.Hide();
        }
        private void transport_Click(object sender, EventArgs e)
        {
            trans_data.Show();
            refresh_data();
        }


        
        public void refresh_data()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("trans_list_sp", con);
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
                trans_data.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

       

        
    }
}
