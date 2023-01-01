
namespace segmentoOtoneurologia
{
    partial class frmPrintAudioAltasFreq
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintAudioAltasFreq));
            this.tabelaExamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAudioCampAASI = new System.Windows.Forms.GroupBox();
            this.txtPacienteAltasFreq = new System.Windows.Forms.TextBox();
            this.btnPrintAltasFreq = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabelaExamesTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaExamesTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            this.tabelaExamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn181 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn478 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAudioCampAASI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaExamesBindingSource
            // 
            this.tabelaExamesBindingSource.DataMember = "tabelaExames";
            this.tabelaExamesBindingSource.DataSource = this.segmsaude001DataSet;
            // 
            // segmsaude001DataSet
            // 
            this.segmsaude001DataSet.DataSetName = "segmsaude001DataSet";
            this.segmsaude001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbAudioCampAASI, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.54251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 742);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbAudioCampAASI
            // 
            this.gbAudioCampAASI.Controls.Add(this.label1);
            this.gbAudioCampAASI.Controls.Add(this.tabelaExamesDataGridView);
            this.gbAudioCampAASI.Controls.Add(this.txtPacienteAltasFreq);
            this.gbAudioCampAASI.Controls.Add(this.btnPrintAltasFreq);
            this.gbAudioCampAASI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAudioCampAASI.Location = new System.Drawing.Point(4, 4);
            this.gbAudioCampAASI.Name = "gbAudioCampAASI";
            this.gbAudioCampAASI.Size = new System.Drawing.Size(1081, 152);
            this.gbAudioCampAASI.TabIndex = 4;
            this.gbAudioCampAASI.TabStop = false;
            this.gbAudioCampAASI.Text = "Imprimir paciente";
            // 
            // txtPacienteAltasFreq
            // 
            this.txtPacienteAltasFreq.Enabled = false;
            this.txtPacienteAltasFreq.Location = new System.Drawing.Point(779, 80);
            this.txtPacienteAltasFreq.Name = "txtPacienteAltasFreq";
            this.txtPacienteAltasFreq.Size = new System.Drawing.Size(217, 26);
            this.txtPacienteAltasFreq.TabIndex = 1;
            // 
            // btnPrintAltasFreq
            // 
            this.btnPrintAltasFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAltasFreq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintAltasFreq.Image = global::segmentoOtoneurologia.Properties.Resources.filtrar;
            this.btnPrintAltasFreq.Location = new System.Drawing.Point(1002, 57);
            this.btnPrintAltasFreq.Name = "btnPrintAltasFreq";
            this.btnPrintAltasFreq.Size = new System.Drawing.Size(71, 49);
            this.btnPrintAltasFreq.TabIndex = 0;
            this.btnPrintAltasFreq.UseVisualStyleBackColor = true;
            this.btnPrintAltasFreq.Click += new System.EventHandler(this.btnPrintAltasFreq_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tabelaExamesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "segmentoOtoneurologia.rpvPrintAltasFreq.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 163);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1081, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabelaExamesTableAdapter
            // 
            this.tabelaExamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaAgendamentoTableAdapter = null;
            this.tableAdapterManager.tabelaBlocoNotasTableAdapter = null;
            this.tableAdapterManager.tabelaCadastroSenhasTableAdapter = null;
            this.tableAdapterManager.tabelaContatosTableAdapter = null;
            this.tableAdapterManager.tabelaEstoqueTableAdapter = null;
            this.tableAdapterManager.tabelaExamesTableAdapter = this.tabelaExamesTableAdapter;
            this.tableAdapterManager.tabelaLaudario1TableAdapter = null;
            this.tableAdapterManager.tabelaLaudarioTableAdapter = null;
            this.tableAdapterManager.tabelaOcupacionalTableAdapter = null;
            this.tableAdapterManager.tabelaOtoneuroTableAdapter = null;
            this.tableAdapterManager.tabelaPacienteTableAdapter = null;
            this.tableAdapterManager.tabelaProntuarioTableAdapter = null;
            this.tableAdapterManager.tabelaReceituarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabelaExamesDataGridView
            // 
            this.tabelaExamesDataGridView.AllowUserToAddRows = false;
            this.tabelaExamesDataGridView.AllowUserToDeleteRows = false;
            this.tabelaExamesDataGridView.AllowUserToOrderColumns = true;
            this.tabelaExamesDataGridView.AutoGenerateColumns = false;
            this.tabelaExamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaExamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn181,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn478,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tabelaExamesDataGridView.DataSource = this.tabelaExamesBindingSource;
            this.tabelaExamesDataGridView.Location = new System.Drawing.Point(8, 25);
            this.tabelaExamesDataGridView.Name = "tabelaExamesDataGridView";
            this.tabelaExamesDataGridView.ReadOnly = true;
            this.tabelaExamesDataGridView.Size = new System.Drawing.Size(765, 121);
            this.tabelaExamesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn181
            // 
            this.dataGridViewTextBoxColumn181.DataPropertyName = "nomePaciente";
            this.dataGridViewTextBoxColumn181.HeaderText = "Nome do paciente";
            this.dataGridViewTextBoxColumn181.Name = "dataGridViewTextBoxColumn181";
            this.dataGridViewTextBoxColumn181.ReadOnly = true;
            this.dataGridViewTextBoxColumn181.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "identificacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identificação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "D. N.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn478
            // 
            this.dataGridViewTextBoxColumn478.DataPropertyName = "idadePacienteNovo";
            this.dataGridViewTextBoxColumn478.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn478.Name = "dataGridViewTextBoxColumn478";
            this.dataGridViewTextBoxColumn478.ReadOnly = true;
            this.dataGridViewTextBoxColumn478.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataExame";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data exame";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "empresa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identificação:";
            // 
            // frmPrintAudioAltasFreq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintAudioAltasFreq";
            this.Text = "Impressão Audiometria de Altas Frequências";
            this.Load += new System.EventHandler(this.frmPrintAudioAltasFreq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbAudioCampAASI.ResumeLayout(false);
            this.gbAudioCampAASI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaExamesBindingSource;
        private segmsaude001DataSetTableAdapters.tabelaExamesTableAdapter tabelaExamesTableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gbAudioCampAASI;
        private System.Windows.Forms.TextBox txtPacienteAltasFreq;
        private System.Windows.Forms.Button btnPrintAltasFreq;
        private System.Windows.Forms.DataGridView tabelaExamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn181;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn478;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}