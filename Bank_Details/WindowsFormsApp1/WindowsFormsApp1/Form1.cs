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
    public partial class Form1 : Form
    {
        String path = Environment.CurrentDirectory + "/" + "details.txt";
        static public int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //StreamWriter sw = new StreamWriter(Application.StartupPath + "\\form\\" + "details.txt");

            //sw.WriteLine(tbid.Text + "\t" + tbname.Text + "\t" + tbcontactno.Text);
            //sw.Close();


            if (!File.Exists(path))
            {
                File.Create("details.txt").Close();
                using (StreamWriter sw = File.AppendText("details.txt"))
                {
                    sw.WriteLine("ID,NAME,CONTACT_NUMBER,BANK_NAME,BANK_INDEX");

                    sw.Close();
                }
            }
            else
            {

                using (StreamWriter sw = File.AppendText("details.txt"))
                {
                    sw.WriteLine(id + "," + tbname.Text + "," + tbcontactno.Text +
                        "," + comboBox_Bankname.SelectedItem.ToString() + "," +
                        comboBox_Bankname.SelectedIndex);

                    sw.Close();
                    MessageBox.Show("Data add sucessfully");
                    id++;
                }
            }


        }

        private void btnfileopen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox_Bankname.SelectedIndex = 0;
            tbid.Clear();
            tbname.Clear();
            tbcontactno.Clear();
        }
    }
}
