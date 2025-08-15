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
            this.labelMaterias = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.PictureBox();
            this.labelEditarMateria = new System.Windows.Forms.Label();
            this.buttonCancelarEdicionMateria = new System.Windows.Forms.Button();
            this.buttonEditarMateria = new System.Windows.Forms.Button();
            this.textBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.labelNuevoNombre = new System.Windows.Forms.Label();
            this.textBoxIDMateriaEditada = new System.Windows.Forms.TextBox();
            this.labelIDMateriaEditada = new System.Windows.Forms.Label();
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
            // labelEditarMateria
            // 
            this.labelEditarMateria.AutoSize = true;
            this.labelEditarMateria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarMateria.ForeColor = System.Drawing.Color.Black;
            this.labelEditarMateria.Location = new System.Drawing.Point(16, 120);
            this.labelEditarMateria.Name = "labelEditarMateria";
            this.labelEditarMateria.Size = new System.Drawing.Size(163, 23);
            this.labelEditarMateria.TabIndex = 26;
            this.labelEditarMateria.Text = "Editar Materia";
            // 
            // buttonCancelarEdicionMateria
            // 
            this.buttonCancelarEdicionMateria.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelarEdicionMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarEdicionMateria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarEdicionMateria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelarEdicionMateria.Location = new System.Drawing.Point(11, 550);
            this.buttonCancelarEdicionMateria.Name = "buttonCancelarEdicionMateria";
            this.buttonCancelarEdicionMateria.Size = new System.Drawing.Size(150, 40);
            this.buttonCancelarEdicionMateria.TabIndex = 25;
            this.buttonCancelarEdicionMateria.Text = "Cancelar";
            this.buttonCancelarEdicionMateria.UseVisualStyleBackColor = false;
            // 
            // buttonEditarMateria
            // 
            this.buttonEditarMateria.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonEditarMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarMateria.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarMateria.Location = new System.Drawing.Point(182, 550);
            this.buttonEditarMateria.Name = "buttonEditarMateria";
            this.buttonEditarMateria.Size = new System.Drawing.Size(150, 40);
            this.buttonEditarMateria.TabIndex = 24;
            this.buttonEditarMateria.Text = "Editar";
            this.buttonEditarMateria.UseVisualStyleBackColor = false;
            // 
            // textBoxNuevoNombre
            // 
            this.textBoxNuevoNombre.Location = new System.Drawing.Point(20, 296);
            this.textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            this.textBoxNuevoNombre.Size = new System.Drawing.Size(312, 20);
            this.textBoxNuevoNombre.TabIndex = 23;
            // 
            // labelNuevoNombre
            // 
            this.labelNuevoNombre.AutoSize = true;
            this.labelNuevoNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoNombre.Location = new System.Drawing.Point(17, 263);
            this.labelNuevoNombre.Name = "labelNuevoNombre";
            this.labelNuevoNombre.Size = new System.Drawing.Size(105, 14);
            this.labelNuevoNombre.TabIndex = 22;
            this.labelNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // textBoxIDMateriaEditada
            // 
            this.textBoxIDMateriaEditada.Location = new System.Drawing.Point(197, 190);
            this.textBoxIDMateriaEditada.Name = "textBoxIDMateriaEditada";
            this.textBoxIDMateriaEditada.Size = new System.Drawing.Size(135, 20);
            this.textBoxIDMateriaEditada.TabIndex = 17;
            // 
            // labelIDMateriaEditada
            // 
            this.labelIDMateriaEditada.AutoSize = true;
            this.labelIDMateriaEditada.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMateriaEditada.Location = new System.Drawing.Point(17, 191);
            this.labelIDMateriaEditada.Name = "labelIDMateriaEditada";
            this.labelIDMateriaEditada.Size = new System.Drawing.Size(172, 16);
            this.labelIDMateriaEditada.TabIndex = 16;
            this.labelIDMateriaEditada.Text = "ID de la Materia editada:";
            // 
            // FormEditarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.labelEditarMateria);
            this.Controls.Add(this.buttonCancelarEdicionMateria);
            this.Controls.Add(this.buttonEditarMateria);
            this.Controls.Add(this.textBoxNuevoNombre);
            this.Controls.Add(this.labelNuevoNombre);
            this.Controls.Add(this.textBoxIDMateriaEditada);
            this.Controls.Add(this.labelIDMateriaEditada);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarMateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Materia";
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
        private System.Windows.Forms.Label labelEditarMateria;
        private System.Windows.Forms.Button buttonCancelarEdicionMateria;
        private System.Windows.Forms.Button buttonEditarMateria;
        private System.Windows.Forms.TextBox textBoxNuevoNombre;
        private System.Windows.Forms.Label labelNuevoNombre;
        private System.Windows.Forms.TextBox textBoxIDMateriaEditada;
        private System.Windows.Forms.Label labelIDMateriaEditada;
    }
}