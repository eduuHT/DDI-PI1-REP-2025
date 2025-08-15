namespace UTApp.Forms.Materias
{
    partial class FormAgregarMateria
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
            this.botonRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.labelNuevaMateria = new System.Windows.Forms.Label();
            this.botonCancelarAdicion = new System.Windows.Forms.Button();
            this.botonConfirmarAdicion = new System.Windows.Forms.Button();
            this.textBoxNombreMateria = new System.Windows.Forms.TextBox();
            this.labelNombreMateria = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 2;
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
            // labelNuevaMateria
            // 
            this.labelNuevaMateria.AutoSize = true;
            this.labelNuevaMateria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaMateria.ForeColor = System.Drawing.Color.Black;
            this.labelNuevaMateria.Location = new System.Drawing.Point(16, 120);
            this.labelNuevaMateria.Name = "labelNuevaMateria";
            this.labelNuevaMateria.Size = new System.Drawing.Size(167, 23);
            this.labelNuevaMateria.TabIndex = 21;
            this.labelNuevaMateria.Text = "Nueva Materia";
            // 
            // botonCancelarAdicion
            // 
            this.botonCancelarAdicion.BackColor = System.Drawing.SystemColors.Control;
            this.botonCancelarAdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelarAdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarAdicion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonCancelarAdicion.Location = new System.Drawing.Point(11, 550);
            this.botonCancelarAdicion.Name = "botonCancelarAdicion";
            this.botonCancelarAdicion.Size = new System.Drawing.Size(150, 40);
            this.botonCancelarAdicion.TabIndex = 20;
            this.botonCancelarAdicion.Text = "Cancelar";
            this.botonCancelarAdicion.UseVisualStyleBackColor = false;
            // 
            // botonConfirmarAdicion
            // 
            this.botonConfirmarAdicion.BackColor = System.Drawing.Color.PaleGreen;
            this.botonConfirmarAdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmarAdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarAdicion.Location = new System.Drawing.Point(182, 550);
            this.botonConfirmarAdicion.Name = "botonConfirmarAdicion";
            this.botonConfirmarAdicion.Size = new System.Drawing.Size(150, 40);
            this.botonConfirmarAdicion.TabIndex = 19;
            this.botonConfirmarAdicion.Text = "Agregar";
            this.botonConfirmarAdicion.UseVisualStyleBackColor = false;
            // 
            // textBoxNombreMateria
            // 
            this.textBoxNombreMateria.Location = new System.Drawing.Point(20, 225);
            this.textBoxNombreMateria.Name = "textBoxNombreMateria";
            this.textBoxNombreMateria.Size = new System.Drawing.Size(312, 20);
            this.textBoxNombreMateria.TabIndex = 16;
            // 
            // labelNombreMateria
            // 
            this.labelNombreMateria.AutoSize = true;
            this.labelNombreMateria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMateria.Location = new System.Drawing.Point(17, 190);
            this.labelNombreMateria.Name = "labelNombreMateria";
            this.labelNombreMateria.Size = new System.Drawing.Size(153, 16);
            this.labelNombreMateria.TabIndex = 15;
            this.labelNombreMateria.Text = "Nombre de la Materia:";
            // 
            // FormAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.labelNuevaMateria);
            this.Controls.Add(this.botonCancelarAdicion);
            this.Controls.Add(this.botonConfirmarAdicion);
            this.Controls.Add(this.textBoxNombreMateria);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Materia";
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
        private System.Windows.Forms.Label labelNuevaMateria;
        private System.Windows.Forms.Button botonCancelarAdicion;
        private System.Windows.Forms.Button botonConfirmarAdicion;
        private System.Windows.Forms.TextBox textBoxNombreMateria;
        private System.Windows.Forms.Label labelNombreMateria;
    }
}