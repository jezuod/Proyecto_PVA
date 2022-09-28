using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//necesario using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_pva
{
    public partial class Form_login : Form
    {
        Conexion c;
        Form_opciones_admin f_admin;
        Form_opciones f_user;
        public Form_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
                
                c = new Conexion();
               
               // SqlDataReader login = c.leerbasedatos("*", "Usuario" );
                SqlDataReader login = c.leerbasedatos("*", "Usuario", " WHERE id_user='" + txb_user.Text + "' AND contrasena='" + txb_password.Text+"'");
            if (login.Read())//si la consulta tiene datos
                {
                    MessageBox.Show("Login correcto");
                    login = c.leerbasedatos("*", "Usuario", " WHERE id_user='" + txb_user.Text + "' AND es_admin=1");
                    if( login.Read())//si la consulta tiene datos
                    {
                    f_admin = new Form_opciones_admin(txb_user.Text);
                    this.Hide(); // ocultamos
                    f_admin.ShowDialog(); // mostramos formulario para admins
                    if(f_admin.cerrar==1)
                    {
                        Close();// cerramos el formulario
                    }
                    else
                    {
                        Show(); //volvemos al form principal con el login
                    }
                    
                }
                else
                    {
                    f_user=new Form_opciones(txb_user.Text);
                    this.Hide();
                    f_user.ShowDialog(); // mostramos formulario para user
                    if (f_user.cerrar == 1)
                    {
                        Close();// cerramos el formulario
                    }
                    else
                    {
                        Show(); //volvemos al form principal con el login
                    }

                }
                }
                else
                    MessageBox.Show("Login incorrecto");
                c.cerrarConexion();
           
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Form_registro f_reg = new Form_registro();
            f_reg.Show();
        }

        private void link_lbl_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación creada para la asignatura de PVA. Prentende poder permitir crear plantillas de bicicletas");
        }
    }
}
