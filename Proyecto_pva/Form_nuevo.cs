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
    public partial class Form_nuevo : Form
    {
        private string Usuario;
        public int cerrar;
        private int id_cuadro, id_grupo, id_ruedas, id_pedales, id_sillin;
        string dato1=null;
        int conta_histo;
        private int id_bicicleta;
        double precio;
        Conexion c;
        DateTime fecha;
        String fech;
        public Form_nuevo(String dato)
        {
            InitializeComponent();
            Usuario = dato;

            
            
            
        }
        
        public Form_nuevo(String dato, int form_id_bicicleta, int form_id_cuadro, int form_id_grupo, int form_id_rueda, int form_id_sillin, int form_id_pedal, double f_precio)
        {
            InitializeComponent();
            Usuario = dato;
            id_bicicleta = form_id_bicicleta;
            id_cuadro = form_id_cuadro;
            id_grupo = form_id_grupo;
            id_ruedas = form_id_rueda;
            id_sillin = form_id_sillin;
            id_pedales = form_id_pedal;
            precio = f_precio;

            plantilla_Click(null, null);
            /* SIN IMPLEMENTAR --> posible actualizacion con mas tiempo
           c = new Conexion();
            SqlCommand comandosql = new SqlCommand();
            comandosql.Connection = c.conectarse;
            comandosql.CommandText = "SELECT Marca From Cuadro WHERE id_cuadro=(SELECT id_cuadro FROM Bicicleta WHERE id_bicicleta="+form_id_bicicleta+");";


            SqlDataReader midatareader = comandosql.ExecuteReader();


            cb_marca_cuadro.Items.Clear();
            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0);
                
               
            }
            cb_marca_cuadro.SelectedIndex = cb_marca_cuadro.Items.IndexOf(dato1);
           
           */


        }
        private void plantilla_Click(object sender, EventArgs e)
        {
            //insertarla en la base de datos de nuevo y ya
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form_nuevo_Load(object sender, EventArgs e)
        {

        }

        private void cb_marca_cuadro_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_modelo_cuadro.SelectedIndex != -1 )
                {
                    cb_modelo_cuadro.Text=null;
                    cb_modelo_cuadro.Items.Clear();
                    
                    txb_precio_cuadro.Text = null;
                }
                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT DISTINCT marca FROM Cuadro;";


                SqlDataReader midatareader = comandosql.ExecuteReader();


                cb_marca_cuadro.Items.Clear();
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                    cb_marca_cuadro.Items.Add(dato1);
                }
                dato1 = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_cuadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_modelo_cuadro.Items[0] != null)
            {
                if(cb_modelo_cuadro.SelectedItem!=null)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT DISTINCT precio FROM Cuadro WHERE modelo='" + cb_modelo_cuadro.SelectedItem.ToString() + "';";


                    SqlDataReader midatareader = comandosql.ExecuteReader();



                    while (midatareader.Read())
                    {
                        double precio = midatareader.GetDouble(0);
                        txb_precio_cuadro.Text = precio.ToString();


                    }
                    

                }
                
            }
            else
                MessageBox.Show("Error");

        }

        private void cb_modelo_cuadro_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(cb_marca_cuadro.SelectedIndex!=-1)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT DISTINCT modelo FROM Cuadro WHERE marca='" + cb_marca_cuadro.SelectedItem.ToString() + "';";


                    SqlDataReader midatareader = comandosql.ExecuteReader();

                    cb_modelo_cuadro.Items.Clear();


                    while (midatareader.Read())
                    {
                        dato1 = midatareader.GetString(0);
                        cb_modelo_cuadro.Items.Add(dato1);
                    }
                    dato1 = null;

                    
                }
                else
                    MessageBox.Show("Selecciona una marca para ver los modelos");

            }
            catch
            {
                MessageBox.Show("Error");
            }
            /*catch (NullReferenceException excep)
            {
                MessageBox.Show("Error no exite");
            }*/



        }

        private void btn_precio_cuadro_Click(object sender, EventArgs e)
        {
            

            try
            {
                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT DISTINCT precio FROM Cuadro WHERE modelo='" + cb_modelo_cuadro.SelectedItem.ToString() + "';";


                SqlDataReader midatareader = comandosql.ExecuteReader();
                while (midatareader.Read())
                {
                    double precio = midatareader.GetDouble(0);
                    txb_precio_cuadro.Text = precio.ToString();



                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_marca_grupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_grupo.SelectedIndex != -1)
                {
                    cb_modelo_grupo.Text = null;
                    cb_modelo_grupo.Items.Clear();

                    txb_precio_grupo.Text = null;
                }
                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT DISTINCT marca FROM Grupo;";


                SqlDataReader midatareader = comandosql.ExecuteReader();


                cb_marca_grupo.Items.Clear();
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                    cb_marca_grupo.Items.Add(dato1);
                }
                dato1 = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_grupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_grupo.SelectedIndex != -1)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT DISTINCT modelo FROM Grupo WHERE marca='" + cb_marca_grupo.SelectedItem.ToString() + "';";


                    SqlDataReader midatareader = comandosql.ExecuteReader();

                    cb_modelo_grupo.Items.Clear();


                    while (midatareader.Read())
                    {
                        dato1 = midatareader.GetString(0);
                        cb_modelo_grupo.Items.Add(dato1);
                    }
                    dato1 = null;


                }
                else
                    MessageBox.Show("Selecciona una marca para ver los modelos");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_modelo_grupo.Items[0] != null)
                {
                    if (cb_modelo_grupo.SelectedItem != null)
                    {
                        c = new Conexion();
                        SqlCommand comandosql = new SqlCommand();
                        comandosql.Connection = c.conectarse;
                        comandosql.CommandText = "SELECT DISTINCT precio FROM Grupo WHERE modelo='" + cb_modelo_grupo.SelectedItem.ToString() + "';";


                        SqlDataReader midatareader = comandosql.ExecuteReader();



                        while (midatareader.Read())
                        {
                            double precio = midatareader.GetDouble(0);
                            txb_precio_grupo.Text = precio.ToString();


                        }


                    }

                }
                else
                    MessageBox.Show("Error");

            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void cb_marca_ruedas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_marca_ruedas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_ruedas.SelectedIndex != -1)
                {
                    cb_modelo_ruedas.Text = null;
                    cb_modelo_ruedas.Items.Clear();

                    txb_precio_ruedas.Text = null;
                }
                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT DISTINCT marca FROM Rueda;";


                SqlDataReader midatareader = comandosql.ExecuteReader();


                cb_marca_ruedas.Items.Clear();
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                    cb_marca_ruedas.Items.Add(dato1);
                }
                dato1 = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_ruedas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_ruedas.SelectedIndex != -1)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT DISTINCT modelo FROM Rueda WHERE marca='" + cb_marca_ruedas.SelectedItem.ToString() + "';";


                    SqlDataReader midatareader = comandosql.ExecuteReader();

                    cb_modelo_ruedas.Items.Clear();


                    while (midatareader.Read())
                    {
                        dato1 = midatareader.GetString(0);
                        cb_modelo_ruedas.Items.Add(dato1);
                    }
                    dato1 = null;


                }
                else
                    MessageBox.Show("Selecciona una marca para ver los modelos");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }







        private void btn_factura_Click(object sender, EventArgs e)
        {
            
            
          
            try
            {
                if (cb_modelo_cuadro.SelectedIndex != -1 && cb_modelo_grupo.SelectedIndex != -1 && cb_modelo_sillin.SelectedIndex != -1 && cb_modelo_ruedas.SelectedIndex != -1 && cb_modelo_pedales.SelectedIndex != -1)
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
                    formatRange = objExcel.get_Range("a1", "f1");
                    formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGoldenrodYellow);
                    formatRange.Font.Size = 10;
                    formatRange.BorderAround(Excel.XlLineStyle.xlContinuous,
                    Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                    Excel.XlColorIndex.xlColorIndexAutomatic);

                    formatRange = objExcel.get_Range("e2", "i2");
                    formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);


                    


                    //(AÑADIR CELDAS)
                    objHoja.Cells[1, 1] = "Id_Bicleta"; //Celda A1
                    objHoja.Cells[1, 2] = "Usuario"; //Celda b1
                    objHoja.Cells[1, 3] = "Precio"; //Celda c1
                    objHoja.Cells[1, 5] = "Componentes"; //Celda e1
                    objHoja.Cells[2, 5] = "Cuadro";
                    objHoja.Cells[2, 6] = "Grupo";
                    objHoja.Cells[2, 7] = "Ruedas";
                    objHoja.Cells[2, 8] = "Sillin";
                    objHoja.Cells[2, 9] = "Pedales";







                    //añadir datos
                    objHoja.Cells[2, 1] = id_bicicleta;
                    objHoja.Cells[2, 2] = Usuario;
                    objHoja.Cells[2, 3] = Double.Parse(txb_precio_cuadro.Text) + Double.Parse(txb_precio_grupo.Text) + Double.Parse(txb_precio_pedales.Text) + Double.Parse(txb_precio_ruedas.Text) + Double.Parse(txb_precio_sillin.Text) + "€";

                    objHoja.Cells[3, 5] = cb_modelo_cuadro.SelectedItem.ToString();
                    objHoja.Cells[3, 6] = cb_modelo_grupo.SelectedItem.ToString();
                    objHoja.Cells[3, 7] = cb_modelo_ruedas.SelectedItem.ToString();
                    objHoja.Cells[3, 8] = cb_modelo_sillin.SelectedItem.ToString();
                    objHoja.Cells[3, 9] = cb_modelo_pedales.SelectedItem.ToString();



                }

                else
                    MessageBox.Show("Faltan componentes por seleccionar");
            }
            catch
            {
                MessageBox.Show("Excepcion");
            }


        }

        private void cb_modelo_ruedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_modelo_ruedas.Items[0] != null)
                {
                    if (cb_modelo_ruedas.SelectedItem != null)
                    {
                        c = new Conexion();
                        SqlCommand comandosql = new SqlCommand();
                        comandosql.Connection = c.conectarse;
                        comandosql.CommandText = "SELECT DISTINCT precio FROM Rueda WHERE modelo='" + cb_modelo_ruedas.SelectedItem.ToString() + "';";


                        SqlDataReader midatareader = comandosql.ExecuteReader();



                        while (midatareader.Read())
                        {
                            double precio = midatareader.GetDouble(0);
                            txb_precio_ruedas.Text = precio.ToString();


                        }


                    }

                }
                else
                    MessageBox.Show("Error");
            }catch
            {
                MessageBox.Show("Error");
            }
            

        }

        private void cb_marca_sillin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_marca_sillin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_sillin.SelectedIndex != -1)
                {
                    cb_modelo_sillin.Text = null;
                    cb_modelo_sillin.Items.Clear();

                    txb_precio_sillin.Text = null;
                }
                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT DISTINCT marca FROM Sillin;";


                SqlDataReader midatareader = comandosql.ExecuteReader();


                cb_marca_sillin.Items.Clear();
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                    cb_marca_sillin.Items.Add(dato1);
                }
                dato1 = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_sillin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_sillin.SelectedIndex != -1)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT DISTINCT modelo FROM Sillin WHERE marca='" + cb_marca_sillin.SelectedItem.ToString() + "';";


                    SqlDataReader midatareader = comandosql.ExecuteReader();

                    cb_modelo_sillin.Items.Clear();


                    while (midatareader.Read())
                    {
                        dato1 = midatareader.GetString(0);
                        cb_modelo_sillin.Items.Add(dato1);
                    }
                    dato1 = null;


                }
                else
                    MessageBox.Show("Selecciona una marca para ver los modelos");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_sillin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_modelo_sillin.Items[0] != null)
                {
                    if (cb_modelo_sillin.SelectedItem != null)
                    {
                        c = new Conexion();
                        SqlCommand comandosql = new SqlCommand();
                        comandosql.Connection = c.conectarse;
                        comandosql.CommandText = "SELECT DISTINCT precio FROM Sillin WHERE modelo='" + cb_modelo_sillin.SelectedItem.ToString() + "';";


                        SqlDataReader midatareader = comandosql.ExecuteReader();



                        while (midatareader.Read())
                        {
                            double precio = midatareader.GetDouble(0);
                            txb_precio_sillin.Text = precio.ToString();


                        }


                    }

                }
                else
                    MessageBox.Show("Error");
            }
            catch { MessageBox.Show("Error"); }
            
        }

        private void cb_marca_pedales_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_pedales.SelectedIndex != -1)
                {
                    cb_modelo_pedales.Text = null;
                    cb_modelo_pedales.Items.Clear();

                    txb_precio_pedales.Text = null;
                }
                c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT DISTINCT marca FROM Pedal;";


                SqlDataReader midatareader = comandosql.ExecuteReader();


                cb_marca_pedales.Items.Clear();
                while (midatareader.Read())
                {
                    dato1 = midatareader.GetString(0);
                    cb_marca_pedales.Items.Add(dato1);
                }
                dato1 = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_pedales_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_marca_pedales.SelectedIndex != -1)
                {
                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT DISTINCT modelo FROM Pedal WHERE marca='" + cb_marca_pedales.SelectedItem.ToString() + "';";


                    SqlDataReader midatareader = comandosql.ExecuteReader();

                    cb_modelo_pedales.Items.Clear();


                    while (midatareader.Read())
                    {
                        dato1 = midatareader.GetString(0);
                        cb_modelo_pedales.Items.Add(dato1);
                    }
                    dato1 = null;


                }
                else
                    MessageBox.Show("Selecciona una marca para ver los modelos");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cb_modelo_pedales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_modelo_pedales.Items[0] != null)
                {
                    if (cb_modelo_pedales.SelectedItem != null)
                    {
                        c = new Conexion();
                        SqlCommand comandosql = new SqlCommand();
                        comandosql.Connection = c.conectarse;
                        comandosql.CommandText = "SELECT DISTINCT precio FROM Pedal WHERE modelo='" + cb_modelo_pedales.SelectedItem.ToString() + "';";


                        SqlDataReader midatareader = comandosql.ExecuteReader();



                        while (midatareader.Read())
                        {
                            double precio = midatareader.GetDouble(0);
                            txb_precio_pedales.Text = precio.ToString();


                        }



                    }

                }
                else
                    MessageBox.Show("Error");
            }
            catch { MessageBox.Show("Error"); }
            
        }

        private void btn_precio_total_Click(object sender, EventArgs e)
        {

            


        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
             int i = 0; double precio;
            
            try
            {
                if (cb_modelo_cuadro.SelectedIndex != -1 && cb_modelo_grupo.SelectedIndex != -1 && cb_modelo_ruedas.SelectedIndex != -1 && cb_modelo_sillin.SelectedIndex != -1 && cb_modelo_pedales.SelectedIndex != -1)
                {

                    c = new Conexion();
                    SqlCommand comandosql = new SqlCommand();
                    comandosql.Connection = c.conectarse;
                    comandosql.CommandText = "SELECT COUNT(*) FROM Bicicleta;";


                    SqlDataReader midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        i = midatareader.GetInt32(0);

                    }
                    i++;
                    midatareader.Close();

                    // SACAMOS IDs..
                    comandosql.CommandText = "SELECT id_cuadro FROM Cuadro WHERE modelo='" + cb_modelo_cuadro.SelectedItem.ToString() + "';";
                    midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id_cuadro = midatareader.GetInt32(0);
                    }
                    midatareader.Close();

                    comandosql.CommandText = "SELECT id_grupo FROM Grupo WHERE modelo='" + cb_modelo_grupo.SelectedItem.ToString() + "';";
                    midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id_grupo = midatareader.GetInt32(0);
                    }
                    midatareader.Close();

                    comandosql.CommandText = "SELECT id_rueda FROM Rueda WHERE modelo='" + cb_modelo_ruedas.SelectedItem.ToString() + "';";
                    midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id_ruedas = midatareader.GetInt32(0);
                    }
                    midatareader.Close();

                    comandosql.CommandText = "SELECT id_pedal FROM Pedal WHERE modelo='" + cb_modelo_pedales.SelectedItem.ToString() + "';";
                    midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id_pedales = midatareader.GetInt32(0);
                    }
                    midatareader.Close();

                    comandosql.CommandText = "SELECT id_sillin FROM Sillin WHERE modelo='" + cb_modelo_sillin.SelectedItem.ToString() + "';";
                    midatareader = comandosql.ExecuteReader();
                    while (midatareader.Read())
                    {
                        id_sillin = midatareader.GetInt32(0);
                    }
                    midatareader.Close();


                    precio = Double.Parse(txb_precio_cuadro.Text) + Double.Parse(txb_precio_grupo.Text) + Double.Parse(txb_precio_pedales.Text) + Double.Parse(txb_precio_ruedas.Text) + Double.Parse(txb_precio_sillin.Text);
                   
                    comandosql.CommandText = "INSERT INTO Bicicleta VALUES (" + i + "," + precio + ",0,'" + Usuario + "'," + id_cuadro + "," + id_grupo + "," + id_ruedas + "," + id_sillin + "," + id_pedales + ") ;";
                    midatareader = comandosql.ExecuteReader();
                    midatareader.Close();

                    id_bicicleta = i;

                    comandosql.CommandText = "	select convert(varchar, getdate(), 10)";
                    midatareader = comandosql.ExecuteReader();

                    while (midatareader.Read())
                    {
                        fech = midatareader.GetString(0);
                    }
                    midatareader.Close();

                    comandosql.CommandText = "SELECT COUNT(*) FROM Historial";
                    midatareader = comandosql.ExecuteReader();

                    while (midatareader.Read())
                    {
                        conta_histo = midatareader.GetInt32(0);
                    }
                    midatareader.Close();

                    comandosql.CommandText = "INSERT INTO Historial VALUES (" + conta_histo + ",'" + fech + "'," + precio + ",'" + Usuario + "'," + i + "," + id_cuadro + "," + id_grupo + "," + id_ruedas + "," + id_sillin + "," + id_pedales + ") ;";
                    midatareader = comandosql.ExecuteReader();
                    midatareader.Close();


                }
                else
                    MessageBox.Show("Faltan componentes sin seleccionar");
                //envento factura

                btn_factura_Click(null, null);






            }
            catch { MessageBox.Show("Excepcion"); }

            

                




        }
    }
}
