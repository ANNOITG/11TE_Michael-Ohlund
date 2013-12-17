using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        List<Person> personer = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("Object.txt");

            tw.WriteLine("André;Lillkyrka;87654;9876543456789;\n"
                        + "Adam;Lillkyrka;4567890;4567890");

            tw.Close();

            TextReader tr = new StreamReader("Object.txt");
            // read a line of text
            string rad = "";
            while (rad != null)
            {
                rad = tr.ReadLine();
                var strings = rad.Split(';');
                Person p = new Person();
                p.name = strings[0];
                p.adress = strings[1];
                p.pnr = strings[2];
                p.telenr = strings[3];

                personer.Add(p);
                
            }
            // close the stream
            tr.Close();
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Person p in personer)
            {
                richTextBox1.Text += p.name + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.name = textBox1.Text;
            p.adress = textBox2.Text;
            p.pnr = textBox3.Text;
            p.telenr = textBox4.Text;

            personer.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

    }
}
