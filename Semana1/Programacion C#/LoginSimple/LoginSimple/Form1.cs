using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSimple
{
    public partial class Form1 : Form
    {
        int contador = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtLogear_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text;
            string contraseña = TbContraseña.Text;

            if(contador == 1)
            {
                MessageBox.Show(
                    "Limite de intentos superado",
                    "Limite Superado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
            }

            if(usuario != "admin" || contraseña != "admin123")
            {
                contador--;

                MessageBox.Show(
                    "Usuario o contraseña incorrectos te quedan " + contador + " intentos.",
                    "Error de inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show(
                    "Inicio de sesión exitoso bienvenido " + usuario,
                    "Inicio de Sesión exitoso",
                    MessageBoxButtons.OK
                );

                Close();
            }
        }
    }
}
