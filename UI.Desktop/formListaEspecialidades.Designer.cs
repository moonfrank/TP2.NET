namespace UI.Desktop
{
    partial class formListaEspecialidades
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
            this.tcEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.idespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsEspecialidades = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.especialidadesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.especialidadesTableAdapter();
            this.tcEspecialidades.ContentPanel.SuspendLayout();
            this.tcEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tcEspecialidades.SuspendLayout();
            this.tlEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            this.tsEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEspecialidades
            // 
            // 
            // tcEspecialidades.ContentPanel
            // 
            this.tcEspecialidades.ContentPanel.Controls.Add(this.tlEspecialidades);
            this.tcEspecialidades.ContentPanel.Size = new System.Drawing.Size(672, 252);
            this.tcEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tcEspecialidades.Name = "tcEspecialidades";
            this.tcEspecialidades.Size = new System.Drawing.Size(672, 277);
            this.tcEspecialidades.TabIndex = 0;
            this.tcEspecialidades.Text = "toolStripContainer1";
            // 
            // tcEspecialidades.TopToolStripPanel
            // 
            this.tcEspecialidades.TopToolStripPanel.Controls.Add(this.tsEspecialidades);
            // 
            // tlEspecialidades
            // 
            this.tlEspecialidades.ColumnCount = 2;
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidades.Controls.Add(this.dgvEspecialidades, 0, 0);
            this.tlEspecialidades.Controls.Add(this.btnActualizar, 0, 1);
            this.tlEspecialidades.Controls.Add(this.btnSalir, 1, 1);
            this.tlEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidades.Name = "tlEspecialidades";
            this.tlEspecialidades.RowCount = 2;
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidades.Size = new System.Drawing.Size(672, 252);
            this.tlEspecialidades.TabIndex = 1;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidadDataGridViewTextBoxColumn,
            this.descespecialidadDataGridViewTextBoxColumn});
            this.tlEspecialidades.SetColumnSpan(this.dgvEspecialidades, 2);
            this.dgvEspecialidades.DataSource = this.especialidadesBindingSource;
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(666, 217);
            this.dgvEspecialidades.TabIndex = 0;
            // 
            // idespecialidadDataGridViewTextBoxColumn
            // 
            this.idespecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.Name = "idespecialidadDataGridViewTextBoxColumn";
            this.idespecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descespecialidadDataGridViewTextBoxColumn
            // 
            this.descespecialidadDataGridViewTextBoxColumn.DataPropertyName = "desc_especialidad";
            this.descespecialidadDataGridViewTextBoxColumn.HeaderText = "desc_especialidad";
            this.descespecialidadDataGridViewTextBoxColumn.Name = "descespecialidadDataGridViewTextBoxColumn";
            this.descespecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(513, 226);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsEspecialidades
            // 
            this.tsEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsEspecialidades.Location = new System.Drawing.Point(3, 0);
            this.tsEspecialidades.Name = "tsEspecialidades";
            this.tsEspecialidades.Size = new System.Drawing.Size(112, 25);
            this.tsEspecialidades.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // formListaEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 277);
            this.Controls.Add(this.tcEspecialidades);
            this.Name = "formListaEspecialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.tcEspecialidades.ContentPanel.ResumeLayout(false);
            this.tcEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tcEspecialidades.TopToolStripPanel.PerformLayout();
            this.tcEspecialidades.ResumeLayout(false);
            this.tcEspecialidades.PerformLayout();
            this.tlEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            this.tsEspecialidades.ResumeLayout(false);
            this.tsEspecialidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcEspecialidades;
        private System.Windows.Forms.TableLayoutPanel tlEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private tp2_netDataSetTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descespecialidadDataGridViewTextBoxColumn;
    }
}