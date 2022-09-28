using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_pva
{
    public partial class Form_opciones : Form
    {
        private string usuario;
        public int cerrar;
        Form_nuevo f_nuevo;
        public Form_opciones(String dato)
        {
            InitializeComponent();
            usuario = dato;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form_opciones_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            cerrar = 1;
            Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            f_nuevo = new Form_nuevo(usuario);
            this.Hide();
            f_nuevo.ShowDialog(); // mostramos formulario para user
            if (f_nuevo.cerrar == 1)
            {
                Close();// cerramos el formulario
            }
            else
            {
                Show(); //volvemos al form principal con el login
            }
        }
    }
}
