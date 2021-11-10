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
    public partial class frmBlocoNotas : Form
    {
        public frmBlocoNotas()
        {
            InitializeComponent();

            tabelaBlocoNotasBindingSource.Filter = $"dataNota >= '#{DateTime.Now}#'"; //filtra a BD como o que estiver na data escolhida
        }

        private void tabelaBlocoNotasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaBlocoNotasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

        }

        private void frmBlocoNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaBlocoNotas'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaBlocoNotasTableAdapter.Fill(this.segmsaude001DataSet.tabelaBlocoNotas);

        }

        private void btnPesquisarNotas_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == "")) //se os txt estiverem vazios ou incompletos
            {
                MessageBox.Show("Atenção, preencha todos os campos de pesquisa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//lança msg

                //limpa os txts              
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }

            else //do contrário
            {
                tabelaBlocoNotasBindingSource.Filter = string.Format("dataNota >= '#{0:dd/MM/yyyy}#' And dataNota <= '#{1:dd/MM/yyyy}#'", maskedTextBox1.Text, maskedTextBox2.Text); //filtra a BD por data

                //limpa os txts
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
        }
    }
}
