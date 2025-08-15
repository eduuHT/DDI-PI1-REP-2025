namespace UTApp.Forms.Grupos
{
    partial class FormGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupos));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.botonRegresar = new System.Windows.Forms.PictureBox();
            this.labelGrupos = new System.Windows.Forms.Label();
            this.labelCatálogo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.GrupoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxEditar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAgregar = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).BeginInit();
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
            this.panelHeader.TabIndex = 1;
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
            // labelCatálogo
            // 
            this.labelCatálogo.AutoSize = true;
            this.labelCatálogo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogo.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogo.Location = new System.Drawing.Point(16, 120);
            this.labelCatálogo.Name = "labelCatálogo";
            this.labelCatálogo.Size = new System.Drawing.Size(105, 23);
            this.labelCatálogo.TabIndex = 2;
            this.labelCatálogo.Text = "Catálogo";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupoID,
            this.GrupoNombre});
            this.dataGridView.Location = new System.Drawing.Point(12, 167);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(320, 385);
            this.dataGridView.TabIndex = 6;
            // 
            // GrupoID
            // 
            this.GrupoID.HeaderText = "ID";
            this.GrupoID.Name = "GrupoID";
            this.GrupoID.Width = 75;
            // 
            // GrupoNombre
            // 
            this.GrupoNombre.HeaderText = "Nombre";
            this.GrupoNombre.Name = "GrupoNombre";
            this.GrupoNombre.Width = 240;
            // 
            // pictureBoxEditar
            // 
            this.pictureBoxEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEditar.Image = global::UTApp.Properties.Resources.edit;
            this.pictureBoxEditar.Location = new System.Drawing.Point(260, 558);
            this.pictureBoxEditar.Name = "pictureBoxEditar";
            this.pictureBoxEditar.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEditar.TabIndex = 10;
            this.pictureBoxEditar.TabStop = false;
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEliminar.Image = global::UTApp.Properties.Resources.delete;
            this.pictureBoxEliminar.Location = new System.Drawing.Point(221, 558);
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEliminar.TabIndex = 9;
            this.pictureBoxEliminar.TabStop = false;
            // 
            // pictureBoxAgregar
            // 
            this.pictureBoxAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAgregar.Image = global::UTApp.Properties.Resources.add;
            this.pictureBoxAgregar.Location = new System.Drawing.Point(299, 558);
            this.pictureBoxAgregar.Name = "pictureBoxAgregar";
            this.pictureBoxAgregar.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAgregar.TabIndex = 8;
            this.pictureBoxAgregar.TabStop = false;
            // 
            // FormGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.pictureBoxEditar);
            this.Controls.Add(this.pictureBoxEliminar);
            this.Controls.Add(this.pictureBoxAgregar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelCatálogo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonRegresar;
        private System.Windows.Forms.Label labelGrupos;
        private System.Windows.Forms.Label labelCatálogo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoNombre;
        private System.Windows.Forms.PictureBox pictureBoxEditar;
        private System.Windows.Forms.PictureBox pictureBoxEliminar;
        private System.Windows.Forms.PictureBox pictureBoxAgregar;
    }
}