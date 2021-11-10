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
    public partial class frmReceituarios : Form
    {
        public frmReceituarios()
        {
            InitializeComponent();
        }

        private void tabelaReceituarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaReceituarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

        }

        private void frmReceituarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaReceituario'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaReceituarioTableAdapter.Fill(this.segmsaude001DataSet.tabelaReceituario);

        }

        private void txtBuscarReceituario_TextChanged(object sender, EventArgs e)
        {
            tabelaReceituarioBindingSource.Filter = $"nomeReceituario like '*{txtBuscarReceituario.Text}*'";
        }
    }
}
