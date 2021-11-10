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
    public partial class frmPrintAgendaDia : Form
    {
        public frmPrintAgendaDia()
        {
            InitializeComponent();

            reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
        }

        private void frmPrintAgendaDia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaAgendamentoTableAdapter.Fill(this.segmsaude001DataSet.tabelaAgendamento);

            this.reportViewer1.RefreshReport();
        }

        private void tabelaAgendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaAgendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

        }

        private void btnPrintAgendaDia_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.Visible = true;
                this.reportViewer1.RefreshReport();
                tabelaAgendamentoBindingSource.Filter = string.Format("dataConsulta >= '#{0:dd/MM/yyyy}#' And dataConsulta <= '#{1:dd/MM/yyyy}#'", maskedTextBox1.Text, maskedTextBox2.Text); //filtra a BD por data
            }
            catch
            {
                MessageBox.Show("Preencha com as dadas para realizar a impressão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            { 
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
        }
    }
}
