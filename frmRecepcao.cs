
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
    public partial class frmRecepcao : Form
    {
        public frmRecepcao()
        {
            InitializeComponent();

            ConfigurarTimer();

            ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            gbDadosConvenio.Enabled = false; 
        }

        void ConfigurarTimer()
        {
            timer1.Interval = 350; //setar intervalo de 2 segundos...
            timer1.Enabled = true;
        }

        private void tabelaPacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaPacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
        }

        private void frmRecepcao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaAgendamentoTableAdapter.Fill(this.segmsaude001DataSet.tabelaAgendamento);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaAgendamentoTableAdapter.Fill(this.segmsaude001DataSet.tabelaAgendamento);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaPaciente'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaPacienteTableAdapter.Fill(this.segmsaude001DataSet.tabelaPaciente);
        }

        private void btnSituacao_Click(object sender, EventArgs e)
        {
            try
            {    
                this.Validate();
                this.tabelaPacienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

                MessageBox.Show("Situação aplicada com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabelaPacienteDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarNomePacienteRecep_TextChanged(object sender, EventArgs e)
        {
            tabelaPacienteBindingSource.Filter = $"nomePaciente like '*{txtBuscarNomePacienteRecep.Text}*'";
        }

        private void porConvenioRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ((Control)tabControl1.TabPages["tabPage2"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            gbDadosConvenio.Enabled = true;
        }

        private void particularRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = true;
            gbDadosConvenio.Enabled = false;
        }

        private void semOnusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = true;
            gbDadosConvenio.Enabled = false;
        }

        private void idadePacienteNovoTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            idadePacienteNovoTextBox.Clear();

            DateTime DataNascimento = dataNascimentoDateTimePicker.Value;
            DateTime DataAtual = DateTime.Now;
            int Anos = new DateTime(DateTime.Now.Subtract(DataNascimento).Ticks).Year - 1;
            DateTime AnosTranscorridos = DataNascimento.AddYears(Anos);
            int Meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (AnosTranscorridos.AddMonths(i) == DataAtual)
                {
                    Meses = i;
                    break;
                }
                else if (AnosTranscorridos.AddMonths(i) >= DataAtual)
                {
                    Meses = i - 1;
                    break;
                }
            }
            int Dias = DataAtual.Subtract(AnosTranscorridos.AddMonths(Meses)).Days;

            idadePacienteNovoTextBox.Text += ((Anos.ToString()) + " anos, " + (Meses.ToString()) + " meses, " + (Dias.ToString()) + " dias.");
        }

        private void tabelaPacienteDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals("horário bloqueado"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

            if (e.Value != null && e.Value.Equals("em espera"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }

            if (e.Value != null && e.Value.Equals("na recepção"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            }

            if (e.Value != null && e.Value.Equals("em atendimento"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }

            if (e.Value != null && e.Value.Equals("não compareceu"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }

            if (e.Value != null && e.Value.Equals("desmarcou"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
            }

            if (e.Value != null && e.Value.Equals("já atendido"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }

            if (e.Value != null && e.Value.Equals("confirmado"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
            }

            if (e.Value != null && e.Value.Equals("tentativa de contato"))
            {
                tabelaPacienteDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tabelaPacienteDataGridView.Refresh();
        }
    }
}
