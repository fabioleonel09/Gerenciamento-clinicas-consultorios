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
        }

        private void tabelaContatosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaContatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

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
    }
}
