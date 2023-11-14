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

namespace finallab
{
    public partial class Form2 : Form
    {
        public string picpath = "";
        public Form2()
        {
            InitializeComponent();
            this.button1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox8.Text != "")
            {
                StreamWriter SW = new StreamWriter("Text2.txt", true);
                string Name = textBox1.Text;
                string username = textBox2.Text;
                string email = textBox3.Text;
                string phone = textBox4.Text;
                string password = textBox5.Text;
                string confirmpass=textBox6.Text;
                SW.WriteLine(Name + "," + username + "," + email + "," +phone+ "," + password +","+ confirmpass +",");
                SW.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
                MessageBox.Show("Done");
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                picpath = OFD.FileName;
                pictureBox1.Image = Image.FromFile(picpath);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            comboBox1.Items.Add("egypt");
            comboBox1.Items.Add("congo");
            comboBox1.Items.Add("morocco");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                this.button1.Visible = true;
            else
                this.button1.Visible = false;
        }
    }
    }

