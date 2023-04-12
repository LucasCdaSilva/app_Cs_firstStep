using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_Cs_firstStep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClickHere_Click(object sender, EventArgs e)
        {
            if (buttonClickHere.Text != "Done!")
            {
                buttonClickHere.Text = "Done!";
                labelResultClickHEre.Text = "Hello World!";
            }
            else
            {
                buttonClickHere.Text = "Undone!";
                labelResultClickHEre.Text = "None";
            }


        }

        private void labelResultClickHEre_Click(object sender, EventArgs e)
        {
            labelResultClickHEre.ForeColor = System.Drawing.SystemColors.ControlText;
         
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelResultClickHEre.Text = textBox1.Text;
        }

        
    }
}
