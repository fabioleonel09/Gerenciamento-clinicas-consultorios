﻿
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaExamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.tabelaExamesTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaExamesTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbAudioCampAASI = new System.Windows.Forms.GroupBox();
            this.txtPacienteAltasFreq = new System.Windows.Forms.TextBox();
            this.btnPrintAltasFreq = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.gbAudioCampAASI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbAudioCampAASI, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.39136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.60863F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 742);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tabelaExamesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "segmentoOtoneurologia.rpvPrintAltasFreq.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1081, 657);
            this.reportViewer1.TabIndex = 0;
            // 
            // gbAudioCampAASI
            // 
            this.gbAudioCampAASI.Controls.Add(this.txtPacienteAltasFreq);
            this.gbAudioCampAASI.Controls.Add(this.btnPrintAltasFreq);
            this.gbAudioCampAASI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAudioCampAASI.Location = new System.Drawing.Point(4, 4);
            this.gbAudioCampAASI.Name = "gbAudioCampAASI";
            this.gbAudioCampAASI.Size = new System.Drawing.Size(1081, 70);
            this.gbAudioCampAASI.TabIndex = 4;
            this.gbAudioCampAASI.TabStop = false;
            this.gbAudioCampAASI.Text = "Imprimir paciente";
            // 
            // txtPacienteAltasFreq
            // 
            this.txtPacienteAltasFreq.Location = new System.Drawing.Point(263, 29);
            this.txtPacienteAltasFreq.Name = "txtPacienteAltasFreq";
            this.txtPacienteAltasFreq.Size = new System.Drawing.Size(439, 26);
            this.txtPacienteAltasFreq.TabIndex = 1;
            // 
            // btnPrintAltasFreq
            // 
            this.btnPrintAltasFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAltasFreq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintAltasFreq.Image = global::segmentoOtoneurologia.Properties.Resources.filtrar;
            this.btnPrintAltasFreq.Location = new System.Drawing.Point(749, 15);
            this.btnPrintAltasFreq.Name = "btnPrintAltasFreq";
            this.btnPrintAltasFreq.Size = new System.Drawing.Size(71, 49);
            this.btnPrintAltasFreq.TabIndex = 0;
            this.btnPrintAltasFreq.UseVisualStyleBackColor = true;
            this.btnPrintAltasFreq.Click += new System.EventHandler(this.btnPrintAltasFreq_Click);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.gbAudioCampAASI.ResumeLayout(false);
            this.gbAudioCampAASI.PerformLayout();
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
    }
}