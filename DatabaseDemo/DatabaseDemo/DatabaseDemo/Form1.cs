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

namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        string connetionString;
        SqlConnection cnn;
        SqlCommand cmd;
        string query;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from login_details where user_name=@username and user_password=@userpasssword;";
                cnn.Open();

                cmd = new SqlCommand(query,cnn);
                cmd.Parameters.AddWithValue("@username", tbloginid.Text);
                cmd.Parameters.AddWithValue("@userpasssword", tbloginpassword.Text);
                DataTable dtbl = new DataTable();

                SqlDataAdapter sqlsda = new SqlDataAdapter(cmd);
                sqlsda.Fill(dtbl);
                cnn.Close();

                if (dtbl.Rows.Count == 1)
                {
                    this.Hide();

                    if (tbloginid.Text == "admin")
                    {
                        MessageBox.Show("You are logged in as an Admin");
                        this.Hide();
                        AdminHome adminfm = new AdminHome(tbloginid.Text);
                        adminfm.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("You are logged in as a User");
                        this.Hide();
                        UserHome userfm = new UserHome(tbloginid.Text);
                        userfm.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Login error "+ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Data Source=LAPTOP-2AMVTRQA;Initial Catalog=DatabaseDemo;Integrated Security=True;Trust Server Certificate=True
                //connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
                connetionString = @"Data Source=LAPTOP-2AMVTRQA;Initial Catalog=DatabaseDemo;Integrated Security=True;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open  !");
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Form load Error occure "+ex);
            }
        }

       

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbloginid.Text = "";
            tbloginpassword.Text = "";
        }
    }
}
