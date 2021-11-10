using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segmentoOtoneurologia
{
    public partial class frmPrintReceituario : Form
    {
        public List<dados> dados = new List<dados>();
        public frmPrintReceituario()
        {
            InitializeComponent();
        }

        private void frmPrintReceituario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaProntuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaProntuarioTableAdapter.Fill(this.segmsaude001DataSet.tabelaProntuario);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dados));
            this.reportViewer1.RefreshReport();
        }
    }
}
