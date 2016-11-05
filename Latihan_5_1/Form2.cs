using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.bgcolor.Items.Add(c.Name);
            }
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tree.ExpandAll();

            if (tree.SelectedNode.Text == "Background Color")
            {
                label1.Visible = true;
                bgcolor.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                bgcolor.Visible = false;                
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = (Form1)MdiParent;
            main.ubahBackground(bgcolor.Text);
        }

        private void bgcolor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bgcolor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Bottom);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
