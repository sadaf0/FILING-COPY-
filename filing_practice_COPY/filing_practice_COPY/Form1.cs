using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filing_practice_COPY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox4.ReadOnly = true;
            this.label1.Text = "Source Address ";
            this.label2.Text = "Source Name ";
            this.label3.Text = "Destination Address ";
            this.label4.Text = "Destination Name ";
            this.button1.Text = "COPY";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox4.Text = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text + this.textBox2.Text;
            string d = this.textBox3.Text + this.textBox2.Text;
            if (File.Exists(d))
            {

                DialogResult dr = MessageBox.Show("Do You Want to Replace");
                if (dr == DialogResult.OK)
                {

                    
                    File.Copy(s,d);
                
                }
                else if (dr == DialogResult.No)
                {

                DialogResult r=    MessageBox.Show("Would You Like to Change the file Name Which is Already Exists");
                if (r == DialogResult.OK)
                {

                    File.Delete(d);
                    File.Copy(s,d);
                    MessageBox.Show("File Copied Successfully");

                }
                else
                {
                    
                    MessageBox.Show("File Not Copied");
                }
                }
                else 
                {
                    File.Copy(s,d);
                
                }

            
            
            }
        }
    }
}
