using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "/" + "details.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bname = comboBox1.GetItemText(comboBox1.SelectedIndex);
            label1.Text = bname;//return 0,1,2,3,4

            var lines = File.ReadAllLines(Application.StartupPath + "/" + "details.txt");
            foreach (var line in lines)
            {
                var col = line.Split(',');

                if (col[4] == label1.Text)
                {
                    MessageBox.Show(col[0] + " " + col[1] + " " + col[2] + " " + col[3] + " " + col[4]);
                }

            }
        }
    }
}
