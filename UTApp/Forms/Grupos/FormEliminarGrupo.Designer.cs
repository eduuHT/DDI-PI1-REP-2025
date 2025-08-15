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
            this.botonRegresar = new System.Windows.Forms.PictureBox();
            this.labelGrupos = new System.Windows.Forms.Label();
            this.labelEliminarGrupo = new System.Windows.Forms.Label();
            this.botonCancelarEliminacion = new System.Windows.Forms.Button();
            this.botonConfirmarEliminacion = new System.Windows.Forms.Button();
            this.textBoxIDGrupoEliminado = new System.Windows.Forms.TextBox();
            this.labelIDGrupoEliminado = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 3;
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
            // labelEliminarGrupo
            // 
            this.labelEliminarGrupo.AutoSize = true;
            this.labelEliminarGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarGrupo.ForeColor = System.Drawing.Color.Black;
            this.labelEliminarGrupo.Location = new System.Drawing.Point(16, 120);
            this.labelEliminarGrupo.Name = "labelEliminarGrupo";
            this.labelEliminarGrupo.Size = new System.Drawing.Size(171, 23);
            this.labelEliminarGrupo.TabIndex = 27;
            this.labelEliminarGrupo.Text = "Eliminar Grupo";
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
            this.botonCancelarEliminacion.TabIndex = 31;
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
            this.botonConfirmarEliminacion.TabIndex = 30;
            this.botonConfirmarEliminacion.Text = "Eliminar";
            this.botonConfirmarEliminacion.UseVisualStyleBackColor = false;
            // 
            // textBoxIDGrupoEliminado
            // 
            this.textBoxIDGrupoEliminado.Location = new System.Drawing.Point(183, 184);
            this.textBoxIDGrupoEliminado.Name = "textBoxIDGrupoEliminado";
            this.textBoxIDGrupoEliminado.Size = new System.Drawing.Size(149, 20);
            this.textBoxIDGrupoEliminado.TabIndex = 29;
            // 
            // labelIDGrupoEliminado
            // 
            this.labelIDGrupoEliminado.AutoSize = true;
            this.labelIDGrupoEliminado.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelIDGrupoEliminado.Location = new System.Drawing.Point(16, 185);
            this.labelIDGrupoEliminado.Name = "labelIDGrupoEliminado";
            this.labelIDGrupoEliminado.Size = new System.Drawing.Size(161, 16);
            this.labelIDGrupoEliminado.TabIndex = 28;
            this.labelIDGrupoEliminado.Text = "ID del Grupo a eliminar:";
            // 
            // FormEliminarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.botonCancelarEliminacion);
            this.Controls.Add(this.botonConfirmarEliminacion);
            this.Controls.Add(this.textBoxIDGrupoEliminado);
            this.Controls.Add(this.labelIDGrupoEliminado);
            this.Controls.Add(this.labelEliminarGrupo);
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
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonRegresar;
        private System.Windows.Forms.Label labelGrupos;
        private System.Windows.Forms.Label labelEliminarGrupo;
        private System.Windows.Forms.Button botonCancelarEliminacion;
        private System.Windows.Forms.Button botonConfirmarEliminacion;
        private System.Windows.Forms.TextBox textBoxIDGrupoEliminado;
        private System.Windows.Forms.Label labelIDGrupoEliminado;
    }
}