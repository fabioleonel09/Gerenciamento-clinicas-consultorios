
namespace segmentoOtoneurologia
{
    partial class frmPrintAudioClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintAudioClinica));
            this.tabelaExamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPacienteAudioClinica = new System.Windows.Forms.TextBox();
            this.btnPrintAudioClinica = new System.Windows.Forms.Button();
            this.tabelaExamesTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaExamesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.20108F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.79892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 742);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tabelaExamesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "segmentoOtoneurologia.rpvPrintAudioClinica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1081, 651);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPacienteAudioClinica);
            this.groupBox1.Controls.Add(this.btnPrintAudioClinica);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimir paciente";
            // 
            // txtPacienteAudioClinica
            // 
            this.txtPacienteAudioClinica.Location = new System.Drawing.Point(262, 32);
            this.txtPacienteAudioClinica.Name = "txtPacienteAudioClinica";
            this.txtPacienteAudioClinica.Size = new System.Drawing.Size(439, 26);
            this.txtPacienteAudioClinica.TabIndex = 3;
            // 
            // btnPrintAudioClinica
            // 
            this.btnPrintAudioClinica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAudioClinica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintAudioClinica.Image = global::segmentoOtoneurologia.Properties.Resources.filtrar;
            this.btnPrintAudioClinica.Location = new System.Drawing.Point(748, 18);
            this.btnPrintAudioClinica.Name = "btnPrintAudioClinica";
            this.btnPrintAudioClinica.Size = new System.Drawing.Size(71, 49);
            this.btnPrintAudioClinica.TabIndex = 2;
            this.btnPrintAudioClinica.UseVisualStyleBackColor = true;
            this.btnPrintAudioClinica.Click += new System.EventHandler(this.btnPrintAudioClinica_Click);
            // 
            // tabelaExamesTableAdapter
            // 
            this.tabelaExamesTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintAudioClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintAudioClinica";
            this.Text = "Impressão Audiometria Clínica";
            this.Load += new System.EventHandler(this.frmPrintAudioClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tabelaExamesBindingSource;
        private segmsaude001DataSet segmsaude001DataSet;
        private segmsaude001DataSetTableAdapters.tabelaExamesTableAdapter tabelaExamesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPacienteAudioClinica;
        private System.Windows.Forms.Button btnPrintAudioClinica;
    }
}