using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATACHORI
{
    public class Conexion
    {
        public static SqlConnection miConexion;
        private string ownerConnection = Environment.MachineName;
        private string BD = "bd_chorizos";

        public void conectar()
        {
            try
            {
                miConexion = new SqlConnection("Data Source=" + ownerConnection + "\\sqlexpress; Initial Catalog=" + BD + ";Integrated Security=True");
                miConexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public void desconectar()
        {
            try
            {
                miConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al intentar cerrar la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
