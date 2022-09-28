using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_pva
{
    public partial class ejemplos : Form
    {
        int id_bicicleta,id_cuadro, id_grupo, id_ruedas, id_sillin, id_pedales;
        String id_user;
        double precio;
        int dato;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public ejemplos(String dato)
        {
            InitializeComponent();
            id_user = dato;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ejemplos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myBikeDataSet1.Bicicleta' table. You can move, or remove it, as needed.
            this.bicicletaTableAdapter.Fill(this.myBikeDataSet1.Bicicleta);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bicicletaTableAdapter.FillBy(this.myBikeDataSet1.Bicicleta);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // OTRA OPCION ES QUE SE HAGA LA INSERCCION AQUI Y YA ESTA, CON EL EXCEL TAMBIEN 
                //id_user= bicicletaDataGridView.SelectedCells[3].Value.ToString(); 
                /*
                    bicicletaDataGridView.SelectedRows[0]
                    precio = Double.Parse(bicicletaDataGridView.SelectedCells[1].Value.ToString());
                    id_bicicleta = Int32.Parse(bicicletaDataGridView.SelectedCells[0].Value.ToString());
                    id_cuadro= Int32.Parse(bicicletaDataGridView.SelectedCells[4].Value.ToString());
                    id_grupo = Int32.Parse(bicicletaDataGridView.SelectedCells[5].Value.ToString());
                    id_ruedas= Int32.Parse(bicicletaDataGridView.SelectedCells[6].Value.ToString());
                    id_sillin=Int32.Parse(bicicletaDataGridView.SelectedCells[7].Value.ToString());
                    id_pedales=Int32.Parse(bicicletaDataGridView.SelectedCells[8].Value.ToString());
               */
                foreach (DataGridViewRow row in bicicletaDataGridView.SelectedRows)
                {
                    id_bicicleta = Int32.Parse(row.Cells[0].Value.ToString());
                    precio = Double.Parse(row.Cells[1].Value.ToString());
                    id_cuadro = Int32.Parse(row.Cells[4].Value.ToString());
                    id_grupo = Int32.Parse(row.Cells[5].Value.ToString());
                    id_ruedas = Int32.Parse(row.Cells[6].Value.ToString());
                    id_sillin = Int32.Parse(row.Cells[7].Value.ToString());
                    id_pedales = Int32.Parse(row.Cells[8].Value.ToString());
                }

                //Form_nuevo f = new Form_nuevo(id_user,id_bicicleta,id_cuadro,id_grupo,id_ruedas,id_sillin,id_pedales,precio);



                Conexion c = new Conexion();
                SqlCommand comandosql = new SqlCommand();
                comandosql.Connection = c.conectarse;
                comandosql.CommandText = "SELECT COUNT(*) FROM Bicicleta";


                SqlDataReader midatareader = comandosql.ExecuteReader();


                while (midatareader.Read())
                {
                    dato = midatareader.GetInt32(0);
                }
                midatareader.Close();

                dato++;

                comandosql.CommandText = "INSERT INTO Bicicleta VALUES(" + dato + "," + precio + ",0,'" + id_user + "'," + id_cuadro + "," + id_grupo + "," + id_ruedas + "," + id_sillin + "," + id_pedales + ");";
                midatareader = comandosql.ExecuteReader();
                midatareader.Close();
                MessageBox.Show("Duplicación realizada correctamente");

            }
            catch
            {
                MessageBox.Show("EXCEPCION");
            }

        }
    }
}
