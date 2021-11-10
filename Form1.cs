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
using MySql.Data.MySqlClient;

namespace segmentoOtoneurologia
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;

        public frmLogin()
        {
            InitializeComponent();

            gbBancoDados.Visible = false;//inabilita o gb do BD

            tabelaCadastroSenhasDataGridView.Enabled = false;//inabilita o dgw do cadastro de senhas
        }

        void OpenData()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)//evento do btn entrar
        {
            try
            {
                conexao = new MySqlConnection("server=segmsaude001.mysql.uhserver.com;user id=sistemaslua4;password=ba0038-eldw;persistsecurityinfo=True;database=segmsaude001;");
                strSQL = "SELECT * FROM `tabelaCadastroSenhas` WHERE `novoUsuario` = @NOVOUSUARIO AND `tipoProfissional` = @TIPOPROFISSIONAL AND `novaSenha` = @NOVASENHA ";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOVOUSUARIO", txtUsuario.Text);
                comando.Parameters.AddWithValue("@TIPOPROFISSIONAL", cbProfissionais.Text);
                comando.Parameters.AddWithValue("@NOVASENHA", txtSenha.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    autenticacao.Entrar(dr["novoUsuario"].ToString(), dr["tipoProfissional"].ToString(), dr["novaSenha"].ToString());
                
                    this.Visible = false;//o frm fecha

                    using (frmAguarde fa = new frmAguarde(OpenData))
                    {
                        fa.ShowDialog(this);
                    }

                    string valor1 = cbProfissionais.Text;//atribui o combobox a uma variável

                    var form1 = new frmPrincial(valor1);//instancia o frm que abrirá com a variável
                    form1.Show();//abre o próximo frm
                }

                else if (( txtUsuario.Text == "") || (txtSenha.Text == "") || (cbProfissionais.Text == ""))
                {
                    MessageBox.Show("Preencha os campos vazios com os dados corretos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Dados incorretos. Preencha novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtUsuario.Clear();
                    txtSenha.Clear();
                    cbProfissionais.SelectedIndex = -1;
                }
            }
            catch
            {
                MessageBox.Show("Verifique a conexão com a internet, para acessar o programa.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)//caso o 'x' do frm seja clicado
        {
            Application.Exit();//a aplicação fecha
        }

        private void btnAjuda_Click(object sender, EventArgs e)//evento do btn ajuda
        {
            frmAjuda fa = new frmAjuda();//instancia o frm ajuda
            fa.ShowDialog();//abre o frm ajuda
        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)//evento do teclado
        {
            if (e.KeyChar == 13)//caso o ENTER seja pressionado com o btn entrar selecionado...
            {
                this.Visible = false;//o frm fecha

                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }

                string valor1 = cbProfissionais.Text;//atribui o combobox a uma variável

                var form1 = new frmPrincial(valor1);//instancia o frm que abrirá com a variável
                form1.Show();//abre o próximo frm           
            }
        }

        private void btnAdm_Click(object sender, EventArgs e)//evento do btn administrativo
        {
            if ((txtAdministrativo.Text == "administrativolua") || (txtSenhaAdm.Text == "adm1030#$"))//se o usuário e senha corresponderem
            {
                gbBancoDados.Visible = true;//deixa o gb dados visível
                gbAdministrativo.Enabled = false;//deixa o gb adm inativo

                //limpa os txt's
                txtAdministrativo.Clear();
                txtSenhaAdm.Clear();
            }

            else //do contrário
            {
                MessageBox.Show("Usuário e/ou senha incorretos! Tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//lança a msg

                //limpa os txt's
                txtAdministrativo.Clear();
                txtSenhaAdm.Clear();
            }
        }

        private void tabelaCadastroSenhasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try//tratamento para salvar a ação
            {
                this.Validate();
                this.tabelaCadastroSenhasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
            finally
            {
                MessageBox.Show("Os dados foram salvos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //lança a msg de aviso
                tabelaCadastroSenhasDataGridView.Enabled = false;//inabilita o dwg dos dados
                gbAdministrativo.Enabled = true;//habilita o gb do adm
                gbBancoDados.Visible = false;//inabilita o gb do BD
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaCadastroSenhas'. Você pode movê-la ou removê-la conforme necessário.
                this.tabelaCadastroSenhasTableAdapter.Fill(this.segmsaude001DataSet.tabelaCadastroSenhas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)//evento do btn add dados
        {
            MessageBox.Show("O modo de adição de dados foi aberto.\n\nApague a ação caso não adicionar dado algum.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); //lança a msg de aviso
            tabelaCadastroSenhasDataGridView.Enabled = true;//habilita o dgw para add os dados
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)//evento do btn apagar
        {
            try//tratamento para salvar a ação
            {
                this.Validate();
                this.tabelaCadastroSenhasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
            finally
            {
                MessageBox.Show("Os dados foram apagados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //lança a msg de aviso
                tabelaCadastroSenhasDataGridView.Enabled = false;//inabilita o dwg dos dados
                gbAdministrativo.Enabled = true;//habilita o gb do adm
                gbBancoDados.Visible = false;//inabilita o gb do BD
            } 
        }

        private void button1_Click(object sender, EventArgs e)//sai da aplicação
        {
            Application.Exit();
        }
    }
}
