namespace UTApp.Forms.Grupos
{
    partial class FormEliminarGrupo
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
            this.lblGrupos = new System.Windows.Forms.Label();
            this.lblEliminarGrupo = new System.Windows.Forms.Label();
            this.btnCancelarEliminacion = new System.Windows.Forms.Button();
            this.btnConfirmarEliminacion = new System.Windows.Forms.Button();
            this.txtGrupoEliminadoID = new System.Windows.Forms.TextBox();
            this.lblGrupoEliminadoID = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.btnRegresar);
            this.panelHeader.Controls.Add(this.lblGrupos);
            this.panelHeader.Location = new System.Drawing.Point(-5, -4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(353, 99);
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
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupos.ForeColor = System.Drawing.Color.White;
            this.lblGrupos.Location = new System.Drawing.Point(134, 45);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(87, 25);
            this.lblGrupos.TabIndex = 0;
            this.lblGrupos.Text = "Grupos";
            // 
            // lblEliminarGrupo
            // 
            this.lblEliminarGrupo.AutoSize = true;
            this.lblEliminarGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarGrupo.ForeColor = System.Drawing.Color.Black;
            this.lblEliminarGrupo.Location = new System.Drawing.Point(16, 120);
            this.lblEliminarGrupo.Name = "lblEliminarGrupo";
            this.lblEliminarGrupo.Size = new System.Drawing.Size(171, 23);
            this.lblEliminarGrupo.TabIndex = 27;
            this.lblEliminarGrupo.Text = "Eliminar Grupo";
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
            this.btnCancelarEliminacion.TabIndex = 31;
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
            this.btnConfirmarEliminacion.TabIndex = 30;
            this.btnConfirmarEliminacion.Text = "Eliminar";
            this.btnConfirmarEliminacion.UseVisualStyleBackColor = false;
            this.btnConfirmarEliminacion.Click += new System.EventHandler(this.btnConfirmarEliminacion_Click);
            // 
            // txtGrupoEliminadoID
            // 
            this.txtGrupoEliminadoID.Location = new System.Drawing.Point(183, 184);
            this.txtGrupoEliminadoID.Name = "txtGrupoEliminadoID";
            this.txtGrupoEliminadoID.Size = new System.Drawing.Size(149, 20);
            this.txtGrupoEliminadoID.TabIndex = 29;
            // 
            // lblGrupoEliminadoID
            // 
            this.lblGrupoEliminadoID.AutoSize = true;
            this.lblGrupoEliminadoID.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblGrupoEliminadoID.Location = new System.Drawing.Point(16, 185);
            this.lblGrupoEliminadoID.Name = "lblGrupoEliminadoID";
            this.lblGrupoEliminadoID.Size = new System.Drawing.Size(161, 16);
            this.lblGrupoEliminadoID.TabIndex = 28;
            this.lblGrupoEliminadoID.Text = "ID del Grupo a eliminar:";
            // 
            // FormEliminarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.btnCancelarEliminacion);
            this.Controls.Add(this.btnConfirmarEliminacion);
            this.Controls.Add(this.txtGrupoEliminadoID);
            this.Controls.Add(this.lblGrupoEliminadoID);
            this.Controls.Add(this.lblEliminarGrupo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEliminarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Grupo";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Label lblEliminarGrupo;
        private System.Windows.Forms.Button btnCancelarEliminacion;
        private System.Windows.Forms.Button btnConfirmarEliminacion;
        private System.Windows.Forms.TextBox txtGrupoEliminadoID;
        private System.Windows.Forms.Label lblGrupoEliminadoID;
    }
}