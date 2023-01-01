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
    public partial class frmPrincial : Form
    {
        public frmPrincial(string valor1)//recebe ea variável do frm1, de senhas
        {
            InitializeComponent();

            ConfigurarTimer();

            txtProfissionalLogado.Text = valor1;//associa a variável ao txt

            tabelaPacienteBindingSource.Filter = $"dataAtendimento >= '#{DateTime.Now}#'"; //filtra a BD do mySQL como o que estiver na data escolhida
            tabelaPacienteDataGridView.Refresh();

            tabelaAgendamentoBindingSource.Filter = $"dataConsulta >= '#{DateTime.Now}#'"; //filtra a BD do mySQL como o que estiver na data escolhida
            tabelaAgendamentoDataGridView.Refresh();

            if (txtProfissionalLogado.Text == "Profissional da saúde")
            {
                btnFinanceiroEstoque.Enabled = false;
                btnRecepcao.Enabled = false;
                btnProntuario.Enabled = true;
                btnReceituario.Enabled = true;
                btnOtoneuro.Enabled = true;
                btnOcupacional.Enabled = true;
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
            }
            else if (txtProfissionalLogado.Text == "Administração")
            {
                btnFinanceiroEstoque.Enabled = true;
                btnRecepcao.Enabled = true;
                btnProntuario.Enabled = false;
                btnReceituario.Enabled = false;
                btnOtoneuro.Enabled = false;
                btnOcupacional.Enabled = false;
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = true;
            }
            else if (txtProfissionalLogado.Text == "Faturamento")
            {
                btnFinanceiroEstoque.Enabled = true;
                btnRecepcao.Enabled = false;
                btnProntuario.Enabled = false;
                btnReceituario.Enabled = false;
                btnOtoneuro.Enabled = false;
                btnOcupacional.Enabled = false;
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
            }
            else if (txtProfissionalLogado.Text == "Recepção")
            {
                btnFinanceiroEstoque.Enabled = false;
                btnRecepcao.Enabled = true;
                btnProntuario.Enabled = false;
                btnReceituario.Enabled = false;
                btnOtoneuro.Enabled = false;
                btnOcupacional.Enabled = false;
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = true;
            }
            else if (txtProfissionalLogado.Text == "Telefonia")
            {
                btnFinanceiroEstoque.Enabled = false;
                btnRecepcao.Enabled = false;
                btnProntuario.Enabled = false;
                btnReceituario.Enabled = false;
                btnOtoneuro.Enabled = false;
                btnOcupacional.Enabled = false;
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = true;
            }
            if (txtProfissionalLogado.Text == "Exames")
            {
                btnFinanceiroEstoque.Enabled = false;
                btnRecepcao.Enabled = false;
                btnProntuario.Enabled = false;
                btnReceituario.Enabled = false;
                btnOtoneuro.Enabled = true;
                btnOcupacional.Enabled = false;
                gbLembretes.Enabled = true;
                tabelaAgendamentoBindingNavigator.Enabled = false;
                ((Control)tabControl1.TabPages["tabPage1"]).Enabled = false;
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
                ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            }
        }

        void ConfigurarTimer()
        {
            timer1.Interval = 300; //setar intervalo de 2 segundos...
            timer1.Enabled = true;
        }

        private void atualizaForm()
        {
            tabelaPacienteDataGridView.Refresh();
            tabelaAgendamentoDataGridView.Refresh();
        }

        private void frmPrincial_FormClosing(object sender, FormClosingEventArgs e)//ao clicar no 'x' do frm
        {
            Application.Exit();//sai da aplicação
        }

        private void tabelaAgendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)//evento de salvar no bd
        {
            this.Validate();
            this.tabelaAgendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
        }

        private void frmPrincial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaPaciente'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaPacienteTableAdapter.Fill(this.segmsaude001DataSet.tabelaPaciente);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaBlocoNotas'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaBlocoNotasTableAdapter.Fill(this.segmsaude001DataSet.tabelaBlocoNotas);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaAgendamentoTableAdapter.Fill(this.segmsaude001DataSet.tabelaAgendamento);

            //*********
            tabelaPacienteBindingSource.Filter = $"dataAtendimento >= '#{DateTime.Now}#'"; //filtra a BD do mySQL como o que estiver na data escolhida
            tabelaPacienteDataGridView.Refresh();         

            tabelaAgendamentoBindingSource.Filter = $"dataConsulta >= '#{DateTime.Now}#'"; //filtra a BD do mySQL como o que estiver na data escolhida
            tabelaAgendamentoDataGridView.Refresh();
        }

        private void btnOtoneuro_Click(object sender, EventArgs e)// evento do btn otoneuro
        {
            if (Application.OpenForms.OfType<frmExames>().Count() > 0)
            {
                Application.OpenForms["frmExames"].BringToFront();
                Application.OpenForms["frmExames"].WindowState = FormWindowState.Normal;
            }

            else
            {
                frmExames fe = new frmExames();//instancia o frm exames
                fe.Show();//abre o frm
            }

            //frmCadastroOtoneurologia fco = new frmCadastroOtoneurologia();//instancia o frm cadastro otoneuro
            //fco.ShowDialog();//abre o frm
        }

        private void btnNotas_Click(object sender, EventArgs e)//evento do btn notas
        {
            frmBlocoNotas fbn = new frmBlocoNotas();//instancia o frm
            fbn.ShowDialog();//abre o frm
        }

        private void btnReceituario_Click(object sender, EventArgs e)//evento do btn receituário
        {
            frmReceituarios fr = new frmReceituarios();//instancia o frm
            fr.ShowDialog();//abre o frm
        }

        private void btnContatos_Click(object sender, EventArgs e)// evento do btn contatos
        {
            frmContatos fc = new frmContatos();//instancia o frm
            fc.ShowDialog();//abre o frm
        }

        private void btnProntuario_Click(object sender, EventArgs e)// evento do btn prontuário
        {
            frmProntuario fp = new frmProntuario();//instancia o frm
            fp.ShowDialog();//abre o frm
        }

        private void btnOcupacional_Click(object sender, EventArgs e)// evento do btn saúde auditiva
        {
            frmConservacaoAuditiva fca = new frmConservacaoAuditiva();//instancia o frm
            fca.ShowDialog();//abre o frm
        }

        private void btnRecepcao_Click(object sender, EventArgs e)//evento do btn recepção
        {
            if (txtProfissionalLogado.Text == "Recepção")//caso seja recepção o logado...
            {
                frmRecepcao fr = new frmRecepcao();//instancia o frm
                fr.ShowDialog();//abre o frm
            }
            else if (txtProfissionalLogado.Text == "Administração")//caso seja adminstração o logado...
            {
                tabControl1.SelectTab(tabPage3); //seleciona a aba 3 do tabControl1

                frmRecepcao fr = new frmRecepcao();//instancia o frm
                fr.ShowDialog();// abre o frm
            }

            else
            {
                tabControl1.SelectTab(tabPage3); //seleciona a aba 3 do tabControl1   
            }
            
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            if (rbNome.Checked == true)
            {
                tabelaAgendamentoBindingSource.Filter = $"nomePaciente like '*{txtPesquisarPaciente.Text}*'";
                tabelaAgendamentoBindingSource.Filter = string.Format("dataConsulta >= '#{0:dd/MM/yyyy}#' And dataConsulta <= '#{1:dd/MM/yyyy}#'", mtbDataInicio.Text, mtbDataTermino.Text); //filtra a BD por data

                mtbDataInicio.Clear();
                mtbDataTermino.Clear();
                txtPesquisarPaciente.Clear();
            }
            else if (rbNomeProfissional.Checked == true)
            {
                tabelaAgendamentoBindingSource.Filter = $"nomeProfissional like '*{txtPesquisarPaciente.Text}*'";
                tabelaAgendamentoBindingSource.Filter = string.Format("dataConsulta >= '#{0:dd/MM/yyyy}#' And dataConsulta <= '#{1:dd/MM/yyyy}#'", mtbDataInicio.Text, mtbDataTermino.Text); //filtra a BD por data

                mtbDataInicio.Clear();
                mtbDataTermino.Clear();
                txtPesquisarPaciente.Clear();
            }
            else if ((txtPesquisarPaciente.Text == "") || (mtbDataInicio.Text == "") || (mtbDataTermino.Text == ""))
            {
                MessageBox.Show("Preencha os campos 'nome' e 'datas' para realizar a pesquisa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            frmPrintAgendaDia fpad = new frmPrintAgendaDia();
            fpad.ShowDialog();
        }

        private void btnFinanceiroEstoque_Click(object sender, EventArgs e)
        {
            frmFinanceiroEstoque ffe = new frmFinanceiroEstoque();
            ffe.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaForm();
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
    }
}
