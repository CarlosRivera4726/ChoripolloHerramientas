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
    public partial class FrmProveedor : Form
    {
        Ejecucion ejecucion;
        public FrmProveedor()
        {
            InitializeComponent();
            ejecucion = new Ejecucion();
            ejecucion.actualizarGrid(this.dataGridView1, "SELECT * FROM PROVEEDOR");
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            ejecucion.conectar();
            ejecucion.ejecutarSQL("INSERT INTO PROVEEDOR (NOMBRE, TELEFONO) VALUES ('" + this.txtNombre.Text + "', '" + this.txtTelefono.Text + "')");
            ejecucion.actualizarGrid(this.dataGridView1, "SELECT * FROM proveedor");
            ejecucion.desconectar();
        }

        private void txtBuscarNombre_KeyUp(object sender, KeyEventArgs e)
        {
            ejecucion.conectar();
            ejecucion.actualizarGrid(this.dataGridView1, "SELECT * FROM proveedor WHERE nombre LIKE '" + txtBuscarNombre.Text + "%'");
            ejecucion.desconectar();
        }
    }
}
