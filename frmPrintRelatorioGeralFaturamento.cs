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
    public partial class frmPrintRelatorioGeralFaturamento : Form
    {
        public List<dados> dados = new List<dados>();
        public frmPrintRelatorioGeralFaturamento()
        {
            InitializeComponent();
        }

        private void frmPrintRelatorioGeralFaturamento_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dados));
            this.reportViewer1.RefreshReport();
        }
    }
}
