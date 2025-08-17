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
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.lblNuevoGrupo = new System.Windows.Forms.Label();
            this.btnCancelarAdicion = new System.Windows.Forms.Button();
            this.btnConfirmarAdicion = new System.Windows.Forms.Button();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 4;
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
            // lblNuevoGrupo
            // 
            this.lblNuevoGrupo.AutoSize = true;
            this.lblNuevoGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoGrupo.ForeColor = System.Drawing.Color.Black;
            this.lblNuevoGrupo.Location = new System.Drawing.Point(16, 120);
            this.lblNuevoGrupo.Name = "lblNuevoGrupo";
            this.lblNuevoGrupo.Size = new System.Drawing.Size(149, 23);
            this.lblNuevoGrupo.TabIndex = 21;
            this.lblNuevoGrupo.Text = "Nuevo Grupo";
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
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(19, 225);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(292, 20);
            this.txtNombreGrupo.TabIndex = 16;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.Location = new System.Drawing.Point(16, 185);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(129, 16);
            this.lblNombreGrupo.TabIndex = 15;
            this.lblNombreGrupo.Text = "Nombre del Grupo:";
            // 
            // FormAgregarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.lblNuevoGrupo);
            this.Controls.Add(this.btnCancelarAdicion);
            this.Controls.Add(this.btnConfirmarAdicion);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.lblNombreGrupo);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Label lblNuevoGrupo;
        private System.Windows.Forms.Button btnCancelarAdicion;
        private System.Windows.Forms.Button btnConfirmarAdicion;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
    }
}