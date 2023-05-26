namespace CATACHORI
{
    partial class FrmProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_BUSCAR = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.lblProveedorBuscador = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BTN_BORRAR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.BTN_BUSCAR);
            this.panel2.Controls.Add(this.txtBuscarNombre);
            this.panel2.Controls.Add(this.lblProveedorBuscador);
            this.panel2.Location = new System.Drawing.Point(317, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 159);
            this.panel2.TabIndex = 9;
            // 
            // BTN_BUSCAR
            // 
            this.BTN_BUSCAR.BackgroundImage = global::CATACHORI.Properties.Resources._2622200;
            this.BTN_BUSCAR.Location = new System.Drawing.Point(385, 93);
            this.BTN_BUSCAR.Name = "BTN_BUSCAR";
            this.BTN_BUSCAR.Size = new System.Drawing.Size(92, 22);
            this.BTN_BUSCAR.TabIndex = 9;
            this.BTN_BUSCAR.Text = "BUSCAR";
            this.BTN_BUSCAR.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombre.Location = new System.Drawing.Point(59, 93);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(277, 22);
            this.txtBuscarNombre.TabIndex = 8;
            this.txtBuscarNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarNombre_KeyUp);
            // 
            // lblProveedorBuscador
            // 
            this.lblProveedorBuscador.AutoSize = true;
            this.lblProveedorBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorBuscador.Location = new System.Drawing.Point(54, 34);
            this.lblProveedorBuscador.Name = "lblProveedorBuscador";
            this.lblProveedorBuscador.Size = new System.Drawing.Size(132, 29);
            this.lblProveedorBuscador.TabIndex = 7;
            this.lblProveedorBuscador.Text = "Proveedor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 294);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.BTN_BORRAR);
            this.panel1.Controls.Add(this.BTN_EDITAR);
            this.panel1.Controls.Add(this.BTN_GUARDAR);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 294);
            this.panel1.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(117, 13);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(64, 20);
            this.txt_id.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(90, 16);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(117, 92);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(144, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // BTN_BORRAR
            // 
            this.BTN_BORRAR.BackgroundImage = global::CATACHORI.Properties.Resources.bin_red_icon;
            this.BTN_BORRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_BORRAR.Location = new System.Drawing.Point(198, 201);
            this.BTN_BORRAR.Name = "BTN_BORRAR";
            this.BTN_BORRAR.Size = new System.Drawing.Size(63, 65);
            this.BTN_BORRAR.TabIndex = 6;
            this.BTN_BORRAR.UseVisualStyleBackColor = true;
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.BackgroundImage = global::CATACHORI.Properties.Resources.Pencil_icon;
            this.BTN_EDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_EDITAR.Location = new System.Drawing.Point(117, 201);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(64, 65);
            this.BTN_EDITAR.TabIndex = 5;
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackgroundImage = global::CATACHORI.Properties.Resources.Floppy_icon;
            this.BTN_GUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(38, 201);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(63, 65);
            this.BTN_GUARDAR.TabIndex = 4;
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CATACHORI.Properties.Resources.chritos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CATACHORI.Properties.Resources.Proveedor;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_BUSCAR;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label lblProveedorBuscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BTN_BORRAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}