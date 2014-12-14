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

namespace ADOdemo
{
    public partial class Form1 : Form
    {
        DataTable oopTable = new DataTable("CIS2621");
        
        private static DataSet SelectRows(DataSet dataset, string connectionString, string queryString)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    queryString, connection);
                adapter.Fill(dataset);
                return dataset;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MERCIER-PC\\SQLEXPRESS;Initial Catalog=Classmates;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("INSERT into CIS2621 values('" + textBoxID.Text + "','" + textBoxFirstname.Text + "','" + textBoxLastname.Text + "','" + textBoxGender.Text + "','" + textBoxEmail.Text + "');", con);
            int a = sc.ExecuteNonQuery();
            MessageBox.Show(a + " Record Added.");
            
            con.Close();

            textBoxID.Clear(); 
            textBoxFirstname.Clear();
            textBoxLastname.Clear();
            textBoxGender.Clear();
            textBoxEmail.Clear();
            textBoxID.Focus();
        }

        CompleteList secondForm = new CompleteList();

        private void button2_Click(object sender, EventArgs e)
        {
            secondForm.Show();

            //string queryString = "Select [ID], [firstname], [lastname], [gender], [email] From [CIS2621]";
            //DataSet ds = new DataSet();
            ////DataSet ds = GetData(queryString);
            //SqlDataAdapter adapter = new SqlDataAdapter(queryString);

            //adapter.Fill(ds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
