using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double saydamlık; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button3.Enabled = false;
        }
        
        
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //saydamlık=100;
            this.Opacity = saydamlık / 100;
            button3.Enabled = true;
            textBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
                saydamlık = Convert.ToDouble(textBox1.Text);
            else
                saydamlık=100;
            this.Opacity=saydamlık / 100;
            button3.Enabled=true;
            textBox1.Visible=false;
            button4.Visible=false;
            button5.Visible=false;

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.DarkBlue;
            button1.Text = "Dark M.";
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.LightGray;
            button2.Text = "white m ";
            button3.Text = "saydam";
            textBox1.Visible = false;
            button4.Visible = false;
        }
    }
}
