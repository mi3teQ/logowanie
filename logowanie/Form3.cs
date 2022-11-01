using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowanie
{

    


    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public class Server
        {
            public SqlConnection con;
            public SqlCommand cmd = new SqlCommand();
            public SqlDataAdapter da = new SqlDataAdapter();
            public DataTable dt = new DataTable();

            public string query;
            public string connectionString = "Data Source=DESKTOP-6DTKNUT;Initial Catalog=logowanie;Integrated Security=True";



            public void ServerConnect()
            {
                con = new SqlConnection(connectionString);
                con.Open();
            }
            public void CloseConnection()
            {
                con.Close();
            }

           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Server serv123 = new Server();
            try
            {
                serv123.cmd = new SqlCommand();
                serv123.cmd.Connection = serv123.con;
                serv123.cmd.CommandText = serv123.query;

                serv123.da.SelectCommand = serv123.cmd;
                serv123.da.Fill(serv123.dt);

                listBox1.DataSource = serv123.dt;
                listBox1.DisplayMember = "Fullname";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                serv123.da.Dispose();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
