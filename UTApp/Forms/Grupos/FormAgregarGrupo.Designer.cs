namespace UTApp.Forms.Grupos
{
    partial class FormAgregarGrupo
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
            this.labelNuevoGrupo = new System.Windows.Forms.Label();
            this.botonCancelarAdicion = new System.Windows.Forms.Button();
            this.botonConfirmarAdicion = new System.Windows.Forms.Button();
            this.textBoxNombreGrupo = new System.Windows.Forms.TextBox();
            this.labelNombreGrupo = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 4;
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
            // labelNuevoGrupo
            // 
            this.labelNuevoGrupo.AutoSize = true;
            this.labelNuevoGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoGrupo.ForeColor = System.Drawing.Color.Black;
            this.labelNuevoGrupo.Location = new System.Drawing.Point(16, 120);
            this.labelNuevoGrupo.Name = "labelNuevoGrupo";
            this.labelNuevoGrupo.Size = new System.Drawing.Size(149, 23);
            this.labelNuevoGrupo.TabIndex = 21;
            this.labelNuevoGrupo.Text = "Nuevo Grupo";
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
            // textBoxNombreGrupo
            // 
            this.textBoxNombreGrupo.Location = new System.Drawing.Point(19, 225);
            this.textBoxNombreGrupo.Name = "textBoxNombreGrupo";
            this.textBoxNombreGrupo.Size = new System.Drawing.Size(292, 20);
            this.textBoxNombreGrupo.TabIndex = 16;
            // 
            // labelNombreGrupo
            // 
            this.labelNombreGrupo.AutoSize = true;
            this.labelNombreGrupo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreGrupo.Location = new System.Drawing.Point(16, 185);
            this.labelNombreGrupo.Name = "labelNombreGrupo";
            this.labelNombreGrupo.Size = new System.Drawing.Size(129, 16);
            this.labelNombreGrupo.TabIndex = 15;
            this.labelNombreGrupo.Text = "Nombre del Grupo:";
            // 
            // FormAgregarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.labelNuevoGrupo);
            this.Controls.Add(this.botonCancelarAdicion);
            this.Controls.Add(this.botonConfirmarAdicion);
            this.Controls.Add(this.textBoxNombreGrupo);
            this.Controls.Add(this.labelNombreGrupo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Grupo";
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
        private System.Windows.Forms.Label labelNuevoGrupo;
        private System.Windows.Forms.Button botonCancelarAdicion;
        private System.Windows.Forms.Button botonConfirmarAdicion;
        private System.Windows.Forms.TextBox textBoxNombreGrupo;
        private System.Windows.Forms.Label labelNombreGrupo;
    }
}