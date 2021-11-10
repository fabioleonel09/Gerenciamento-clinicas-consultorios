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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();

            gbCadastrarProduto.Enabled = false;          
        }

        private void tabelaEstoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tabelaEstoqueBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar as alterações.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                MessageBox.Show("As alterações foram realizadas com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCadastrarProduto.Enabled = false;
            }
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaEstoqueTableAdapter.Fill(this.segmsaude001DataSet.tabelaEstoque);      
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbCadastrarProduto.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tabelaEstoqueBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar as alterações.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                MessageBox.Show("As alterações foram realizadas com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCadastrarProduto.Enabled = false;
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1, valor2, resultado;

                valor1 = Convert.ToInt32(quantidadeProdutoTextBox.Text);
                valor2 = Convert.ToInt32(txtRetirar.Text);

                resultado = valor1 - valor2;

                quantidadeProdutoTextBox.Text = resultado.ToString();

                this.Validate();
                this.tabelaEstoqueBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);
            }
            catch
            {
                MessageBox.Show("Há algum valor inadequado?", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tabelaEstoqueDataGridView.RefreshEdit();

                MessageBox.Show("As alterações foram realizadas com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbCadastrarProduto.Enabled = false;
            }
        }

        private void txtBuscarProduto_TextChanged(object sender, EventArgs e)
        {
            tabelaEstoqueBindingSource.Filter = $"nomeProduto like '*{txtBuscarProduto.Text}*'";          
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            gbCadastrarProduto.Enabled = true;
        }

        private void quantidadeProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantidadeProdutoTextBox.Text == "2")
            {
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
            }

            else if (quantidadeProdutoTextBox.Text == "1")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
            }

            else if (quantidadeProdutoTextBox.Text == "0")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
            }

            else
            {
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }
    }
}
