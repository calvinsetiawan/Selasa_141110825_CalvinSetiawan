using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bold_Click(object sender, EventArgs e)
        {
            Font fontlama, fontbaru;

            fontlama = richtxt.SelectionFont;
            if (fontlama.Bold)
            {
                fontbaru = new Font(fontlama, fontlama.Style & ~FontStyle.Bold);
                bold.Checked = false;
            }
            else
            {
                fontbaru = new Font(fontlama, fontlama.Style | FontStyle.Bold);
                bold.Checked = true;
            }
            richtxt.SelectionFont = fontbaru;
        }

        private void italic_Click(object sender, EventArgs e)
        {
            Font fontlama, fontbaru;
            fontlama = richtxt.SelectionFont;
            if (fontlama.Italic)
            {
                fontbaru = new Font(fontlama, fontlama.Style & ~FontStyle.Italic);
                bold.Checked = false;
            }
            else
            {
                fontbaru = new Font(fontlama, fontlama.Style | FontStyle.Italic);
                bold.Checked = true;
            }
            richtxt.SelectionFont = fontbaru;
        }

        private void underline_Click(object sender, EventArgs e)
        {
            Font fontlama, fontbaru;
            fontlama = richtxt.SelectionFont;
            if (fontlama.Underline)
            {
                fontbaru = new Font(fontlama, fontlama.Style & ~FontStyle.Underline);
                bold.Checked = false;
            }
            else
            {
                fontbaru = new Font(fontlama, fontlama.Style | FontStyle.Underline);
                bold.Checked = true;
            }
            richtxt.SelectionFont = fontbaru;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily tulisan in FontFamily.Families)
            {
                fontfamily.Items.Add(tulisan.Name.ToString());
            }
            fontsize.SelectedIndex = 2;
            fontfamily.Text = "Times New Roman";
        }

        private void fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richtxt.Font = new Font(fontfamily.Font.FontFamily, float.Parse(fontsize.SelectedItem.ToString()));
        }

        private void fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            richtxt.Font = new Font(fontfamily.SelectedItem.ToString(), richtxt.Font.Size);
        }

        private void color_Click(object sender, EventArgs e)
        {
            var warna = new ColorDialog();
            warna.ShowDialog();
            richtxt.ForeColor = warna.Color;
        }
    }
}
