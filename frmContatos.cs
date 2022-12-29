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
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();

            gbAdicionarContato.Enabled = false;
        }

        private void tabelaContatosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaContatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

            MessageBox.Show("Contato salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbAdicionarContato.Enabled = false;
        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaContatos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaContatosTableAdapter.Fill(this.segmsaude001DataSet.tabelaContatos);

        }

        private void txtBuscarContato_TextChanged(object sender, EventArgs e)
        {
            tabelaContatosBindingSource.Filter = $"nomeContato like '*{txtBuscarContato.Text}*'";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbAdicionarContato.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaContatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

            MessageBox.Show("Contato apagado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbAdicionarContato.Enabled = false;
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            gbAdicionarContato.Enabled = true;
        }

        private void toolStripButtonBloquear_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaContatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

            gbAdicionarContato.Enabled = false;
        }
    }
}
