using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATACHORI
{
    public partial class FrmProduucto : Form
    {
        Ejecucion ejecucion;
        public FrmProduucto()
        {
            InitializeComponent();
            ejecucion = new Ejecucion();
            ejecucion.actualizarGrid(this.dataGridView1, "SELECT * FROM producto");
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            //TODO: COMPLETAR SQL PARA INSERTAR PRODUCTOS CON SU RESPECTIVO PROVEEDOR
            ejecucion.conectar();
            ejecucion.actualizarGrid(this.dataGridView1, "INSERT INTO PRODUCTO (nombre)");

            ejecucion.desconectar();
        }

        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            ejecucion.conectar();
            ejecucion.actualizarGrid(this.dataGridView1, "SELECT * FROM producto");

            ejecucion.desconectar();
        }
    }
}
