using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPerformance
{
    public partial class frmGuessWord : Form
    {
        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static StringBuilder word = new StringBuilder("computer");
        public void Form1_Load(object sender, EventArgs e)
        {

            StringBuilder wordtwo = new StringBuilder("");
            for (int index = 0; index <= 7; index++)
            {
                if (index >= 1 && index < 7)
                {
                    wordtwo.Append('?');                
                }
                else if (index == 7)
                {
                    wordtwo.Append(word[index]);
                }
                else 
                {
                    wordtwo.Append(word[index]);
                }
            }
            string strWord = wordtwo.ToString();
            label1.Text = strWord;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string hidword = word.ToString();
            if (textBox1.Text.Equals(hidword))
            {
                string msg1 = "Correct guess!";
                label1.Text = hidword;
                MessageBox.Show(msg1);
            }
            else
            { 
                string msg2 = "Wrong guess\n" + "Try again.";
                listBox1.Items.Add(textBox1.Text);
                MessageBox.Show(msg2);
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
