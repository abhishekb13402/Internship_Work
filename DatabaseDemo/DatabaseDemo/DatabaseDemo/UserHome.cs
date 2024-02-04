using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo
{
    public partial class UserHome : Form
    {
        string usertxt;
        public UserHome(string text)
        {
            InitializeComponent();
            usertxt = text;
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            lblusertext.Text = usertxt;
        }

        private void UserHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            //this.Close();
        }
    }
}
