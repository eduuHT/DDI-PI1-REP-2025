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
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.lblEditarGrupo = new System.Windows.Forms.Label();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtGrupoEditadoID = new System.Windows.Forms.TextBox();
            this.lblGrupoEditadoID = new System.Windows.Forms.Label();
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
            // lblEditarGrupo
            // 
            this.lblEditarGrupo.AutoSize = true;
            this.lblEditarGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarGrupo.ForeColor = System.Drawing.Color.Black;
            this.lblEditarGrupo.Location = new System.Drawing.Point(16, 120);
            this.lblEditarGrupo.Name = "lblEditarGrupo";
            this.lblEditarGrupo.Size = new System.Drawing.Size(145, 23);
            this.lblEditarGrupo.TabIndex = 26;
            this.lblEditarGrupo.Text = "Editar Grupo";
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
            this.txtNuevoNombre.Location = new System.Drawing.Point(18, 287);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(313, 20);
            this.txtNuevoNombre.TabIndex = 23;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombre.Location = new System.Drawing.Point(16, 255);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(105, 14);
            this.lblNuevoNombre.TabIndex = 22;
            this.lblNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // txtGrupoEditadoID
            // 
            this.txtGrupoEditadoID.Location = new System.Drawing.Point(170, 184);
            this.txtGrupoEditadoID.Name = "txtGrupoEditadoID";
            this.txtGrupoEditadoID.Size = new System.Drawing.Size(88, 20);
            this.txtGrupoEditadoID.TabIndex = 17;
            // 
            // lblGrupoEditadoID
            // 
            this.lblGrupoEditadoID.AutoSize = true;
            this.lblGrupoEditadoID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoEditadoID.Location = new System.Drawing.Point(16, 185);
            this.lblGrupoEditadoID.Name = "lblGrupoEditadoID";
            this.lblGrupoEditadoID.Size = new System.Drawing.Size(148, 16);
            this.lblGrupoEditadoID.TabIndex = 16;
            this.lblGrupoEditadoID.Text = "ID del Grupo editado:";
            // 
            // FormEditarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.lblEditarGrupo);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnConfirmarEdicion);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtGrupoEditadoID);
            this.Controls.Add(this.lblGrupoEditadoID);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Label lblEditarGrupo;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtGrupoEditadoID;
        private System.Windows.Forms.Label lblGrupoEditadoID;
    }
}