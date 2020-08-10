namespace UI.Desktop
{
    partial class AlumnoInscripcionDesktop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxIDAlumno = new System.Windows.Forms.ComboBox();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AcademiaDataSet_NOEXPRESS_ = new UI.Desktop._AcademiaDataSet_NOEXPRESS_();
            this.cbxIDCurso = new System.Windows.Forms.ComboBox();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.personasTableAdapter = new UI.Desktop._AcademiaDataSet_NOEXPRESS_TableAdapters.personasTableAdapter();
            this.cursosTableAdapter = new UI.Desktop._AcademiaDataSet_NOEXPRESS_TableAdapters.cursosTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AcademiaDataSet_NOEXPRESS_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.13726F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.86274F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxIDAlumno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxIDCurso, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCondicion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNota, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.34123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.65877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Curso";
            // 
            // cbxIDAlumno
            // 
            this.cbxIDAlumno.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personasBindingSource, "id_persona", true));
            this.cbxIDAlumno.DataSource = this.personasBindingSource;
            this.cbxIDAlumno.DisplayMember = "id_persona";
            this.cbxIDAlumno.FormattingEnabled = true;
            this.cbxIDAlumno.Location = new System.Drawing.Point(113, 112);
            this.cbxIDAlumno.Name = "cbxIDAlumno";
            this.cbxIDAlumno.Size = new System.Drawing.Size(121, 21);
            this.cbxIDAlumno.TabIndex = 3;
            this.cbxIDAlumno.ValueMember = "id_persona";
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "personas";
            this.personasBindingSource.DataSource = this._AcademiaDataSet_NOEXPRESS_;
            // 
            // _AcademiaDataSet_NOEXPRESS_
            // 
            this._AcademiaDataSet_NOEXPRESS_.DataSetName = "AcademiaDataSet(NOEXPRESS)";
            this._AcademiaDataSet_NOEXPRESS_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxIDCurso
            // 
            this.cbxIDCurso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cursosBindingSource, "id_curso", true));
            this.cbxIDCurso.DataSource = this.cursosBindingSource;
            this.cbxIDCurso.DisplayMember = "id_curso";
            this.cbxIDCurso.FormattingEnabled = true;
            this.cbxIDCurso.Location = new System.Drawing.Point(378, 112);
            this.cbxIDCurso.Name = "cbxIDCurso";
            this.cbxIDCurso.Size = new System.Drawing.Size(121, 21);
            this.cbxIDCurso.TabIndex = 4;
            this.cbxIDCurso.ValueMember = "id_curso";
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this._AcademiaDataSet_NOEXPRESS_;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Condicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(113, 228);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion.TabIndex = 7;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(378, 228);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(258, 347);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(378, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 11;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // AlumnoInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(520, 383);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlumnoInscripcionDesktop";
            this.Text = "";
            this.Load += new System.EventHandler(this.AlumnoInscripcion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AcademiaDataSet_NOEXPRESS_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxIDAlumno;
        private System.Windows.Forms.ComboBox cbxIDCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtID;
        private _AcademiaDataSet_NOEXPRESS_ _AcademiaDataSet_NOEXPRESS_;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private _AcademiaDataSet_NOEXPRESS_TableAdapters.personasTableAdapter personasTableAdapter;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private _AcademiaDataSet_NOEXPRESS_TableAdapters.cursosTableAdapter cursosTableAdapter;
    }
}
