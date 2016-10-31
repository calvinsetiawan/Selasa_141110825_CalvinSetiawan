using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tanggal = Convert.ToInt32(numericUpDown1.Value);
            DateTime tambah = new DateTime(2016, (int)domainUpDown1.SelectedIndex + 1, tanggal);
            monthCalendar1.AddBoldedDate(tambah);
            MessageBox.Show("Tanggal Libur Telah Ditambahkan");
            monthCalendar1.UpdateBoldedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime awal = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2016, 12, 31);
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1996, 9, 2));
            for (int i = 0; i < akhir.DayOfYear; i++)
            {
                if (awal.DayOfWeek.ToString() == "Saturday" || awal.DayOfWeek.ToString() == "Sunday")
                {
                    monthCalendar1.AddBoldedDate(awal);
                }
                awal = awal.AddDays(1);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime hapus = new DateTime(2016, (int)domainUpDown1.SelectedIndex + 1, Convert.ToInt32(numericUpDown1.Value));
            if (hapus.DayOfWeek.ToString() != "Saturday" || hapus.DayOfWeek.ToString() != "Sunday" || hapus.Day != 2 || hapus.Month != 9)
            {
                monthCalendar1.RemoveBoldedDate(hapus);
                MessageBox.Show("Tanggal Libur Telah Dihapus");

            }
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
