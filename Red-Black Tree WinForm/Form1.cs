using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedBlackTreeCollection;

namespace Red_Black_Tree_WinForm
{
    public partial class Form1 : Form
    {
        public RedBlackTree<int,int> RBT = new RedBlackTree<int, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RBT.Add(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox1.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label4.Text = $"The {Convert.ToInt32(textBox2.Text)} key is: {RBT.Get(Convert.ToInt32(textBox2.Text))}";
            label6.Text = $"Iterations: {RBT.iter}";
            RBT.iter = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10001; i++)
            {
                RBT.Add(i, random.Next(0,2500));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RBT.Add(Convert.ToInt32(textBox3.Text), 0);
        }
    }
}
