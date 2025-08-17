namespace UTApp.Forms.Estudiantes
{
    partial class FormEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiantes));
            this.gridEstudiantes = new System.Windows.Forms.DataGridView();
            this.EstudianteMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstudianteNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.botonOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEstudiantes
            // 
            this.gridEstudiantes.AllowUserToAddRows = false;
            this.gridEstudiantes.AllowUserToDeleteRows = false;
            this.gridEstudiantes.AllowUserToResizeRows = false;
            this.gridEstudiantes.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.gridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstudianteMatricula,
            this.EstudianteNombreCompleto});
            this.gridEstudiantes.Location = new System.Drawing.Point(17, 170);
            this.gridEstudiantes.MultiSelect = false;
            this.gridEstudiantes.Name = "gridEstudiantes";
            this.gridEstudiantes.ReadOnly = true;
            this.gridEstudiantes.RowHeadersVisible = false;
            this.gridEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEstudiantes.Size = new System.Drawing.Size(310, 385);
            this.gridEstudiantes.TabIndex = 16;
            this.gridEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEstudiantes_CellContentClick);
            // 
            // EstudianteMatricula
            // 
            this.EstudianteMatricula.DataPropertyName = "EstudianteMatricula";
            this.EstudianteMatricula.HeaderText = "Matrícula";
            this.EstudianteMatricula.MaxInputLength = 10;
            this.EstudianteMatricula.Name = "EstudianteMatricula";
            this.EstudianteMatricula.ReadOnly = true;
            this.EstudianteMatricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EstudianteMatricula.Width = 80;
            // 
            // EstudianteNombreCompleto
            // 
            this.EstudianteNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstudianteNombreCompleto.DataPropertyName = "EstudianteNombreCompleto";
            this.EstudianteNombreCompleto.HeaderText = "Nombre";
            this.EstudianteNombreCompleto.MinimumWidth = 20;
            this.EstudianteNombreCompleto.Name = "EstudianteNombreCompleto";
            this.EstudianteNombreCompleto.ReadOnly = true;
            this.EstudianteNombreCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(20, 120);
            this.labelCatálogoMaterias.Name = "labelCatálogoMaterias";
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(105, 23);
            this.labelCatálogoMaterias.TabIndex = 14;
            this.labelCatálogoMaterias.Text = "Catálogo";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.botonOpciones);
            this.panelHeader.Controls.Add(this.pbRegresar);
            this.panelHeader.Controls.Add(this.labelMaterias);
            this.panelHeader.Location = new System.Drawing.Point(1, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(343, 94);
            this.panelHeader.TabIndex = 13;
            // 
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterias.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterias.ForeColor = System.Drawing.Color.White;
            this.labelMaterias.Location = new System.Drawing.Point(110, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(134, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Estudiantes";
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::UTApp.Properties.Resources.scan;
            this.pbBuscar.Location = new System.Drawing.Point(294, 113);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(33, 33);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 27;
            this.pbBuscar.TabStop = false;
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = global::UTApp.Properties.Resources.edit;
            this.pbEditar.Location = new System.Drawing.Point(255, 563);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(33, 33);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 18;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbAgregar
            // 
            this.pbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregar.Image = global::UTApp.Properties.Resources.add;
            this.pbAgregar.Location = new System.Drawing.Point(216, 563);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(33, 33);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregar.TabIndex = 17;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.pbAgregar_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminar.Image = global::UTApp.Properties.Resources.delete;
            this.pbEliminar.Location = new System.Drawing.Point(294, 564);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(33, 33);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminar.TabIndex = 15;
            this.pbEliminar.TabStop = false;
            // 
            // botonOpciones
            // 
            this.botonOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonOpciones.Image = global::UTApp.Properties.Resources.dots;
            this.botonOpciones.Location = new System.Drawing.Point(293, 46);
            this.botonOpciones.Name = "botonOpciones";
            this.botonOpciones.Size = new System.Drawing.Size(23, 24);
            this.botonOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonOpciones.TabIndex = 2;
            this.botonOpciones.TabStop = false;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegresar.Image = global::UTApp.Properties.Resources.left_chevron;
            this.pbRegresar.Location = new System.Drawing.Point(25, 30);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(25, 40);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegresar.TabIndex = 1;
            this.pbRegresar.TabStop = false;
            // 
            // FormEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbAgregar);
            this.Controls.Add(this.gridEstudiantes);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEstudiantes_FormClosed);
            this.Load += new System.EventHandler(this.FormEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.DataGridView gridEstudiantes;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonOpciones;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteNombreCompleto;
    }
}