using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Forms;


namespace Proyecto_pva
{
    public partial class Form_registro : Form
    {
        Conexion c;
        String dato;
        Boolean user_existente=false;
        public Form_registro()
        {
            InitializeComponent();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            user_existente = false;
            if (txb_usuario.Text != null)
            {
                if (txb_pass_1.Text == txb_pass_2.Text)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT id_user FROM Usuario ;";


                    SqlDataReader midatareader = comandosql.ExecuteReader();

                    // cb_modelo_ruedas.Items.Clear();
                    dato = txb_usuario.Text;

                    while (midatareader.Read())
                    {
                        if (midatareader.GetString(0) == dato)
                        {
                            user_existente = true;

                        }


                    }
                    midatareader.Close();
                    if (user_existente)
                    {
                        MessageBox.Show("Elija otro nombre de usuario");
                    }
                    else
                    {
                        comandosql.CommandText = "INSERT INTO Usuario VALUES('" + txb_usuario.Text + "','" + txb_pass_1.Text + "',0);";
                        midatareader = comandosql.ExecuteReader();
                        MessageBox.Show("Creación correcta");
                    }
                }
                else
                    MessageBox.Show("Introduzca la contraseña igual");
            }
            else
                MessageBox.Show("Introduzca el usuario");
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Excepcion");
            }
        }
    }
}
