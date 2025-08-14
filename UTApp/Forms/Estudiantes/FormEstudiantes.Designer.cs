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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EstudianteMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstudianteApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstudianteGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCatálogoMaterias = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.pbEditarEstudiante = new System.Windows.Forms.PictureBox();
            this.pbEliminarEstudiante = new System.Windows.Forms.PictureBox();
            this.pbAgregarEstudiante = new System.Windows.Forms.PictureBox();
            this.botonOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstudianteMatricula,
            this.EstudianteApellido,
            this.EstudianteGrupo});
            this.dataGridView1.Location = new System.Drawing.Point(17, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(310, 385);
            this.dataGridView1.TabIndex = 16;
            // 
            // EstudianteMatricula
            // 
            this.EstudianteMatricula.HeaderText = "Matrícula";
            this.EstudianteMatricula.Name = "EstudianteMatricula";
            this.EstudianteMatricula.Width = 75;
            // 
            // EstudianteApellido
            // 
            this.EstudianteApellido.HeaderText = "Apellido";
            this.EstudianteApellido.Name = "EstudianteApellido";
            this.EstudianteApellido.Width = 160;
            // 
            // EstudianteGrupo
            // 
            this.EstudianteGrupo.HeaderText = "Grupo";
            this.EstudianteGrupo.Name = "EstudianteGrupo";
            this.EstudianteGrupo.Width = 55;
            // 
            // labelCatálogoMaterias
            // 
            this.labelCatálogoMaterias.AutoSize = true;
            this.labelCatálogoMaterias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatálogoMaterias.ForeColor = System.Drawing.Color.Black;
            this.labelCatálogoMaterias.Location = new System.Drawing.Point(21, 123);
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
            this.labelMaterias.Location = new System.Drawing.Point(101, 45);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(134, 25);
            this.labelMaterias.TabIndex = 0;
            this.labelMaterias.Text = "Estudiantes";
            // 
            // pbEditarEstudiante
            // 
            this.pbEditarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarEstudiante.Image = global::UTApp.Properties.Resources.scan;
            this.pbEditarEstudiante.Location = new System.Drawing.Point(255, 563);
            this.pbEditarEstudiante.Name = "pbEditarEstudiante";
            this.pbEditarEstudiante.Size = new System.Drawing.Size(33, 33);
            this.pbEditarEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarEstudiante.TabIndex = 18;
            this.pbEditarEstudiante.TabStop = false;
            // 
            // pbEliminarEstudiante
            // 
            this.pbEliminarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminarEstudiante.Image = global::UTApp.Properties.Resources.pen;
            this.pbEliminarEstudiante.Location = new System.Drawing.Point(216, 563);
            this.pbEliminarEstudiante.Name = "pbEliminarEstudiante";
            this.pbEliminarEstudiante.Size = new System.Drawing.Size(33, 33);
            this.pbEliminarEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarEstudiante.TabIndex = 17;
            this.pbEliminarEstudiante.TabStop = false;
            // 
            // pbAgregarEstudiante
            // 
            this.pbAgregarEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregarEstudiante.Image = global::UTApp.Properties.Resources.delete;
            this.pbAgregarEstudiante.Location = new System.Drawing.Point(294, 564);
            this.pbAgregarEstudiante.Name = "pbAgregarEstudiante";
            this.pbAgregarEstudiante.Size = new System.Drawing.Size(33, 33);
            this.pbAgregarEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregarEstudiante.TabIndex = 15;
            this.pbAgregarEstudiante.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::UTApp.Properties.Resources.square;
            this.pictureBox1.Location = new System.Drawing.Point(177, 563);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbEditarEstudiante);
            this.Controls.Add(this.pbEliminarEstudiante);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbAgregarEstudiante);
            this.Controls.Add(this.labelCatálogoMaterias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEditarEstudiante;
        private System.Windows.Forms.PictureBox pbEliminarEstudiante;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteGrupo;
        private System.Windows.Forms.PictureBox pbAgregarEstudiante;
        private System.Windows.Forms.Label labelCatálogoMaterias;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox botonOpciones;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}