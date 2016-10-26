using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2
{
    public partial class Form1 : Form
    {
        int min = 0, max = 0;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void vScrollBar(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_scroll(object sender, ScrollEventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = vScrollBar1.Value.ToString();
            if (vScrollBar2.Value > vScrollBar1.Value)
            {
                vScrollBar1.Value = vScrollBar2.Value;
                
            }
            dateTimePicker1.MaxDate = now.AddYears(vScrollBar1.Value - vScrollBar1.Maximum).Date;
            dateTimePicker1.MinDate = now.AddYears(vScrollBar2.Value - vScrollBar2.Maximum).Date;
        }

        private void vScrollBar2_scroll(object sender, ScrollEventArgs e)
        {
            DateTime now = DateTime.Now;
            label2.Text = vScrollBar2.Value.ToString();
            if (vScrollBar2.Value > vScrollBar1.Value)
            {
                vScrollBar1.Value = vScrollBar2.Value;
            }
            dateTimePicker1.MaxDate = now.AddYears(vScrollBar1.Value - vScrollBar1.Maximum).Date;
            dateTimePicker1.MinDate = now.AddYears(vScrollBar2.Value - vScrollBar2.Maximum).Date;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
