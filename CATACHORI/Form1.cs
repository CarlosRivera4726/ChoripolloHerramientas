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
    public partial class Form1 : Form
    {
        FrmUsuario win_usuario;
        FrmProduucto win_producto;
        FrmProveedor win_proveedor;



        public Form1()
        {
            InitializeComponent();
        }

        private void índiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (win_usuario == null)
            {
                win_usuario = new FrmUsuario();
                win_usuario.MdiParent = this;
                win_usuario.FormClosed += new FormClosedEventHandler(cerrarVentana);
                win_usuario.Show();
            }
            else 
            {
                win_usuario.Activate();
            }
        }

        private void gestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (win_producto == null)
            {
                win_producto = new FrmProduucto();
                win_producto.MdiParent = this;
                win_producto.FormClosed += new FormClosedEventHandler(cerrarVentana);
                win_producto.Show();
            }
            else 
            {
                win_producto.Activate();
            }   
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (win_proveedor == null)
            {
                win_proveedor = new FrmProveedor();
                win_proveedor.MdiParent = this;
                win_proveedor.FormClosed += new FormClosedEventHandler(cerrarVentana);
                win_proveedor.Show();
            }
            else
            {
                win_proveedor.Activate();
            }
        }

        public void cerrarVentana(object enviar, FormClosedEventArgs evento)
        {
            win_usuario = null;
            win_producto = null;
            win_proveedor = null;

        }

        
    }
}
