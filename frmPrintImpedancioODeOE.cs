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
    public partial class frmPrintImpedancioODeOE : Form
    {
        public frmPrintImpedancioODeOE(string valor1)
        {
            InitializeComponent();

            txtPacienteImpedancio.Text = valor1;

            tabelaExamesBindingSource.Filter = $"identificacao like '*{txtPacienteImpedancio.Text}*'";

            this.reportViewer1.RefreshReport(); 
            reportViewer1.Visible = false;
        }

        private void frmPrintImpedancioODeOE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaExames'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaExamesTableAdapter.Fill(this.segmsaude001DataSet.tabelaExames);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();           
        }

        private void tabelaExamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaExamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
        }

        private void btnPrintImpedancio_Click(object sender, EventArgs e)
        {
            if (txtPacienteImpedancio.Text == "")
            {
                MessageBox.Show("O campo correspondente à identificação do paciente está vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                reportViewer1.Visible = true;
                this.reportViewer1.RefreshReport();
                tabelaExamesBindingSource.Filter = $"identificacao like '*{txtPacienteImpedancio.Text}*'";
            }
        }
    }
}
