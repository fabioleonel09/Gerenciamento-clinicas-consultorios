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
    public partial class frmPrintCampoLivreAASI : Form
    {
        public frmPrintCampoLivreAASI()
        {
            InitializeComponent();
            reportViewer1.Visible = false;
        }

        private void frmPrintCampoLivreAASI_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaExames'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaExamesTableAdapter.Fill(this.segmsaude001DataSet.tabelaExames);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.EnableExternalImages = true;

        }

        private void btnPrintAudioCampoAASI_Click(object sender, EventArgs e)
        {
            if (txtPacienteAudioCampoAASI.Text == "")
            {
                MessageBox.Show("O campo correspondente ao nome do paciente está vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                reportViewer1.Visible = true;
                this.reportViewer1.RefreshReport();
                tabelaExamesBindingSource.Filter = $"nomePaciente like '*{txtPacienteAudioCampoAASI.Text}*'";
            }
        }

        private void tabelaExamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaExamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
        }
    }
}
