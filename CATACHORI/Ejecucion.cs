using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CATACHORI
{
    class Ejecucion : Conexion
    {
        public Ejecucion()
        {
            
        }

        public void ejecutarSQL(string sql)
        {
            try
            {
                SqlCommand sentencia = new SqlCommand(sql, miConexion);
                int numero = sentencia.ExecuteNonQuery();
                if (numero > 0)
                {
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "LA BASE SE HA ESPECIFICADO",
                    MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ACTUALIZAR LA BD", "LA BASE NO SE HA ESPECIFICADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar al usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarGrid(DataGridView dg, String sql)
        {
            try
            {
                this.conectar();
                //creamos el data set
                System.Data.DataSet miDataSet = new System.Data.DataSet();
                //creamos el adaptador de datos
                SqlDataAdapter miAdaptador = new SqlDataAdapter(sql, miConexion);

                //llenar data set 
                miAdaptador.Fill(miDataSet, "usuario");

                //asignar el valor adecuado a las  propiedades del del datagrid

                dg.DataSource = miDataSet;
                dg.DataMember = "usuario";
                //desconecto de la bd
                this.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un  error");
            }
        }
    }
}
