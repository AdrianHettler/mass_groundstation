using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace mass_groundstation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e) 
        {
            // always display latest active output ->       
            OutputTextBox.SelectionStart = OutputTextBox.Text.Length;   // set the current caret position to the end       
            OutputTextBox.ScrollToCaret();   // scroll it automatically     
        }

        public void OutputTextBox_add_output_message(string text)
        {         
            OutputTextBox.AppendText(text);  // add text to OutputTextBox
            OutputTextBox.AppendText(Environment.NewLine); // new line
        }
    }
}



