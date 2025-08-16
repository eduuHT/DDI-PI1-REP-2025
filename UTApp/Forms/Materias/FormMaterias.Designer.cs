namespace UTApp.Forms.Materias
{
    partial class FormMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterias));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.gridMaterias = new System.Windows.Forms.DataGridView();
            this.MateriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
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
            this.panelHeader.TabIndex = 1;
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
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.Black;
            this.lblCatalogo.Location = new System.Drawing.Point(16, 126);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(105, 23);
            this.lblCatalogo.TabIndex = 2;
            this.lblCatalogo.Text = "Catálogo";
            // 
            // gridMaterias
            // 
            this.gridMaterias.AllowUserToAddRows = false;
            this.gridMaterias.AllowUserToDeleteRows = false;
            this.gridMaterias.AllowUserToResizeRows = false;
            this.gridMaterias.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.gridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaID,
            this.MateriaNombre});
            this.gridMaterias.Location = new System.Drawing.Point(12, 202);
            this.gridMaterias.Name = "gridMaterias";
            this.gridMaterias.RowHeadersVisible = false;
            this.gridMaterias.Size = new System.Drawing.Size(320, 350);
            this.gridMaterias.TabIndex = 6;
            // 
            // MateriaID
            // 
            this.MateriaID.HeaderText = "ID";
            this.MateriaID.Name = "MateriaID";
            this.MateriaID.Width = 50;
            // 
            // MateriaNombre
            // 
            this.MateriaNombre.HeaderText = "Nombre";
            this.MateriaNombre.Name = "MateriaNombre";
            this.MateriaNombre.Width = 500;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = global::UTApp.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(260, 558);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(33, 33);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 10;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::UTApp.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(221, 558);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 33);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::UTApp.Properties.Resources.add;
            this.btnAgregar.Location = new System.Drawing.Point(299, 558);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 33);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::UTApp.Properties.Resources.scan;
            this.btnBuscar.Location = new System.Drawing.Point(299, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 163);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(281, 20);
            this.txtBusqueda.TabIndex = 12;
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridMaterias);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.DataGridView gridMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaNombre;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}