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

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void fontsize_Click(object sender, EventArgs e)
        {

        }

        private void richtxt_TextChanged(object sender, EventArgs e)
        {

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

        private void color_Click(object sender, EventArgs e)
        {
            var warna = new ColorDialog();
            warna.ShowDialog();
            richtxt.ForeColor = warna.Color;
        }

        private void fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richtxt.Font = new Font(fontfamily.Font.FontFamily, float.Parse(fontsize.SelectedItem.ToString()));
        }

        private void fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            richtxt.Font = new Font(fontfamily.SelectedItem.ToString(), richtxt.Font.Size);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.Filter = "Rich Text Box(* .rtf)|*.rtf";
            open.FileName = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string text = open.FileName;
                richtxt.Text = File.ReadAllText(text);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save.Filter = "Rich Text Box(* .rtf)|*.rtf";
            save.FileName = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, richtxt.Text);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richtxt.Modified)
            {
                if (MessageBox.Show("File Belum Disimpan", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    save.Filter = "Rich Text Box(* .rtf)|*.rtf";
                    save.FileName = "";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(save.FileName, richtxt.Text);
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richtxt.Modified)
            {
                if (MessageBox.Show("File Belum Disimpan", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    save.Filter = "Rich Text Box(* .rtf)|*.rtf";
                    save.FileName = "";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(save.FileName, richtxt.Text);
                    }
                }
                else
                {
                    richtxt.Clear();
                }
            }
        }
        public void ubahBackground(string color)
        {
            richtxt.BackColor = Color.FromName(color);
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            
            childForm.MdiParent = this;
            
            childForm.Show();
            this.TopMost = true;
            childForm.Location = new Point(358, 11);

            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void richtxt_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this, e.X, e.Y);
                if (richtxt.SelectionLength == 0)
                {
                  contextMenuStrip1.Items[0].Enabled = false;
                  contextMenuStrip1.Items[2].Enabled = false;
                  contextMenuStrip1.Items[4].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[2].Enabled = true;
                    contextMenuStrip1.Items[4].Enabled = true;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxt.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxt.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxt.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxt.SelectedText = "";
        }
    }
}
