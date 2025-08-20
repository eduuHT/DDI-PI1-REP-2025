namespace UTApp.Forms.Materias
{
    partial class FormEditarMateria
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
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblEditarMateria = new System.Windows.Forms.Label();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtMateriaEditadaID = new System.Windows.Forms.TextBox();
            this.lblMateriaEditadaID = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.btnRegresar);
            this.panelHeader.Controls.Add(this.lblMaterias);
            this.panelHeader.Location = new System.Drawing.Point(-4, -5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(352, 102);
            this.panelHeader.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = global::UTApp.Properties.Resources.left_chevron;
            this.btnRegresar.Location = new System.Drawing.Point(24, 46);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(16, 24);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.BackColor = System.Drawing.Color.Transparent;
            this.lblMaterias.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.ForeColor = System.Drawing.Color.White;
            this.lblMaterias.Location = new System.Drawing.Point(121, 45);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(103, 25);
            this.lblMaterias.TabIndex = 0;
            this.lblMaterias.Text = "Materias";
            // 
            // lblEditarMateria
            // 
            this.lblEditarMateria.AutoSize = true;
            this.lblEditarMateria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarMateria.ForeColor = System.Drawing.Color.Black;
            this.lblEditarMateria.Location = new System.Drawing.Point(16, 120);
            this.lblEditarMateria.Name = "lblEditarMateria";
            this.lblEditarMateria.Size = new System.Drawing.Size(163, 23);
            this.lblEditarMateria.TabIndex = 26;
            this.lblEditarMateria.Text = "Editar Materia";
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEdicion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelarEdicion.Location = new System.Drawing.Point(11, 550);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarEdicion.TabIndex = 25;
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.UseVisualStyleBackColor = false;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirmarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(182, 550);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmarEdicion.TabIndex = 24;
            this.btnConfirmarEdicion.Text = "Editar";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = false;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(20, 296);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(312, 20);
            this.txtNuevoNombre.TabIndex = 23;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombre.Location = new System.Drawing.Point(17, 263);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(105, 14);
            this.lblNuevoNombre.TabIndex = 22;
            this.lblNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // txtMateriaEditadaID
            // 
            this.txtMateriaEditadaID.Location = new System.Drawing.Point(197, 190);
            this.txtMateriaEditadaID.Name = "txtMateriaEditadaID";
            this.txtMateriaEditadaID.Size = new System.Drawing.Size(135, 20);
            this.txtMateriaEditadaID.TabIndex = 17;
            // 
            // lblMateriaEditadaID
            // 
            this.lblMateriaEditadaID.AutoSize = true;
            this.lblMateriaEditadaID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaEditadaID.Location = new System.Drawing.Point(17, 191);
            this.lblMateriaEditadaID.Name = "lblMateriaEditadaID";
            this.lblMateriaEditadaID.Size = new System.Drawing.Size(172, 16);
            this.lblMateriaEditadaID.TabIndex = 16;
            this.lblMateriaEditadaID.Text = "ID de la Materia editada:";
            // 
            // FormEditarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.lblEditarMateria);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnConfirmarEdicion);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtMateriaEditadaID);
            this.Controls.Add(this.lblMateriaEditadaID);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Materia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditarMateria_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblEditarMateria;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtMateriaEditadaID;
        private System.Windows.Forms.Label lblMateriaEditadaID;
    }
}