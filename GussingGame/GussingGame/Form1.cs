using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GussingGame
{
    public partial class Form1 : Form
    {

        private string w1_Guess;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void w_Guess_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_Guess_Click(object sender, EventArgs e)
        {
            string e_Word = w_Guess.Text;
            string Gtheword = "Programming";
            string G1theword = "P _ _ _ _ _ _ _ _ _ g";

            quesser.Text = G1theword;

            string checker1 = "Correct guess!";
            string checker2 = "Wrong guess!\nTry again.";

            if (string.IsNullOrEmpty(e_Word))
            {
            }
            else if (e_Word.Equals(Gtheword, StringComparison.OrdinalIgnoreCase))
            {
                quesser.Text = Gtheword;
                MessageBox.Show(checker1);

            }
            else
            {
                MessageBox.Show(checker2);
                w_listbox.Items.Add(e_Word);
            }
        }

        private void w_listboxasd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void q_Guess_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }    
}
 

