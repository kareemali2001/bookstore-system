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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int Index = 0;
        List<books> bk = new List<books>();
        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader("Text.txt");
            while (!SR.EndOfStream)
            {
                string line = SR.ReadLine();
                string[] split = line.Split(',');
                books pnn = new books();
                pnn.name = split[0];
                pnn.category = split[1];
                pnn.picpath = split[2];
                bk.Add(pnn);
            }
            SR.Close();
        }
        class books
        {
            public string name;
           public string category;
            public string picpath;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                label1.Text = bk[Index].name;
                label2.Text = bk[Index].category;
                pictureBox1.Image = Image.FromFile(bk[Index].picpath);
                if (Index > 0)
                {
                    Index--;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = bk[Index].name;
            label2.Text = bk[Index].category;
            pictureBox1.Image = Image.FromFile(bk[Index].picpath);
            if (Index < bk.Count() - 1)
            {
                Index++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
