using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segmentoOtoneurologia
{
    public partial class frmCadastroOtoneurologia : Form
    {
        public frmCadastroOtoneurologia()
        {
            InitializeComponent();
        }

        void OpenData()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);
            }
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            frmExames fexames = new frmExames();
            fexames.ShowDialog();
        }

        private void tabelaOtoneuroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaOtoneuroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
        }

        private void frmCadastroOtoneurologia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaOtoneuro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaOtoneuroTableAdapter.Fill(this.segmsaude001DataSet.tabelaOtoneuro);

        }

        private void idadePacienteNovoTextBox_Click(object sender, EventArgs e)
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

        private void btnBuscarCadastrado_Click(object sender, EventArgs e)
        {
            if (rbBuscarNome.Checked == true)
            {
                tabelaOtoneuroBindingSource.Filter = $"nomePaciente like '*{txtBuscarOtoneuro.Text}*'";
                txtBuscarOtoneuro.Clear();
            }
            else if (rbIdentificacao.Checked == true)
            {
                tabelaOtoneuroBindingSource.Filter = $"identificacao like '*{txtBuscarOtoneuro.Text}*'";
                txtBuscarOtoneuro.Clear();
            }
            else if (rbEmpresa.Checked == true)
            {
                tabelaOtoneuroBindingSource.Filter = $"empresa like '*{txtBuscarOtoneuro.Text}*'";
                txtBuscarOtoneuro.Clear();
            }
            else if (rbEntre.Checked == true)
            {
                tabelaOtoneuroBindingSource.Filter = string.Format("dataExame >= '#{0:dd/MM/yyyy}#' And dataExame <= '#{1:dd/MM/yyyy}#'", maskedTextBox1.Text, maskedTextBox3.Text); //filtra a BD por data

                maskedTextBox1.Clear();
                maskedTextBox3.Clear();
            }
        }
    }
}
