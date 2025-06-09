using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinalis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = ((TextBox)sender).Text;
            string contrasena = ((TextBox)sender).Text;

            string tipousuario = Validarusuario(usuario, contrasena);

            if (tipousuario == "Admin")
            {
                Form1 form1 = new Form1();
                form1.Show();

                this.Close();
            }
            else if (tipousuario == "Cliente")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Informacion incorrecta");
            }
        }
            private string Validarusuario(string usuario, string contrasena)
            {
                string tipousuario = string.Empty;


            }
        }
    }
}
