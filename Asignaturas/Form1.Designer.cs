namespace Asignaturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btmCargar = new System.Windows.Forms.Button();
            this.btmGuardar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.btmActualizar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(148, 56);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(190, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(148, 145);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(190, 20);
            this.tbNota.TabIndex = 6;
            // 
            // dgvSalida
            // 
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(28, 212);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.Size = new System.Drawing.Size(379, 150);
            this.dgvSalida.TabIndex = 7;
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(443, 59);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(75, 23);
            this.btmAgregar.TabIndex = 8;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btmCargar
            // 
            this.btmCargar.Location = new System.Drawing.Point(443, 212);
            this.btmCargar.Name = "btmCargar";
            this.btmCargar.Size = new System.Drawing.Size(142, 51);
            this.btmCargar.TabIndex = 9;
            this.btmCargar.Text = "Cargar";
            this.btmCargar.UseVisualStyleBackColor = true;
            this.btmCargar.Click += new System.EventHandler(this.btmCargar_Click);
            // 
            // btmGuardar
            // 
            this.btmGuardar.Location = new System.Drawing.Point(443, 293);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(142, 51);
            this.btmGuardar.TabIndex = 10;
            this.btmGuardar.Text = "Guardar";
            this.btmGuardar.UseVisualStyleBackColor = true;
            this.btmGuardar.Click += new System.EventHandler(this.btmGuardar_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Location = new System.Drawing.Point(443, 111);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(75, 23);
            this.btmEliminar.TabIndex = 11;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // btmActualizar
            // 
            this.btmActualizar.Location = new System.Drawing.Point(443, 161);
            this.btmActualizar.Name = "btmActualizar";
            this.btmActualizar.Size = new System.Drawing.Size(75, 23);
            this.btmActualizar.TabIndex = 12;
            this.btmActualizar.Text = "Actualizar";
            this.btmActualizar.UseVisualStyleBackColor = true;
            this.btmActualizar.Click += new System.EventHandler(this.btmActualizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmActualizar);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.btmGuardar);
            this.Controls.Add(this.btmCargar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmCargar;
        private System.Windows.Forms.Button btmGuardar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button btmActualizar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

