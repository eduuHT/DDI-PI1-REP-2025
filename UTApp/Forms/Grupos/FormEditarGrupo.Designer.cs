namespace UTApp.Forms.Grupos
{
    partial class FormEditarGrupo
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
            this.labelGrupos = new System.Windows.Forms.Label();
            this.labelEditarGrupo = new System.Windows.Forms.Label();
            this.botonCancelarEdicion = new System.Windows.Forms.Button();
            this.botonConfirmarEdicion = new System.Windows.Forms.Button();
            this.textBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.labelNuevoNombre = new System.Windows.Forms.Label();
            this.textBoxIDGrupoEditado = new System.Windows.Forms.TextBox();
            this.labelIDGrupoEditado = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.botonRegresar);
            this.panelHeader.Controls.Add(this.labelGrupos);
            this.panelHeader.Location = new System.Drawing.Point(-5, -4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(353, 99);
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
            // labelGrupos
            // 
            this.labelGrupos.AutoSize = true;
            this.labelGrupos.BackColor = System.Drawing.Color.Transparent;
            this.labelGrupos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupos.ForeColor = System.Drawing.Color.White;
            this.labelGrupos.Location = new System.Drawing.Point(134, 45);
            this.labelGrupos.Name = "labelGrupos";
            this.labelGrupos.Size = new System.Drawing.Size(87, 25);
            this.labelGrupos.TabIndex = 0;
            this.labelGrupos.Text = "Grupos";
            // 
            // labelEditarGrupo
            // 
            this.labelEditarGrupo.AutoSize = true;
            this.labelEditarGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarGrupo.ForeColor = System.Drawing.Color.Black;
            this.labelEditarGrupo.Location = new System.Drawing.Point(16, 120);
            this.labelEditarGrupo.Name = "labelEditarGrupo";
            this.labelEditarGrupo.Size = new System.Drawing.Size(145, 23);
            this.labelEditarGrupo.TabIndex = 26;
            this.labelEditarGrupo.Text = "Editar Grupo";
            // 
            // botonCancelarEdicion
            // 
            this.botonCancelarEdicion.BackColor = System.Drawing.SystemColors.Control;
            this.botonCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelarEdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarEdicion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonCancelarEdicion.Location = new System.Drawing.Point(11, 550);
            this.botonCancelarEdicion.Name = "botonCancelarEdicion";
            this.botonCancelarEdicion.Size = new System.Drawing.Size(150, 40);
            this.botonCancelarEdicion.TabIndex = 25;
            this.botonCancelarEdicion.Text = "Cancelar";
            this.botonCancelarEdicion.UseVisualStyleBackColor = false;
            // 
            // botonConfirmarEdicion
            // 
            this.botonConfirmarEdicion.BackColor = System.Drawing.Color.PaleGreen;
            this.botonConfirmarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmarEdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarEdicion.Location = new System.Drawing.Point(182, 550);
            this.botonConfirmarEdicion.Name = "botonConfirmarEdicion";
            this.botonConfirmarEdicion.Size = new System.Drawing.Size(150, 40);
            this.botonConfirmarEdicion.TabIndex = 24;
            this.botonConfirmarEdicion.Text = "Editar";
            this.botonConfirmarEdicion.UseVisualStyleBackColor = false;
            // 
            // textBoxNuevoNombre
            // 
            this.textBoxNuevoNombre.Location = new System.Drawing.Point(18, 287);
            this.textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            this.textBoxNuevoNombre.Size = new System.Drawing.Size(313, 20);
            this.textBoxNuevoNombre.TabIndex = 23;
            // 
            // labelNuevoNombre
            // 
            this.labelNuevoNombre.AutoSize = true;
            this.labelNuevoNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoNombre.Location = new System.Drawing.Point(16, 255);
            this.labelNuevoNombre.Name = "labelNuevoNombre";
            this.labelNuevoNombre.Size = new System.Drawing.Size(105, 14);
            this.labelNuevoNombre.TabIndex = 22;
            this.labelNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // textBoxIDGrupoEditado
            // 
            this.textBoxIDGrupoEditado.Location = new System.Drawing.Point(170, 184);
            this.textBoxIDGrupoEditado.Name = "textBoxIDGrupoEditado";
            this.textBoxIDGrupoEditado.Size = new System.Drawing.Size(88, 20);
            this.textBoxIDGrupoEditado.TabIndex = 17;
            // 
            // labelIDGrupoEditado
            // 
            this.labelIDGrupoEditado.AutoSize = true;
            this.labelIDGrupoEditado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDGrupoEditado.Location = new System.Drawing.Point(16, 185);
            this.labelIDGrupoEditado.Name = "labelIDGrupoEditado";
            this.labelIDGrupoEditado.Size = new System.Drawing.Size(148, 16);
            this.labelIDGrupoEditado.TabIndex = 16;
            this.labelIDGrupoEditado.Text = "ID del Grupo editado:";
            // 
            // FormEditarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.labelEditarGrupo);
            this.Controls.Add(this.botonCancelarEdicion);
            this.Controls.Add(this.botonConfirmarEdicion);
            this.Controls.Add(this.textBoxNuevoNombre);
            this.Controls.Add(this.labelNuevoNombre);
            this.Controls.Add(this.textBoxIDGrupoEditado);
            this.Controls.Add(this.labelIDGrupoEditado);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Grupo";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonRegresar;
        private System.Windows.Forms.Label labelGrupos;
        private System.Windows.Forms.Label labelEditarGrupo;
        private System.Windows.Forms.Button botonCancelarEdicion;
        private System.Windows.Forms.Button botonConfirmarEdicion;
        private System.Windows.Forms.TextBox textBoxNuevoNombre;
        private System.Windows.Forms.Label labelNuevoNombre;
        private System.Windows.Forms.TextBox textBoxIDGrupoEditado;
        private System.Windows.Forms.Label labelIDGrupoEditado;
    }
}