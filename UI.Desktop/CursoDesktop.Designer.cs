namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboxIDComision = new System.Windows.Forms.ComboBox();
            this.lblIDComision = new System.Windows.Forms.Label();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.cboxIDMateria = new System.Windows.Forms.ComboBox();
            this.cboxAnioCalendario = new System.Windows.Forms.ComboBox();
            this.academiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.materiasTableAdapter();
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comisionesTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.comisionesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txtCupo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioCalendario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboxIDComision, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDComision, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDMateria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboxIDMateria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboxAnioCalendario, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 272);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtCupo
            // 
            this.txtCupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCupo.Location = new System.Drawing.Point(516, 165);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(254, 20);
            this.txtCupo.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(3, 162);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(79, 13);
            this.lblAnioCalendario.TabIndex = 2;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(388, 162);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 6;
            this.lblCupo.Text = "Cupo";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(131, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(251, 20);
            this.txtID.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(388, 246);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(516, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboxIDComision
            // 
            this.cboxIDComision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comisionesBindingSource, "id_comision", true));
            this.cboxIDComision.DataSource = this.comisionesBindingSource;
            this.cboxIDComision.DisplayMember = "id_comision";
            this.cboxIDComision.FormattingEnabled = true;
            this.cboxIDComision.Location = new System.Drawing.Point(516, 84);
            this.cboxIDComision.Name = "cboxIDComision";
            this.cboxIDComision.Size = new System.Drawing.Size(121, 21);
            this.cboxIDComision.TabIndex = 19;
            this.cboxIDComision.ValueMember = "id_comision";
            // 
            // lblIDComision
            // 
            this.lblIDComision.AutoSize = true;
            this.lblIDComision.Location = new System.Drawing.Point(388, 81);
            this.lblIDComision.Name = "lblIDComision";
            this.lblIDComision.Size = new System.Drawing.Size(63, 13);
            this.lblIDComision.TabIndex = 1;
            this.lblIDComision.Text = "ID Comisión";
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(3, 81);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(56, 13);
            this.lblIDMateria.TabIndex = 3;
            this.lblIDMateria.Text = "ID Materia";
            // 
            // cboxIDMateria
            // 
            this.cboxIDMateria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materiasBindingSource, "id_materia", true));
            this.cboxIDMateria.DataSource = this.materiasBindingSource;
            this.cboxIDMateria.DisplayMember = "id_materia";
            this.cboxIDMateria.FormattingEnabled = true;
            this.cboxIDMateria.Location = new System.Drawing.Point(131, 84);
            this.cboxIDMateria.Name = "cboxIDMateria";
            this.cboxIDMateria.Size = new System.Drawing.Size(121, 21);
            this.cboxIDMateria.TabIndex = 18;
            this.cboxIDMateria.ValueMember = "id_materia";
            // 
            // cboxAnioCalendario
            // 
            this.cboxAnioCalendario.FormattingEnabled = true;
            this.cboxAnioCalendario.Location = new System.Drawing.Point(131, 165);
            this.cboxAnioCalendario.Name = "cboxAnioCalendario";
            this.cboxAnioCalendario.Size = new System.Drawing.Size(121, 21);
            this.cboxAnioCalendario.TabIndex = 20;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.academiaDataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "comisiones";
            this.comisionesBindingSource.DataSource = this.academiaDataSet;
            // 
            // comisionesTableAdapter
            // 
            this.comisionesTableAdapter.ClearBeforeFill = true;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(773, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDComision;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.ComboBox cboxIDMateria;
        private System.Windows.Forms.ComboBox cboxIDComision;
        private System.Windows.Forms.ComboBox cboxAnioCalendario;
        private AcademiaDataSet academiaDataSet;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private AcademiaDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
        private AcademiaDataSetTableAdapters.comisionesTableAdapter comisionesTableAdapter;
    }
}
