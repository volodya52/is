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
        Form f1;
        int click=0;
        StreamReader sr;
        StreamReader sr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sr = File.OpenText("contacts");
            sr2 = File.OpenText("zadachi");
            if (File.Exists("zadachi") || File.Exists("contacts"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                while (!sr2.EndOfStream)
                {
                    listBox2.Items.Add(sr2.ReadLine());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
           
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
           this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            click++;
            listBox1.Visible = true;
            button9.Visible = true;
            if (click == 2)
            { 
                click = 0;
                listBox1.Visible=false;
                button9.Visible=false;
                groupBox1.Visible=false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button12.Visible = true;
            listBox2.Visible = true;
           
            click++;
            if (click == 2)
            {
                
                listBox2.Visible=false;
                button12.Visible=false;
                Задача.Visible=false;
                click = 0;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listBox3.Visible = true;
            click++;
            if (click == 2)
            {
                listBox3.Visible = false;
                click = 0;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label1.Visible = true;
            Panel p=new Panel();
            p.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            click++;
            if (click == 2)
            {
                listBox2.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                click = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            label1.Visible = true;
            Panel p = new Panel();
            p.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("contacts");
            sw.WriteLine($"{textBox1.Text}");
            sw.WriteLine($"{textBox2.Text}");
            sw.WriteLine($"{textBox3.Text}");
            sw.WriteLine($"{textBox4.Text}");
            sw.WriteLine($"{textBox5.Text}");
            sw.Close();
            MessageBox.Show("Контакт добавлен");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Задача.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("zadachi");
            sw.WriteLine($"{comboBox1.Text}");
            sw.WriteLine($"{dateTimePicker1.Value}");
            sw.WriteLine($"{textBox6.Text}");
            sw.Close ();
            MessageBox.Show("Задача добавлена");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
