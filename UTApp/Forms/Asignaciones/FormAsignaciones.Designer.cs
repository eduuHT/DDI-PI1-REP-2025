namespace UTApp.Forms.Asignaciones
{
    partial class FormAsignaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignaciones));
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblAsignaciones = new System.Windows.Forms.Label();
            this.gridAsignaciones = new System.Windows.Forms.DataGridView();
            this.btnScan = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.uTApp_Integradora1DataSet = new UTApp.UTApp_Integradora1DataSet();
            this.asignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionTableAdapter = new UTApp.UTApp_Integradora1DataSetTableAdapters.AsignacionTableAdapter();
            this.asignacionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacionTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacionDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacionFechaLimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataformaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTApp_Integradora1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlBanner.Controls.Add(this.btnBack);
            this.pnlBanner.Controls.Add(this.lblAsignaciones);
            this.pnlBanner.Location = new System.Drawing.Point(-1, -2);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(356, 92);
            this.pnlBanner.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::UTApp.Properties.Resources.left_chevron;
            this.btnBack.Location = new System.Drawing.Point(13, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAsignaciones
            // 
            this.lblAsignaciones.AutoSize = true;
            this.lblAsignaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaciones.ForeColor = System.Drawing.Color.White;
            this.lblAsignaciones.Location = new System.Drawing.Point(94, 26);
            this.lblAsignaciones.Name = "lblAsignaciones";
            this.lblAsignaciones.Size = new System.Drawing.Size(178, 37);
            this.lblAsignaciones.TabIndex = 0;
            this.lblAsignaciones.Text = "Asignaciones";
            // 
            // gridAsignaciones
            // 
            this.gridAsignaciones.AllowUserToAddRows = false;
            this.gridAsignaciones.AllowUserToDeleteRows = false;
            this.gridAsignaciones.AllowUserToResizeColumns = false;
            this.gridAsignaciones.AllowUserToResizeRows = false;
            this.gridAsignaciones.AutoGenerateColumns = false;
            this.gridAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asignacionIDDataGridViewTextBoxColumn,
            this.asignacionTituloDataGridViewTextBoxColumn,
            this.asignacionDescripcionDataGridViewTextBoxColumn,
            this.asignacionFechaLimiteDataGridViewTextBoxColumn,
            this.plataformaIDDataGridViewTextBoxColumn,
            this.claseIDDataGridViewTextBoxColumn});
            this.gridAsignaciones.DataSource = this.asignacionBindingSource;
            this.gridAsignaciones.Location = new System.Drawing.Point(-1, 129);
            this.gridAsignaciones.MultiSelect = false;
            this.gridAsignaciones.Name = "gridAsignaciones";
            this.gridAsignaciones.ReadOnly = true;
            this.gridAsignaciones.RowHeadersVisible = false;
            this.gridAsignaciones.Size = new System.Drawing.Size(345, 404);
            this.gridAsignaciones.TabIndex = 2;
            // 
            // btnScan
            // 
            this.btnScan.Image = global::UTApp.Properties.Resources.scan;
            this.btnScan.Location = new System.Drawing.Point(269, 539);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(49, 50);
            this.btnScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnScan.TabIndex = 6;
            this.btnScan.TabStop = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::UTApp.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(214, 539);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 50);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::UTApp.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(159, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 50);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::UTApp.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(104, 539);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 50);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // uTApp_Integradora1DataSet
            // 
            this.uTApp_Integradora1DataSet.DataSetName = "UTApp_Integradora1DataSet";
            this.uTApp_Integradora1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignacionBindingSource
            // 
            this.asignacionBindingSource.DataMember = "Asignacion";
            this.asignacionBindingSource.DataSource = this.uTApp_Integradora1DataSet;
            // 
            // asignacionTableAdapter
            // 
            this.asignacionTableAdapter.ClearBeforeFill = true;
            // 
            // asignacionIDDataGridViewTextBoxColumn
            // 
            this.asignacionIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.asignacionIDDataGridViewTextBoxColumn.DataPropertyName = "AsignacionID";
            this.asignacionIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.asignacionIDDataGridViewTextBoxColumn.Name = "asignacionIDDataGridViewTextBoxColumn";
            this.asignacionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.asignacionIDDataGridViewTextBoxColumn.Width = 43;
            // 
            // asignacionTituloDataGridViewTextBoxColumn
            // 
            this.asignacionTituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asignacionTituloDataGridViewTextBoxColumn.DataPropertyName = "AsignacionTitulo";
            this.asignacionTituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.asignacionTituloDataGridViewTextBoxColumn.Name = "asignacionTituloDataGridViewTextBoxColumn";
            this.asignacionTituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignacionDescripcionDataGridViewTextBoxColumn
            // 
            this.asignacionDescripcionDataGridViewTextBoxColumn.DataPropertyName = "AsignacionDescripcion";
            this.asignacionDescripcionDataGridViewTextBoxColumn.HeaderText = "AsignacionDescripcion";
            this.asignacionDescripcionDataGridViewTextBoxColumn.Name = "asignacionDescripcionDataGridViewTextBoxColumn";
            this.asignacionDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.asignacionDescripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // asignacionFechaLimiteDataGridViewTextBoxColumn
            // 
            this.asignacionFechaLimiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asignacionFechaLimiteDataGridViewTextBoxColumn.DataPropertyName = "AsignacionFechaLimite";
            this.asignacionFechaLimiteDataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.asignacionFechaLimiteDataGridViewTextBoxColumn.Name = "asignacionFechaLimiteDataGridViewTextBoxColumn";
            this.asignacionFechaLimiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataformaIDDataGridViewTextBoxColumn
            // 
            this.plataformaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plataformaIDDataGridViewTextBoxColumn.DataPropertyName = "PlataformaID";
            this.plataformaIDDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.plataformaIDDataGridViewTextBoxColumn.Name = "plataformaIDDataGridViewTextBoxColumn";
            this.plataformaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claseIDDataGridViewTextBoxColumn
            // 
            this.claseIDDataGridViewTextBoxColumn.DataPropertyName = "ClaseID";
            this.claseIDDataGridViewTextBoxColumn.HeaderText = "Clase";
            this.claseIDDataGridViewTextBoxColumn.Name = "claseIDDataGridViewTextBoxColumn";
            this.claseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridAsignaciones);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAsignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAsignaciones_FormClosed);
            this.Load += new System.EventHandler(this.FormAsignaciones_Load);
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTApp_Integradora1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblAsignaciones;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnScan;
        private System.Windows.Forms.DataGridView gridAsignaciones;
        private UTApp_Integradora1DataSet uTApp_Integradora1DataSet;
        private System.Windows.Forms.BindingSource asignacionBindingSource;
        private UTApp_Integradora1DataSetTableAdapters.AsignacionTableAdapter asignacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignacionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignacionTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignacionDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignacionFechaLimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataformaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseIDDataGridViewTextBoxColumn;
    }
}