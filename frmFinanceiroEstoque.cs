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
    public partial class frmFinanceiroEstoque : Form
    {
        public frmFinanceiroEstoque()
        {
            InitializeComponent();
        }

        private void btnAbreEstoque_Click(object sender, EventArgs e)
        {
            frmFinanceiroEstoque ffe = new frmFinanceiroEstoque();
            this.Visible = false;

            frmEstoque fe = new frmEstoque();
            fe.ShowDialog();
        }

        private void btnAbreFinanceiro_Click(object sender, EventArgs e)
        {
            frmFinanceiroEstoque ffe = new frmFinanceiroEstoque();
            this.Visible = false;

            frmFinanceiroFaturamento fff = new frmFinanceiroFaturamento();
            fff.ShowDialog();
        }
    }
}
