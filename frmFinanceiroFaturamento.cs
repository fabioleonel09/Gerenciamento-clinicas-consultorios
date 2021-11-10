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
    public partial class frmFinanceiroFaturamento : Form
    {
        public frmFinanceiroFaturamento()
        {
            InitializeComponent();

            txtAliqIR.Enabled = true;
            txtAliqPIS.Enabled = true;
            txtAliqCOFINS.Enabled = true;
            txtAliqCSLL.Enabled = true;
            txtAliqISS.Enabled = true;

            txtIR.Enabled = false;
            txtPIS.Enabled = false;
            txtCOFINS.Enabled = false;
            txtCSLL.Enabled = false;
            txtISS.Enabled = false;
            txtSOMA.Enabled = false;
            txtRetencoes.Enabled = false;
        }

        private void tabelaPacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaPacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

        }

        private void frmFinanceiroFaturamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaPaciente'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaPacienteTableAdapter.Fill(this.segmsaude001DataSet.tabelaPaciente);

        }

        private void btnPrintRelatorioGeral_Click(object sender, EventArgs e)
        {
            frmPrintRelatorioGeralFaturamento fprgf = new frmPrintRelatorioGeralFaturamento();
            fprgf.ShowDialog();
        }

        private void totalParcialProcedimento1TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento1TextBox.Text == "") || (quantProcedimento1TextBox.Text == "") || (acrescimoProcedimento1TextBox.Text == "") || (descontoProcedimento1TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento1TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento1TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento1TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento1TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento1TextBox.Clear();

                totalParcialProcedimento1TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento1TextBox.Text) + "     " + Convert.ToString(regisProcedimento1TextBox.Text) + "     " + Convert.ToString(procedimento1TextBox.Text) + "     " + Convert.ToString(quantProcedimento1TextBox.Text) + "     " + Convert.ToString(valorProcedimento1TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento1TextBox.Text) + "     " + Convert.ToString(descontoProcedimento1TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento1TextBox.Text) + "\r\n";
            } 
        }

        private void totalParcialProcedimento2TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento2TextBox.Text == "") || (quantProcedimento2TextBox.Text == "") || (acrescimoProcedimento2TextBox.Text == "") || (descontoProcedimento2TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento2TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento2TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento2TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento2TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento2TextBox.Clear();

                totalParcialProcedimento2TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento2TextBox.Text) + "     " + Convert.ToString(regisProcedimento2TextBox.Text) + "     " + Convert.ToString(procedimento2TextBox.Text) + "     " + Convert.ToString(quantProcedimento2TextBox.Text) + "     " + Convert.ToString(valorProcedimento2TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento2TextBox.Text) + "     " + Convert.ToString(descontoProcedimento2TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento2TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento3TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento3TextBox.Text == "") || (quantProcedimento3TextBox.Text == "") || (acrescimoProcedimento3TextBox.Text == "") || (descontoProcedimento3TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento3TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento3TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento3TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento3TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento3TextBox.Clear();

                totalParcialProcedimento3TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento3TextBox.Text) + "     " + Convert.ToString(regisProcedimento3TextBox.Text) + "     " + Convert.ToString(procedimento3TextBox.Text) + "     " + Convert.ToString(quantProcedimento3TextBox.Text) + "     " + Convert.ToString(valorProcedimento3TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento3TextBox.Text) + "     " + Convert.ToString(descontoProcedimento3TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento3TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento4TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento4TextBox.Text == "") || (quantProcedimento4TextBox.Text == "") || (acrescimoProcedimento4TextBox.Text == "") || (descontoProcedimento4TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento4TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento4TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento4TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento4TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento4TextBox.Clear();

                totalParcialProcedimento4TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento4TextBox.Text) + "     " + Convert.ToString(regisProcedimento4TextBox.Text) + "     " + Convert.ToString(procedimento4TextBox.Text) + "     " + Convert.ToString(quantProcedimento4TextBox.Text) + "     " + Convert.ToString(valorProcedimento4TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento4TextBox.Text) + "     " + Convert.ToString(descontoProcedimento4TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento4TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento5TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento5TextBox.Text == "") || (quantProcedimento5TextBox.Text == "") || (acrescimoProcedimento5TextBox.Text == "") || (descontoProcedimento5TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento5TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento5TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento5TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento5TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento5TextBox.Clear();

                totalParcialProcedimento5TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento5TextBox.Text) + "     " + Convert.ToString(regisProcedimento5TextBox.Text) + "     " + Convert.ToString(procedimento5TextBox.Text) + "     " + Convert.ToString(quantProcedimento5TextBox.Text) + "     " + Convert.ToString(valorProcedimento5TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento5TextBox.Text) + "     " + Convert.ToString(descontoProcedimento5TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento5TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento6TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento6TextBox.Text == "") || (quantProcedimento6TextBox.Text == "") || (acrescimoProcedimento6TextBox.Text == "") || (descontoProcedimento6TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento6TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento6TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento6TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento6TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento6TextBox.Clear();

                totalParcialProcedimento6TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento6TextBox.Text) + "     " + Convert.ToString(regisProcedimento6TextBox.Text) + "     " + Convert.ToString(procedimento6TextBox.Text) + "     " + Convert.ToString(quantProcedimento6TextBox.Text) + "     " + Convert.ToString(valorProcedimento6TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento6TextBox.Text) + "     " + Convert.ToString(descontoProcedimento6TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento6TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento7TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento7TextBox.Text == "") || (quantProcedimento7TextBox.Text == "") || (acrescimoProcedimento7TextBox.Text == "") || (descontoProcedimento7TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento7TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento7TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento7TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento7TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento7TextBox.Clear();

                totalParcialProcedimento7TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento7TextBox.Text) + "     " + Convert.ToString(regisProcedimento7TextBox.Text) + "     " + Convert.ToString(procedimento7TextBox.Text) + "     " + Convert.ToString(quantProcedimento7TextBox.Text) + "     " + Convert.ToString(valorProcedimento7TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento7TextBox.Text) + "     " + Convert.ToString(descontoProcedimento7TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento7TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento8TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento8TextBox.Text == "") || (quantProcedimento8TextBox.Text == "") || (acrescimoProcedimento8TextBox.Text == "") || (descontoProcedimento8TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento8TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento8TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento8TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento8TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento8TextBox.Clear();

                totalParcialProcedimento8TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento8TextBox.Text) + "     " + Convert.ToString(regisProcedimento8TextBox.Text) + "     " + Convert.ToString(procedimento8TextBox.Text) + "     " + Convert.ToString(quantProcedimento8TextBox.Text) + "     " + Convert.ToString(valorProcedimento8TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento8TextBox.Text) + "     " + Convert.ToString(descontoProcedimento8TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento8TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento9TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento9TextBox.Text == "") || (quantProcedimento9TextBox.Text == "") || (acrescimoProcedimento9TextBox.Text == "") || (descontoProcedimento9TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento9TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento9TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento9TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento9TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento9TextBox.Clear();

                totalParcialProcedimento9TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento9TextBox.Text) + "     " + Convert.ToString(regisProcedimento9TextBox.Text) + "     " + Convert.ToString(procedimento9TextBox.Text) + "     " + Convert.ToString(quantProcedimento9TextBox.Text) + "     " + Convert.ToString(valorProcedimento9TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento9TextBox.Text) + "     " + Convert.ToString(descontoProcedimento9TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento9TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento10TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento10TextBox.Text == "") || (quantProcedimento10TextBox.Text == "") || (acrescimoProcedimento10TextBox.Text == "") || (descontoProcedimento10TextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento10TextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento10TextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento10TextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento10TextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento10TextBox.Clear();

                totalParcialProcedimento10TextBox.Text = resultado.ToString();

                txtFaturamentoConvenios.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(convenioTextBox.Text) + "     " + Convert.ToString(numCarteirinhaTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(codProcedimento10TextBox.Text) + "     " + Convert.ToString(regisProcedimento10TextBox.Text) + "     " + Convert.ToString(procedimento10TextBox.Text) + "     " + Convert.ToString(quantProcedimento10TextBox.Text) + "     " + Convert.ToString(valorProcedimento10TextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento10TextBox.Text) + "     " + Convert.ToString(descontoProcedimento10TextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento10TextBox.Text) + "\r\n";
            }
        }

        private void totalGeralTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (quantProcedimento1TextBox.Text == "")
            {
                quantProcedimento1TextBox.Text = "0";
            }

            if (valorProcedimento1TextBox.Text == "")
            {
                valorProcedimento1TextBox.Text = "0";
            }

            if (acrescimoProcedimento1TextBox.Text == "")
            {
                acrescimoProcedimento1TextBox.Text = "0";
            }

            if (descontoProcedimento1TextBox.Text == "")
            {
                descontoProcedimento1TextBox.Text = "0";
            }

            if (quantProcedimento2TextBox.Text == "")
            {              
                quantProcedimento2TextBox.Text = "0";              
            }

            if (valorProcedimento2TextBox.Text == "")
            {
                valorProcedimento2TextBox.Text = "0";               
            }

            if (acrescimoProcedimento2TextBox.Text == "")
            {
                acrescimoProcedimento2TextBox.Text = "0";               
            }

            if (descontoProcedimento2TextBox.Text == "")
            {
                descontoProcedimento2TextBox.Text = "0";            
            }

            if (quantProcedimento3TextBox.Text == "")
            {
                quantProcedimento3TextBox.Text = "0";                
            }

            if (valorProcedimento3TextBox.Text == "")
            {
                valorProcedimento3TextBox.Text = "0";             
            }

            if (acrescimoProcedimento3TextBox.Text == "")
            {
                acrescimoProcedimento3TextBox.Text = "0";             
            }

            if (descontoProcedimento3TextBox.Text == "")
            {
                descontoProcedimento3TextBox.Text = "0";             
            }

            if (quantProcedimento4TextBox.Text == "")
            {
                quantProcedimento4TextBox.Text = "0";             
            }

            if (valorProcedimento4TextBox.Text == "")
            {
                valorProcedimento4TextBox.Text = "0";               
            }

            if (acrescimoProcedimento4TextBox.Text == "")
            {
                acrescimoProcedimento4TextBox.Text = "0";              
            }

            if (descontoProcedimento4TextBox.Text == "")
            {
                descontoProcedimento4TextBox.Text = "0";              
            }

            if (quantProcedimento5TextBox.Text == "")
            {
                quantProcedimento5TextBox.Text = "0";              
            }

            if (valorProcedimento5TextBox.Text == "")
            {
                valorProcedimento5TextBox.Text = "0";              
            }

            if (acrescimoProcedimento5TextBox.Text == "")
            {
                acrescimoProcedimento5TextBox.Text = "0";             
            }

            if (descontoProcedimento5TextBox.Text == "")
            {
                descontoProcedimento5TextBox.Text = "0";               
            }

            if (quantProcedimento6TextBox.Text == "")
            {
                quantProcedimento6TextBox.Text = "0";             
            }

            if (valorProcedimento6TextBox.Text == "")
            {
                valorProcedimento6TextBox.Text = "0";            
            }

            if (acrescimoProcedimento6TextBox.Text == "")
            {
                acrescimoProcedimento6TextBox.Text = "0";              
            }

            if (descontoProcedimento6TextBox.Text == "")
            {
                descontoProcedimento6TextBox.Text = "0";              
            }

            if (quantProcedimento7TextBox.Text == "")
            {
                quantProcedimento7TextBox.Text = "0";             
            }

            if (valorProcedimento7TextBox.Text == "")
            {
                valorProcedimento7TextBox.Text = "0";              
            }


            if (acrescimoProcedimento7TextBox.Text == "")
            {
                acrescimoProcedimento7TextBox.Text = "0";          
            }

            if (descontoProcedimento7TextBox.Text == "")
            {
                descontoProcedimento7TextBox.Text = "0";             
            }

            if (quantProcedimento8TextBox.Text == "")
            {
                quantProcedimento8TextBox.Text = "0";          
            }

            if (valorProcedimento8TextBox.Text == "")
            {
                valorProcedimento8TextBox.Text = "0";          
            }

            if (acrescimoProcedimento8TextBox.Text == "")
            {
                acrescimoProcedimento8TextBox.Text = "0";            
            }

            if (descontoProcedimento8TextBox.Text == "")
            {
                descontoProcedimento8TextBox.Text = "0";         
            }

            if (quantProcedimento9TextBox.Text == "")
            {
                quantProcedimento9TextBox.Text = "0";          
            }

            if (valorProcedimento9TextBox.Text == "")
            {
                valorProcedimento9TextBox.Text = "0";          
            }

            if (acrescimoProcedimento9TextBox.Text == "")
            {
                acrescimoProcedimento9TextBox.Text = "0";           
            }

            if (descontoProcedimento9TextBox.Text == "")
            {
                descontoProcedimento9TextBox.Text = "0";          
            }

            if (quantProcedimento10TextBox.Text == "")
            {
                quantProcedimento10TextBox.Text = "0";       
            }

            if (valorProcedimento10TextBox.Text == "")
            {
                valorProcedimento10TextBox.Text = "0";         
            }

            if (acrescimoProcedimento10TextBox.Text == "")
            {
                acrescimoProcedimento10TextBox.Text = "0";            
            }

            if (descontoProcedimento10TextBox.Text == "")
            {
                descontoProcedimento10TextBox.Text = "0";         
            }

            if (totalParcialProcedimento1TextBox.Text == "")
            {
                totalParcialProcedimento1TextBox.Text = "0";    
            }

            if (totalParcialProcedimento2TextBox.Text == "")
            {
                totalParcialProcedimento2TextBox.Text = "0";          
            }

            if (totalParcialProcedimento3TextBox.Text == "")
            {
                totalParcialProcedimento3TextBox.Text = "0";    
            }

            if (totalParcialProcedimento4TextBox.Text == "")
            {
                totalParcialProcedimento4TextBox.Text = "0";         
            }

            if (totalParcialProcedimento5TextBox.Text == "")
            {
                totalParcialProcedimento5TextBox.Text = "0";      
            }

            if (totalParcialProcedimento6TextBox.Text == "")
            {
                totalParcialProcedimento6TextBox.Text = "0";           
            }

            if (totalParcialProcedimento7TextBox.Text == "")
            {
                totalParcialProcedimento7TextBox.Text = "0";        
            }

            if (totalParcialProcedimento8TextBox.Text == "")
            {
                totalParcialProcedimento8TextBox.Text = "0";          
            }

            if (totalParcialProcedimento9TextBox.Text == "")
            {
                totalParcialProcedimento9TextBox.Text = "0";           
            }

            if (totalParcialProcedimento10TextBox.Text == "")
            {
                totalParcialProcedimento10TextBox.Text = "0";
            }
           
                decimal sub1, sub2, sub3, sub4, sub5, sub6, sub7, sub8, sub9, sub10, resultadoToral;

                sub1 = Convert.ToDecimal(totalParcialProcedimento1TextBox.Text);
                sub2 = Convert.ToDecimal(totalParcialProcedimento2TextBox.Text);
                sub3 = Convert.ToDecimal(totalParcialProcedimento3TextBox.Text);
                sub4 = Convert.ToDecimal(totalParcialProcedimento4TextBox.Text);
                sub5 = Convert.ToDecimal(totalParcialProcedimento5TextBox.Text);
                sub6 = Convert.ToDecimal(totalParcialProcedimento6TextBox.Text);
                sub7 = Convert.ToDecimal(totalParcialProcedimento7TextBox.Text);
                sub8 = Convert.ToDecimal(totalParcialProcedimento8TextBox.Text);
                sub9 = Convert.ToDecimal(totalParcialProcedimento9TextBox.Text);
                sub10 = Convert.ToDecimal(totalParcialProcedimento10TextBox.Text);

                resultadoToral = (sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7 + sub8 + sub9 + sub10);

                totalGeralTextBox.Clear();

                totalGeralTextBox.Text = resultadoToral.ToString();

            txtFaturamentoConvenios.Text += "Total para o paciente = R$  " + Convert.ToString(totalGeralTextBox.Text) +"     " + Convert.ToString(competProcedimento1DateTimePicker.Text) + "\r\n";
        }

        private void btnPrintConvenios_Click(object sender, EventArgs e)
        {
            dados dados = new dados();

            frmPrintRelatorioGeralFaturamento fprgf = new frmPrintRelatorioGeralFaturamento();
            dados.convenios = txtFaturamentoConvenios.Text;
            fprgf.dados.Add(dados);
            fprgf.ShowDialog();
        }

        private void totalParcialProcedimento1particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento1particularTextBox.Text == "") || (quantProcedimento1particularTextBox.Text == "") || (acrescimoProcedimento1particularTextBox.Text == "") || (descontoProcedimento1particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento1particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento1particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento1particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento1particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento1particularTextBox.Clear();

                totalParcialProcedimento1particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento1particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento1particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento1particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento1particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento1particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento1particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento1TextBox.Text) +"\r\n";
            }
        }

        private void totalParcialProcedimento2particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento2particularTextBox.Text == "") || (quantProcedimento2particularTextBox.Text == "") || (acrescimoProcedimento2particularTextBox.Text == "") || (descontoProcedimento2particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento2particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento2particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento2particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento2particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento2particularTextBox.Clear();

                totalParcialProcedimento2particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento2particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento2particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento2particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento2particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento2particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento2particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento2TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento3particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento3particularTextBox.Text == "") || (quantProcedimento3particularTextBox.Text == "") || (acrescimoProcedimento3particularTextBox.Text == "") || (descontoProcedimento3particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento3particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento3particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento3particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento3particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento3particularTextBox.Clear();

                totalParcialProcedimento3particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento3particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento3particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento3particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento3particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento3particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento3particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento3TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento4particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento4particularTextBox.Text == "") || (quantProcedimento4particularTextBox.Text == "") || (acrescimoProcedimento4particularTextBox.Text == "") || (descontoProcedimento4particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento4particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento4particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento4particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento4particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento4particularTextBox.Clear();

                totalParcialProcedimento4particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento4particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento4particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento4particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento4particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento4particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento4particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento4TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento5particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento5particularTextBox.Text == "") || (quantProcedimento5particularTextBox.Text == "") || (acrescimoProcedimento5particularTextBox.Text == "") || (descontoProcedimento5particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento5particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento5particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento5particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento5particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento5particularTextBox.Clear();

                totalParcialProcedimento5particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento5particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento5particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento5particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento5particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento5particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento5particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento5TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento6particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento6particularTextBox.Text == "") || (quantProcedimento6particularTextBox.Text == "") || (acrescimoProcedimento6particularTextBox.Text == "") || (descontoProcedimento6particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento6particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento6particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento6particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento6particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento6particularTextBox.Clear();

                totalParcialProcedimento6particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento6particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento6particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento6particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento6particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento6particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento6particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento6TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento7particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento7particularTextBox.Text == "") || (quantProcedimento7particularTextBox.Text == "") || (acrescimoProcedimento7particularTextBox.Text == "") || (descontoProcedimento7particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento7particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento7particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento7particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento7particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento7particularTextBox.Clear();

                totalParcialProcedimento7particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento7particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento7particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento7particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento7particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento7particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento7particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento7TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento8particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento8particularTextBox.Text == "") || (quantProcedimento8particularTextBox.Text == "") || (acrescimoProcedimento8particularTextBox.Text == "") || (descontoProcedimento8particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento8particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento8particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento8particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento8particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento8particularTextBox.Clear();

                totalParcialProcedimento8particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento8particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento8particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento8particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento8particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento8particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento8particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento8TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento9particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento9particularTextBox.Text == "") || (quantProcedimento9particularTextBox.Text == "") || (acrescimoProcedimento9particularTextBox.Text == "") || (descontoProcedimento9particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento9particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento9particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento9particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento9particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento9particularTextBox.Clear();

                totalParcialProcedimento9particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento9particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento9particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento9particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento9particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento9particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento9particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento9TextBox.Text) + "\r\n";
            }
        }

        private void totalParcialProcedimento10particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((valorProcedimento10particularTextBox.Text == "") || (quantProcedimento10particularTextBox.Text == "") || (acrescimoProcedimento10particularTextBox.Text == "") || (descontoProcedimento10particularTextBox.Text == ""))
            {
                MessageBox.Show("Preencha as caixas do valor, quantidade, acréscimo e desconto, mesmo que com o valor '0', para realizar o cálculo do subtotal.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal valor, quant, acres, desc, resultado;

                valor = Convert.ToDecimal(valorProcedimento10particularTextBox.Text);
                quant = Convert.ToDecimal(quantProcedimento10particularTextBox.Text);
                acres = Convert.ToDecimal(acrescimoProcedimento10particularTextBox.Text);
                desc = Convert.ToDecimal(descontoProcedimento10particularTextBox.Text);

                resultado = (((valor * quant) + acres) - desc);

                totalParcialProcedimento10particularTextBox.Clear();

                totalParcialProcedimento10particularTextBox.Text = resultado.ToString();

                txtFaturamentoParticular.Text += Convert.ToString(nomePacienteTextBox.Text) + "     " + Convert.ToString(nomeProfissionalTextBox.Text) + "     " + Convert.ToString(inscricaoConselhoRegionalTextBox.Text) + "     " + Convert.ToString(especialidadeTextBox.Text) + "\r\n" + Convert.ToString(dataAtendimentoDateTimePicker.Text) + "     " + Convert.ToString(procedimento10particularTextBox.Text) + "     " + Convert.ToString(quantProcedimento10particularTextBox.Text) + "     " + Convert.ToString(valorProcedimento10particularTextBox.Text) + "     " + Convert.ToString(acrescimoProcedimento10particularTextBox.Text) + "     " + Convert.ToString(descontoProcedimento10particularTextBox.Text) + "     " + Convert.ToString(totalParcialProcedimento10particularTextBox.Text) + "     " + Convert.ToString(formaPagProcedimento10TextBox.Text) + "\r\n";
            }
        }

        private void totalGeralparticularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (quantProcedimento1particularTextBox.Text == "")
            {
                quantProcedimento1particularTextBox.Text = "0";
            }

            if (valorProcedimento1particularTextBox.Text == "")
            {
                valorProcedimento1particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento1particularTextBox.Text == "")
            {
                acrescimoProcedimento1particularTextBox.Text = "0";
            }

            if (descontoProcedimento1particularTextBox.Text == "")
            {
                descontoProcedimento1particularTextBox.Text = "0";
            }

            if (quantProcedimento2particularTextBox.Text == "")
            {
                quantProcedimento2particularTextBox.Text = "0";
            }

            if (valorProcedimento2particularTextBox.Text == "")
            {
                valorProcedimento2particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento2particularTextBox.Text == "")
            {
                acrescimoProcedimento2particularTextBox.Text = "0";
            }

            if (descontoProcedimento2particularTextBox.Text == "")
            {
                descontoProcedimento2particularTextBox.Text = "0";
            }

            if (quantProcedimento3particularTextBox.Text == "")
            {
                quantProcedimento3particularTextBox.Text = "0";
            }

            if (valorProcedimento3particularTextBox.Text == "")
            {
                valorProcedimento3particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento3particularTextBox.Text == "")
            {
                acrescimoProcedimento3particularTextBox.Text = "0";
            }

            if (descontoProcedimento3particularTextBox.Text == "")
            {
                descontoProcedimento3particularTextBox.Text = "0";
            }

            if (quantProcedimento4particularTextBox.Text == "")
            {
                quantProcedimento4particularTextBox.Text = "0";
            }

            if (valorProcedimento4particularTextBox.Text == "")
            {
                valorProcedimento4particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento4particularTextBox.Text == "")
            {
                acrescimoProcedimento4particularTextBox.Text = "0";
            }

            if (descontoProcedimento4particularTextBox.Text == "")
            {
                descontoProcedimento4particularTextBox.Text = "0";
            }

            if (quantProcedimento5particularTextBox.Text == "")
            {
                quantProcedimento5particularTextBox.Text = "0";
            }

            if (valorProcedimento5particularTextBox.Text == "")
            {
                valorProcedimento5particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento5particularTextBox.Text == "")
            {
                acrescimoProcedimento5particularTextBox.Text = "0";
            }

            if (descontoProcedimento5particularTextBox.Text == "")
            {
                descontoProcedimento5particularTextBox.Text = "0";
            }

            if (quantProcedimento6particularTextBox.Text == "")
            {
                quantProcedimento6particularTextBox.Text = "0";
            }

            if (valorProcedimento6particularTextBox.Text == "")
            {
                valorProcedimento6particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento6particularTextBox.Text == "")
            {
                acrescimoProcedimento6particularTextBox.Text = "0";
            }

            if (descontoProcedimento6particularTextBox.Text == "")
            {
                descontoProcedimento6particularTextBox.Text = "0";
            }

            if (quantProcedimento7particularTextBox.Text == "")
            {
                quantProcedimento7particularTextBox.Text = "0";
            }

            if (valorProcedimento7particularTextBox.Text == "")
            {
                valorProcedimento7particularTextBox.Text = "0";
            }


            if (acrescimoProcedimento7particularTextBox.Text == "")
            {
                acrescimoProcedimento7particularTextBox.Text = "0";
            }

            if (descontoProcedimento7particularTextBox.Text == "")
            {
                descontoProcedimento7particularTextBox.Text = "0";
            }

            if (quantProcedimento8particularTextBox.Text == "")
            {
                quantProcedimento8particularTextBox.Text = "0";
            }

            if (valorProcedimento8particularTextBox.Text == "")
            {
                valorProcedimento8particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento8particularTextBox.Text == "")
            {
                acrescimoProcedimento8particularTextBox.Text = "0";
            }

            if (descontoProcedimento8particularTextBox.Text == "")
            {
                descontoProcedimento8particularTextBox.Text = "0";
            }

            if (quantProcedimento9particularTextBox.Text == "")
            {
                quantProcedimento9particularTextBox.Text = "0";
            }

            if (valorProcedimento9particularTextBox.Text == "")
            {
                valorProcedimento9particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento9particularTextBox.Text == "")
            {
                acrescimoProcedimento9particularTextBox.Text = "0";
            }

            if (descontoProcedimento9particularTextBox.Text == "")
            {
                descontoProcedimento9particularTextBox.Text = "0";
            }

            if (quantProcedimento10particularTextBox.Text == "")
            {
                quantProcedimento10particularTextBox.Text = "0";
            }

            if (valorProcedimento10particularTextBox.Text == "")
            {
                valorProcedimento10particularTextBox.Text = "0";
            }

            if (acrescimoProcedimento10particularTextBox.Text == "")
            {
                acrescimoProcedimento10particularTextBox.Text = "0";
            }

            if (descontoProcedimento10particularTextBox.Text == "")
            {
                descontoProcedimento10particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento1particularTextBox.Text == "")
            {
                totalParcialProcedimento1particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento2particularTextBox.Text == "")
            {
                totalParcialProcedimento2particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento3particularTextBox.Text == "")
            {
                totalParcialProcedimento3particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento4particularTextBox.Text == "")
            {
                totalParcialProcedimento4particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento5particularTextBox.Text == "")
            {
                totalParcialProcedimento5particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento6particularTextBox.Text == "")
            {
                totalParcialProcedimento6particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento7particularTextBox.Text == "")
            {
                totalParcialProcedimento7particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento8particularTextBox.Text == "")
            {
                totalParcialProcedimento8particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento9particularTextBox.Text == "")
            {
                totalParcialProcedimento9particularTextBox.Text = "0";
            }

            if (totalParcialProcedimento10particularTextBox.Text == "")
            {
                totalParcialProcedimento10particularTextBox.Text = "0";
            }

            decimal sub1, sub2, sub3, sub4, sub5, sub6, sub7, sub8, sub9, sub10, resultadoToral;

            sub1 = Convert.ToDecimal(totalParcialProcedimento1particularTextBox.Text);
            sub2 = Convert.ToDecimal(totalParcialProcedimento2particularTextBox.Text);
            sub3 = Convert.ToDecimal(totalParcialProcedimento3particularTextBox.Text);
            sub4 = Convert.ToDecimal(totalParcialProcedimento4particularTextBox.Text);
            sub5 = Convert.ToDecimal(totalParcialProcedimento5particularTextBox.Text);
            sub6 = Convert.ToDecimal(totalParcialProcedimento6particularTextBox.Text);
            sub7 = Convert.ToDecimal(totalParcialProcedimento7particularTextBox.Text);
            sub8 = Convert.ToDecimal(totalParcialProcedimento8particularTextBox.Text);
            sub9 = Convert.ToDecimal(totalParcialProcedimento9particularTextBox.Text);
            sub10 = Convert.ToDecimal(totalParcialProcedimento10particularTextBox.Text);

            resultadoToral = (sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7 + sub8 + sub9 + sub10);

            totalGeralparticularTextBox.Clear();

            totalGeralparticularTextBox.Text = resultadoToral.ToString();

            txtFaturamentoParticular.Text += "Total para o paciente = R$  " + Convert.ToString(totalGeralparticularTextBox.Text) + "\r\n";
        }

        private void btnPrintParticulares_Click(object sender, EventArgs e)
        {
            dados dados = new dados();

            frmPrintRelatorioFaturamentoParticulares fprfp = new frmPrintRelatorioFaturamentoParticulares();
            dados.particulares = txtFaturamentoParticular.Text;
            fprfp.dados.Add(dados);
            fprfp.ShowDialog();
        }

        private void btnFiltrarProcedimentos_Click(object sender, EventArgs e)
        {
            tabelaPacienteBindingSource.Filter = $"convenio like '*{txtBuscarProcedimento.Text}*'";
            tabelaPacienteBindingSource.Filter = $"dataAtendimento >= '#{mkbDataProcedimento.Text}#'";

            txtBuscarProcedimento.Clear();
            mkbDataProcedimento.Clear();
        }

        private void btnLimparCalculos_Click(object sender, EventArgs e)
        {
            txtReal.Clear();
            txtIR.Clear();
            txtPIS.Clear();
            txtCOFINS.Clear();
            txtCSLL.Clear();
            txtSOMA.Clear();
            txtRetencoes.Clear();
            txtISS.Clear();
            txtAliqIR.Clear();
            txtAliqPIS.Clear();
            txtAliqCOFINS.Clear();
            txtAliqCSLL.Clear();
            txtAliqISS.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtReal.Text == "" || txtAliqIR.Text == "" || txtAliqPIS.Text == "" || txtAliqCOFINS.Text == "" || txtAliqCSLL.Text == "" || txtAliqISS.Text == "")
            {
                MessageBox.Show("Preencha com o valor e as alíquotas necessárias para efetuar os cálculos! Coloque zero '0' se não for calcular a alíquota.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal valor, aliqIR, aliqPIS, aliqCOFINS, aliqCSLL, aliqISS, resultadoIR, resultadoPIS, resultadoCOFINS, resultadoCSLL, resultadoSOMA, resultadoRETENCOES, resultadoISS;

                valor = Convert.ToDecimal(txtReal.Text);
                aliqIR = Convert.ToDecimal(txtAliqIR.Text);
                aliqPIS = Convert.ToDecimal(txtAliqPIS.Text);
                aliqCOFINS = Convert.ToDecimal(txtAliqCOFINS.Text);
                aliqCSLL = Convert.ToDecimal(txtAliqCSLL.Text);
                aliqISS = Convert.ToDecimal(txtAliqISS.Text);


                resultadoIR = ((valor * aliqIR) / 100);
                txtIR.Text = resultadoIR.ToString();

                resultadoPIS = ((valor * aliqPIS) / 100);
                txtPIS.Text = resultadoPIS.ToString();

                resultadoCOFINS = ((valor * aliqCOFINS) / 100);
                txtCOFINS.Text = resultadoCOFINS.ToString();

                resultadoCSLL = ((valor * aliqCSLL) / 100);
                txtCSLL.Text = resultadoCSLL.ToString();

                resultadoISS = ((valor * aliqISS) / 100);
                txtISS.Text = resultadoISS.ToString();

                resultadoSOMA = (resultadoPIS + resultadoCOFINS + resultadoCSLL);
                txtSOMA.Text = resultadoSOMA.ToString();

                resultadoRETENCOES = (resultadoIR + resultadoSOMA);
                txtRetencoes.Text = resultadoRETENCOES.ToString();
            }
        }
    }
}
