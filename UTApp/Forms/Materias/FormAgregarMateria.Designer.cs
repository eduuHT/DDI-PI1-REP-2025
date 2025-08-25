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
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblNuevaMateria = new System.Windows.Forms.Label();
            this.btnCancelarAdicion = new System.Windows.Forms.Button();
            this.btnConfirmarAdicion = new System.Windows.Forms.Button();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
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
            // lblNuevaMateria
            // 
            this.lblNuevaMateria.AutoSize = true;
            this.lblNuevaMateria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaMateria.ForeColor = System.Drawing.Color.Black;
            this.lblNuevaMateria.Location = new System.Drawing.Point(16, 120);
            this.lblNuevaMateria.Name = "lblNuevaMateria";
            this.lblNuevaMateria.Size = new System.Drawing.Size(167, 23);
            this.lblNuevaMateria.TabIndex = 21;
            this.lblNuevaMateria.Text = "Nueva Materia";
            // 
            // btnCancelarAdicion
            // 
            this.btnCancelarAdicion.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarAdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAdicion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelarAdicion.Location = new System.Drawing.Point(11, 550);
            this.btnCancelarAdicion.Name = "btnCancelarAdicion";
            this.btnCancelarAdicion.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarAdicion.TabIndex = 20;
            this.btnCancelarAdicion.Text = "Cancelar";
            this.btnCancelarAdicion.UseVisualStyleBackColor = false;
            this.btnCancelarAdicion.Click += new System.EventHandler(this.btnCancelarAdicion_Click);
            // 
            // btnConfirmarAdicion
            // 
            this.btnConfirmarAdicion.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirmarAdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarAdicion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAdicion.Location = new System.Drawing.Point(182, 550);
            this.btnConfirmarAdicion.Name = "btnConfirmarAdicion";
            this.btnConfirmarAdicion.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmarAdicion.TabIndex = 19;
            this.btnConfirmarAdicion.Text = "Agregar";
            this.btnConfirmarAdicion.UseVisualStyleBackColor = false;
            this.btnConfirmarAdicion.Click += new System.EventHandler(this.btnConfirmarAdicion_Click);
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(20, 225);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(312, 20);
            this.txtNombreMateria.TabIndex = 16;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(17, 190);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(153, 16);
            this.lblNombreMateria.TabIndex = 15;
            this.lblNombreMateria.Text = "Nombre de la Materia:";
            // 
            // FormAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.lblNuevaMateria);
            this.Controls.Add(this.btnCancelarAdicion);
            this.Controls.Add(this.btnConfirmarAdicion);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.lblNombreMateria);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Materia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAgregarMateria_FormClosed);
            this.Load += new System.EventHandler(this.FormAgregarMateria_Load);
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
        private System.Windows.Forms.Label lblNuevaMateria;
        private System.Windows.Forms.Button btnCancelarAdicion;
        private System.Windows.Forms.Button btnConfirmarAdicion;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
    }
}