namespace UI.Desktop
{
    partial class PersonaDesktop
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.DTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPersona = new System.Windows.Forms.ComboBox();
            this.comboBoxIDPlan = new System.Windows.Forms.ComboBox();
            this.planesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._AcademiaDataSet_NOEXPRESS_ = new UI.Desktop._AcademiaDataSet_NOEXPRESS_();
            this.planesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.planesTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.planesTableAdapter();
            this.planesTableAdapter1 = new UI.Desktop._AcademiaDataSet_NOEXPRESS_TableAdapters.planesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AcademiaDataSet_NOEXPRESS_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.txtDireccion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDireccion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoPersona, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIDPlan, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNombre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textApellido, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaNac, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DTPFechaNac, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLegajo, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxTipoPersona, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxIDPlan, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefono, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 370);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(94, 116);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(177, 20);
            this.txtDireccion.TabIndex = 10;
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
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 113);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(3, 226);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(70, 13);
            this.lblTipoPersona.TabIndex = 2;
            this.lblTipoPersona.Text = "Tipo Persona";
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Location = new System.Drawing.Point(277, 226);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(42, 13);
            this.lblIDPlan.TabIndex = 6;
            this.lblIDPlan.Text = "ID Plan";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(94, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(177, 20);
            this.txtID.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(277, 342);
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
            this.btnCancelar.Location = new System.Drawing.Point(368, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(277, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(368, 3);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 18;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(551, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(649, 3);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 20;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(277, 113);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(60, 26);
            this.lblFechaNac.TabIndex = 21;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // DTPFechaNac
            // 
            this.DTPFechaNac.Location = new System.Drawing.Point(368, 116);
            this.DTPFechaNac.Name = "DTPFechaNac";
            this.DTPFechaNac.Size = new System.Drawing.Size(177, 20);
            this.DTPFechaNac.TabIndex = 22;
            this.DTPFechaNac.ValueChanged += new System.EventHandler(this.DTPFechaNac_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(649, 116);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 24;
            // 
            // comboBoxTipoPersona
            // 
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(94, 229);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoPersona.TabIndex = 25;
            // 
            // comboBoxIDPlan
            // 
            this.comboBoxIDPlan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planesBindingSource2, "id_plan", true));
            this.comboBoxIDPlan.DataSource = this.planesBindingSource1;
            this.comboBoxIDPlan.DisplayMember = "desc_plan";
            this.comboBoxIDPlan.FormattingEnabled = true;
            this.comboBoxIDPlan.Location = new System.Drawing.Point(368, 229);
            this.comboBoxIDPlan.Name = "comboBoxIDPlan";
            this.comboBoxIDPlan.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIDPlan.TabIndex = 26;
            // 
            // planesBindingSource2
            // 
            this.planesBindingSource2.DataMember = "planes";
            this.planesBindingSource2.DataSource = this._AcademiaDataSet_NOEXPRESS_;
            // 
            // _AcademiaDataSet_NOEXPRESS_
            // 
            this._AcademiaDataSet_NOEXPRESS_.DataSetName = "AcademiaDataSet(NOEXPRESS)";
            this._AcademiaDataSet_NOEXPRESS_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource1
            // 
            this.planesBindingSource1.DataMember = "planes";
            this.planesBindingSource1.DataSource = this._AcademiaDataSet_NOEXPRESS_;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(551, 226);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(649, 229);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(8, 20);
            this.txtTelefono.TabIndex = 28;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.academiaDataSet;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // planesTableAdapter1
            // 
            this.planesTableAdapter1.ClearBeforeFill = true;
            // 
            // PersonaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonaDesktop";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.PersonaDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AcademiaDataSet_NOEXPRESS_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private AcademiaDataSet academiaDataSet;
        private AcademiaDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker DTPFechaNac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox comboBoxTipoPersona;
        private System.Windows.Forms.ComboBox comboBoxIDPlan;
        private _AcademiaDataSet_NOEXPRESS_ _AcademiaDataSet_NOEXPRESS_;
        private System.Windows.Forms.BindingSource planesBindingSource1;
        private _AcademiaDataSet_NOEXPRESS_TableAdapters.planesTableAdapter planesTableAdapter1;
        private System.Windows.Forms.BindingSource planesBindingSource2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}