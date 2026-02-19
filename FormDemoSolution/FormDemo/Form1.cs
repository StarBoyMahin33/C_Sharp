using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("close", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                this.Close();

                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length !=0 && textBox2.Text.Length !=0)
            {
                string un= textBox1 .Text;
                string ps= textBox2 .Text;
                if(un.Equals("mahin")&&ps.Equals("123"))
                {
                    Form2 fr = new Form2();
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("INVALID Id & Pass", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Enter Id & Pass","confirm",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
