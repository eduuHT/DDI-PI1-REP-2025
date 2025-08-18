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
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblEliminarMateria = new System.Windows.Forms.Label();
            this.btnCancelarEliminacion = new System.Windows.Forms.Button();
            this.btnConfirmarEliminacion = new System.Windows.Forms.Button();
            this.txtMateriaEliminadaID = new System.Windows.Forms.TextBox();
            this.lblMateriaEliminadaID = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 3;
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
            // lblEliminarMateria
            // 
            this.lblEliminarMateria.AutoSize = true;
            this.lblEliminarMateria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarMateria.ForeColor = System.Drawing.Color.Black;
            this.lblEliminarMateria.Location = new System.Drawing.Point(16, 120);
            this.lblEliminarMateria.Name = "lblEliminarMateria";
            this.lblEliminarMateria.Size = new System.Drawing.Size(189, 23);
            this.lblEliminarMateria.TabIndex = 20;
            this.lblEliminarMateria.Text = "Eliminar Materia";
            // 
            // btnCancelarEliminacion
            // 
            this.btnCancelarEliminacion.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarEliminacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEliminacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEliminacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelarEliminacion.Location = new System.Drawing.Point(11, 550);
            this.btnCancelarEliminacion.Name = "btnCancelarEliminacion";
            this.btnCancelarEliminacion.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarEliminacion.TabIndex = 19;
            this.btnCancelarEliminacion.Text = "Cancelar";
            this.btnCancelarEliminacion.UseVisualStyleBackColor = false;
            this.btnCancelarEliminacion.Click += new System.EventHandler(this.btnCancelarEliminacion_Click);
            // 
            // btnConfirmarEliminacion
            // 
            this.btnConfirmarEliminacion.BackColor = System.Drawing.Color.Tomato;
            this.btnConfirmarEliminacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEliminacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEliminacion.Location = new System.Drawing.Point(182, 550);
            this.btnConfirmarEliminacion.Name = "btnConfirmarEliminacion";
            this.btnConfirmarEliminacion.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmarEliminacion.TabIndex = 18;
            this.btnConfirmarEliminacion.Text = "Eliminar";
            this.btnConfirmarEliminacion.UseVisualStyleBackColor = false;
            this.btnConfirmarEliminacion.Click += new System.EventHandler(this.btnConfirmarEliminacion_Click);
            // 
            // txtMateriaEliminadaID
            // 
            this.txtMateriaEliminadaID.Location = new System.Drawing.Point(208, 190);
            this.txtMateriaEliminadaID.Name = "txtMateriaEliminadaID";
            this.txtMateriaEliminadaID.Size = new System.Drawing.Size(124, 20);
            this.txtMateriaEliminadaID.TabIndex = 17;
            // 
            // lblMateriaEliminadaID
            // 
            this.lblMateriaEliminadaID.AutoSize = true;
            this.lblMateriaEliminadaID.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblMateriaEliminadaID.Location = new System.Drawing.Point(17, 190);
            this.lblMateriaEliminadaID.Name = "lblMateriaEliminadaID";
            this.lblMateriaEliminadaID.Size = new System.Drawing.Size(185, 16);
            this.lblMateriaEliminadaID.TabIndex = 16;
            this.lblMateriaEliminadaID.Text = "ID de la materia a eliminar:";
            // 
            // FormEliminarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.lblEliminarMateria);
            this.Controls.Add(this.btnCancelarEliminacion);
            this.Controls.Add(this.btnConfirmarEliminacion);
            this.Controls.Add(this.txtMateriaEliminadaID);
            this.Controls.Add(this.lblMateriaEliminadaID);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblEliminarMateria;
        private System.Windows.Forms.Button btnCancelarEliminacion;
        private System.Windows.Forms.Button btnConfirmarEliminacion;
        private System.Windows.Forms.TextBox txtMateriaEliminadaID;
        private System.Windows.Forms.Label lblMateriaEliminadaID;
    }
}