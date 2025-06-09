using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinalis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;
            string tipoVehiculo = comboBox1.Text.ToString();
            string tipoCobro = comboBox2.Text.ToString();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string codigo = "TKT" + rnd.Next(minValue: 100000, maxValue: 999999);
            textBox2.Text = codigo;
        }
    }
}
