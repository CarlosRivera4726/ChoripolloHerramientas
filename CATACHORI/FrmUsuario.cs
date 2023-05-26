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
    public partial class FrmUsuario : Form
    {

        Ejecucion usuario;
        string sql;
        public FrmUsuario()
        {
            InitializeComponent();
            usuario = new Ejecucion();
            usuario.actualizarGrid(this.dataGridView1 , "SELECT * FROM usuario");
        }

        private void button1_Click(object sender, EventArgs e) //BTN_BUSCAR
        {
            usuario.conectar();
            usuario.actualizarGrid(this.dataGridView1, "SELECT * FROM usuario");

            usuario.desconectar();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO usuario (nombre, apellido, genero) values ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtGenero.Text + "' )";
            usuario.conectar();
            usuario.ejecutarSQL(sql);
            usuario.desconectar();
            usuario.actualizarGrid(this.dataGridView1, "SELECT * FROM usuario");

        }

        private void BTN_BORRAR_Click(object sender, EventArgs e)
        {
            sql = "DELETE from usuario where id_usuario = " + txt_id.Text;
            usuario.conectar();
            usuario.ejecutarSQL(sql);
            usuario.desconectar();
            usuario.actualizarGrid(this.dataGridView1, "SELECT * FROM usuario");

        }

       

        private void txtBuscarNombre_KeyUp(object sender, KeyEventArgs e)
        {
            usuario.conectar();
            usuario.actualizarGrid(dataGridView1, "SELECT * FROM usuario WHERE nombre LIKE '" + txtBuscarNombre.Text + "%'");
            usuario.desconectar();
        }
    }
}
