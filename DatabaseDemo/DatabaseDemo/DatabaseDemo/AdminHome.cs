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
    public partial class AdminHome : Form
    {
        string admintxt;
        public AdminHome(string text)
        {
            InitializeComponent();
            admintxt = text;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lbladmintext.Text = admintxt;
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            //this.Close();
        }
    }
}
