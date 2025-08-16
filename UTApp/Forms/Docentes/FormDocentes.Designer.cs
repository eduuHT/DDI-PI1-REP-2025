namespace UTApp.Forms.Docentes
{
    partial class FormDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocentes));
            this.gridDocentes = new System.Windows.Forms.DataGridView();
            this.DocenteNumeroEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocenteNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.botonOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocentes)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDocentes
            // 
            this.gridDocentes.AllowUserToAddRows = false;
            this.gridDocentes.AllowUserToDeleteRows = false;
            this.gridDocentes.AllowUserToResizeRows = false;
            this.gridDocentes.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.gridDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocenteNumeroEmpleado,
            this.DocenteNombreCompleto});
            this.gridDocentes.Location = new System.Drawing.Point(17, 170);
            this.gridDocentes.MultiSelect = false;
            this.gridDocentes.Name = "gridDocentes";
            this.gridDocentes.ReadOnly = true;
            this.gridDocentes.RowHeadersVisible = false;
            this.gridDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDocentes.Size = new System.Drawing.Size(310, 385);
            this.gridDocentes.TabIndex = 23;
            // 
            // DocenteNumeroEmpleado
            // 
            this.DocenteNumeroEmpleado.DataPropertyName = "DocenteNumeroEmpleado";
            this.DocenteNumeroEmpleado.HeaderText = "Empleado";
            this.DocenteNumeroEmpleado.MaxInputLength = 4;
            this.DocenteNumeroEmpleado.Name = "DocenteNumeroEmpleado";
            this.DocenteNumeroEmpleado.ReadOnly = true;
            this.DocenteNumeroEmpleado.Width = 80;
            // 
            // DocenteNombreCompleto
            // 
            this.DocenteNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocenteNombreCompleto.DataPropertyName = "DocenteNombreCompleto";
            this.DocenteNombreCompleto.HeaderText = "Nombre";
            this.DocenteNombreCompleto.MaxInputLength = 200;
            this.DocenteNombreCompleto.Name = "DocenteNombreCompleto";
            this.DocenteNombreCompleto.ReadOnly = true;
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(20, 120);
            this.labelCatálogoMaterias.Name = "labelCatálogoMaterias";
            this.labelCatálogoMaterias.Size = new System.Drawing.Size(105, 23);
            this.labelCatálogoMaterias.TabIndex = 21;
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
            this.panelHeader.TabIndex = 20;
            // 
            // botonOpciones
            // 
            this.botonOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterias.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterias.ForeColor = System.Drawing.Color.White;
            this.labelMaterias.Location = new System.Drawing.Point(119, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(110, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Docentes";
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::UTApp.Properties.Resources.scan;
            this.pbBuscar.Location = new System.Drawing.Point(294, 113);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(33, 33);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 26;
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
            this.pbEditar.TabIndex = 25;
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
            this.pbAgregar.TabIndex = 24;
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
            this.pbEliminar.TabIndex = 22;
            this.pbEliminar.TabStop = false;
            // 
            // FormDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbAgregar);
            this.Controls.Add(this.gridDocentes);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDocentes_FormClosed);
            this.Load += new System.EventHandler(this.FormDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDocentes)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.DataGridView gridDocentes;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonOpciones;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocenteNumeroEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocenteNombreCompleto;
    }
}