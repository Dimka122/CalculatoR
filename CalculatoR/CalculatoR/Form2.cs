using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatoR
{
    public partial class Form2 : Form
    {
        public decimal Km = 0;
        public decimal Litr = 0;
        public decimal Cena = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Km = numericUpDown1.Value;
            decimal Litr = numericUpDown2.Value;
            decimal Cena = numericUpDown3.Value;

            textBox1.Text = Convert.ToString(Km * Litr / 100);
            textBox2.Text = Convert.ToString((Km * Litr / 100) * Cena);
        }
    }
}
