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
    public partial class frmLaudario : Form
    {
        public frmLaudario()
        {
            InitializeComponent();

            gbNovoLaudo.Enabled = false;//inabilita o gb para cadastro
        }

        private void tabelaLaudario1BindingNavigatorSaveItem_Click(object sender, EventArgs e)//evento do btn salvar
        {
            try//tratamento para atualizar e salvar a ação
            {
                this.Validate();
                this.tabelaLaudario1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
            finally
            {
                MessageBox.Show("Os dados foram salvos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //msg de confirmação
                gbNovoLaudo.Enabled = false;//inabilita o gb para cadastro
            }
        }

        private void frmLaudario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaLaudario1'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaLaudario1TableAdapter.Fill(this.segmsaude001DataSet.tabelaLaudario1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)//evento do btn add dados
        {
            MessageBox.Show("O modo adicionar dados foi aberto.\n\nApague a ação, caso não adicione dado algum.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //msg de alerta
            gbNovoLaudo.Enabled = true;//habilita o gb para cadastro
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)//evento do btn apagar
        {
            try//tratamento para atualizar e salvar a ação
            {
                this.Validate();
                this.tabelaLaudario1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
            finally
            {
                MessageBox.Show("Os dados foram apagados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //msg de confirmação
                gbNovoLaudo.Enabled = false;//inabilita o gb para cadastro
            }
        }

        private void toolStripBloquear_Click(object sender, EventArgs e)//evento do btn bloquear
        {
            try//tratamento para atualizar e salvar a ação
            {
                this.Validate();
                this.tabelaLaudario1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
            finally
            {
                MessageBox.Show("Os dados foram editados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //msg de confirmação
                gbNovoLaudo.Enabled = false;//inabilita o gb para cadastro
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)//evento do btn editar
        {
            MessageBox.Show("O modo editar dados foi aberto.\n\nBloqueie a ação, caso não adicione dado algum\n ou realize alguma edição.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //msg de alerta
            gbNovoLaudo.Enabled = true;//habilita o gb para cadastro
        }

        private void txtBuscarLaudo_TextChanged(object sender, EventArgs e)//para buscar os laudos
        {
            tabelaLaudario1BindingSource.Filter = $"nomeLaudo like '*{txtBuscarLaudo.Text}*'";//filtra o bd com o que está escrito no txt
        }
    }
}
