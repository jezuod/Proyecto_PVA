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
    public partial class Form_opciones_admin : Form
    {
        private string usuario;
        public int cerrar;
        Form_nuevo f_nuevo;
        Conexion c;
        public Form_opciones_admin(String dato)
        {
            InitializeComponent();
            usuario = dato;
        }
        

        private void Form_opciones_admin_Load(object sender, EventArgs e)
        {

        }

        private void Form_opciones_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            cerrar = 1;
            Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
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
            
            catch
            {
                MessageBox.Show("Excepcion");
            }
        }

        private void btn_ejemplos_Click(object sender, EventArgs e)
        {
            ejemplos ejem = new ejemplos(usuario);
            ejem.Show();
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            try
            {
                //Creamos la instancia y la ponemos visible:
                Excel.Application objExcel = new Excel.Application();
                objExcel.Visible = true; //Podríamos trabajar sin que se vea…

                //Creamos el libro y accedemos a la primera hoja:
                Excel.Workbook objLibro = objExcel.Workbooks.Add(Missing.Value);
                Excel.Worksheet objHoja =
               (Excel.Worksheet)objLibro.Worksheets.get_Item(1); //hoja 1.

                //CAMBIAR COLOR CELDAS
                Excel.Range formatRange;
                formatRange = objExcel.get_Range("a1", "I1");
                formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGoldenrodYellow);
                formatRange.Font.Size = 10;
                formatRange.BorderAround(Excel.XlLineStyle.xlContinuous,
                Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                Excel.XlColorIndex.xlColorIndexAutomatic);


                objHoja.Cells[1, 1] = "FECHA"; //Celda A1
                objHoja.Cells[1, 2] = "USUARIO"; //Celda b1
                objHoja.Cells[1, 3] = "ID_BICICLETA";
                objHoja.Cells[1, 4] = "ID_CUADRO";
                objHoja.Cells[1, 5] = "ID_GRUPO";
                objHoja.Cells[1, 6] = "ID_RUEDA";
                objHoja.Cells[1, 7] = "ID_SILLIN";
                objHoja.Cells[1, 8] = "ID_PEDAL";
                objHoja.Cells[1, 9] = "PRECIO";


                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT * FROM Historial;";


                SqlDataReader midatareader = comandosql.ExecuteReader();

                int conta = 2;


                while (midatareader.Read())
                {
                    objHoja.Cells[conta, 1] = midatareader.GetDateTime(1);
                    objHoja.Cells[conta, 2] = midatareader.GetString(3);
                    objHoja.Cells[conta, 3] = midatareader.GetInt32(4);
                    objHoja.Cells[conta, 4] = midatareader.GetInt32(5);
                    objHoja.Cells[conta, 5] = midatareader.GetInt32(6);
                    objHoja.Cells[conta, 6] = midatareader.GetInt32(7);
                    objHoja.Cells[conta, 7] = midatareader.GetInt32(8);
                    objHoja.Cells[conta, 8] = midatareader.GetInt32(9);
                    objHoja.Cells[conta, 9] = midatareader.GetDouble(2);

                    ++conta;
                }
            }
            catch { MessageBox.Show("Excepcion"); }
        }


    }
}
