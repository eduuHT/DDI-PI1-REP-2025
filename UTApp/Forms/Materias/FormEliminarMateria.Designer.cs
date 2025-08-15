namespace UTApp.Forms.Materias
{
    partial class FormEliminarMateria
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.PictureBox();
            this.labelEliminarMateria = new System.Windows.Forms.Label();
            this.botonCancelarEliminacion = new System.Windows.Forms.Button();
            this.botonConfirmarEliminacion = new System.Windows.Forms.Button();
            this.textBoxIDMateriaEliminada = new System.Windows.Forms.TextBox();
            this.labelIDMateriaEliminada = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.botonRegresar);
            this.panelHeader.Controls.Add(this.labelMaterias);
            this.panelHeader.Location = new System.Drawing.Point(-4, -5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(352, 102);
            this.panelHeader.TabIndex = 3;
            // 
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterias.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterias.ForeColor = System.Drawing.Color.White;
            this.labelMaterias.Location = new System.Drawing.Point(121, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(103, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Materias";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegresar.Image = global::UTApp.Properties.Resources.left_chevron;
            this.botonRegresar.Location = new System.Drawing.Point(24, 46);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(16, 24);
            this.botonRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonRegresar.TabIndex = 1;
            this.botonRegresar.TabStop = false;
            // 
            // labelEliminarMateria
            // 
            this.labelEliminarMateria.AutoSize = true;
            this.labelEliminarMateria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarMateria.ForeColor = System.Drawing.Color.Black;
            this.labelEliminarMateria.Location = new System.Drawing.Point(16, 120);
            this.labelEliminarMateria.Name = "labelEliminarMateria";
            this.labelEliminarMateria.Size = new System.Drawing.Size(189, 23);
            this.labelEliminarMateria.TabIndex = 20;
            this.labelEliminarMateria.Text = "Eliminar Materia";
            // 
            // botonCancelarEliminacion
            // 
            this.botonCancelarEliminacion.BackColor = System.Drawing.SystemColors.Control;
            this.botonCancelarEliminacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelarEliminacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarEliminacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonCancelarEliminacion.Location = new System.Drawing.Point(11, 550);
            this.botonCancelarEliminacion.Name = "botonCancelarEliminacion";
            this.botonCancelarEliminacion.Size = new System.Drawing.Size(150, 40);
            this.botonCancelarEliminacion.TabIndex = 19;
            this.botonCancelarEliminacion.Text = "Cancelar";
            this.botonCancelarEliminacion.UseVisualStyleBackColor = false;
            // 
            // botonConfirmarEliminacion
            // 
            this.botonConfirmarEliminacion.BackColor = System.Drawing.Color.Tomato;
            this.botonConfirmarEliminacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmarEliminacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarEliminacion.Location = new System.Drawing.Point(182, 550);
            this.botonConfirmarEliminacion.Name = "botonConfirmarEliminacion";
            this.botonConfirmarEliminacion.Size = new System.Drawing.Size(150, 40);
            this.botonConfirmarEliminacion.TabIndex = 18;
            this.botonConfirmarEliminacion.Text = "Eliminar";
            this.botonConfirmarEliminacion.UseVisualStyleBackColor = false;
            // 
            // textBoxIDMateriaEliminada
            // 
            this.textBoxIDMateriaEliminada.Location = new System.Drawing.Point(208, 190);
            this.textBoxIDMateriaEliminada.Name = "textBoxIDMateriaEliminada";
            this.textBoxIDMateriaEliminada.Size = new System.Drawing.Size(124, 20);
            this.textBoxIDMateriaEliminada.TabIndex = 17;
            // 
            // labelIDMateriaEliminada
            // 
            this.labelIDMateriaEliminada.AutoSize = true;
            this.labelIDMateriaEliminada.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelIDMateriaEliminada.Location = new System.Drawing.Point(17, 190);
            this.labelIDMateriaEliminada.Name = "labelIDMateriaEliminada";
            this.labelIDMateriaEliminada.Size = new System.Drawing.Size(185, 16);
            this.labelIDMateriaEliminada.TabIndex = 16;
            this.labelIDMateriaEliminada.Text = "ID de la materia a eliminar:";
            // 
            // FormEliminarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.labelEliminarMateria);
            this.Controls.Add(this.botonCancelarEliminacion);
            this.Controls.Add(this.botonConfirmarEliminacion);
            this.Controls.Add(this.textBoxIDMateriaEliminada);
            this.Controls.Add(this.labelIDMateriaEliminada);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEliminarMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Materia";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.Label labelEliminarMateria;
        private System.Windows.Forms.Button botonCancelarEliminacion;
        private System.Windows.Forms.Button botonConfirmarEliminacion;
        private System.Windows.Forms.TextBox textBoxIDMateriaEliminada;
        private System.Windows.Forms.Label labelIDMateriaEliminada;
    }
}