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
using System.Windows.Forms.DataVisualization.Charting;

namespace segmentoOtoneurologia
{
    public partial class frmExames : Form
    {
        public frmExames()
        {
            InitializeComponent();

            gbDadosPaciente.Enabled = false;
            gbTipoAudiograma.Enabled = false;

            tsbPreencherAudio.Enabled = false;
            tsbPreencherTimpanogramas.Enabled = false;

            ((Control)tabControl1.TabPages["tabPage2"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage4"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage5"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage6"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage7"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage36"]).Enabled = false;
        }

        void OpenData()
        {
            for (int i = 0; i <= 400; i++)
            {
                Thread.Sleep(2);
            }
        }

        private void tabelaExamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)//evento do boTão salvar na barra de ferramentas
        {
            if (string.IsNullOrEmpty(identificacaoTextBox.Text))
            {
                MessageBox.Show("O campo 'Identificação' não está preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.tabelaExamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

            MessageBox.Show("Os exames foram salvos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbDadosPaciente.Enabled = false;
            gbTipoAudiograma.Enabled = false;

            tipoAudiometriaComboBox.SelectedIndex = -1;

            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage4"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage5"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage6"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage7"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage36"]).Enabled = false;
        }

        private void frmExames_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaLaudario1'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaLaudario1TableAdapter.Fill(this.segmsaude001DataSet.tabelaLaudario1);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaLaudario1'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaLaudario1TableAdapter.Fill(this.segmsaude001DataSet.tabelaLaudario1);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaExames'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaExamesTableAdapter.Fill(this.segmsaude001DataSet.tabelaExames);           
        }

        private void frmExames_FormClosing(object sender, FormClosingEventArgs e)//evento do formClosing
        {
            if (e.CloseReason == CloseReason.UserClosing)//instancia o evento
            {
                //instancia a messageBox
                dynamic mboxResult = MessageBox.Show("Já salvou os dados inseridos ou alterados?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (mboxResult == DialogResult.Cancel)//se escolher cancel no dialógo
                {
                    e.Cancel = true;//realmente cancela a ação e volta ao frm
                }

                else if (mboxResult == DialogResult.OK)//se escolhe ok
                {
                    frmExames fec = new frmExames();//instancia o frm já aberto
                    fec.Close();//fecha ele
                }
            }
        }

        //**aqui temos a construção dos gráficos**
        //**de impedanciometria**

        private void btnPlotarImpOD_Click(object sender, EventArgs e)//evento do btn plotar od
        {
            try
            {
                chartODimp.Series.Clear();//limpa o gráfico               

                fechaodTextBox.Visible = true;

                decimal valorA, valorB, valorC;

                valorA = Convert.ToDecimal(pressaoodTextBox.Text);
                valorB = Convert.ToDecimal(complodTextBox.Text);
                valorC = Convert.ToDecimal(fechaodTextBox.Text);

                if (rbExibeEstimativaOD.Checked == true)
                {
                    var fundoODimp = new NamedImage("sombraTimpanoOD", Properties.Resources.sombraTimpanoOD);
                    chartODimp.Images.Clear();
                    chartODimp.Images.Add(fundoODimp);
                    chartODimp.ChartAreas[0].BackImage = "sombraTimpanoOD";
                }
                else if (rbOcultaEstimativaOD.Checked == true)
                {
                    var fundoODimp = new NamedImage("brancoTimpano", Properties.Resources.brancoTimpano);
                    chartODimp.Images.Clear();
                    chartODimp.Images.Add(fundoODimp);
                    chartODimp.ChartAreas[0].BackImage = "brancoTimpano";
                }

                string seriesNameA = "liga A";
                Series serA = chartODimp.Series.Add(seriesNameA);

                serA.ChartArea = chartODimp.ChartAreas[0].Name;
                serA.Name = seriesNameA;
                serA.ChartType = SeriesChartType.Line;

                serA.Points.AddXY(200, 0);
                serA.Points.AddXY(valorA, valorB);

                serA.IsVisibleInLegend = false;
                serA.MarkerStyle = MarkerStyle.None;
                serA.BorderColor = Color.Transparent;
                serA.Color = Color.Red;
                serA.BorderWidth = Convert.ToInt32(1.5);

                //******************

                string seriesNameB = "liga B";
                Series serB = chartODimp.Series.Add(seriesNameB);

                serB.ChartArea = chartODimp.ChartAreas[0].Name;
                serB.Name = seriesNameB;
                serB.ChartType = SeriesChartType.Line;

                serB.Points.AddXY(valorA, valorB);
                serB.Points.AddXY(valorC, 0);

                serB.IsVisibleInLegend = false;
                serB.MarkerStyle = MarkerStyle.None;
                serB.BorderColor = Color.Transparent;
                serB.Color = Color.Red;
                serB.BorderWidth = Convert.ToInt32(1.5);

                if (curvaBodCheckBox.Checked == true)
                {
                    chartODimp.Series.Clear();//limpa o gráfico
                    fechaodTextBox.Visible = false;

                    string seriesNameC = "liga C";
                    Series serC = chartODimp.Series.Add(seriesNameC);

                    serC.ChartArea = chartODimp.ChartAreas[0].Name;
                    serC.Name = seriesNameC;
                    serC.ChartType = SeriesChartType.Line;

                    serC.Points.AddXY(200, 0);
                    serC.Points.AddXY(valorA, valorB);

                    serC.IsVisibleInLegend = false;
                    serC.MarkerStyle = MarkerStyle.None;
                    serC.BorderColor = Color.Transparent;
                    serC.Color = Color.Red;
                    serC.BorderWidth = Convert.ToInt32(1.5);

                    //******************

                    string seriesNameD = "liga D";
                    Series serD = chartODimp.Series.Add(seriesNameD);

                    serD.ChartArea = chartODimp.ChartAreas[0].Name;
                    serD.Name = seriesNameD;
                    serD.ChartType = SeriesChartType.Line;

                    serD.Points.AddXY(valorA, valorB);
                    serD.Points.AddXY(-200000, 0);

                    serD.IsVisibleInLegend = false;
                    serD.MarkerStyle = MarkerStyle.None;
                    serD.BorderColor = Color.Transparent;
                    serD.Color = Color.Red;
                    serD.BorderWidth = Convert.ToInt32(1.5);
                }
            }
            catch
            {
                MessageBox.Show("Valor (es) incorreto (s) para plotar o gráfico!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnPlotarImpOE_Click(object sender, EventArgs e)//evento do btn plotar o gráfico da oe
        {
            try
            {
                chartOEimp.Series.Clear();//limpa o gráfico
                fechaoeTextBox.Visible = true;

                decimal valorA, valorB, valorC;

                valorA = Convert.ToDecimal(pressaooeTextBox.Text);
                valorB = Convert.ToDecimal(comploeTextBox.Text);
                valorC = Convert.ToDecimal(fechaoeTextBox.Text);

                if (rbExibeEstimativaOE.Checked == true)
                {
                    var fundoOEimp = new NamedImage("sombraTimpanoOE", Properties.Resources.sombraTimpanoOE);
                    chartOEimp.Images.Clear();
                    chartOEimp.Images.Add(fundoOEimp);
                    chartOEimp.ChartAreas[0].BackImage = "sombraTimpanoOE";
                }
                else if (rbOcultaEstimativaOE.Checked == true)
                {
                    var fundoOEimp = new NamedImage("brancoTimpano", Properties.Resources.brancoTimpano);
                    chartOEimp.Images.Clear();
                    chartOEimp.Images.Add(fundoOEimp);
                    chartOEimp.ChartAreas[0].BackImage = "brancoTimpano";
                }

                string seriesNameA = "liga A";
                Series serA = chartOEimp.Series.Add(seriesNameA);

                serA.ChartArea = chartOEimp.ChartAreas[0].Name;
                serA.Name = seriesNameA;
                serA.ChartType = SeriesChartType.Line;
              
                serA.Points.AddXY(200, 0);
                serA.Points.AddXY(valorA, valorB);

                serA.IsVisibleInLegend = false;
                serA.MarkerStyle = MarkerStyle.None;
                serA.BorderColor = Color.Transparent;
                serA.Color = Color.DodgerBlue;
                serA.BorderWidth = Convert.ToInt32(1.5);

                //******************

                string seriesNameB = "liga B";
                Series serB = chartOEimp.Series.Add(seriesNameB);

                serB.ChartArea = chartOEimp.ChartAreas[0].Name;
                serB.Name = seriesNameB;
                serB.ChartType = SeriesChartType.Line;

                serB.Points.AddXY(valorA, valorB);
                serB.Points.AddXY(valorC, 0);

                serB.IsVisibleInLegend = false;
                serB.MarkerStyle = MarkerStyle.None;
                serB.BorderColor = Color.Transparent;
                serB.Color = Color.DodgerBlue;
                serB.BorderWidth = Convert.ToInt32(1.5);

                if (curvaBoeCheckBox.Checked == true)
                {
                    chartOEimp.Series.Clear();//limpa o gráfico
                    fechaoeTextBox.Visible = false;

                    string seriesNameC = "liga C";
                    Series serC = chartOEimp.Series.Add(seriesNameC);

                    serC.ChartArea = chartOEimp.ChartAreas[0].Name;
                    serC.Name = seriesNameC;
                    serC.ChartType = SeriesChartType.Line;

                    serC.Points.AddXY(200, 0);
                    serC.Points.AddXY(valorA, valorB);

                    serC.IsVisibleInLegend = false;
                    serC.MarkerStyle = MarkerStyle.None;
                    serC.BorderColor = Color.Transparent;
                    serC.Color = Color.DodgerBlue;
                    serC.BorderWidth = Convert.ToInt32(1.5);

                    //******************

                    string seriesNameD = "liga D";
                    Series serD = chartOEimp.Series.Add(seriesNameD);

                    serD.ChartArea = chartOEimp.ChartAreas[0].Name;
                    serD.Name = seriesNameD;
                    serD.ChartType = SeriesChartType.Line;

                    serD.Points.AddXY(valorA, valorB);
                    serD.Points.AddXY(-200000, 0);

                    serD.IsVisibleInLegend = false;
                    serD.MarkerStyle = MarkerStyle.None;
                    serD.BorderColor = Color.Transparent;
                    serD.Color = Color.DodgerBlue;
                    serD.BorderWidth = Convert.ToInt32(1.5);
                }
            }
            catch
            {
                MessageBox.Show("Valor (es) incorreto (s) para plotar o gráfico!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrarLaudos_Click(object sender, EventArgs e)//evento do btnCadastrarLaudos
        {
            frmLaudario fl = new frmLaudario();//instancia o frm laudário
            fl.ShowDialog();//abre o frm
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)//Evento da aba 36 do tabcontrol 1 - geral
        {
            if (tabControl1.SelectedTab == tabPage36)//se a aba 36 for selecionada com o mouse
            {
                tabelaExamesBindingNavigator.Enabled = false;//a barra de ferramentas fica inabilitada

            }

            else//caso contrário
            {
                tabelaExamesBindingNavigator.Enabled = true;//a barra de ferramentas fica habilitada
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscaCategoria.Text == "Nome do laudo")
            {
                tabelaLaudario1BindingSource.Filter = $"nomeLaudo like '*{txtBusca.Text}*'"; //filtra a base de dados do mysql pelo nome do laudo digitado na txt e retorna no dgw 
            }

            else
            {
                if (cbBuscaCategoria.Text == "Categoria")
                {
                    tabelaLaudario1BindingSource.Filter = $"categoria like '*{txtBusca.Text}*'"; //filtra a base de dados do mysql pela categoria digitado na txt e retorna no dgw 
                }

                else
                {
                    if (cbBuscaCategoria.Text == "")
                    {
                        MessageBox.Show("Selecione o tipo de busca antes de digitar.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        //**aqui temos a construção dos gráficos**
        //**de audiometria**

        //Audiometria em Campo Livre***

        private void btnCalcularMediaCom_Click(object sender, EventArgs e)//evento do btn calcular média tritonal com AASI
        {
            try//no bloco de tratamento de erros
            {
                comMEDIATextBox.Clear();//limpa o txt média tritonal com AASI

                if ((com500ComboBox.Text == "") || (com1kComboBox.Text == "") || (com2KComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média tritonal de 500Hz, 1kHz e 2kHZ.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((chkAusente500comCheckBox.Checked == true) || (chkAusente1kcomCheckBox.Checked == true) || (chkAusente2kcomCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        comMEDIATextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, media;//criam-se três variáveis

                        //as variáveis são atribuídas aos respectivos txt's, convertendo-os em decimais
                        valor1 = Convert.ToInt32(com500ComboBox.Text);
                        valor2 = Convert.ToInt32(com1kComboBox.Text);
                        valor3 = Convert.ToInt32(com2KComboBox.Text);

                        media = ((valor1 + valor2 + valor3) / 3);//cáculo da média tritonal

                        comMEDIATextBox.Text = Convert.ToString(media);//atribui o resultado da média ao txt média com AASI, convertendo-o para string
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnCalcularMediaSemAASI_Click(object sender, EventArgs e)//evento do btn calcular média de 500Hz, 1kHZ e 2kHZ sem AASI
        {
            try//no bloco de tratamento de erros
            {
                semMEDIATextBox.Clear();//limpa o txt média tritonal sem AASI

                if ((sem500ComboBox.Text == "") || (sem1kComboBox.Text == "") || (sem2KComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média tritonal de 500Hz, 1kHz e 2kHZ.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((chkAusente500semCheckBox.Checked == true) || (chkAusente1ksemCheckBox.Checked == true) || (chkAusente2ksemCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        semMEDIATextBox.Text = "Saída máxima";//atritui a frase à txt média sem AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, media;//criam-se três variáveis

                        //as variáveis são atribuídas aos respectivos txt's, convertendo-os em decimais
                        valor1 = Convert.ToInt32(sem500ComboBox.Text);
                        valor2 = Convert.ToInt32(sem1kComboBox.Text);
                        valor3 = Convert.ToInt32(sem2KComboBox.Text);

                        media = ((valor1 + valor2 + valor3) / 3);//cáculo da média tritonal

                        semMEDIATextBox.Text = Convert.ToString(media);//atribui o resultado da média ao txt média sem AASI, convertendo-o para string
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnPlotarAudioAltOD_Click(object sender, EventArgs e)
        {
            chartAltOD.Series.Clear();// limpa o chart
           
            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 9;
           
            chartAltOD.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartAltOD.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;           

            string seriesName1 = "grade1";
            Series ser1 = chartAltOD.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);
            

            string seriesName2 = "grade2";
            Series ser2 = chartAltOD.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(3, -10);  // x, high
            ser2.Points.AddXY(3, 120);

            string seriesName3 = "grade3";
            Series ser3 = chartAltOD.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(5, -10);  // x, high
            ser3.Points.AddXY(5, 120);

            string seriesName4 = "grade4";
            Series ser4 = chartAltOD.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.Points.AddXY(6, -10);  // x, high
            ser4.Points.AddXY(6, 120);

            string seriesName5 = "grade5";
            Series ser5 = chartAltOD.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(7, -10);  // x, high
            ser5.Points.AddXY(7, 120);

            string seriesName6 = "grade6";
            Series ser6 = chartAltOD.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.Points.AddXY(8, -10);  // x, high
            ser6.Points.AddXY(8, 120);

            string seriesName7 = "grade7";
            Series ser7 = chartAltOD.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(9, -10);  // x, high
            ser7.Points.AddXY(9, 120);

            string seriesName7a = "grade12_5k";
            Series ser7a = chartAltOD.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(4.25, -10);  // x, high
            ser7a.Points.AddXY(4.25, 120);

            //***PARA A SIMBOLOGIA***

            //***

            if (string.IsNullOrEmpty(tipoAudiometriaComboBox.Text))
            {
                MessageBox.Show("Escolha 'Audiometria de altas frequências' para a plotagem da simbologia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria de altas frequências")
            {
                string seriesName8 = "simbol_9k";
                Series ser8 = chartAltOD.Series.Add(seriesName8);

                ser8.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser8.Name = seriesName8;
                ser8.ChartType = SeriesChartType.Point;

                if (va9kodComboBox.Text == "")
                {
                    var vaODpresente9vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente9vaz);
                    ser8.MarkerImage = "vazio";
                }

                else if (va9kodComboBox.Text != "")
                {
                    int valor8;
                    valor8 = Convert.ToInt32(va9kodComboBox.Text);
                    ser8.Points.AddXY(2, valor8);  // x, high
                }

                if ((chkAusente9kODCheckBox.Checked == false) && (chkMasc9kODCheckBox.Checked == false))
                {
                    var vaODpresente8p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente8p);
                    ser8.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente9kODCheckBox.Checked == true) && (chkMasc9kODCheckBox.Checked == false))
                {
                    var vaODausente8a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente8a);
                    ser8.MarkerImage = "vaODausente";
                }

                else if ((chkAusente9kODCheckBox.Checked == false) && (chkMasc9kODCheckBox.Checked == true))
                {
                    var vaODpresente8m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente8m);
                    ser8.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc9kODCheckBox.Checked == true) && (chkAusente9kODCheckBox.Checked == true))
                {
                    var vaODpresente8ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente8ma);
                    ser8.MarkerImage = "vaODmascAusente";
                }


                //***
                string seriesName9 = "simbol_10k";
                Series ser9 = chartAltOD.Series.Add(seriesName9);

                ser9.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser9.Name = seriesName9;
                ser9.ChartType = SeriesChartType.Point;

                if (va10kodComboBox.Text == "")
                {
                    var vaODpresente10vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente10vaz);
                    ser9.MarkerImage = "vazio";
                }

                else if (va10kodComboBox.Text != "")
                {
                    int valor9;
                    valor9 = Convert.ToInt32(va10kodComboBox.Text);
                    ser9.Points.AddXY(3, valor9);  // x, high
                }

                if ((chkAusente10kODCheckBox.Checked == false) && (chkMasc10kODCheckBox.Checked == false))
                {
                    var vaODpresente9p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente9p);
                    ser9.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente10kODCheckBox.Checked == true) && (chkMasc10kODCheckBox.Checked == false))
                {
                    var vaODausente9a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente9a);
                    ser9.MarkerImage = "vaODausente";
                }

                else if ((chkAusente10kODCheckBox.Checked == false) && (chkMasc10kODCheckBox.Checked == true))
                {
                    var vaODpresente9m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente9m);
                    ser9.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc10kODCheckBox.Checked == true) && (chkAusente10kODCheckBox.Checked == true))
                {
                    var vaODpresente9ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente9ma);
                    ser9.MarkerImage = "vaODmascAusente";
                }


                //***
                string seriesName10 = "simbol_12_5k";
                Series ser10 = chartAltOD.Series.Add(seriesName10);

                ser10.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser10.Name = seriesName10;
                ser10.ChartType = SeriesChartType.Point;

                if (va12e5kodComboBox.Text == "")
                {
                    var vaODpresente12_5vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente12_5vaz);
                    ser10.MarkerImage = "vazio";
                }

                else if (va12e5kodComboBox.Text != "")
                {
                    int valor10;
                    valor10 = Convert.ToInt32(va12e5kodComboBox.Text);
                    ser10.Points.AddXY(4.25, valor10);  // x, high
                }

                if ((chkAusente12_5kODCheckBox.Checked == false) && (chkMasc12_5kODCheckBox.Checked == false))
                {
                    var vaODpresente10p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente10p);
                    ser10.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente12_5kODCheckBox.Checked == true) && (chkMasc12_5kODCheckBox.Checked == false))
                {
                    var vaODausente10a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente10a);
                    ser10.MarkerImage = "vaODausente";
                }

                else if ((chkAusente12_5kODCheckBox.Checked == false) && (chkMasc12_5kODCheckBox.Checked == true))
                {
                    var vaODpresente10m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente10m);
                    ser10.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc12_5kODCheckBox.Checked == true) && (chkAusente12_5kODCheckBox.Checked == true))
                {
                    var vaODpresente10ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente10ma);
                    ser10.MarkerImage = "vaODmascAusente";
                }


                //***
                string seriesName11 = "simbol_14k";
                Series ser11 = chartAltOD.Series.Add(seriesName11);

                ser11.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser11.Name = seriesName11;
                ser11.ChartType = SeriesChartType.Point;

                if (va14kodComboBox.Text == "")
                {
                    var vaODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente14vaz);
                    ser11.MarkerImage = "vazio";
                }

                else if (va14kodComboBox.Text != "")
                {
                    int valor11;
                    valor11 = Convert.ToInt32(va14kodComboBox.Text);
                    ser11.Points.AddXY(5, valor11);  // x, high
                }

                if ((chkAusente14kODCheckBox.Checked == false) && (chkMasc14kODCheckBox.Checked == false))
                {
                    var vaODpresente11p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente11p);
                    ser11.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente14kODCheckBox.Checked == true) && (chkMasc14kODCheckBox.Checked == false))
                {
                    var vaODausente11a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente11a);
                    ser11.MarkerImage = "vaODausente";
                }

                else if ((chkAusente14kODCheckBox.Checked == false) && (chkMasc14kODCheckBox.Checked == true))
                {
                    var vaODpresente11m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente11m);
                    ser11.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc14kODCheckBox.Checked == true) && (chkAusente14kODCheckBox.Checked == true))
                {
                    var vaODpresente11ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente11ma);
                    ser11.MarkerImage = "vaODmascAusente";
                }


                //***
                string seriesName12 = "simbol_16k";
                Series ser12 = chartAltOD.Series.Add(seriesName12);

                ser12.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser12.Name = seriesName12;
                ser12.ChartType = SeriesChartType.Point;

                if (va16kodComboBox.Text == "")
                {
                    var vaODpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente16vaz);
                    ser12.MarkerImage = "vazio";
                }

                else if (va16kodComboBox.Text != "")
                {
                    int valor12;
                    valor12 = Convert.ToInt32(va16kodComboBox.Text);
                    ser12.Points.AddXY(6, valor12);  // x, high
                }

                if ((chkAusente16kODCheckBox.Checked == false) && (chkMasc16kODCheckBox.Checked == false))
                {
                    var vaODpresente12p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente12p);
                    ser12.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente16kODCheckBox.Checked == true) && (chkMasc16kODCheckBox.Checked == false))
                {
                    var vaODausente12a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente12a);
                    ser12.MarkerImage = "vaODausente";
                }

                else if ((chkAusente16kODCheckBox.Checked == false) && (chkMasc16kODCheckBox.Checked == true))
                {
                    var vaODpresente12m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente12m);
                    ser12.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc16kODCheckBox.Checked == true) && (chkAusente16kODCheckBox.Checked == true))
                {
                    var vaODpresente12ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente12ma);
                    ser12.MarkerImage = "vaODmascAusente";
                }


                //***
                string seriesName13 = "simbol_18k";
                Series ser13 = chartAltOD.Series.Add(seriesName13);

                ser13.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (va18kodComboBox.Text == "")
                {
                    var vaODpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                else if (va18kodComboBox.Text != "")
                {
                    int valor13;
                    valor13 = Convert.ToInt32(va18kodComboBox.Text);
                    ser13.Points.AddXY(7, valor13);  // x, high
                }


                if ((chkAusente18kODCheckBox.Checked == false) && (chkMasc18kODCheckBox.Checked == false))
                {
                    var vaODpresente13p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente13p);
                    ser13.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente18kODCheckBox.Checked == true) && (chkMasc18kODCheckBox.Checked == false))
                {
                    var vaODausente13a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente13a);
                    ser13.MarkerImage = "vaODausente";
                }

                else if ((chkAusente18kODCheckBox.Checked == false) && (chkMasc18kODCheckBox.Checked == true))
                {
                    var vaODpresente13m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente13m);
                    ser13.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc18kODCheckBox.Checked == true) && (chkAusente18kODCheckBox.Checked == true))
                {
                    var vaODpresente13ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente13ma);
                    ser13.MarkerImage = "vaODmascAusente";
                }


                //***
                string seriesName14 = "simbol_20k";
                Series ser14 = chartAltOD.Series.Add(seriesName14);

                ser14.ChartArea = chartAltOD.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (va20kodComboBox.Text == "")
                {
                    var vaODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (va20kodComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(va20kodComboBox.Text);
                    ser14.Points.AddXY(8, valor14);  // x, high
                }


                if ((chkAusente20kODCheckBox.Checked == false) && (chkMasc20kODCheckBox.Checked == false))
                {
                    var vaODpresente14p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente14p);
                    ser14.MarkerImage = "vaODpresente";
                }

                else if ((chkAusente20kODCheckBox.Checked == true) && (chkMasc20kODCheckBox.Checked == false))
                {
                    var vaODausente14a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODausente14a);
                    ser14.MarkerImage = "vaODausente";
                }

                else if ((chkAusente20kODCheckBox.Checked == false) && (chkMasc20kODCheckBox.Checked == true))
                {
                    var vaODpresente14m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente14m);
                    ser14.MarkerImage = "vaODmascPresente";
                }

                else if ((chkMasc20kODCheckBox.Checked == true) && (chkAusente20kODCheckBox.Checked == true))
                {
                    var vaODpresente14ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaODpresente14ma);
                    ser14.MarkerImage = "vaODmascAusente";
                }


                //***SEQUÊNCIA PARA LIGAR SIMBOLOGIA

                try
                {
                    string seriesName15 = "liga 9k_10K";
                    Series ser15 = chartAltOD.Series.Add(seriesName15);

                    ser15.ChartArea = chartAltOD.ChartAreas[0].Name;
                    ser15.Name = seriesName15;
                    ser15.ChartType = SeriesChartType.Line;

                    if (chkliga9_10ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va9kodComboBox.Text);
                        valorB = Convert.ToInt32(va10kodComboBox.Text);

                        ser15.Points.AddXY(2, valorA);
                        ser15.Points.AddXY(3, valorB);

                        ser15.BorderColor = Color.Transparent;
                        ser15.Color = Color.Red;
                        ser15.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga9_10ODCheckBox.Checked == false)
                    {
                        ser15.Points.Clear();
                    }

                    //*******

                    string seriesName16 = "liga 10k_12_5K";
                    Series ser16 = chartAltOD.Series.Add(seriesName16);

                    ser16.ChartArea = chartAltOD.ChartAreas[0].Name;
                    ser16.Name = seriesName16;
                    ser16.ChartType = SeriesChartType.Line;

                    if (chkliga10_12_5ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va10kodComboBox.Text);
                        valorB = Convert.ToInt32(va12e5kodComboBox.Text);

                        ser16.Points.AddXY(3, valorA);
                        ser16.Points.AddXY(4.25, valorB);

                        ser16.BorderColor = Color.Transparent;
                        ser16.Color = Color.Red;
                        ser16.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga10_12_5ODCheckBox.Checked == false)
                    {
                        ser16.Points.Clear();
                    }

                    //******


                    string seriesName17 = "liga 12_5k_14K";
                    Series ser17 = chartAltOD.Series.Add(seriesName17);

                    ser17.ChartArea = chartAltOD.ChartAreas[0].Name;
                    ser17.Name = seriesName17;
                    ser17.ChartType = SeriesChartType.Line;

                    if (chkliga12_5_14ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va12e5kodComboBox.Text);
                        valorB = Convert.ToInt32(va14kodComboBox.Text);

                        ser17.Points.AddXY(4.25, valorA);
                        ser17.Points.AddXY(5, valorB);

                        ser17.BorderColor = Color.Transparent;
                        ser17.Color = Color.Red;
                        ser17.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga12_5_14ODCheckBox.Checked == false)
                    {
                        ser17.Points.Clear();
                    }

                    //*****

                    string seriesName18 = "liga 14k_16K";
                    Series ser18 = chartAltOD.Series.Add(seriesName18);

                    ser18.ChartArea = chartAltOD.ChartAreas[0].Name;
                    ser18.Name = seriesName18;
                    ser18.ChartType = SeriesChartType.Line;

                    if (chkliga14_16ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va14kodComboBox.Text);
                        valorB = Convert.ToInt32(va16kodComboBox.Text);

                        ser18.Points.AddXY(5, valorA);
                        ser18.Points.AddXY(6, valorB);

                        ser18.BorderColor = Color.Transparent;
                        ser18.Color = Color.Red;
                        ser18.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga14_16ODCheckBox.Checked == false)
                    {
                        ser18.Points.Clear();
                    }


                    //******

                    string seriesName19 = "liga 16k_18K";
                    Series ser19 = chartAltOD.Series.Add(seriesName19);

                    ser19.ChartArea = chartAltOD.ChartAreas[0].Name;
                    ser19.Name = seriesName19;
                    ser19.ChartType = SeriesChartType.Line;

                    if (chkliga16_18ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va16kodComboBox.Text);
                        valorB = Convert.ToInt32(va18kodComboBox.Text);

                        ser19.Points.AddXY(6, valorA);
                        ser19.Points.AddXY(7, valorB);

                        ser19.BorderColor = Color.Transparent;
                        ser19.Color = Color.Red;
                        ser19.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga16_18ODCheckBox.Checked == false)
                    {
                        ser19.Points.Clear();
                    }

                    //******

                    string seriesName20 = "liga 18k_20K";
                    Series ser20 = chartAltOD.Series.Add(seriesName20);

                    ser20.ChartArea = chartAltOD.ChartAreas[0].Name;
                    ser20.Name = seriesName20;
                    ser20.ChartType = SeriesChartType.Line;

                    if (chkliga18_20ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va18kodComboBox.Text);
                        valorB = Convert.ToInt32(va20kodComboBox.Text);

                        ser20.Points.AddXY(7, valorA);
                        ser20.Points.AddXY(8, valorB);

                        ser20.BorderColor = Color.Transparent;
                        ser20.Color = Color.Red;
                        ser20.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga18_20ODCheckBox.Checked == false)
                    {
                        ser20.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    chkliga9_10ODCheckBox.Checked = false;
                    chkliga10_12_5ODCheckBox.Checked = false;
                    chkliga12_5_14ODCheckBox.Checked = false;
                    chkliga14_16ODCheckBox.Checked = false;
                    chkliga16_18ODCheckBox.Checked = false;
                    chkliga18_20ODCheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Escolha 'Audiometria de altas frequências' para a plotagem da simbologia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }              
        }

        private void btnPlotarAudioAltOE_Click(object sender, EventArgs e)
        {
            chartAltOE.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 9;

            chartAltOE.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartAltOE.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string seriesName1 = "grade1";
            Series ser1 = chartAltOE.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2";
            Series ser2 = chartAltOE.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(3, -10);  // x, high
            ser2.Points.AddXY(3, 120);

            string seriesName3 = "grade3";
            Series ser3 = chartAltOE.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(5, -10);  // x, high
            ser3.Points.AddXY(5, 120);

            string seriesName4 = "grade4";
            Series ser4 = chartAltOE.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.Points.AddXY(6, -10);  // x, high
            ser4.Points.AddXY(6, 120);

            string seriesName5 = "grade5";
            Series ser5 = chartAltOE.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(7, -10);  // x, high
            ser5.Points.AddXY(7, 120);

            string seriesName6 = "grade6";
            Series ser6 = chartAltOE.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.Points.AddXY(8, -10);  // x, high
            ser6.Points.AddXY(8, 120);

            string seriesName7 = "grade7";
            Series ser7 = chartAltOE.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(9, -10);  // x, high
            ser7.Points.AddXY(9, 120);

            string seriesName7a = "grade12_5k";
            Series ser7a = chartAltOE.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(4.25, -10);  // x, high
            ser7a.Points.AddXY(4.25, 120);

            //***PARA A SIMBOLOGIA***

            //***

            if (string.IsNullOrEmpty(tipoAudiometriaComboBox.Text))
            {
                MessageBox.Show("Escolha 'Audiometria de altas frequências' para a plotagem da simbologia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria de altas frequências")
            {
                string seriesName8 = "simbol_9k";
                Series ser8 = chartAltOE.Series.Add(seriesName8);

                ser8.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser8.Name = seriesName8;
                ser8.ChartType = SeriesChartType.Point;

                if (va9koeComboBox.Text == "")
                {
                    var vaODpresente9vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaODpresente9vaz);
                    ser8.MarkerImage = "vazio";
                }

                else if (va9koeComboBox.Text != "")
                {
                    int valor8;
                    valor8 = Convert.ToInt32(va9koeComboBox.Text);
                    ser8.Points.AddXY(2, valor8);  // x, high
                }

                if ((chkAusente9kOECheckBox.Checked == false) && (chkMasc9kOECheckBox.Checked == false))
                {
                    var vaOEpresente8p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente8p);
                    ser8.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente9kOECheckBox.Checked == true) && (chkMasc9kOECheckBox.Checked == false))
                {
                    var vaOEausente8a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente8a);
                    ser8.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente9kOECheckBox.Checked == false) && (chkMasc9kOECheckBox.Checked == true))
                {
                    var vaOEpresente8m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente8m);
                    ser8.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc9kOECheckBox.Checked == true) && (chkAusente9kOECheckBox.Checked == true))
                {
                    var vaOEpresente8ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente8ma);
                    ser8.MarkerImage = "vaOEmascAusente";
                }


                //***
                string seriesName9 = "simbol_10k";
                Series ser9 = chartAltOE.Series.Add(seriesName9);

                ser9.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser9.Name = seriesName9;
                ser9.ChartType = SeriesChartType.Point;

                if (va10koeComboBox.Text == "")
                {
                    var vaODpresente10vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaODpresente10vaz);
                    ser9.MarkerImage = "vazio";
                }

                else if (va10koeComboBox.Text != "")
                {
                    int valor9;
                    valor9 = Convert.ToInt32(va10koeComboBox.Text);
                    ser9.Points.AddXY(3, valor9);  // x, high
                }

                if ((chkAusente10kOECheckBox.Checked == false) && (chkMasc10kOECheckBox.Checked == false))
                {
                    var vaOEpresente9p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente9p);
                    ser9.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente10kOECheckBox.Checked == true) && (chkMasc10kOECheckBox.Checked == false))
                {
                    var vaOEausente9a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente9a);
                    ser9.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente10kOECheckBox.Checked == false) && (chkMasc10kOECheckBox.Checked == true))
                {
                    var vaOEpresente9m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente9m);
                    ser9.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc10kOECheckBox.Checked == true) && (chkAusente10kOECheckBox.Checked == true))
                {
                    var vaOEpresente9ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente9ma);
                    ser9.MarkerImage = "vaOEmascAusente";
                }


                //***
                string seriesName10 = "simbol_12_5k";
                Series ser10 = chartAltOE.Series.Add(seriesName10);

                ser10.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser10.Name = seriesName10;
                ser10.ChartType = SeriesChartType.Point;

                if (va12e5koeComboBox.Text == "")
                {
                    var vaODpresente12_5vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaODpresente12_5vaz);
                    ser10.MarkerImage = "vazio";
                }

                else if (va12e5koeComboBox.Text != "")
                {
                    int valor10;
                    valor10 = Convert.ToInt32(va12e5koeComboBox.Text);
                    ser10.Points.AddXY(4.25, valor10);  // x, high
                }

                if ((chkAusente12_5kOECheckBox.Checked == false) && (chkMasc12_5kOECheckBox.Checked == false))
                {
                    var vaOEpresente10p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente10p);
                    ser10.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente12_5kOECheckBox.Checked == true) && (chkMasc12_5kOECheckBox.Checked == false))
                {
                    var vaOEausente10a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente10a);
                    ser10.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente12_5kOECheckBox.Checked == false) && (chkMasc12_5kOECheckBox.Checked == true))
                {
                    var vaOEpresente10m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOD.Images.Clear();
                    chartAltOD.Images.Add(vaOEpresente10m);
                    ser10.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc12_5kOECheckBox.Checked == true) && (chkAusente12_5kOECheckBox.Checked == true))
                {
                    var vaOEpresente10ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente10ma);
                    ser10.MarkerImage = "vaOEmascAusente";
                }


                //***
                string seriesName11 = "simbol_14k";
                Series ser11 = chartAltOE.Series.Add(seriesName11);

                ser11.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser11.Name = seriesName11;
                ser11.ChartType = SeriesChartType.Point;

                if (va14koeComboBox.Text == "")
                {
                    var vaODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaODpresente14vaz);
                    ser11.MarkerImage = "vazio";
                }

                else if (va14koeComboBox.Text != "")
                {
                    int valor11;
                    valor11 = Convert.ToInt32(va14koeComboBox.Text);
                    ser11.Points.AddXY(5, valor11);  // x, high
                }

                if ((chkAusente14kOECheckBox.Checked == false) && (chkMasc14kOECheckBox.Checked == false))
                {
                    var vaOEpresente11p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente11p);
                    ser11.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente14kOECheckBox.Checked == true) && (chkMasc14kOECheckBox.Checked == false))
                {
                    var vaOEausente11a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente11a);
                    ser11.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente14kOECheckBox.Checked == false) && (chkMasc14kOECheckBox.Checked == true))
                {
                    var vaOEpresente11m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente11m);
                    ser11.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc14kOECheckBox.Checked == true) && (chkAusente14kOECheckBox.Checked == true))
                {
                    var vaOEpresente11ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente11ma);
                    ser11.MarkerImage = "vaOEmascAusente";
                }


                //***
                string seriesName12 = "simbol_16k";
                Series ser12 = chartAltOE.Series.Add(seriesName12);

                ser12.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser12.Name = seriesName12;
                ser12.ChartType = SeriesChartType.Point;

                if (va16koeComboBox.Text == "")
                {
                    var vaODpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaODpresente16vaz);
                    ser12.MarkerImage = "vazio";
                }

                else if (va16koeComboBox.Text != "")
                {
                    int valor12;
                    valor12 = Convert.ToInt32(va16koeComboBox.Text);
                    ser12.Points.AddXY(6, valor12);  // x, high
                }

                if ((chkAusente16kOECheckBox.Checked == false) && (chkMasc16kOECheckBox.Checked == false))
                {
                    var vaOEpresente12p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente12p);
                    ser12.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente16kOECheckBox.Checked == true) && (chkMasc16kOECheckBox.Checked == false))
                {
                    var vaOEausente12a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente12a);
                    ser12.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente16kOECheckBox.Checked == false) && (chkMasc16kOECheckBox.Checked == true))
                {
                    var vaOEpresente12m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente12m);
                    ser12.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc16kOECheckBox.Checked == true) && (chkAusente16kOECheckBox.Checked == true))
                {
                    var vaOEpresente12ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente12ma);
                    ser12.MarkerImage = "vaOEmascAusente";
                }


                //***
                string seriesName13 = "simbol_18k";
                Series ser13 = chartAltOE.Series.Add(seriesName13);

                ser13.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (va18koeComboBox.Text == "")
                {
                    var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                else if (va18koeComboBox.Text != "")
                {
                    int valor13;
                    valor13 = Convert.ToInt32(va18koeComboBox.Text);
                    ser13.Points.AddXY(7, valor13);  // x, high
                }


                if ((chkAusente18kOECheckBox.Checked == false) && (chkMasc18kOECheckBox.Checked == false))
                {
                    var vaOEpresente13p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente13p);
                    ser13.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente18kOECheckBox.Checked == true) && (chkMasc18kOECheckBox.Checked == false))
                {
                    var vaOEausente13a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente13a);
                    ser13.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente18kOECheckBox.Checked == false) && (chkMasc18kOECheckBox.Checked == true))
                {
                    var vaOEpresente13m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente13m);
                    ser13.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc18kOECheckBox.Checked == true) && (chkAusente18kOECheckBox.Checked == true))
                {
                    var vaOEpresente13ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente13ma);
                    ser13.MarkerImage = "vaOEmascAusente";
                }


                //***
                string seriesName14 = "simbol_20k";
                Series ser14 = chartAltOE.Series.Add(seriesName14);

                ser14.ChartArea = chartAltOE.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (va20koeComboBox.Text == "")
                {
                    var vaOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (va20koeComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(va20koeComboBox.Text);
                    ser14.Points.AddXY(8, valor14);  // x, high
                }


                if ((chkAusente20kOECheckBox.Checked == false) && (chkMasc20kOECheckBox.Checked == false))
                {
                    var vaOEpresente14p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente14p);
                    ser14.MarkerImage = "vaOEpresente";
                }

                else if ((chkAusente20kOECheckBox.Checked == true) && (chkMasc20kOECheckBox.Checked == false))
                {
                    var vaOEausente14a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEausente14a);
                    ser14.MarkerImage = "vaOEausente";
                }

                else if ((chkAusente20kOECheckBox.Checked == false) && (chkMasc20kOECheckBox.Checked == true))
                {
                    var vaOEpresente14m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente14m);
                    ser14.MarkerImage = "vaOEmascPresente";
                }

                else if ((chkMasc20kOECheckBox.Checked == true) && (chkAusente20kOECheckBox.Checked == true))
                {
                    var vaOEpresente14ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAltOE.Images.Clear();
                    chartAltOE.Images.Add(vaOEpresente14ma);
                    ser14.MarkerImage = "vaOEmascAusente";
                }


                //***SEQUÊNCIA PARA LIGAR SIMBOLOGIA

                try
                {

                    string seriesName15 = "liga 9k_10K";
                    Series ser15 = chartAltOE.Series.Add(seriesName15);

                    ser15.ChartArea = chartAltOE.ChartAreas[0].Name;
                    ser15.Name = seriesName15;
                    ser15.ChartType = SeriesChartType.Line;

                    if (chkliga9_10OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va9koeComboBox.Text);
                        valorB = Convert.ToInt32(va10koeComboBox.Text);

                        ser15.Points.AddXY(2, valorA);
                        ser15.Points.AddXY(3, valorB);

                        ser15.BorderColor = Color.Transparent;
                        ser15.Color = Color.DodgerBlue;
                        ser15.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga9_10OECheckBox.Checked == false)
                    {
                        ser15.Points.Clear();
                    }

                    //*******

                    string seriesName16 = "liga 10k_12_5K";
                    Series ser16 = chartAltOE.Series.Add(seriesName16);

                    ser16.ChartArea = chartAltOE.ChartAreas[0].Name;
                    ser16.Name = seriesName16;
                    ser16.ChartType = SeriesChartType.Line;

                    if (chkliga10_12_5OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va10koeComboBox.Text);
                        valorB = Convert.ToInt32(va12e5koeComboBox.Text);

                        ser16.Points.AddXY(3, valorA);
                        ser16.Points.AddXY(4.25, valorB);

                        ser16.BorderColor = Color.Transparent;
                        ser16.Color = Color.DodgerBlue;
                        ser16.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga10_12_5OECheckBox.Checked == false)
                    {
                        ser16.Points.Clear();
                    }

                    //******


                    string seriesName17 = "liga 12_5k_14K";
                    Series ser17 = chartAltOE.Series.Add(seriesName17);

                    ser17.ChartArea = chartAltOE.ChartAreas[0].Name;
                    ser17.Name = seriesName17;
                    ser17.ChartType = SeriesChartType.Line;

                    if (chkliga12_5_14OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va12e5koeComboBox.Text);
                        valorB = Convert.ToInt32(va14koeComboBox.Text);

                        ser17.Points.AddXY(4.25, valorA);
                        ser17.Points.AddXY(5, valorB);

                        ser17.BorderColor = Color.Transparent;
                        ser17.Color = Color.DodgerBlue;
                        ser17.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga12_5_14OECheckBox.Checked == false)
                    {
                        ser17.Points.Clear();
                    }

                    //*****

                    string seriesName18 = "liga 14k_16K";
                    Series ser18 = chartAltOE.Series.Add(seriesName18);

                    ser18.ChartArea = chartAltOE.ChartAreas[0].Name;
                    ser18.Name = seriesName18;
                    ser18.ChartType = SeriesChartType.Line;

                    if (chkliga14_16OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va14koeComboBox.Text);
                        valorB = Convert.ToInt32(va16koeComboBox.Text);

                        ser18.Points.AddXY(5, valorA);
                        ser18.Points.AddXY(6, valorB);

                        ser18.BorderColor = Color.Transparent;
                        ser18.Color = Color.DodgerBlue;
                        ser18.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga14_16OECheckBox.Checked == false)
                    {
                        ser18.Points.Clear();
                    }


                    //******

                    string seriesName19 = "liga 16k_18K";
                    Series ser19 = chartAltOE.Series.Add(seriesName19);

                    ser19.ChartArea = chartAltOE.ChartAreas[0].Name;
                    ser19.Name = seriesName19;
                    ser19.ChartType = SeriesChartType.Line;

                    if (chkliga16_18OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va16koeComboBox.Text);
                        valorB = Convert.ToInt32(va18koeComboBox.Text);

                        ser19.Points.AddXY(6, valorA);
                        ser19.Points.AddXY(7, valorB);

                        ser19.BorderColor = Color.Transparent;
                        ser19.Color = Color.DodgerBlue;
                        ser19.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga16_18OECheckBox.Checked == false)
                    {
                        ser19.Points.Clear();
                    }

                    //******

                    string seriesName20 = "liga 18k_20K";
                    Series ser20 = chartAltOE.Series.Add(seriesName20);

                    ser20.ChartArea = chartAltOE.ChartAreas[0].Name;
                    ser20.Name = seriesName20;
                    ser20.ChartType = SeriesChartType.Line;

                    if (chkliga18_20OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va18koeComboBox.Text);
                        valorB = Convert.ToInt32(va20koeComboBox.Text);

                        ser20.Points.AddXY(7, valorA);
                        ser20.Points.AddXY(8, valorB);

                        ser20.BorderColor = Color.Transparent;
                        ser20.Color = Color.DodgerBlue;
                        ser20.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chkliga18_20OECheckBox.Checked == false)
                    {
                        ser20.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    chkliga9_10OECheckBox.Checked = false;
                    chkliga10_12_5OECheckBox.Checked = false;
                    chkliga12_5_14OECheckBox.Checked = false;
                    chkliga14_16OECheckBox.Checked = false;
                    chkliga16_18OECheckBox.Checked = false;
                    chkliga18_20OECheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Escolha 'Audiometria de altas frequências' para a plotagem da simbologia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void btnPlotarCampoLivre_Click(object sender, EventArgs e)
        {
            chartAudioEmCampo.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartAudioEmCampo.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartAudioEmCampo.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string fundoChart = "fundoChartTransp";
            Series imgFundo = chartAudioEmCampo.Series.Add(fundoChart);

            imgFundo.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
            imgFundo.Name = fundoChart;
            imgFundo.ChartType = SeriesChartType.Point;

            if (rbExibeBananaAudioGanhoFuncio.Checked == true)
            {
                var fundoAudioEmCampoFuncio = new NamedImage("bananaCinza", Properties.Resources.bananaCinza);
                chartAudioEmCampo.Images.Clear();
                chartAudioEmCampo.Images.Add(fundoAudioEmCampoFuncio);
                imgFundo.MarkerImage = "bananaCinza";
                imgFundo.Points.AddXY(7.50, 45);
            }
            else if (rbEscondeBananaAudioGanhoFuncio.Checked == true)
            {
                chartAudioEmCampo.Series[fundoChart].Points.Clear();
            }

            string seriesName1 = "grade1camp";
            Series ser1 = chartAudioEmCampo.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2camp";
            Series ser2 = chartAudioEmCampo.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3camp";
            Series ser3 = chartAudioEmCampo.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4camp";
            Series ser4 = chartAudioEmCampo.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5camp";
            Series ser5 = chartAudioEmCampo.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6camp";
            Series ser6 = chartAudioEmCampo.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7camp";
            Series ser7 = chartAudioEmCampo.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8camp";
            Series ser7a = chartAudioEmCampo.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9camp";
            Series ser9a = chartAudioEmCampo.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10camp";
            Series ser10a = chartAudioEmCampo.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11camp";
            Series ser11a = chartAudioEmCampo.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12camp";
            Series ser12a = chartAudioEmCampo.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);

            //*******SIMBOLOGIA*******
            //**** COM AASI *******

            if (string.IsNullOrEmpty(tipoAudiometriaComboBox.Text))
            {
                MessageBox.Show("Escolha 'Audiometria de Ganho Funcional'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria de ganho funcional")
            {
                string seriesName13 = "simbol_500com";
                Series ser13 = chartAudioEmCampo.Series.Add(seriesName13);

                ser13.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (com500ComboBox.Text == "")
                {
                    var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                else if (com500ComboBox.Text != "")
                {
                    int valor13;
                    valor13 = Convert.ToInt32(com500ComboBox.Text);
                    ser13.Points.AddXY(6, valor13);  // x, high
                }


                if (chkAusente500comCheckBox.Checked == true)
                {
                    var com500a = new NamedImage("campoComAASIausente", Properties.Resources.campoComAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com500a);
                    ser13.MarkerImage = "campoComAASIausente";
                }

                else if (chkAusente500comCheckBox.Checked == false)
                {
                    var com500p = new NamedImage("campoComAASIpresente", Properties.Resources.campoComAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com500p);
                    ser13.MarkerImage = "campoComAASIpresente";
                }

                //*****

                string seriesName14 = "simbol_1kcom";
                Series ser14 = chartAudioEmCampo.Series.Add(seriesName14);

                ser14.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (com1kComboBox.Text == "")
                {
                    var vaOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (com1kComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(com1kComboBox.Text);
                    ser14.Points.AddXY(8, valor14);  // x, high
                }


                if (chkAusente1kcomCheckBox.Checked == true)
                {
                    var com1ka = new NamedImage("campoComAASIausente", Properties.Resources.campoComAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com1ka);
                    ser14.MarkerImage = "campoComAASIausente";
                }

                else if (chkAusente1kcomCheckBox.Checked == false)
                {
                    var com1kp = new NamedImage("campoComAASIpresente", Properties.Resources.campoComAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com1kp);
                    ser14.MarkerImage = "campoComAASIpresente";
                }

                //*****

                string seriesName15 = "simbol_2kcom";
                Series ser15 = chartAudioEmCampo.Series.Add(seriesName15);

                ser15.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser15.Name = seriesName15;
                ser15.ChartType = SeriesChartType.Point;

                if (com2KComboBox.Text == "")
                {
                    var vaOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente15vaz);
                    ser15.MarkerImage = "vazio";
                }

                else if (com2KComboBox.Text != "")
                {
                    int valor15;
                    valor15 = Convert.ToInt32(com2KComboBox.Text);
                    ser15.Points.AddXY(10, valor15);  // x, high
                }


                if (chkAusente2kcomCheckBox.Checked == true)
                {
                    var com2ka = new NamedImage("campoComAASIausente", Properties.Resources.campoComAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com2ka);
                    ser15.MarkerImage = "campoComAASIausente";
                }

                else if (chkAusente2kcomCheckBox.Checked == false)
                {
                    var com2kp = new NamedImage("campoComAASIpresente", Properties.Resources.campoComAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com2kp);
                    ser15.MarkerImage = "campoComAASIpresente";
                }


                //*****

                string seriesName16 = "simbol_3kcom";
                Series ser16 = chartAudioEmCampo.Series.Add(seriesName16);

                ser16.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser16.Name = seriesName16;
                ser16.ChartType = SeriesChartType.Point;

                if (com3kComboBox.Text == "")
                {
                    var vaOEpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente16vaz);
                    ser16.MarkerImage = "vazio";
                }

                else if (com3kComboBox.Text != "")
                {
                    int valor16;
                    valor16 = Convert.ToInt32(com3kComboBox.Text);
                    ser16.Points.AddXY(11.25, valor16);  // x, high
                }


                if (chkAusente3kcomCheckBox.Checked == true)
                {
                    var com3ka = new NamedImage("campoComAASIausente", Properties.Resources.campoComAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com3ka);
                    ser16.MarkerImage = "campoComAASIausente";
                }

                else if (chkAusente3kcomCheckBox.Checked == false)
                {
                    var com3kp = new NamedImage("campoComAASIpresente", Properties.Resources.campoComAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com3kp);
                    ser16.MarkerImage = "campoComAASIpresente";
                }

                //******

                string seriesName17 = "simbol_4kcom";
                Series ser17 = chartAudioEmCampo.Series.Add(seriesName17);

                ser17.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser17.Name = seriesName17;
                ser17.ChartType = SeriesChartType.Point;

                if (com4kComboBox.Text == "")
                {
                    var vaOEpresente17vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente17vaz);
                    ser17.MarkerImage = "vazio";
                }

                else if (com4kComboBox.Text != "")
                {
                    int valor17;
                    valor17 = Convert.ToInt32(com4kComboBox.Text);
                    ser17.Points.AddXY(12, valor17);  // x, high
                }


                if (chkAusente4kcomCheckBox.Checked == true)
                {
                    var com4ka = new NamedImage("campoComAASIausente", Properties.Resources.campoComAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com4ka);
                    ser17.MarkerImage = "campoComAASIausente";
                }

                else if (chkAusente4kcomCheckBox.Checked == false)
                {
                    var com4kp = new NamedImage("campoComAASIpresente", Properties.Resources.campoComAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(com4kp);
                    ser17.MarkerImage = "campoComAASIpresente";
                }


                //*******SIMBOLOGIA*******
                //**** SEM AASI *******

                string seriesName18 = "simbol_500sem";
                Series ser18 = chartAudioEmCampo.Series.Add(seriesName18);

                ser18.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser18.Name = seriesName18;
                ser18.ChartType = SeriesChartType.Point;

                if (sem500ComboBox.Text == "")
                {
                    var vaOEpresente18vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente18vaz);
                    ser18.MarkerImage = "vazio";
                }

                else if (sem500ComboBox.Text != "")
                {
                    int valor18;
                    valor18 = Convert.ToInt32(sem500ComboBox.Text);
                    ser18.Points.AddXY(6, valor18);  // x, high
                }


                if (chkAusente500semCheckBox.Checked == true)
                {
                    var sem500a = new NamedImage("campoSemAASIausente", Properties.Resources.campoSemAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem500a);
                    ser18.MarkerImage = "campoSemAASIausente";
                }

                else if (chkAusente500semCheckBox.Checked == false)
                {
                    var sem500p = new NamedImage("campoSemAASIpresente", Properties.Resources.campoSemAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem500p);
                    ser18.MarkerImage = "campoSemAASIpresente";
                }

                //*****

                string seriesName19 = "simbol_1ksem";
                Series ser19 = chartAudioEmCampo.Series.Add(seriesName19);

                ser19.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser19.Name = seriesName19;
                ser19.ChartType = SeriesChartType.Point;

                if (sem1kComboBox.Text == "")
                {
                    var vaOEpresente19vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente19vaz);
                    ser19.MarkerImage = "vazio";
                }

                else if (sem1kComboBox.Text != "")
                {
                    int valor19;
                    valor19 = Convert.ToInt32(sem1kComboBox.Text);
                    ser19.Points.AddXY(8, valor19);  // x, high
                }


                if (chkAusente1ksemCheckBox.Checked == true)
                {
                    var sem1ka = new NamedImage("campoSemAASIausente", Properties.Resources.campoSemAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem1ka);
                    ser19.MarkerImage = "campoSemAASIausente";
                }

                else if (chkAusente1ksemCheckBox.Checked == false)
                {
                    var sem1kp = new NamedImage("campoSemAASIpresente", Properties.Resources.campoSemAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem1kp);
                    ser19.MarkerImage = "campoSemAASIpresente";
                }

                //*****

                string seriesName20 = "simbol_2ksem";
                Series ser20 = chartAudioEmCampo.Series.Add(seriesName20);

                ser20.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser20.Name = seriesName20;
                ser20.ChartType = SeriesChartType.Point;

                if (sem2KComboBox.Text == "")
                {
                    var vaOEpresente20vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente20vaz);
                    ser20.MarkerImage = "vazio";
                }

                else if (sem2KComboBox.Text != "")
                {
                    int valor20;
                    valor20 = Convert.ToInt32(sem2KComboBox.Text);
                    ser20.Points.AddXY(10, valor20);  // x, high
                }


                if (chkAusente2ksemCheckBox.Checked == true)
                {
                    var sem2ka = new NamedImage("campoSemAASIausente", Properties.Resources.campoSemAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem2ka);
                    ser20.MarkerImage = "campoSemAASIausente";
                }

                else if (chkAusente2ksemCheckBox.Checked == false)
                {
                    var sem2kp = new NamedImage("campoSemAASIpresente", Properties.Resources.campoSemAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem2kp);
                    ser20.MarkerImage = "campoSemAASIpresente";
                }


                //*****

                string seriesName21 = "simbol_3ksem";
                Series ser21 = chartAudioEmCampo.Series.Add(seriesName21);

                ser21.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser21.Name = seriesName21;
                ser21.ChartType = SeriesChartType.Point;

                if (sem3kComboBox.Text == "")
                {
                    var vaOEpresente21vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente21vaz);
                    ser21.MarkerImage = "vazio";
                }

                else if (sem3kComboBox.Text != "")
                {
                    int valor21;
                    valor21 = Convert.ToInt32(sem3kComboBox.Text);
                    ser21.Points.AddXY(11.25, valor21);  // x, high
                }


                if (chkAusente3ksemCheckBox.Checked == true)
                {
                    var sem3ka = new NamedImage("campoSemAASIausente", Properties.Resources.campoSemAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem3ka);
                    ser21.MarkerImage = "campoSemAASIausente";
                }

                else if (chkAusente3ksemCheckBox.Checked == false)
                {
                    var sem3kp = new NamedImage("campoSemAASIpresente", Properties.Resources.campoSemAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem3kp);
                    ser21.MarkerImage = "campoSemAASIpresente";
                }

                //******

                string seriesName22 = "simbol_4ksem";
                Series ser22 = chartAudioEmCampo.Series.Add(seriesName22);

                ser22.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                ser22.Name = seriesName22;
                ser22.ChartType = SeriesChartType.Point;

                if (sem4kComboBox.Text == "")
                {
                    var vaOEpresente22vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(vaOEpresente22vaz);
                    ser22.MarkerImage = "vazio";
                }

                else if (sem4kComboBox.Text != "")
                {
                    int valor22;
                    valor22 = Convert.ToInt32(sem4kComboBox.Text);
                    ser22.Points.AddXY(12, valor22);  // x, high
                }


                if (chkAusente4ksemCheckBox.Checked == true)
                {
                    var sem4ka = new NamedImage("campoSemAASIausente", Properties.Resources.campoSemAASIausente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem4ka);
                    ser22.MarkerImage = "campoSemAASIausente";
                }

                else if (chkAusente4ksemCheckBox.Checked == false)
                {
                    var sem4kp = new NamedImage("campoSemAASIpresente", Properties.Resources.campoSemAASIpresente);
                    chartAudioEmCampo.Images.Clear();
                    chartAudioEmCampo.Images.Add(sem4kp);
                    ser22.MarkerImage = "campoSemAASIpresente";
                }


                //***SEQUÊNCIA PARA LIGAR SIMBOLOGIA COM AASSI

                try
                {

                    string seriesName23 = "liga 500_1kcom";
                    Series ser23 = chartAudioEmCampo.Series.Add(seriesName23);

                    ser23.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser23.Name = seriesName23;
                    ser23.ChartType = SeriesChartType.Line;

                    if (chbLiga500_1k_comCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(com500ComboBox.Text);
                        valorB = Convert.ToInt32(com1kComboBox.Text);

                        ser23.Points.AddXY(6, valorA);
                        ser23.Points.AddXY(8, valorB);

                        ser23.BorderColor = Color.Transparent;
                        ser23.Color = Color.Black;
                        ser23.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga500_1k_comCheckBox.Checked == false)
                    {
                        ser23.Points.Clear();
                    }

                    //*******

                    string seriesName24 = "liga 1k_2kcom";
                    Series ser24 = chartAudioEmCampo.Series.Add(seriesName24);

                    ser24.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser24.Name = seriesName24;
                    ser24.ChartType = SeriesChartType.Line;

                    if (chbLiga1k_2k_comCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(com1kComboBox.Text);
                        valorB = Convert.ToInt32(com2KComboBox.Text);

                        ser24.Points.AddXY(8, valorA);
                        ser24.Points.AddXY(10, valorB);

                        ser24.BorderColor = Color.Transparent;
                        ser24.Color = Color.Black;
                        ser24.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga1k_2k_comCheckBox.Checked == false)
                    {
                        ser24.Points.Clear();
                    }

                    //*******

                    string seriesName25 = "liga 2k_3kcom";
                    Series ser25 = chartAudioEmCampo.Series.Add(seriesName25);

                    ser25.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser25.Name = seriesName25;
                    ser25.ChartType = SeriesChartType.Line;

                    if (chbLiga2k_3k_comCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(com2KComboBox.Text);
                        valorB = Convert.ToInt32(com3kComboBox.Text);

                        ser25.Points.AddXY(10, valorA);
                        ser25.Points.AddXY(11.25, valorB);

                        ser25.BorderColor = Color.Transparent;
                        ser25.Color = Color.Black;
                        ser25.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga2k_3k_comCheckBox.Checked == false)
                    {
                        ser25.Points.Clear();
                    }

                    //******

                    string seriesName26 = "liga 3k_4kcom";
                    Series ser26 = chartAudioEmCampo.Series.Add(seriesName26);

                    ser26.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser26.Name = seriesName26;
                    ser26.ChartType = SeriesChartType.Line;

                    if (chbLiga3k_4k_comCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(com3kComboBox.Text);
                        valorB = Convert.ToInt32(com4kComboBox.Text);

                        ser26.Points.AddXY(11.25, valorA);
                        ser26.Points.AddXY(12, valorB);

                        ser26.BorderColor = Color.Transparent;
                        ser26.Color = Color.Black;
                        ser26.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga3k_4k_comCheckBox.Checked == false)
                    {
                        ser26.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    chbLiga500_1k_comCheckBox.Checked = false;
                    chbLiga1k_2k_comCheckBox.Checked = false;
                    chbLiga2k_3k_comCheckBox.Checked = false;
                    chbLiga3k_4k_comCheckBox.Checked = false;
                }

                //***SEQUÊNCIA PARA LIGAR SIMBOLOGIA SEM AASSI

                try
                {

                    string seriesName27 = "liga 500_1ksem";
                    Series ser27 = chartAudioEmCampo.Series.Add(seriesName27);

                    ser27.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser27.Name = seriesName27;
                    ser27.ChartType = SeriesChartType.Line;

                    if (chbLiga500_1k_semCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(sem500ComboBox.Text);
                        valorB = Convert.ToInt32(sem1kComboBox.Text);

                        ser27.Points.AddXY(6, valorA);
                        ser27.Points.AddXY(8, valorB);

                        ser27.BorderColor = Color.Transparent;
                        ser27.Color = Color.Black;
                        ser27.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga500_1k_semCheckBox.Checked == false)
                    {
                        ser27.Points.Clear();
                    }

                    //*******

                    string seriesName28 = "liga 1k_2ksem";
                    Series ser28 = chartAudioEmCampo.Series.Add(seriesName28);

                    ser28.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser28.Name = seriesName28;
                    ser28.ChartType = SeriesChartType.Line;

                    if (chbLiga1k_2k_semCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(sem1kComboBox.Text);
                        valorB = Convert.ToInt32(sem2KComboBox.Text);

                        ser28.Points.AddXY(8, valorA);
                        ser28.Points.AddXY(10, valorB);

                        ser28.BorderColor = Color.Transparent;
                        ser28.Color = Color.Black;
                        ser28.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga1k_2k_semCheckBox.Checked == false)
                    {
                        ser28.Points.Clear();
                    }

                    //*******

                    string seriesName29 = "liga 2k_3ksem";
                    Series ser29 = chartAudioEmCampo.Series.Add(seriesName29);

                    ser29.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser29.Name = seriesName29;
                    ser29.ChartType = SeriesChartType.Line;

                    if (chbLiga2k_3k_semCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(sem2KComboBox.Text);
                        valorB = Convert.ToInt32(sem3kComboBox.Text);

                        ser29.Points.AddXY(10, valorA);
                        ser29.Points.AddXY(11.25, valorB);

                        ser29.BorderColor = Color.Transparent;
                        ser29.Color = Color.Black;
                        ser29.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga2k_3k_semCheckBox.Checked == false)
                    {
                        ser29.Points.Clear();
                    }

                    //******

                    string seriesName30 = "liga 3k_4ksem";
                    Series ser30 = chartAudioEmCampo.Series.Add(seriesName30);

                    ser30.ChartArea = chartAudioEmCampo.ChartAreas[0].Name;
                    ser30.Name = seriesName30;
                    ser30.ChartType = SeriesChartType.Line;

                    if (chbLiga3k_4k_semCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(sem3kComboBox.Text);
                        valorB = Convert.ToInt32(sem4kComboBox.Text);

                        ser30.Points.AddXY(11.25, valorA);
                        ser30.Points.AddXY(12, valorB);

                        ser30.BorderColor = Color.Transparent;
                        ser30.Color = Color.Black;
                        ser30.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (chbLiga3k_4k_semCheckBox.Checked == false)
                    {
                        ser30.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    chbLiga500_1k_semCheckBox.Checked = false;
                    chbLiga1k_2k_semCheckBox.Checked = false;
                    chbLiga2k_3k_semCheckBox.Checked = false;
                    chbLiga3k_4k_semCheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Escolha 'Audiometria de Ganho Funcional'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlotarAudioOD_Click(object sender, EventArgs e)
        {
            chartAudioOD.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***
  
            int iniciar = 1;
            int finalizar = 15;

            chartAudioOD.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartAudioOD.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string fundoChart = "fundoChartTransp";
            Series imgFundo = chartAudioOD.Series.Add(fundoChart);

            imgFundo.ChartArea = chartAudioOD.ChartAreas[0].Name;
            imgFundo.Name = fundoChart;
            imgFundo.ChartType = SeriesChartType.Point;

            if (rbExibeBananaAudioClinicaOD.Checked == true)
            {
                var fundoAudioOD = new NamedImage("bananaVermelha", Properties.Resources.bananaVermelha);
                chartAudioOD.Images.Clear();
                chartAudioOD.Images.Add(fundoAudioOD);
                imgFundo.MarkerImage = "bananaVermelha";
                imgFundo.Points.AddXY(7.50, 45);
            }
            else if (rbEscondeBananaAudioClinicaOD.Checked == true)
            {
                chartAudioOD.Series[fundoChart].Points.Clear();
            }           

            string seriesName1 = "grade1OD";
            Series ser1 = chartAudioOD.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2OD";
            Series ser2 = chartAudioOD.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3OD";
            Series ser3 = chartAudioOD.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4OD";
            Series ser4 = chartAudioOD.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5OD";
            Series ser5 = chartAudioOD.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6OD";
            Series ser6 = chartAudioOD.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7OD";
            Series ser7 = chartAudioOD.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8OD";
            Series ser7a = chartAudioOD.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9OD";
            Series ser9a = chartAudioOD.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10OD";
            Series ser10a = chartAudioOD.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11OD";
            Series ser11a = chartAudioOD.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12OD";
            Series ser12a = chartAudioOD.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);


            //****DEVE-SE ESCOLHER O TIPO DE AUDIOMETRIA PARA A PLOTAGEM DA SIMBOLOGIA*****


            if (tipoAudiometriaComboBox.Text == "")
            {
                MessageBox.Show("Escolha o tipo de audiometria para a plotagem da simbologia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria clínica todas as frequências")//AUDIOMETRIA COMPLETA
            {
                va125odComboBox.Enabled = true;
                va750odComboBox.Enabled = true;
                va1e5kodComboBox.Enabled = true;

                masc125vaODCheckBox.Enabled = true;
                masc750vaODCheckBox.Enabled = true;
                masc1_5kvaODCheckBox.Enabled = true;

                aus125vaODCheckBox.Enabled = true;
                aus750vaODCheckBox.Enabled = true;

                liga125_250vaODCheckBox.Enabled = true;
                liga500_750vaODCheckBox.Enabled = true;
                liga1k_1_5kvaODCheckBox.Enabled = true;

                vo750odComboBox.Enabled = true;
                vo1e5kodComboBox.Enabled = true;

                masc750vo_ODCheckBox.Enabled = true;
                masc1_5kvo_ODCheckBox.Enabled = true;

                aus750vo_ODCheckBox.Enabled = true;
                aus1_5kvo_ODCheckBox.Enabled = true;

                liga500_750vo_ODCheckBox.Enabled = true;
                liga1k_1_5kvo_ODCheckBox.Enabled = true;


                //***SIMBOLOGIA DE VA DA OD

                string seriesName13 = "simbol125";
                Series ser13 = chartAudioOD.Series.Add(seriesName13);

                ser13.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (va125odComboBox.Text == "")
                {
                    var vaODpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                else if (va125odComboBox.Text != "")
                {
                    int valor13;
                    valor13 = Convert.ToInt32(va125odComboBox.Text);
                    ser13.Points.AddXY(2, valor13);  // x, high
                }

                if ((aus125vaODCheckBox.Checked == false) && (masc125vaODCheckBox.Checked == false))
                {
                    var vaODpresente13p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente13p);
                    ser13.MarkerImage = "vaODpresente";
                }

                else if ((aus125vaODCheckBox.Checked == true) && (masc125vaODCheckBox.Checked == false))
                {
                    var vaODausente13a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente13a);
                    ser13.MarkerImage = "vaODausente";
                }

                else if ((aus125vaODCheckBox.Checked == false) && (masc125vaODCheckBox.Checked == true))
                {
                    var vaODpresente13m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente13m);
                    ser13.MarkerImage = "vaODmascPresente";
                }

                else if ((masc125vaODCheckBox.Checked == true) && (aus125vaODCheckBox.Checked == true))
                {
                    var vaODpresente13ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente13ma);
                    ser13.MarkerImage = "vaODmascAusente";
                }

                //*********

                string seriesName14 = "simbol250";
                Series ser14 = chartAudioOD.Series.Add(seriesName14);

                ser14.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (va250odComboBox.Text == "")
                {
                    var vaODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (va250odComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(va250odComboBox.Text);
                    ser14.Points.AddXY(4, valor14);  // x, high
                }

                if ((aus250vaODCheckBox.Checked == false) && (masc250vaODCheckBox.Checked == false))
                {
                    var vaODpresente14p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14p);
                    ser14.MarkerImage = "vaODpresente";
                }

                else if ((aus250vaODCheckBox.Checked == true) && (masc250vaODCheckBox.Checked == false))
                {
                    var vaODausente14a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente14a);
                    ser14.MarkerImage = "vaODausente";
                }

                else if ((aus250vaODCheckBox.Checked == false) && (masc250vaODCheckBox.Checked == true))
                {
                    var vaODpresente14m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14m);
                    ser14.MarkerImage = "vaODmascPresente";
                }

                else if ((masc250vaODCheckBox.Checked == true) && (aus250vaODCheckBox.Checked == true))
                {
                    var vaODpresente14ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14ma);
                    ser14.MarkerImage = "vaODmascAusente";
                }

                //**********

                string seriesName15 = "simbol500";
                Series ser15 = chartAudioOD.Series.Add(seriesName15);

                ser15.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser15.Name = seriesName15;
                ser15.ChartType = SeriesChartType.Point;

                if (va500odComboBox.Text == "")
                {
                    var vaODpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15vaz);
                    ser15.MarkerImage = "vazio";
                }

                else if (va500odComboBox.Text != "")
                {
                    int valor15;
                    valor15 = Convert.ToInt32(va500odComboBox.Text);
                    ser15.Points.AddXY(6, valor15);  // x, high
                }

                if ((aus500vaODCheckBox.Checked == false) && (masc500vaODCheckBox.Checked == false))
                {
                    var vaODpresente15p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15p);
                    ser15.MarkerImage = "vaODpresente";
                }

                else if ((aus500vaODCheckBox.Checked == true) && (masc500vaODCheckBox.Checked == false))
                {
                    var vaODausente15a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente15a);
                    ser15.MarkerImage = "vaODausente";
                }

                else if ((aus500vaODCheckBox.Checked == false) && (masc500vaODCheckBox.Checked == true))
                {
                    var vaODpresente15m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15m);
                    ser15.MarkerImage = "vaODmascPresente";
                }

                else if ((masc500vaODCheckBox.Checked == true) && (aus500vaODCheckBox.Checked == true))
                {
                    var vaODpresente15ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15ma);
                    ser15.MarkerImage = "vaODmascAusente";
                }

                //********

                string seriesName16 = "simbol750";
                Series ser16 = chartAudioOD.Series.Add(seriesName16);

                ser16.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser16.Name = seriesName16;
                ser16.ChartType = SeriesChartType.Point;

                if (va750odComboBox.Text == "")
                {
                    var vaODpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente16vaz);
                    ser16.MarkerImage = "vazio";
                }

                else if (va750odComboBox.Text != "")
                {
                    int valor16;
                    valor16 = Convert.ToInt32(va750odComboBox.Text);
                    ser16.Points.AddXY(7.25, valor16);  // x, high
                }

                if ((aus750vaODCheckBox.Checked == false) && (masc750vaODCheckBox.Checked == false))
                {
                    var vaODpresente16p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente16p);
                    ser16.MarkerImage = "vaODpresente";
                }

                else if ((aus750vaODCheckBox.Checked == true) && (masc750vaODCheckBox.Checked == false))
                {
                    var vaODausente16a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente16a);
                    ser16.MarkerImage = "vaODausente";
                }

                else if ((aus750vaODCheckBox.Checked == false) && (masc750vaODCheckBox.Checked == true))
                {
                    var vaODpresente16m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente16m);
                    ser16.MarkerImage = "vaODmascPresente";
                }

                else if ((masc750vaODCheckBox.Checked == true) && (aus750vaODCheckBox.Checked == true))
                {
                    var vaODpresente16ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente16ma);
                    ser16.MarkerImage = "vaODmascAusente";
                }

                //*********

                string seriesName17 = "simbol1k";
                Series ser17 = chartAudioOD.Series.Add(seriesName17);

                ser17.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser17.Name = seriesName17;
                ser17.ChartType = SeriesChartType.Point;

                if (va1kodComboBox.Text == "")
                {
                    var vaODpresente17vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17vaz);
                    ser17.MarkerImage = "vazio";
                }

                else if (va1kodComboBox.Text != "")
                {
                    int valor17;
                    valor17 = Convert.ToInt32(va1kodComboBox.Text);
                    ser17.Points.AddXY(8, valor17);  // x, high
                }

                if ((aus1kvaODCheckBox.Checked == false) && (masc1kvaODCheckBox.Checked == false))
                {
                    var vaODpresente17p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17p);
                    ser17.MarkerImage = "vaODpresente";
                }

                else if ((aus1kvaODCheckBox.Checked == true) && (masc1kvaODCheckBox.Checked == false))
                {
                    var vaODausente17a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente17a);
                    ser17.MarkerImage = "vaODausente";
                }

                else if ((aus1kvaODCheckBox.Checked == false) && (masc1kvaODCheckBox.Checked == true))
                {
                    var vaODpresente17m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17m);
                    ser17.MarkerImage = "vaODmascPresente";
                }

                else if ((masc1kvaODCheckBox.Checked == true) && (aus1kvaODCheckBox.Checked == true))
                {
                    var vaODpresente17ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17ma);
                    ser17.MarkerImage = "vaODmascAusente";
                }

                //***********

                string seriesName18 = "simbol1,5k";
                Series ser18 = chartAudioOD.Series.Add(seriesName18);

                ser18.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser18.Name = seriesName18;
                ser18.ChartType = SeriesChartType.Point;

                if (va1e5kodComboBox.Text == "")
                {
                    var vaODpresente18vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente18vaz);
                    ser18.MarkerImage = "vazio";
                }

                else if (va1e5kodComboBox.Text != "")
                {
                    int valor18;
                    valor18 = Convert.ToInt32(va1e5kodComboBox.Text);
                    ser18.Points.AddXY(9.25, valor18);  // x, high
                }

                if ((aus1_5kvaODCheckBox.Checked == false) && (masc1_5kvaODCheckBox.Checked == false))
                {
                    var vaODpresente18p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente18p);
                    ser18.MarkerImage = "vaODpresente";
                }

                else if ((aus1_5kvaODCheckBox.Checked == true) && (masc1_5kvaODCheckBox.Checked == false))
                {
                    var vaODausente18a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente18a);
                    ser18.MarkerImage = "vaODausente";
                }

                else if ((aus1_5kvaODCheckBox.Checked == false) && (masc1_5kvaODCheckBox.Checked == true))
                {
                    var vaODpresente18m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente18m);
                    ser18.MarkerImage = "vaODmascPresente";
                }

                else if ((masc1_5kvaODCheckBox.Checked == true) && (aus1_5kvaODCheckBox.Checked == true))
                {
                    var vaODpresente18ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente18ma);
                    ser18.MarkerImage = "vaODmascAusente";
                }

                //************

                string seriesName19 = "simbol2k";
                Series ser19 = chartAudioOD.Series.Add(seriesName19);

                ser19.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser19.Name = seriesName19;
                ser19.ChartType = SeriesChartType.Point;

                if (va2kodComboBox.Text == "")
                {
                    var vaODpresente19vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19vaz);
                    ser19.MarkerImage = "vazio";
                }

                else if (va2kodComboBox.Text != "")
                {
                    int valor19;
                    valor19 = Convert.ToInt32(va2kodComboBox.Text);
                    ser19.Points.AddXY(10, valor19);  // x, high
                }

                if ((aus2kvaODCheckBox.Checked == false) && (masc2kvaODCheckBox.Checked == false))
                {
                    var vaODpresente19p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19p);
                    ser19.MarkerImage = "vaODpresente";
                }

                else if ((aus2kvaODCheckBox.Checked == true) && (masc2kvaODCheckBox.Checked == false))
                {
                    var vaODausente19a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente19a);
                    ser19.MarkerImage = "vaODausente";
                }

                else if ((aus2kvaODCheckBox.Checked == false) && (masc2kvaODCheckBox.Checked == true))
                {
                    var vaODpresente19m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19m);
                    ser19.MarkerImage = "vaODmascPresente";
                }

                else if ((masc2kvaODCheckBox.Checked == true) && (aus2kvaODCheckBox.Checked == true))
                {
                    var vaODpresente19ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19ma);
                    ser19.MarkerImage = "vaODmascAusente";
                }

                //*********

                string seriesName20 = "simbol3k";
                Series ser20 = chartAudioOD.Series.Add(seriesName20);

                ser20.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser20.Name = seriesName20;
                ser20.ChartType = SeriesChartType.Point;

                if (va3kodComboBox.Text == "")
                {
                    var vaODpresente20vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20vaz);
                    ser20.MarkerImage = "vazio";
                }

                else if (va3kodComboBox.Text != "")
                {
                    int valor20;
                    valor20 = Convert.ToInt32(va3kodComboBox.Text);
                    ser20.Points.AddXY(11.25, valor20);  // x, high
                }

                if ((aus3kvaODCheckBox.Checked == false) && (masc3kvaODCheckBox.Checked == false))
                {
                    var vaODpresente20p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20p);
                    ser20.MarkerImage = "vaODpresente";
                }

                else if ((aus3kvaODCheckBox.Checked == true) && (masc3kvaODCheckBox.Checked == false))
                {
                    var vaODausente20a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente20a);
                    ser20.MarkerImage = "vaODausente";
                }

                else if ((aus3kvaODCheckBox.Checked == false) && (masc3kvaODCheckBox.Checked == true))
                {
                    var vaODpresente20m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20m);
                    ser20.MarkerImage = "vaODmascPresente";
                }

                else if ((masc3kvaODCheckBox.Checked == true) && (aus3kvaODCheckBox.Checked == true))
                {
                    var vaODpresente20ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20ma);
                    ser20.MarkerImage = "vaODmascAusente";
                }

                //********

                string seriesName21 = "simbol4k";
                Series ser21 = chartAudioOD.Series.Add(seriesName21);

                ser21.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser21.Name = seriesName21;
                ser21.ChartType = SeriesChartType.Point;

                if (va4kodComboBox.Text == "")
                {
                    var vaODpresente21vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21vaz);
                    ser21.MarkerImage = "vazio";
                }

                else if (va4kodComboBox.Text != "")
                {
                    int valor21;
                    valor21 = Convert.ToInt32(va4kodComboBox.Text);
                    ser21.Points.AddXY(12, valor21);  // x, high
                }

                if ((aus4kvaODCheckBox.Checked == false) && (masc4kvaODCheckBox.Checked == false))
                {
                    var vaODpresente21p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21p);
                    ser21.MarkerImage = "vaODpresente";
                }

                else if ((aus4kvaODCheckBox.Checked == true) && (masc4kvaODCheckBox.Checked == false))
                {
                    var vaODausente21a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente21a);
                    ser21.MarkerImage = "vaODausente";
                }

                else if ((aus4kvaODCheckBox.Checked == false) && (masc4kvaODCheckBox.Checked == true))
                {
                    var vaODpresente21m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21m);
                    ser21.MarkerImage = "vaODmascPresente";
                }

                else if ((masc4kvaODCheckBox.Checked == true) && (aus4kvaODCheckBox.Checked == true))
                {
                    var vaODpresente21ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21ma);
                    ser21.MarkerImage = "vaODmascAusente";
                }

                //**********

                string seriesName22 = "simbol6k";
                Series ser22 = chartAudioOD.Series.Add(seriesName22);

                ser22.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser22.Name = seriesName22;
                ser22.ChartType = SeriesChartType.Point;

                if (va6kodComboBox.Text == "")
                {
                    var vaODpresente22vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22vaz);
                    ser22.MarkerImage = "vazio";
                }

                else if (va6kodComboBox.Text != "")
                {
                    int valor22;
                    valor22 = Convert.ToInt32(va6kodComboBox.Text);
                    ser22.Points.AddXY(13.25, valor22);  // x, high
                }

                if ((aus6kvaODCheckBox.Checked == false) && (masc6kvaODCheckBox.Checked == false))
                {
                    var vaODpresente22p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22p);
                    ser22.MarkerImage = "vaODpresente";
                }

                else if ((aus6kvaODCheckBox.Checked == true) && (masc6kvaODCheckBox.Checked == false))
                {
                    var vaODausente22a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente22a);
                    ser22.MarkerImage = "vaODausente";
                }

                else if ((aus6kvaODCheckBox.Checked == false) && (masc6kvaODCheckBox.Checked == true))
                {
                    var vaODpresente22m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22m);
                    ser22.MarkerImage = "vaODmascPresente";
                }

                else if ((masc6kvaODCheckBox.Checked == true) && (aus6kvaODCheckBox.Checked == true))
                {
                    var vaODpresente22ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22ma);
                    ser22.MarkerImage = "vaODmascAusente";
                }

                //***********

                string seriesName23 = "simbol8k";
                Series ser23 = chartAudioOD.Series.Add(seriesName23);

                ser23.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser23.Name = seriesName23;
                ser23.ChartType = SeriesChartType.Point;

                if (va8kodComboBox.Text == "")
                {
                    var vaODpresente23vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23vaz);
                    ser23.MarkerImage = "vazio";
                }

                else if (va8kodComboBox.Text != "")
                {
                    int valor23;
                    valor23 = Convert.ToInt32(va8kodComboBox.Text);
                    ser23.Points.AddXY(14, valor23);  // x, high
                }

                if ((aus8kvaODCheckBox.Checked == false) && (masc8kvaODCheckBox.Checked == false))
                {
                    var vaODpresente23p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23p);
                    ser23.MarkerImage = "vaODpresente";
                }

                else if ((aus8kvaODCheckBox.Checked == true) && (masc8kvaODCheckBox.Checked == false))
                {
                    var vaODausente23a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente23a);
                    ser23.MarkerImage = "vaODausente";
                }

                else if ((aus8kvaODCheckBox.Checked == false) && (masc8kvaODCheckBox.Checked == true))
                {
                    var vaODpresente23m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23m);
                    ser23.MarkerImage = "vaODmascPresente";
                }

                else if ((masc8kvaODCheckBox.Checked == true) && (aus8kvaODCheckBox.Checked == true))
                {
                    var vaODpresente23ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23ma);
                    ser23.MarkerImage = "vaODmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OD

                try
                {

                    string seriesName24 = "liga 125_ 250 vaOD";
                    Series ser24 = chartAudioOD.Series.Add(seriesName24);

                    ser24.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser24.Name = seriesName24;
                    ser24.ChartType = SeriesChartType.Line;

                    if (liga125_250vaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va125odComboBox.Text);
                        valorB = Convert.ToInt32(va250odComboBox.Text);

                        ser24.Points.AddXY(2, valorA);
                        ser24.Points.AddXY(4, valorB);

                        ser24.BorderColor = Color.Transparent;
                        ser24.Color = Color.Red;
                        ser24.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga125_250vaODCheckBox.Checked == false)
                    {
                        ser24.Points.Clear();
                    }

                    //*******

                    string seriesName25 = "liga 250_500 vaOD";
                    Series ser25 = chartAudioOD.Series.Add(seriesName25);

                    ser25.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser25.Name = seriesName25;
                    ser25.ChartType = SeriesChartType.Line;

                    if (liga250_500vaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va250odComboBox.Text);
                        valorB = Convert.ToInt32(va500odComboBox.Text);

                        ser25.Points.AddXY(4, valorA);
                        ser25.Points.AddXY(6, valorB);

                        ser25.BorderColor = Color.Transparent;
                        ser25.Color = Color.Red;
                        ser25.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vaODCheckBox.Checked == false)
                    {
                        ser25.Points.Clear();
                    }

                    //*******

                    string seriesName26 = "liga 500_750 vaOD";
                    Series ser26 = chartAudioOD.Series.Add(seriesName26);

                    ser26.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser26.Name = seriesName26;
                    ser26.ChartType = SeriesChartType.Line;

                    if (liga500_750vaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va500odComboBox.Text);
                        valorB = Convert.ToInt32(va750odComboBox.Text);

                        ser26.Points.AddXY(6, valorA);
                        ser26.Points.AddXY(7.25, valorB);

                        ser26.BorderColor = Color.Transparent;
                        ser26.Color = Color.Red;
                        ser26.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga500_750vaODCheckBox.Checked == false)
                    {
                        ser26.Points.Clear();
                    }

                    //******

                    string seriesName27 = "liga 750_1k OD";
                    Series ser27 = chartAudioOD.Series.Add(seriesName27);

                    ser27.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser27.Name = seriesName27;
                    ser27.ChartType = SeriesChartType.Line;

                    if (liga750_1kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va750odComboBox.Text);
                        valorB = Convert.ToInt32(va1kodComboBox.Text);

                        ser27.Points.AddXY(7.25, valorA);
                        ser27.Points.AddXY(8, valorB);

                        ser27.BorderColor = Color.Transparent;
                        ser27.Color = Color.Red;
                        ser27.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvaODCheckBox.Checked == false)
                    {
                        ser27.Points.Clear();
                    }

                    //******

                    string seriesName28 = "liga 1k_1,5K vaOD";
                    Series ser28 = chartAudioOD.Series.Add(seriesName28);

                    ser28.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser28.Name = seriesName28;
                    ser28.ChartType = SeriesChartType.Line;

                    if (liga1k_1_5kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va1kodComboBox.Text);
                        valorB = Convert.ToInt32(va1e5kodComboBox.Text);

                        ser28.Points.AddXY(8, valorA);
                        ser28.Points.AddXY(9.25, valorB);

                        ser28.BorderColor = Color.Transparent;
                        ser28.Color = Color.Red;
                        ser28.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1k_1_5kvaODCheckBox.Checked == false)
                    {
                        ser28.Points.Clear();
                    }

                    //******

                    string seriesName29 = "liga 1,5k _ 2k vaOD";
                    Series ser29 = chartAudioOD.Series.Add(seriesName29);

                    ser29.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser29.Name = seriesName29;
                    ser29.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va1e5kodComboBox.Text);
                        valorB = Convert.ToInt32(va2kodComboBox.Text);

                        ser29.Points.AddXY(9.25, valorA);
                        ser29.Points.AddXY(10, valorB);

                        ser29.BorderColor = Color.Transparent;
                        ser29.Color = Color.Red;
                        ser29.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvaODCheckBox.Checked == false)
                    {
                        ser29.Points.Clear();
                    }

                    //******

                    string seriesName30 = "liga 2k_3k vaOD";
                    Series ser30 = chartAudioOD.Series.Add(seriesName30);

                    ser30.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser30.Name = seriesName30;
                    ser30.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va2kodComboBox.Text);
                        valorB = Convert.ToInt32(va3kodComboBox.Text);

                        ser30.Points.AddXY(10, valorA);
                        ser30.Points.AddXY(11.25, valorB);

                        ser30.BorderColor = Color.Transparent;
                        ser30.Color = Color.Red;
                        ser30.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvaODCheckBox.Checked == false)
                    {
                        ser30.Points.Clear();
                    }

                    //******

                    string seriesName31 = "liga 3k_4k vaOD";
                    Series ser31 = chartAudioOD.Series.Add(seriesName31);

                    ser31.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser31.Name = seriesName31;
                    ser31.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va3kodComboBox.Text);
                        valorB = Convert.ToInt32(va4kodComboBox.Text);

                        ser31.Points.AddXY(11.25, valorA);
                        ser31.Points.AddXY(12, valorB);

                        ser31.BorderColor = Color.Transparent;
                        ser31.Color = Color.Red;
                        ser31.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvaODCheckBox.Checked == false)
                    {
                        ser31.Points.Clear();
                    }

                    //******

                    string seriesName32 = "liga 4k_6k vaOD";
                    Series ser32 = chartAudioOD.Series.Add(seriesName32);

                    ser32.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser32.Name = seriesName32;
                    ser32.ChartType = SeriesChartType.Line;

                    if (liga4k_6kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va4kodComboBox.Text);
                        valorB = Convert.ToInt32(va6kodComboBox.Text);

                        ser32.Points.AddXY(12, valorA);
                        ser32.Points.AddXY(13.25, valorB);

                        ser32.BorderColor = Color.Transparent;
                        ser32.Color = Color.Red;
                        ser32.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga4k_6kvaODCheckBox.Checked == false)
                    {
                        ser32.Points.Clear();
                    }

                    //******

                    string seriesName33 = "liga 6k-8k vaOD";
                    Series ser33 = chartAudioOD.Series.Add(seriesName33);

                    ser33.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser33.Name = seriesName33;
                    ser33.ChartType = SeriesChartType.Line;

                    if (liga6k_8kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va6kodComboBox.Text);
                        valorB = Convert.ToInt32(va8kodComboBox.Text);

                        ser33.Points.AddXY(13.25, valorA);
                        ser33.Points.AddXY(14, valorB);

                        ser33.BorderColor = Color.Transparent;
                        ser33.Color = Color.Red;
                        ser33.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga6k_8kvaODCheckBox.Checked == false)
                    {
                        ser33.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga125_250vaODCheckBox.Checked = false;
                    liga250_500vaODCheckBox.Checked = false;
                    liga500_750vaODCheckBox.Checked = false;
                    liga750_1kvaODCheckBox.Checked = false;
                    liga1k_1_5kvaODCheckBox.Checked = false;
                    liga1_5k_2kvaODCheckBox.Checked = false;
                    liga2k_3kvaODCheckBox.Checked = false;
                    liga3k_4kvaODCheckBox.Checked = false;
                    liga4k_6kvaODCheckBox.Checked = false;
                    liga6k_8kvaODCheckBox.Checked = false;
                }

                //*********
                //********** SIMBOLOGIA DE VO OD


                string seriesName34 = "simbol 250 voOD";
                Series ser34 = chartAudioOD.Series.Add(seriesName34);

                ser34.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser34.Name = seriesName34;
                ser34.ChartType = SeriesChartType.Point;

                if (vo250odComboBox.Text == "")
                {
                    var voODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente14vaz);
                    ser34.MarkerImage = "vazio";
                }

                else if (vo250odComboBox.Text != "")
                {
                    int valor34;
                    valor34 = Convert.ToInt32(vo250odComboBox.Text);
                    ser34.Points.AddXY(4, valor34);  // x, high
                }

                if ((aus250vo_ODCheckBox.Checked == false) && (masc250vo_ODCheckBox.Checked == false))
                {
                    var voODpresente34p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente34p);
                    ser34.MarkerImage = "voODpresente";
                }

                else if ((aus250vo_ODCheckBox.Checked == true) && (masc250vo_ODCheckBox.Checked == false))
                {
                    var voODausente34a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente34a);
                    ser34.MarkerImage = "voODausente";
                }

                else if ((aus250vo_ODCheckBox.Checked == false) && (masc250vo_ODCheckBox.Checked == true))
                {
                    var voODpresente34m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente34m);
                    ser34.MarkerImage = "voODmascPresente";
                }

                else if ((masc250vo_ODCheckBox.Checked == true) && (aus250vo_ODCheckBox.Checked == true))
                {
                    var voODpresente34ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente34ma);
                    ser34.MarkerImage = "voODmascAusente";
                }

                //**********

                string seriesName35 = "simbol500 voOD";
                Series ser35 = chartAudioOD.Series.Add(seriesName35);

                ser35.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser35.Name = seriesName35;
                ser35.ChartType = SeriesChartType.Point;

                if (vo500odComboBox.Text == "")
                {
                    var voODpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15vaz);
                    ser35.MarkerImage = "vazio";
                }

                else if (vo500odComboBox.Text != "")
                {
                    int valor35;
                    valor35 = Convert.ToInt32(vo500odComboBox.Text);
                    ser35.Points.AddXY(6, valor35);  // x, high
                }

                if ((aus500vo_ODCheckBox.Checked == false) && (masc500vo_ODCheckBox.Checked == false))
                {
                    var voODpresente15p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15p);
                    ser35.MarkerImage = "voODpresente";
                }

                else if ((aus500vo_ODCheckBox.Checked == true) && (masc500vo_ODCheckBox.Checked == false))
                {
                    var voODausente15a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente15a);
                    ser35.MarkerImage = "voODausente";
                }

                else if ((aus500vo_ODCheckBox.Checked == false) && (masc500vo_ODCheckBox.Checked == true))
                {
                    var voODpresente15m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15m);
                    ser35.MarkerImage = "voODmascPresente";
                }

                else if ((masc500vo_ODCheckBox.Checked == true) && (aus500vo_ODCheckBox.Checked == true))
                {
                    var voODpresente15ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15ma);
                    ser35.MarkerImage = "voODmascAusente";
                }

                //********

                string seriesName36 = "simbol750 voOD";
                Series ser36 = chartAudioOD.Series.Add(seriesName36);

                ser36.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser36.Name = seriesName36;
                ser36.ChartType = SeriesChartType.Point;

                if (vo750odComboBox.Text == "")
                {
                    var voODpresente36vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente36vaz);
                    ser36.MarkerImage = "vazio";
                }

                else if (vo750odComboBox.Text != "")
                {
                    int valor36;
                    valor36 = Convert.ToInt32(vo750odComboBox.Text);
                    ser36.Points.AddXY(7.25, valor36);  // x, high
                }

                if ((aus750vo_ODCheckBox.Checked == false) && (masc750vo_ODCheckBox.Checked == false))
                {
                    var voODpresente36p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente36p);
                    ser36.MarkerImage = "voODpresente";
                }

                else if ((aus750vo_ODCheckBox.Checked == true) && (masc750vo_ODCheckBox.Checked == false))
                {
                    var voODausente36a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente36a);
                    ser36.MarkerImage = "voODausente";
                }

                else if ((aus750vo_ODCheckBox.Checked == false) && (masc750vo_ODCheckBox.Checked == true))
                {
                    var voODpresente36m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente36m);
                    ser36.MarkerImage = "voODmascPresente";
                }

                else if ((masc750vo_ODCheckBox.Checked == true) && (aus750vo_ODCheckBox.Checked == true))
                {
                    var voODpresente36ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente36ma);
                    ser36.MarkerImage = "voODmascAusente";
                }

                //*********

                string seriesName37 = "simbol1k voOD";
                Series ser37 = chartAudioOD.Series.Add(seriesName37);

                ser37.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser37.Name = seriesName37;
                ser37.ChartType = SeriesChartType.Point;

                if (vo1kodComboBox.Text == "")
                {
                    var voODpresente37vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37vaz);
                    ser37.MarkerImage = "vazio";
                }

                else if (vo1kodComboBox.Text != "")
                {
                    int valor37;
                    valor37 = Convert.ToInt32(vo1kodComboBox.Text);
                    ser37.Points.AddXY(8, valor37);  // x, high
                }

                if ((aus1kvo_ODCheckBox.Checked == false) && (masc1kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente37p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37p);
                    ser37.MarkerImage = "voODpresente";
                }

                else if ((aus1kvo_ODCheckBox.Checked == true) && (masc1kvo_ODCheckBox.Checked == false))
                {
                    var voODausente37a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente37a);
                    ser37.MarkerImage = "voODausente";
                }

                else if ((aus1kvo_ODCheckBox.Checked == false) && (masc1kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente37m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37m);
                    ser37.MarkerImage = "voODmascPresente";
                }

                else if ((masc1kvo_ODCheckBox.Checked == true) && (aus1kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente37ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37ma);
                    ser37.MarkerImage = "voODmascAusente";
                }

                //***********

                string seriesName38 = "simbol1,5k voOD";
                Series ser38 = chartAudioOD.Series.Add(seriesName38);

                ser38.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser38.Name = seriesName38;
                ser38.ChartType = SeriesChartType.Point;

                if (vo1e5kodComboBox.Text == "")
                {
                    var voODpresente38vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente38vaz);
                    ser38.MarkerImage = "vazio";
                }

                else if (vo1e5kodComboBox.Text != "")
                {
                    int valor38;
                    valor38 = Convert.ToInt32(vo1e5kodComboBox.Text);
                    ser38.Points.AddXY(9.25, valor38);  // x, high
                }

                if ((aus1_5kvo_ODCheckBox.Checked == false) && (masc1_5kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente38p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente38p);
                    ser38.MarkerImage = "voODpresente";
                }

                else if ((aus1_5kvo_ODCheckBox.Checked == true) && (masc1_5kvo_ODCheckBox.Checked == false))
                {
                    var voODausente38a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente38a);
                    ser38.MarkerImage = "voODausente";
                }

                else if ((aus1_5kvo_ODCheckBox.Checked == false) && (masc1_5kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente38m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente38m);
                    ser38.MarkerImage = "voODmascPresente";
                }

                else if ((masc1_5kvo_ODCheckBox.Checked == true) && (aus1_5kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente38ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente38ma);
                    ser38.MarkerImage = "voODmascAusente";
                }

                //************

                string seriesName39 = "simbol2k voOD";
                Series ser39 = chartAudioOD.Series.Add(seriesName39);

                ser39.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser39.Name = seriesName39;
                ser39.ChartType = SeriesChartType.Point;

                if (vo2kodComboBox.Text == "")
                {
                    var voODpresente39vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39vaz);
                    ser39.MarkerImage = "vazio";
                }

                else if (vo2kodComboBox.Text != "")
                {
                    int valor39;
                    valor39 = Convert.ToInt32(vo2kodComboBox.Text);
                    ser39.Points.AddXY(10, valor39);  // x, high
                }

                if ((aus2kvo_ODCheckBox.Checked == false) && (masc2kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente39p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39p);
                    ser39.MarkerImage = "voODpresente";
                }

                else if ((aus2kvo_ODCheckBox.Checked == true) && (masc2kvo_ODCheckBox.Checked == false))
                {
                    var voODausente39a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente39a);
                    ser39.MarkerImage = "voODausente";
                }

                else if ((aus2kvo_ODCheckBox.Checked == false) && (masc2kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente39m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39m);
                    ser39.MarkerImage = "voODmascPresente";
                }

                else if ((masc2kvo_ODCheckBox.Checked == true) && (aus2kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente39ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39ma);
                    ser39.MarkerImage = "voODmascAusente";
                }

                //*********

                string seriesName40 = "simbol3k voOD";
                Series ser40 = chartAudioOD.Series.Add(seriesName40);

                ser40.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser40.Name = seriesName40;
                ser40.ChartType = SeriesChartType.Point;

                if (vo3kodComboBox.Text == "")
                {
                    var voODpresente40vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40vaz);
                    ser40.MarkerImage = "vazio";
                }

                else if (vo3kodComboBox.Text != "")
                {
                    int valor40;
                    valor40 = Convert.ToInt32(vo3kodComboBox.Text);
                    ser40.Points.AddXY(11.25, valor40);  // x, high
                }

                if ((aus3kvo_ODCheckBox.Checked == false) && (masc3kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente40p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40p);
                    ser40.MarkerImage = "voODpresente";
                }

                else if ((aus3kvo_ODCheckBox.Checked == true) && (masc3kvo_ODCheckBox.Checked == false))
                {
                    var voODausente40a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente40a);
                    ser40.MarkerImage = "voODausente";
                }

                else if ((aus3kvo_ODCheckBox.Checked == false) && (masc3kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente40m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40m);
                    ser40.MarkerImage = "voODmascPresente";
                }

                else if ((masc3kvo_ODCheckBox.Checked == true) && (aus3kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente40ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40ma);
                    ser40.MarkerImage = "voODmascAusente";
                }

                //********

                string seriesName41 = "simbol4k voOD";
                Series ser41 = chartAudioOD.Series.Add(seriesName41);

                ser41.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser41.Name = seriesName41;
                ser41.ChartType = SeriesChartType.Point;

                if (vo4kodComboBox.Text == "")
                {
                    var voODpresente41vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41vaz);
                    ser41.MarkerImage = "vazio";
                }

                else if (vo4kodComboBox.Text != "")
                {
                    int valor41;
                    valor41 = Convert.ToInt32(vo4kodComboBox.Text);
                    ser41.Points.AddXY(12, valor41);  // x, high
                }

                if ((aus4kvo_ODCheckBox.Checked == false) && (masc4kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente41p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41p);
                    ser41.MarkerImage = "voODpresente";
                }

                else if ((aus4kvo_ODCheckBox.Checked == true) && (masc4kvo_ODCheckBox.Checked == false))
                {
                    var voODausente41a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente41a);
                    ser41.MarkerImage = "voODausente";
                }

                else if ((aus4kvo_ODCheckBox.Checked == false) && (masc4kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente41m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41m);
                    ser41.MarkerImage = "voODmascPresente";
                }

                else if ((masc4kvo_ODCheckBox.Checked == true) && (aus4kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente41ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41ma);
                    ser41.MarkerImage = "voODmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OD (VO)

                try
                {
                    //*******

                    string seriesName42 = "liga 250_500 voOD";
                    Series ser42 = chartAudioOD.Series.Add(seriesName42);

                    ser42.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser42.Name = seriesName42;
                    ser42.ChartType = SeriesChartType.Line;

                    if (liga250_500vo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo250odComboBox.Text);
                        valorB = Convert.ToInt32(vo500odComboBox.Text);

                        ser42.Points.AddXY(3.75, valorA);
                        ser42.Points.AddXY(5.75, valorB);

                        ser42.BorderColor = Color.Transparent;
                        ser42.Color = Color.Red;
                        ser42.BorderDashStyle = ChartDashStyle.Dash;
                        ser42.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vo_ODCheckBox.Checked == false)
                    {
                        ser42.Points.Clear();
                    }

                    //*******

                    string seriesName43 = "liga 500_750 voOD";
                    Series ser43 = chartAudioOD.Series.Add(seriesName43);

                    ser43.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser43.Name = seriesName43;
                    ser43.ChartType = SeriesChartType.Line;

                    if (liga500_750vo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo500odComboBox.Text);
                        valorB = Convert.ToInt32(vo750odComboBox.Text);

                        ser43.Points.AddXY(5.75, valorA);
                        ser43.Points.AddXY(7, valorB);

                        ser43.BorderColor = Color.Transparent;
                        ser43.Color = Color.Red;
                        ser43.BorderDashStyle = ChartDashStyle.Dash;
                        ser43.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga500_750vo_ODCheckBox.Checked == false)
                    {
                        ser43.Points.Clear();
                    }

                    //******

                    string seriesName44 = "liga 750_1k voOD";
                    Series ser44 = chartAudioOD.Series.Add(seriesName44);

                    ser44.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser44.Name = seriesName44;
                    ser44.ChartType = SeriesChartType.Line;

                    if (liga750_1kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo750odComboBox.Text);
                        valorB = Convert.ToInt32(vo1kodComboBox.Text);

                        ser44.Points.AddXY(7, valorA);
                        ser44.Points.AddXY(7.75, valorB);

                        ser44.BorderColor = Color.Transparent;
                        ser44.Color = Color.Red;
                        ser44.BorderDashStyle = ChartDashStyle.Dash;
                        ser44.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvo_ODCheckBox.Checked == false)
                    {
                        ser44.Points.Clear();
                    }

                    //******

                    string seriesName45 = "liga 1k_1,5K voOD";
                    Series ser45 = chartAudioOD.Series.Add(seriesName45);

                    ser45.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser45.Name = seriesName45;
                    ser45.ChartType = SeriesChartType.Line;

                    if (liga1k_1_5kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo1kodComboBox.Text);
                        valorB = Convert.ToInt32(vo1e5kodComboBox.Text);

                        ser45.Points.AddXY(7.75, valorA);
                        ser45.Points.AddXY(9, valorB);

                        ser45.BorderColor = Color.Transparent;
                        ser45.Color = Color.Red;
                        ser45.BorderDashStyle = ChartDashStyle.Dash;
                        ser45.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1k_1_5kvo_ODCheckBox.Checked == false)
                    {
                        ser45.Points.Clear();
                    }

                    //******

                    string seriesName46 = "liga 1,5k _ 2k voOD";
                    Series ser46 = chartAudioOD.Series.Add(seriesName46);

                    ser46.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser46.Name = seriesName46;
                    ser46.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo1e5kodComboBox.Text);
                        valorB = Convert.ToInt32(vo2kodComboBox.Text);

                        ser46.Points.AddXY(9, valorA);
                        ser46.Points.AddXY(9.75, valorB);

                        ser46.BorderColor = Color.Transparent;
                        ser46.Color = Color.Red;
                        ser46.BorderDashStyle = ChartDashStyle.Dash;
                        ser46.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvo_ODCheckBox.Checked == false)
                    {
                        ser46.Points.Clear();
                    }

                    //******

                    string seriesName47 = "liga 2k_3k voOD";
                    Series ser47 = chartAudioOD.Series.Add(seriesName47);

                    ser47.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser47.Name = seriesName47;
                    ser47.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo2kodComboBox.Text);
                        valorB = Convert.ToInt32(vo3kodComboBox.Text);

                        ser47.Points.AddXY(9.75, valorA);
                        ser47.Points.AddXY(11, valorB);

                        ser47.BorderColor = Color.Transparent;
                        ser47.Color = Color.Red;
                        ser47.BorderDashStyle = ChartDashStyle.Dash;
                        ser47.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvo_ODCheckBox.Checked == false)
                    {
                        ser47.Points.Clear();
                    }

                    //******

                    string seriesName48 = "liga 3k_4k voOD";
                    Series ser48 = chartAudioOD.Series.Add(seriesName48);

                    ser48.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser48.Name = seriesName48;
                    ser48.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo3kodComboBox.Text);
                        valorB = Convert.ToInt32(vo4kodComboBox.Text);

                        ser48.Points.AddXY(11, valorA);
                        ser48.Points.AddXY(11.75, valorB);

                        ser48.BorderColor = Color.Transparent;
                        ser48.Color = Color.Red;
                        ser48.BorderDashStyle = ChartDashStyle.Dash;
                        ser48.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvo_ODCheckBox.Checked == false)
                    {
                        ser48.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga250_500vo_ODCheckBox.Checked = false;
                    liga500_750vo_ODCheckBox.Checked = false;
                    liga750_1kvo_ODCheckBox.Checked = false;
                    liga1k_1_5kvo_ODCheckBox.Checked = false;
                    liga1_5k_2kvo_ODCheckBox.Checked = false;
                    liga2k_3kvo_ODCheckBox.Checked = false;
                    liga3k_4kvo_ODCheckBox.Checked = false;
                }
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria clínica convencional")//AUDIOMETRIA COM AS FREQUÊNCIAS CONVENCIONAIS
            {
                va125odComboBox.Enabled = false;
                va750odComboBox.Enabled = false;
                va1e5kodComboBox.Enabled = false;

                masc125vaODCheckBox.Enabled = false;
                masc750vaODCheckBox.Enabled = false;
                masc1_5kvaODCheckBox.Enabled = false;

                aus125vaODCheckBox.Enabled = false;
                aus750vaODCheckBox.Enabled = false;

                liga125_250vaODCheckBox.Enabled = false;
                liga500_750vaODCheckBox.Enabled = false;
                liga1k_1_5kvaODCheckBox.Enabled = false;

                vo750odComboBox.Enabled = false;
                vo1e5kodComboBox.Enabled = false;

                masc750vo_ODCheckBox.Enabled = false;
                masc1_5kvo_ODCheckBox.Enabled = false;

                aus750vo_ODCheckBox.Enabled = false;
                aus1_5kvo_ODCheckBox.Enabled = false;

                liga500_750vo_ODCheckBox.Enabled = false;
                liga1k_1_5kvo_ODCheckBox.Enabled = false;

                //***SIMBOLOGIA DE VA DA OD

                string seriesName13 = "simbol125";
                Series ser13 = chartAudioOD.Series.Add(seriesName13);

                ser13.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (va125odComboBox.Text == "")
                {
                    var vaODpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                //*********

                string seriesName14 = "simbol250";
                Series ser14 = chartAudioOD.Series.Add(seriesName14);

                ser14.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (va250odComboBox.Text == "")
                {
                    var vaODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (va250odComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(va250odComboBox.Text);
                    ser14.Points.AddXY(4, valor14);  // x, high
                }

                if ((aus250vaODCheckBox.Checked == false) && (masc250vaODCheckBox.Checked == false))
                {
                    var vaODpresente14p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14p);
                    ser14.MarkerImage = "vaODpresente";
                }

                else if ((aus250vaODCheckBox.Checked == true) && (masc250vaODCheckBox.Checked == false))
                {
                    var vaODausente14a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente14a);
                    ser14.MarkerImage = "vaODausente";
                }

                else if ((aus250vaODCheckBox.Checked == false) && (masc250vaODCheckBox.Checked == true))
                {
                    var vaODpresente14m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14m);
                    ser14.MarkerImage = "vaODmascPresente";
                }

                else if ((masc250vaODCheckBox.Checked == true) && (aus250vaODCheckBox.Checked == true))
                {
                    var vaODpresente14ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente14ma);
                    ser14.MarkerImage = "vaODmascAusente";
                }

                //**********

                string seriesName15 = "simbol500";
                Series ser15 = chartAudioOD.Series.Add(seriesName15);

                ser15.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser15.Name = seriesName15;
                ser15.ChartType = SeriesChartType.Point;

                if (va500odComboBox.Text == "")
                {
                    var vaODpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15vaz);
                    ser15.MarkerImage = "vazio";
                }

                else if (va500odComboBox.Text != "")
                {
                    int valor15;
                    valor15 = Convert.ToInt32(va500odComboBox.Text);
                    ser15.Points.AddXY(6, valor15);  // x, high
                }

                if ((aus500vaODCheckBox.Checked == false) && (masc500vaODCheckBox.Checked == false))
                {
                    var vaODpresente15p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15p);
                    ser15.MarkerImage = "vaODpresente";
                }

                else if ((aus500vaODCheckBox.Checked == true) && (masc500vaODCheckBox.Checked == false))
                {
                    var vaODausente15a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente15a);
                    ser15.MarkerImage = "vaODausente";
                }

                else if ((aus500vaODCheckBox.Checked == false) && (masc500vaODCheckBox.Checked == true))
                {
                    var vaODpresente15m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15m);
                    ser15.MarkerImage = "vaODmascPresente";
                }

                else if ((masc500vaODCheckBox.Checked == true) && (aus500vaODCheckBox.Checked == true))
                {
                    var vaODpresente15ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente15ma);
                    ser15.MarkerImage = "vaODmascAusente";
                }

                //********

                string seriesName16 = "simbol750";
                Series ser16 = chartAudioOD.Series.Add(seriesName16);

                ser16.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser16.Name = seriesName16;
                ser16.ChartType = SeriesChartType.Point;

                if (va750odComboBox.Text == "")
                {
                    var vaODpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente16vaz);
                    ser16.MarkerImage = "vazio";
                }

                //*********

                string seriesName17 = "simbol1k";
                Series ser17 = chartAudioOD.Series.Add(seriesName17);

                ser17.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser17.Name = seriesName17;
                ser17.ChartType = SeriesChartType.Point;

                if (va1kodComboBox.Text == "")
                {
                    var vaODpresente17vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17vaz);
                    ser17.MarkerImage = "vazio";
                }

                else if (va1kodComboBox.Text != "")
                {
                    int valor17;
                    valor17 = Convert.ToInt32(va1kodComboBox.Text);
                    ser17.Points.AddXY(8, valor17);  // x, high
                }

                if ((aus1kvaODCheckBox.Checked == false) && (masc1kvaODCheckBox.Checked == false))
                {
                    var vaODpresente17p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17p);
                    ser17.MarkerImage = "vaODpresente";
                }

                else if ((aus1kvaODCheckBox.Checked == true) && (masc1kvaODCheckBox.Checked == false))
                {
                    var vaODausente17a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente17a);
                    ser17.MarkerImage = "vaODausente";
                }

                else if ((aus1kvaODCheckBox.Checked == false) && (masc1kvaODCheckBox.Checked == true))
                {
                    var vaODpresente17m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17m);
                    ser17.MarkerImage = "vaODmascPresente";
                }

                else if ((masc1kvaODCheckBox.Checked == true) && (aus1kvaODCheckBox.Checked == true))
                {
                    var vaODpresente17ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente17ma);
                    ser17.MarkerImage = "vaODmascAusente";
                }

                //***********

                string seriesName18 = "simbol1,5k";
                Series ser18 = chartAudioOD.Series.Add(seriesName18);

                ser18.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser18.Name = seriesName18;
                ser18.ChartType = SeriesChartType.Point;

                if (va1e5kodComboBox.Text == "")
                {
                    var vaODpresente18vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente18vaz);
                    ser18.MarkerImage = "vazio";
                }

                //************

                string seriesName19 = "simbol2k";
                Series ser19 = chartAudioOD.Series.Add(seriesName19);

                ser19.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser19.Name = seriesName19;
                ser19.ChartType = SeriesChartType.Point;

                if (va2kodComboBox.Text == "")
                {
                    var vaODpresente19vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19vaz);
                    ser19.MarkerImage = "vazio";
                }

                else if (va2kodComboBox.Text != "")
                {
                    int valor19;
                    valor19 = Convert.ToInt32(va2kodComboBox.Text);
                    ser19.Points.AddXY(10, valor19);  // x, high
                }

                if ((aus2kvaODCheckBox.Checked == false) && (masc2kvaODCheckBox.Checked == false))
                {
                    var vaODpresente19p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19p);
                    ser19.MarkerImage = "vaODpresente";
                }

                else if ((aus2kvaODCheckBox.Checked == true) && (masc2kvaODCheckBox.Checked == false))
                {
                    var vaODausente19a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente19a);
                    ser19.MarkerImage = "vaODausente";
                }

                else if ((aus2kvaODCheckBox.Checked == false) && (masc2kvaODCheckBox.Checked == true))
                {
                    var vaODpresente19m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19m);
                    ser19.MarkerImage = "vaODmascPresente";
                }

                else if ((masc2kvaODCheckBox.Checked == true) && (aus2kvaODCheckBox.Checked == true))
                {
                    var vaODpresente19ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente19ma);
                    ser19.MarkerImage = "vaODmascAusente";
                }

                //*********

                string seriesName20 = "simbol3k";
                Series ser20 = chartAudioOD.Series.Add(seriesName20);

                ser20.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser20.Name = seriesName20;
                ser20.ChartType = SeriesChartType.Point;

                if (va3kodComboBox.Text == "")
                {
                    var vaODpresente20vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20vaz);
                    ser20.MarkerImage = "vazio";
                }

                else if (va3kodComboBox.Text != "")
                {
                    int valor20;
                    valor20 = Convert.ToInt32(va3kodComboBox.Text);
                    ser20.Points.AddXY(11.25, valor20);  // x, high
                }

                if ((aus3kvaODCheckBox.Checked == false) && (masc3kvaODCheckBox.Checked == false))
                {
                    var vaODpresente20p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20p);
                    ser20.MarkerImage = "vaODpresente";
                }

                else if ((aus3kvaODCheckBox.Checked == true) && (masc3kvaODCheckBox.Checked == false))
                {
                    var vaODausente20a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente20a);
                    ser20.MarkerImage = "vaODausente";
                }

                else if ((aus3kvaODCheckBox.Checked == false) && (masc3kvaODCheckBox.Checked == true))
                {
                    var vaODpresente20m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20m);
                    ser20.MarkerImage = "vaODmascPresente";
                }

                else if ((masc3kvaODCheckBox.Checked == true) && (aus3kvaODCheckBox.Checked == true))
                {
                    var vaODpresente20ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente20ma);
                    ser20.MarkerImage = "vaODmascAusente";
                }

                //********

                string seriesName21 = "simbol4k";
                Series ser21 = chartAudioOD.Series.Add(seriesName21);

                ser21.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser21.Name = seriesName21;
                ser21.ChartType = SeriesChartType.Point;

                if (va4kodComboBox.Text == "")
                {
                    var vaODpresente21vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21vaz);
                    ser21.MarkerImage = "vazio";
                }

                else if (va4kodComboBox.Text != "")
                {
                    int valor21;
                    valor21 = Convert.ToInt32(va4kodComboBox.Text);
                    ser21.Points.AddXY(12, valor21);  // x, high
                }

                if ((aus4kvaODCheckBox.Checked == false) && (masc4kvaODCheckBox.Checked == false))
                {
                    var vaODpresente21p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21p);
                    ser21.MarkerImage = "vaODpresente";
                }

                else if ((aus4kvaODCheckBox.Checked == true) && (masc4kvaODCheckBox.Checked == false))
                {
                    var vaODausente21a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente21a);
                    ser21.MarkerImage = "vaODausente";
                }

                else if ((aus4kvaODCheckBox.Checked == false) && (masc4kvaODCheckBox.Checked == true))
                {
                    var vaODpresente21m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21m);
                    ser21.MarkerImage = "vaODmascPresente";
                }

                else if ((masc4kvaODCheckBox.Checked == true) && (aus4kvaODCheckBox.Checked == true))
                {
                    var vaODpresente21ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente21ma);
                    ser21.MarkerImage = "vaODmascAusente";
                }

                //**********

                string seriesName22 = "simbol6k";
                Series ser22 = chartAudioOD.Series.Add(seriesName22);

                ser22.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser22.Name = seriesName22;
                ser22.ChartType = SeriesChartType.Point;

                if (va6kodComboBox.Text == "")
                {
                    var vaODpresente22vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22vaz);
                    ser22.MarkerImage = "vazio";
                }

                else if (va6kodComboBox.Text != "")
                {
                    int valor22;
                    valor22 = Convert.ToInt32(va6kodComboBox.Text);
                    ser22.Points.AddXY(13.25, valor22);  // x, high
                }

                if ((aus6kvaODCheckBox.Checked == false) && (masc6kvaODCheckBox.Checked == false))
                {
                    var vaODpresente22p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22p);
                    ser22.MarkerImage = "vaODpresente";
                }

                else if ((aus6kvaODCheckBox.Checked == true) && (masc6kvaODCheckBox.Checked == false))
                {
                    var vaODausente22a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente22a);
                    ser22.MarkerImage = "vaODausente";
                }

                else if ((aus6kvaODCheckBox.Checked == false) && (masc6kvaODCheckBox.Checked == true))
                {
                    var vaODpresente22m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22m);
                    ser22.MarkerImage = "vaODmascPresente";
                }

                else if ((masc6kvaODCheckBox.Checked == true) && (aus6kvaODCheckBox.Checked == true))
                {
                    var vaODpresente22ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente22ma);
                    ser22.MarkerImage = "vaODmascAusente";
                }

                //***********

                string seriesName23 = "simbol8k";
                Series ser23 = chartAudioOD.Series.Add(seriesName23);

                ser23.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser23.Name = seriesName23;
                ser23.ChartType = SeriesChartType.Point;

                if (va8kodComboBox.Text == "")
                {
                    var vaODpresente23vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23vaz);
                    ser23.MarkerImage = "vazio";
                }

                else if (va8kodComboBox.Text != "")
                {
                    int valor23;
                    valor23 = Convert.ToInt32(va8kodComboBox.Text);
                    ser23.Points.AddXY(14, valor23);  // x, high
                }

                if ((aus8kvaODCheckBox.Checked == false) && (masc8kvaODCheckBox.Checked == false))
                {
                    var vaODpresente23p = new NamedImage("vaODpresente", Properties.Resources.vaODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23p);
                    ser23.MarkerImage = "vaODpresente";
                }

                else if ((aus8kvaODCheckBox.Checked == true) && (masc8kvaODCheckBox.Checked == false))
                {
                    var vaODausente23a = new NamedImage("vaODausente", Properties.Resources.vaODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODausente23a);
                    ser23.MarkerImage = "vaODausente";
                }

                else if ((aus8kvaODCheckBox.Checked == false) && (masc8kvaODCheckBox.Checked == true))
                {
                    var vaODpresente23m = new NamedImage("vaODmascPresente", Properties.Resources.vaODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23m);
                    ser23.MarkerImage = "vaODmascPresente";
                }

                else if ((masc8kvaODCheckBox.Checked == true) && (aus8kvaODCheckBox.Checked == true))
                {
                    var vaODpresente23ma = new NamedImage("vaODmascAusente", Properties.Resources.vaODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(vaODpresente23ma);
                    ser23.MarkerImage = "vaODmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OD

                try
                {               
                    //*******

                    string seriesName25 = "liga 250_500 vaOD";
                    Series ser25 = chartAudioOD.Series.Add(seriesName25);

                    ser25.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser25.Name = seriesName25;
                    ser25.ChartType = SeriesChartType.Line;

                    if (liga250_500vaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va250odComboBox.Text);
                        valorB = Convert.ToInt32(va500odComboBox.Text);

                        ser25.Points.AddXY(4, valorA);
                        ser25.Points.AddXY(6, valorB);

                        ser25.BorderColor = Color.Transparent;
                        ser25.Color = Color.Red;
                        ser25.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vaODCheckBox.Checked == false)
                    {
                        ser25.Points.Clear();
                    }                   
                    //******

                    string seriesName27 = "liga 500_1k OD";
                    Series ser27 = chartAudioOD.Series.Add(seriesName27);

                    ser27.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser27.Name = seriesName27;
                    ser27.ChartType = SeriesChartType.Line;

                    if (liga750_1kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va500odComboBox.Text);
                        valorB = Convert.ToInt32(va1kodComboBox.Text);

                        ser27.Points.AddXY(6, valorA);
                        ser27.Points.AddXY(8, valorB);

                        ser27.BorderColor = Color.Transparent;
                        ser27.Color = Color.Red;
                        ser27.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvaODCheckBox.Checked == false)
                    {
                        ser27.Points.Clear();
                    }

                    //******

                    string seriesName29 = "liga 1k _ 2k vaOD";
                    Series ser29 = chartAudioOD.Series.Add(seriesName29);

                    ser29.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser29.Name = seriesName29;
                    ser29.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va1kodComboBox.Text);
                        valorB = Convert.ToInt32(va2kodComboBox.Text);

                        ser29.Points.AddXY(8, valorA);
                        ser29.Points.AddXY(10, valorB);

                        ser29.BorderColor = Color.Transparent;
                        ser29.Color = Color.Red;
                        ser29.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvaODCheckBox.Checked == false)
                    {
                        ser29.Points.Clear();
                    }

                    //******

                    string seriesName30 = "liga 2k_3k vaOD";
                    Series ser30 = chartAudioOD.Series.Add(seriesName30);

                    ser30.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser30.Name = seriesName30;
                    ser30.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va2kodComboBox.Text);
                        valorB = Convert.ToInt32(va3kodComboBox.Text);

                        ser30.Points.AddXY(10, valorA);
                        ser30.Points.AddXY(11.25, valorB);

                        ser30.BorderColor = Color.Transparent;
                        ser30.Color = Color.Red;
                        ser30.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvaODCheckBox.Checked == false)
                    {
                        ser30.Points.Clear();
                    }

                    //******

                    string seriesName31 = "liga 3k_4k vaOD";
                    Series ser31 = chartAudioOD.Series.Add(seriesName31);

                    ser31.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser31.Name = seriesName31;
                    ser31.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va3kodComboBox.Text);
                        valorB = Convert.ToInt32(va4kodComboBox.Text);

                        ser31.Points.AddXY(11.25, valorA);
                        ser31.Points.AddXY(12, valorB);

                        ser31.BorderColor = Color.Transparent;
                        ser31.Color = Color.Red;
                        ser31.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvaODCheckBox.Checked == false)
                    {
                        ser31.Points.Clear();
                    }

                    //******

                    string seriesName32 = "liga 4k_6k vaOD";
                    Series ser32 = chartAudioOD.Series.Add(seriesName32);

                    ser32.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser32.Name = seriesName32;
                    ser32.ChartType = SeriesChartType.Line;

                    if (liga4k_6kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va4kodComboBox.Text);
                        valorB = Convert.ToInt32(va6kodComboBox.Text);

                        ser32.Points.AddXY(12, valorA);
                        ser32.Points.AddXY(13.25, valorB);

                        ser32.BorderColor = Color.Transparent;
                        ser32.Color = Color.Red;
                        ser32.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga4k_6kvaODCheckBox.Checked == false)
                    {
                        ser32.Points.Clear();
                    }

                    //******

                    string seriesName33 = "liga 6k-8k vaOD";
                    Series ser33 = chartAudioOD.Series.Add(seriesName33);

                    ser33.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser33.Name = seriesName33;
                    ser33.ChartType = SeriesChartType.Line;

                    if (liga6k_8kvaODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va6kodComboBox.Text);
                        valorB = Convert.ToInt32(va8kodComboBox.Text);

                        ser33.Points.AddXY(13.25, valorA);
                        ser33.Points.AddXY(14, valorB);

                        ser33.BorderColor = Color.Transparent;
                        ser33.Color = Color.Red;
                        ser33.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga6k_8kvaODCheckBox.Checked == false)
                    {
                        ser33.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga125_250vaODCheckBox.Checked = false;
                    liga250_500vaODCheckBox.Checked = false;
                    liga500_750vaODCheckBox.Checked = false;
                    liga750_1kvaODCheckBox.Checked = false;
                    liga1k_1_5kvaODCheckBox.Checked = false;
                    liga1_5k_2kvaODCheckBox.Checked = false;
                    liga2k_3kvaODCheckBox.Checked = false;
                    liga3k_4kvaODCheckBox.Checked = false;
                    liga4k_6kvaODCheckBox.Checked = false;
                    liga6k_8kvaODCheckBox.Checked = false;
                }

                //*********
                //********** SIMBOLOGIA DE VO OD


                string seriesName34 = "simbol 250 voOD";
                Series ser34 = chartAudioOD.Series.Add(seriesName34);

                ser34.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser34.Name = seriesName34;
                ser34.ChartType = SeriesChartType.Point;

                if (vo250odComboBox.Text == "")
                {
                    var voODpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente14vaz);
                    ser34.MarkerImage = "vazio";
                }

                else if (vo250odComboBox.Text != "")
                {
                    int valor34;
                    valor34 = Convert.ToInt32(vo250odComboBox.Text);
                    ser34.Points.AddXY(4, valor34);  // x, high
                }

                if ((aus250vo_ODCheckBox.Checked == false) && (masc250vo_ODCheckBox.Checked == false))
                {
                    var voODpresente34p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente34p);
                    ser34.MarkerImage = "voODpresente";
                }

                else if ((aus250vo_ODCheckBox.Checked == true) && (masc250vo_ODCheckBox.Checked == false))
                {
                    var voODausente34a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente34a);
                    ser34.MarkerImage = "voODausente";
                }

                else if ((aus250vo_ODCheckBox.Checked == false) && (masc250vo_ODCheckBox.Checked == true))
                {
                    var voODpresente34m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente34m);
                    ser34.MarkerImage = "voODmascPresente";
                }

                else if ((masc250vo_ODCheckBox.Checked == true) && (aus250vo_ODCheckBox.Checked == true))
                {
                    var voODpresente34ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente34ma);
                    ser34.MarkerImage = "voODmascAusente";
                }

                //**********

                string seriesName35 = "simbol500 voOD";
                Series ser35 = chartAudioOD.Series.Add(seriesName35);

                ser35.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser35.Name = seriesName35;
                ser35.ChartType = SeriesChartType.Point;

                if (vo500odComboBox.Text == "")
                {
                    var voODpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15vaz);
                    ser35.MarkerImage = "vazio";
                }

                else if (vo500odComboBox.Text != "")
                {
                    int valor35;
                    valor35 = Convert.ToInt32(vo500odComboBox.Text);
                    ser35.Points.AddXY(6, valor35);  // x, high
                }

                if ((aus500vo_ODCheckBox.Checked == false) && (masc500vo_ODCheckBox.Checked == false))
                {
                    var voODpresente15p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15p);
                    ser35.MarkerImage = "voODpresente";
                }

                else if ((aus500vo_ODCheckBox.Checked == true) && (masc500vo_ODCheckBox.Checked == false))
                {
                    var voODausente15a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente15a);
                    ser35.MarkerImage = "voODausente";
                }

                else if ((aus500vo_ODCheckBox.Checked == false) && (masc500vo_ODCheckBox.Checked == true))
                {
                    var voODpresente15m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15m);
                    ser35.MarkerImage = "voODmascPresente";
                }

                else if ((masc500vo_ODCheckBox.Checked == true) && (aus500vo_ODCheckBox.Checked == true))
                {
                    var voODpresente15ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente15ma);
                    ser35.MarkerImage = "voODmascAusente";
                }

                //********

                string seriesName36 = "simbol750 voOD";
                Series ser36 = chartAudioOD.Series.Add(seriesName36);

                ser36.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser36.Name = seriesName36;
                ser36.ChartType = SeriesChartType.Point;

                if (vo750odComboBox.Text == "")
                {
                    var voODpresente36vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente36vaz);
                    ser36.MarkerImage = "vazio";
                }
              
                //*********

                string seriesName37 = "simbol1k voOD";
                Series ser37 = chartAudioOD.Series.Add(seriesName37);

                ser37.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser37.Name = seriesName37;
                ser37.ChartType = SeriesChartType.Point;

                if (vo1kodComboBox.Text == "")
                {
                    var voODpresente37vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37vaz);
                    ser37.MarkerImage = "vazio";
                }

                else if (vo1kodComboBox.Text != "")
                {
                    int valor37;
                    valor37 = Convert.ToInt32(vo1kodComboBox.Text);
                    ser37.Points.AddXY(8, valor37);  // x, high
                }

                if ((aus1kvo_ODCheckBox.Checked == false) && (masc1kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente37p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37p);
                    ser37.MarkerImage = "voODpresente";
                }

                else if ((aus1kvo_ODCheckBox.Checked == true) && (masc1kvo_ODCheckBox.Checked == false))
                {
                    var voODausente37a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente37a);
                    ser37.MarkerImage = "voODausente";
                }

                else if ((aus1kvo_ODCheckBox.Checked == false) && (masc1kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente37m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37m);
                    ser37.MarkerImage = "voODmascPresente";
                }

                else if ((masc1kvo_ODCheckBox.Checked == true) && (aus1kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente37ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente37ma);
                    ser37.MarkerImage = "voODmascAusente";
                }

                //***********

                string seriesName38 = "simbol1,5k voOD";
                Series ser38 = chartAudioOD.Series.Add(seriesName38);

                ser38.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser38.Name = seriesName38;
                ser38.ChartType = SeriesChartType.Point;

                if (vo1e5kodComboBox.Text == "")
                {
                    var voODpresente38vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente38vaz);
                    ser38.MarkerImage = "vazio";
                }
               
                //************

                string seriesName39 = "simbol2k voOD";
                Series ser39 = chartAudioOD.Series.Add(seriesName39);

                ser39.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser39.Name = seriesName39;
                ser39.ChartType = SeriesChartType.Point;

                if (vo2kodComboBox.Text == "")
                {
                    var voODpresente39vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39vaz);
                    ser39.MarkerImage = "vazio";
                }

                else if (vo2kodComboBox.Text != "")
                {
                    int valor39;
                    valor39 = Convert.ToInt32(vo2kodComboBox.Text);
                    ser39.Points.AddXY(10, valor39);  // x, high
                }

                if ((aus2kvo_ODCheckBox.Checked == false) && (masc2kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente39p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39p);
                    ser39.MarkerImage = "voODpresente";
                }

                else if ((aus2kvo_ODCheckBox.Checked == true) && (masc2kvo_ODCheckBox.Checked == false))
                {
                    var voODausente39a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente39a);
                    ser39.MarkerImage = "voODausente";
                }

                else if ((aus2kvo_ODCheckBox.Checked == false) && (masc2kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente39m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39m);
                    ser39.MarkerImage = "voODmascPresente";
                }

                else if ((masc2kvo_ODCheckBox.Checked == true) && (aus2kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente39ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente39ma);
                    ser39.MarkerImage = "voODmascAusente";
                }

                //*********

                string seriesName40 = "simbol3k voOD";
                Series ser40 = chartAudioOD.Series.Add(seriesName40);

                ser40.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser40.Name = seriesName40;
                ser40.ChartType = SeriesChartType.Point;

                if (vo3kodComboBox.Text == "")
                {
                    var voODpresente40vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40vaz);
                    ser40.MarkerImage = "vazio";
                }

                else if (vo3kodComboBox.Text != "")
                {
                    int valor40;
                    valor40 = Convert.ToInt32(vo3kodComboBox.Text);
                    ser40.Points.AddXY(11.25, valor40);  // x, high
                }

                if ((aus3kvo_ODCheckBox.Checked == false) && (masc3kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente40p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40p);
                    ser40.MarkerImage = "voODpresente";
                }

                else if ((aus3kvo_ODCheckBox.Checked == true) && (masc3kvo_ODCheckBox.Checked == false))
                {
                    var voODausente40a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente40a);
                    ser40.MarkerImage = "voODausente";
                }

                else if ((aus3kvo_ODCheckBox.Checked == false) && (masc3kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente40m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40m);
                    ser40.MarkerImage = "voODmascPresente";
                }

                else if ((masc3kvo_ODCheckBox.Checked == true) && (aus3kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente40ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente40ma);
                    ser40.MarkerImage = "voODmascAusente";
                }

                //********

                string seriesName41 = "simbol4k voOD";
                Series ser41 = chartAudioOD.Series.Add(seriesName41);

                ser41.ChartArea = chartAudioOD.ChartAreas[0].Name;
                ser41.Name = seriesName41;
                ser41.ChartType = SeriesChartType.Point;

                if (vo4kodComboBox.Text == "")
                {
                    var voODpresente41vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41vaz);
                    ser41.MarkerImage = "vazio";
                }

                else if (vo4kodComboBox.Text != "")
                {
                    int valor41;
                    valor41 = Convert.ToInt32(vo4kodComboBox.Text);
                    ser41.Points.AddXY(12, valor41);  // x, high
                }

                if ((aus4kvo_ODCheckBox.Checked == false) && (masc4kvo_ODCheckBox.Checked == false))
                {
                    var voODpresente41p = new NamedImage("voODpresente", Properties.Resources.voODpresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41p);
                    ser41.MarkerImage = "voODpresente";
                }

                else if ((aus4kvo_ODCheckBox.Checked == true) && (masc4kvo_ODCheckBox.Checked == false))
                {
                    var voODausente41a = new NamedImage("voODausente", Properties.Resources.voODausente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODausente41a);
                    ser41.MarkerImage = "voODausente";
                }

                else if ((aus4kvo_ODCheckBox.Checked == false) && (masc4kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente41m = new NamedImage("voODmascPresente", Properties.Resources.voODmascPresente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41m);
                    ser41.MarkerImage = "voODmascPresente";
                }

                else if ((masc4kvo_ODCheckBox.Checked == true) && (aus4kvo_ODCheckBox.Checked == true))
                {
                    var voODpresente41ma = new NamedImage("voODmascAusente", Properties.Resources.voODmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voODpresente41ma);
                    ser41.MarkerImage = "voODmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OD (VO)

                try
                {
                    //*******

                    string seriesName42 = "liga 250_500 voOD";
                    Series ser42 = chartAudioOD.Series.Add(seriesName42);

                    ser42.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser42.Name = seriesName42;
                    ser42.ChartType = SeriesChartType.Line;

                    if (liga250_500vo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo250odComboBox.Text);
                        valorB = Convert.ToInt32(vo500odComboBox.Text);

                        ser42.Points.AddXY(3.75, valorA);
                        ser42.Points.AddXY(5.75, valorB);

                        ser42.BorderColor = Color.Transparent;
                        ser42.Color = Color.Red;
                        ser42.BorderDashStyle = ChartDashStyle.Dash;
                        ser42.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vo_ODCheckBox.Checked == false)
                    {
                        ser42.Points.Clear();
                    }

                    //*******
                  
                    //******

                    string seriesName44 = "liga 500_1k voOD";
                    Series ser44 = chartAudioOD.Series.Add(seriesName44);

                    ser44.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser44.Name = seriesName44;
                    ser44.ChartType = SeriesChartType.Line;

                    if (liga750_1kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo500odComboBox.Text);
                        valorB = Convert.ToInt32(vo1kodComboBox.Text);

                        ser44.Points.AddXY(6, valorA);
                        ser44.Points.AddXY(7.75, valorB);

                        ser44.BorderColor = Color.Transparent;
                        ser44.Color = Color.Red;
                        ser44.BorderDashStyle = ChartDashStyle.Dash;
                        ser44.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvo_ODCheckBox.Checked == false)
                    {
                        ser44.Points.Clear();
                    }
                 
                    //******

                    string seriesName46 = "liga 1k _ 2k voOD";
                    Series ser46 = chartAudioOD.Series.Add(seriesName46);

                    ser46.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser46.Name = seriesName46;
                    ser46.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo1kodComboBox.Text);
                        valorB = Convert.ToInt32(vo2kodComboBox.Text);

                        ser46.Points.AddXY(7.75, valorA);
                        ser46.Points.AddXY(9.75, valorB);

                        ser46.BorderColor = Color.Transparent;
                        ser46.Color = Color.Red;
                        ser46.BorderDashStyle = ChartDashStyle.Dash;
                        ser46.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvo_ODCheckBox.Checked == false)
                    {
                        ser46.Points.Clear();
                    }

                    //******

                    string seriesName47 = "liga 2k_3k voOD";
                    Series ser47 = chartAudioOD.Series.Add(seriesName47);

                    ser47.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser47.Name = seriesName47;
                    ser47.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo2kodComboBox.Text);
                        valorB = Convert.ToInt32(vo3kodComboBox.Text);

                        ser47.Points.AddXY(9.75, valorA);
                        ser47.Points.AddXY(11, valorB);

                        ser47.BorderColor = Color.Transparent;
                        ser47.Color = Color.Red;
                        ser47.BorderDashStyle = ChartDashStyle.Dash;
                        ser47.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvo_ODCheckBox.Checked == false)
                    {
                        ser47.Points.Clear();
                    }

                    //******

                    string seriesName48 = "liga 3k_4k voOD";
                    Series ser48 = chartAudioOD.Series.Add(seriesName48);

                    ser48.ChartArea = chartAudioOD.ChartAreas[0].Name;
                    ser48.Name = seriesName48;
                    ser48.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvo_ODCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo3kodComboBox.Text);
                        valorB = Convert.ToInt32(vo4kodComboBox.Text);

                        ser48.Points.AddXY(11, valorA);
                        ser48.Points.AddXY(11.75, valorB);

                        ser48.BorderColor = Color.Transparent;
                        ser48.Color = Color.Red;
                        ser48.BorderDashStyle = ChartDashStyle.Dash;
                        ser48.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvo_ODCheckBox.Checked == false)
                    {
                        ser48.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga250_500vo_ODCheckBox.Checked = false;
                    liga500_750vo_ODCheckBox.Checked = false;
                    liga750_1kvo_ODCheckBox.Checked = false;
                    liga1k_1_5kvo_ODCheckBox.Checked = false;
                    liga1_5k_2kvo_ODCheckBox.Checked = false;
                    liga2k_3kvo_ODCheckBox.Checked = false;
                    liga3k_4kvo_ODCheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Escolha entre 'Audiometria Clínica Convencional' ou 'Audiomeria Clínica Todas as Frequências'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlotarAudioOE_Click(object sender, EventArgs e)
        {
            chartAudioOE.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartAudioOE.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartAudioOE.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string fundoChart = "fundoChartTransp";
            Series imgFundo = chartAudioOE.Series.Add(fundoChart);

            imgFundo.ChartArea = chartAudioOE.ChartAreas[0].Name;
            imgFundo.Name = fundoChart;
            imgFundo.ChartType = SeriesChartType.Point;

            if (rbExibeBananaAudioClinicaOE.Checked == true)
            {
                var fundoAudioOE = new NamedImage("bananaAzul", Properties.Resources.bananaAzul);
                chartAudioOE.Images.Clear();
                chartAudioOE.Images.Add(fundoAudioOE);
                imgFundo.MarkerImage = "bananaAzul";
                imgFundo.Points.AddXY(7.50, 45);
            }
            else if (rbEscondeBananaAudioClinicaOE.Checked == true)
            {
                chartAudioOE.Series[fundoChart].Points.Clear();
            }

            string seriesName1 = "grade1OE";
            Series ser1 = chartAudioOE.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2OE";
            Series ser2 = chartAudioOE.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3OE";
            Series ser3 = chartAudioOE.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4OE";
            Series ser4 = chartAudioOE.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5OE";
            Series ser5 = chartAudioOE.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6OE";
            Series ser6 = chartAudioOE.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7OE";
            Series ser7 = chartAudioOE.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8OE";
            Series ser7a = chartAudioOE.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9OE";
            Series ser9a = chartAudioOE.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10OE";
            Series ser10a = chartAudioOE.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11OE";
            Series ser11a = chartAudioOE.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12OE";
            Series ser12a = chartAudioOE.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);


            //****DEVE-SE ESCOLHER O TIPO DE AUDIOMETRIA PARA A PLOTAGEM DA SIMBOLOGIA*****


            if (tipoAudiometriaComboBox.Text == "")
            {
                MessageBox.Show("Escolha o tipo de audiometria para a plotagem da simbologia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria clínica todas as frequências")//AUDIOMETRIA COMPLETA
            {
                va125oeComboBox.Enabled = true;
                va750oeComboBox.Enabled = true;
                va1e5koeComboBox.Enabled = true;

                masc125vaOECheckBox.Enabled = true;
                masc750vaOECheckBox.Enabled = true;
                masc1_5kvaOECheckBox.Enabled = true;

                aus125vaOECheckBox.Enabled = true;
                aus750vaOECheckBox.Enabled = true;

                liga125_250vaOECheckBox.Enabled = true;
                liga500_750vaOECheckBox.Enabled = true;
                liga1k_1_5kvaOECheckBox.Enabled = true;

                vo750oeComboBox.Enabled = true;
                vo1e5koeComboBox.Enabled = true;

                masc750vo_OECheckBox.Enabled = true;
                masc1_5kvo_OECheckBox.Enabled = true;

                aus750vo_OECheckBox.Enabled = true;
                aus1_5kvo_OECheckBox.Enabled = true;

                liga500_750vo_OECheckBox.Enabled = true;
                liga1k_1_5kvo_OECheckBox.Enabled = true;


                //***SIMBOLOGIA DE VA DA OE

                string seriesName13 = "simbol125";
                Series ser13 = chartAudioOE.Series.Add(seriesName13);

                ser13.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (va125oeComboBox.Text == "")
                {
                    var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                else if (va125oeComboBox.Text != "")
                {
                    int valor13;
                    valor13 = Convert.ToInt32(va125oeComboBox.Text);
                    ser13.Points.AddXY(2, valor13);  // x, high
                }

                if ((aus125vaOECheckBox.Checked == false) && (masc125vaOECheckBox.Checked == false))
                {
                    var vaOEpresente13p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente13p);
                    ser13.MarkerImage = "vaOEpresente";
                }

                else if ((aus125vaOECheckBox.Checked == true) && (masc125vaOECheckBox.Checked == false))
                {
                    var vaOEausente13a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente13a);
                    ser13.MarkerImage = "vaOEausente";
                }

                else if ((aus125vaOECheckBox.Checked == false) && (masc125vaOECheckBox.Checked == true))
                {
                    var vaOEpresente13m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente13m);
                    ser13.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc125vaOECheckBox.Checked == true) && (aus125vaOECheckBox.Checked == true))
                {
                    var vaOEpresente13ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente13ma);
                    ser13.MarkerImage = "vaOEmascAusente";
                }

                //*********

                string seriesName14 = "simbol250";
                Series ser14 = chartAudioOE.Series.Add(seriesName14);

                ser14.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (va250oeComboBox.Text == "")
                {
                    var vaOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (va250oeComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(va250oeComboBox.Text);
                    ser14.Points.AddXY(4, valor14);  // x, high
                }

                if ((aus250vaOECheckBox.Checked == false) && (masc250vaOECheckBox.Checked == false))
                {
                    var vaOEpresente14p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14p);
                    ser14.MarkerImage = "vaOEpresente";
                }

                else if ((aus250vaOECheckBox.Checked == true) && (masc250vaOECheckBox.Checked == false))
                {
                    var vaOEausente14a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente14a);
                    ser14.MarkerImage = "vaOEausente";
                }

                else if ((aus250vaOECheckBox.Checked == false) && (masc250vaOECheckBox.Checked == true))
                {
                    var vaOEpresente14m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14m);
                    ser14.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc250vaOECheckBox.Checked == true) && (aus250vaOECheckBox.Checked == true))
                {
                    var vaOEpresente14ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14ma);
                    ser14.MarkerImage = "vaOEmascAusente";
                }

                //**********

                string seriesName15 = "simbol500";
                Series ser15 = chartAudioOE.Series.Add(seriesName15);

                ser15.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser15.Name = seriesName15;
                ser15.ChartType = SeriesChartType.Point;

                if (va500oeComboBox.Text == "")
                {
                    var vaOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15vaz);
                    ser15.MarkerImage = "vazio";
                }

                else if (va500oeComboBox.Text != "")
                {
                    int valor15;
                    valor15 = Convert.ToInt32(va500oeComboBox.Text);
                    ser15.Points.AddXY(6, valor15);  // x, high
                }

                if ((aus500vaOECheckBox.Checked == false) && (masc500vaOECheckBox.Checked == false))
                {
                    var vaOEpresente15p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15p);
                    ser15.MarkerImage = "vaOEpresente";
                }

                else if ((aus500vaOECheckBox.Checked == true) && (masc500vaOECheckBox.Checked == false))
                {
                    var vaOEausente15a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente15a);
                    ser15.MarkerImage = "vaOEausente";
                }

                else if ((aus500vaOECheckBox.Checked == false) && (masc500vaOECheckBox.Checked == true))
                {
                    var vaOEpresente15m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15m);
                    ser15.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc500vaOECheckBox.Checked == true) && (aus500vaOECheckBox.Checked == true))
                {
                    var vaOEpresente15ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15ma);
                    ser15.MarkerImage = "vaOEmascAusente";
                }

                //********

                string seriesName16 = "simbol750";
                Series ser16 = chartAudioOE.Series.Add(seriesName16);

                ser16.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser16.Name = seriesName16;
                ser16.ChartType = SeriesChartType.Point;

                if (va750oeComboBox.Text == "")
                {
                    var vaOEpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente16vaz);
                    ser16.MarkerImage = "vazio";
                }

                else if (va750oeComboBox.Text != "")
                {
                    int valor16;
                    valor16 = Convert.ToInt32(va750oeComboBox.Text);
                    ser16.Points.AddXY(7.25, valor16);  // x, high
                }

                if ((aus750vaOECheckBox.Checked == false) && (masc750vaOECheckBox.Checked == false))
                {
                    var vaOEpresente16p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente16p);
                    ser16.MarkerImage = "vaOEpresente";
                }

                else if ((aus750vaOECheckBox.Checked == true) && (masc750vaOECheckBox.Checked == false))
                {
                    var vaOEausente16a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente16a);
                    ser16.MarkerImage = "vaOEausente";
                }

                else if ((aus750vaOECheckBox.Checked == false) && (masc750vaOECheckBox.Checked == true))
                {
                    var vaOEpresente16m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente16m);
                    ser16.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc750vaOECheckBox.Checked == true) && (aus750vaOECheckBox.Checked == true))
                {
                    var vaOEpresente16ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente16ma);
                    ser16.MarkerImage = "vaOEmascAusente";
                }

                //*********

                string seriesName17 = "simbol1k";
                Series ser17 = chartAudioOE.Series.Add(seriesName17);

                ser17.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser17.Name = seriesName17;
                ser17.ChartType = SeriesChartType.Point;

                if (va1koeComboBox.Text == "")
                {
                    var vaOEpresente17vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17vaz);
                    ser17.MarkerImage = "vazio";
                }

                else if (va1koeComboBox.Text != "")
                {
                    int valor17;
                    valor17 = Convert.ToInt32(va1koeComboBox.Text);
                    ser17.Points.AddXY(8, valor17);  // x, high
                }

                if ((aus1kvaOECheckBox.Checked == false) && (masc1kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente17p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17p);
                    ser17.MarkerImage = "vaOEpresente";
                }

                else if ((aus1kvaOECheckBox.Checked == true) && (masc1kvaOECheckBox.Checked == false))
                {
                    var vaOEausente17a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente17a);
                    ser17.MarkerImage = "vaOEausente";
                }

                else if ((aus1kvaOECheckBox.Checked == false) && (masc1kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente17m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17m);
                    ser17.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc1kvaOECheckBox.Checked == true) && (aus1kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente17ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17ma);
                    ser17.MarkerImage = "vaOEmascAusente";
                }

                //***********

                string seriesName18 = "simbol1,5k";
                Series ser18 = chartAudioOE.Series.Add(seriesName18);

                ser18.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser18.Name = seriesName18;
                ser18.ChartType = SeriesChartType.Point;

                if (va1e5koeComboBox.Text == "")
                {
                    var vaOEpresente18vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente18vaz);
                    ser18.MarkerImage = "vazio";
                }

                else if (va1e5koeComboBox.Text != "")
                {
                    int valor18;
                    valor18 = Convert.ToInt32(va1e5koeComboBox.Text);
                    ser18.Points.AddXY(9.25, valor18);  // x, high
                }

                if ((aus1_5kvaOECheckBox.Checked == false) && (masc1_5kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente18p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente18p);
                    ser18.MarkerImage = "vaOEpresente";
                }

                else if ((aus1_5kvaOECheckBox.Checked == true) && (masc1_5kvaOECheckBox.Checked == false))
                {
                    var vaOEausente18a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente18a);
                    ser18.MarkerImage = "vaOEausente";
                }

                else if ((aus1_5kvaOECheckBox.Checked == false) && (masc1_5kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente18m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente18m);
                    ser18.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc1_5kvaOECheckBox.Checked == true) && (aus1_5kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente18ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente18ma);
                    ser18.MarkerImage = "vaOEmascAusente";
                }

                //************

                string seriesName19 = "simbol2k";
                Series ser19 = chartAudioOE.Series.Add(seriesName19);

                ser19.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser19.Name = seriesName19;
                ser19.ChartType = SeriesChartType.Point;

                if (va2koeComboBox.Text == "")
                {
                    var vaOEpresente19vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19vaz);
                    ser19.MarkerImage = "vazio";
                }

                else if (va2koeComboBox.Text != "")
                {
                    int valor19;
                    valor19 = Convert.ToInt32(va2koeComboBox.Text);
                    ser19.Points.AddXY(10, valor19);  // x, high
                }

                if ((aus2kvaOECheckBox.Checked == false) && (masc2kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente19p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19p);
                    ser19.MarkerImage = "vaOEpresente";
                }

                else if ((aus2kvaOECheckBox.Checked == true) && (masc2kvaOECheckBox.Checked == false))
                {
                    var vaOEausente19a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente19a);
                    ser19.MarkerImage = "vaOEausente";
                }

                else if ((aus2kvaOECheckBox.Checked == false) && (masc2kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente19m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19m);
                    ser19.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc2kvaOECheckBox.Checked == true) && (aus2kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente19ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19ma);
                    ser19.MarkerImage = "vaOEmascAusente";
                }

                //*********

                string seriesName20 = "simbol3k";
                Series ser20 = chartAudioOE.Series.Add(seriesName20);

                ser20.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser20.Name = seriesName20;
                ser20.ChartType = SeriesChartType.Point;

                if (va3koeComboBox.Text == "")
                {
                    var vaOEpresente20vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20vaz);
                    ser20.MarkerImage = "vazio";
                }

                else if (va3koeComboBox.Text != "")
                {
                    int valor20;
                    valor20 = Convert.ToInt32(va3koeComboBox.Text);
                    ser20.Points.AddXY(11.25, valor20);  // x, high
                }

                if ((aus3kvaOECheckBox.Checked == false) && (masc3kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente20p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20p);
                    ser20.MarkerImage = "vaOEpresente";
                }

                else if ((aus3kvaOECheckBox.Checked == true) && (masc3kvaOECheckBox.Checked == false))
                {
                    var vaOEausente20a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente20a);
                    ser20.MarkerImage = "vaOEausente";
                }

                else if ((aus3kvaOECheckBox.Checked == false) && (masc3kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente20m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20m);
                    ser20.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc3kvaOECheckBox.Checked == true) && (aus3kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente20ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20ma);
                    ser20.MarkerImage = "vaOEmascAusente";
                }

                //********

                string seriesName21 = "simbol4k";
                Series ser21 = chartAudioOE.Series.Add(seriesName21);

                ser21.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser21.Name = seriesName21;
                ser21.ChartType = SeriesChartType.Point;

                if (va4koeComboBox.Text == "")
                {
                    var vaOEpresente21vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21vaz);
                    ser21.MarkerImage = "vazio";
                }

                else if (va4koeComboBox.Text != "")
                {
                    int valor21;
                    valor21 = Convert.ToInt32(va4koeComboBox.Text);
                    ser21.Points.AddXY(12, valor21);  // x, high
                }

                if ((aus4kvaOECheckBox.Checked == false) && (masc4kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente21p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21p);
                    ser21.MarkerImage = "vaOEpresente";
                }

                else if ((aus4kvaOECheckBox.Checked == true) && (masc4kvaOECheckBox.Checked == false))
                {
                    var vaOEausente21a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente21a);
                    ser21.MarkerImage = "vaOEausente";
                }

                else if ((aus4kvaOECheckBox.Checked == false) && (masc4kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente21m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21m);
                    ser21.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc4kvaOECheckBox.Checked == true) && (aus4kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente21ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21ma);
                    ser21.MarkerImage = "vaOEmascAusente";
                }

                //**********

                string seriesName22 = "simbol6k";
                Series ser22 = chartAudioOE.Series.Add(seriesName22);

                ser22.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser22.Name = seriesName22;
                ser22.ChartType = SeriesChartType.Point;

                if (va6koeComboBox.Text == "")
                {
                    var vaOEpresente22vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22vaz);
                    ser22.MarkerImage = "vazio";
                }

                else if (va6koeComboBox.Text != "")
                {
                    int valor22;
                    valor22 = Convert.ToInt32(va6koeComboBox.Text);
                    ser22.Points.AddXY(13.25, valor22);  // x, high
                }

                if ((aus6kvaOECheckBox.Checked == false) && (masc6kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente22p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22p);
                    ser22.MarkerImage = "vaOEpresente";
                }

                else if ((aus6kvaOECheckBox.Checked == true) && (masc6kvaOECheckBox.Checked == false))
                {
                    var vaOEausente22a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente22a);
                    ser22.MarkerImage = "vaOEausente";
                }

                else if ((aus6kvaOECheckBox.Checked == false) && (masc6kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente22m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22m);
                    ser22.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc6kvaOECheckBox.Checked == true) && (aus6kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente22ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22ma);
                    ser22.MarkerImage = "vaOEmascAusente";
                }

                //***********

                string seriesName23 = "simbol8k";
                Series ser23 = chartAudioOE.Series.Add(seriesName23);

                ser23.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser23.Name = seriesName23;
                ser23.ChartType = SeriesChartType.Point;

                if (va8koeComboBox.Text == "")
                {
                    var vaOEpresente23vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23vaz);
                    ser23.MarkerImage = "vazio";
                }

                else if (va8koeComboBox.Text != "")
                {
                    int valor23;
                    valor23 = Convert.ToInt32(va8koeComboBox.Text);
                    ser23.Points.AddXY(14, valor23);  // x, high
                }

                if ((aus8kvaOECheckBox.Checked == false) && (masc8kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente23p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23p);
                    ser23.MarkerImage = "vaOEpresente";
                }

                else if ((aus8kvaOECheckBox.Checked == true) && (masc8kvaOECheckBox.Checked == false))
                {
                    var vaOEausente23a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente23a);
                    ser23.MarkerImage = "vaOEausente";
                }

                else if ((aus8kvaOECheckBox.Checked == false) && (masc8kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente23m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23m);
                    ser23.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc8kvaOECheckBox.Checked == true) && (aus8kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente23ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23ma);
                    ser23.MarkerImage = "vaOEmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OE

                try
                {

                    string seriesName24 = "liga 125_ 250 vaOE";
                    Series ser24 = chartAudioOE.Series.Add(seriesName24);

                    ser24.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser24.Name = seriesName24;
                    ser24.ChartType = SeriesChartType.Line;

                    if (liga125_250vaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va125oeComboBox.Text);
                        valorB = Convert.ToInt32(va250oeComboBox.Text);

                        ser24.Points.AddXY(2, valorA);
                        ser24.Points.AddXY(4, valorB);

                        ser24.BorderColor = Color.Transparent;
                        ser24.Color = Color.DodgerBlue;
                        ser24.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga125_250vaOECheckBox.Checked == false)
                    {
                        ser24.Points.Clear();
                    }

                    //*******

                    string seriesName25 = "liga 250_500 vaOE";
                    Series ser25 = chartAudioOE.Series.Add(seriesName25);

                    ser25.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser25.Name = seriesName25;
                    ser25.ChartType = SeriesChartType.Line;

                    if (liga250_500vaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va250oeComboBox.Text);
                        valorB = Convert.ToInt32(va500oeComboBox.Text);

                        ser25.Points.AddXY(4, valorA);
                        ser25.Points.AddXY(6, valorB);

                        ser25.BorderColor = Color.Transparent;
                        ser25.Color = Color.DodgerBlue;
                        ser25.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vaOECheckBox.Checked == false)
                    {
                        ser25.Points.Clear();
                    }

                    //*******

                    string seriesName26 = "liga 500_750 vaOE";
                    Series ser26 = chartAudioOE.Series.Add(seriesName26);

                    ser26.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser26.Name = seriesName26;
                    ser26.ChartType = SeriesChartType.Line;

                    if (liga500_750vaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va500oeComboBox.Text);
                        valorB = Convert.ToInt32(va750oeComboBox.Text);

                        ser26.Points.AddXY(6, valorA);
                        ser26.Points.AddXY(7.25, valorB);

                        ser26.BorderColor = Color.Transparent;
                        ser26.Color = Color.DodgerBlue;
                        ser26.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga500_750vaOECheckBox.Checked == false)
                    {
                        ser26.Points.Clear();
                    }

                    //******

                    string seriesName27 = "liga 750_1k OE";
                    Series ser27 = chartAudioOE.Series.Add(seriesName27);

                    ser27.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser27.Name = seriesName27;
                    ser27.ChartType = SeriesChartType.Line;

                    if (liga750_1kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va750oeComboBox.Text);
                        valorB = Convert.ToInt32(va1koeComboBox.Text);

                        ser27.Points.AddXY(7.25, valorA);
                        ser27.Points.AddXY(8, valorB);

                        ser27.BorderColor = Color.Transparent;
                        ser27.Color = Color.DodgerBlue;
                        ser27.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvaOECheckBox.Checked == false)
                    {
                        ser27.Points.Clear();
                    }

                    //******

                    string seriesName28 = "liga 1k_1,5K vaOE";
                    Series ser28 = chartAudioOE.Series.Add(seriesName28);

                    ser28.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser28.Name = seriesName28;
                    ser28.ChartType = SeriesChartType.Line;

                    if (liga1k_1_5kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va1koeComboBox.Text);
                        valorB = Convert.ToInt32(va1e5koeComboBox.Text);

                        ser28.Points.AddXY(8, valorA);
                        ser28.Points.AddXY(9.25, valorB);

                        ser28.BorderColor = Color.Transparent;
                        ser28.Color = Color.DodgerBlue;
                        ser28.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1k_1_5kvaOECheckBox.Checked == false)
                    {
                        ser28.Points.Clear();
                    }

                    //******

                    string seriesName29 = "liga 1,5k _ 2k vaOE";
                    Series ser29 = chartAudioOE.Series.Add(seriesName29);

                    ser29.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser29.Name = seriesName29;
                    ser29.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va1e5koeComboBox.Text);
                        valorB = Convert.ToInt32(va2koeComboBox.Text);

                        ser29.Points.AddXY(9.25, valorA);
                        ser29.Points.AddXY(10, valorB);

                        ser29.BorderColor = Color.Transparent;
                        ser29.Color = Color.DodgerBlue;
                        ser29.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvaOECheckBox.Checked == false)
                    {
                        ser29.Points.Clear();
                    }

                    //******

                    string seriesName30 = "liga 2k_3k vaOE";
                    Series ser30 = chartAudioOE.Series.Add(seriesName30);

                    ser30.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser30.Name = seriesName30;
                    ser30.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va2koeComboBox.Text);
                        valorB = Convert.ToInt32(va3koeComboBox.Text);

                        ser30.Points.AddXY(10, valorA);
                        ser30.Points.AddXY(11.25, valorB);

                        ser30.BorderColor = Color.Transparent;
                        ser30.Color = Color.DodgerBlue;
                        ser30.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvaOECheckBox.Checked == false)
                    {
                        ser30.Points.Clear();
                    }

                    //******

                    string seriesName31 = "liga 3k_4k vaOE";
                    Series ser31 = chartAudioOE.Series.Add(seriesName31);

                    ser31.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser31.Name = seriesName31;
                    ser31.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va3koeComboBox.Text);
                        valorB = Convert.ToInt32(va4koeComboBox.Text);

                        ser31.Points.AddXY(11.25, valorA);
                        ser31.Points.AddXY(12, valorB);

                        ser31.BorderColor = Color.Transparent;
                        ser31.Color = Color.DodgerBlue;
                        ser31.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvaOECheckBox.Checked == false)
                    {
                        ser31.Points.Clear();
                    }

                    //******

                    string seriesName32 = "liga 4k_6k vaOE";
                    Series ser32 = chartAudioOE.Series.Add(seriesName32);

                    ser32.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser32.Name = seriesName32;
                    ser32.ChartType = SeriesChartType.Line;

                    if (liga4k_6kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va4koeComboBox.Text);
                        valorB = Convert.ToInt32(va6koeComboBox.Text);

                        ser32.Points.AddXY(12, valorA);
                        ser32.Points.AddXY(13.25, valorB);

                        ser32.BorderColor = Color.Transparent;
                        ser32.Color = Color.DodgerBlue;
                        ser32.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga4k_6kvaODCheckBox.Checked == false)
                    {
                        ser32.Points.Clear();
                    }

                    //******

                    string seriesName33 = "liga 6k-8k vaOE";
                    Series ser33 = chartAudioOE.Series.Add(seriesName33);

                    ser33.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser33.Name = seriesName33;
                    ser33.ChartType = SeriesChartType.Line;

                    if (liga6k_8kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va6koeComboBox.Text);
                        valorB = Convert.ToInt32(va8koeComboBox.Text);

                        ser33.Points.AddXY(13.25, valorA);
                        ser33.Points.AddXY(14, valorB);

                        ser33.BorderColor = Color.Transparent;
                        ser33.Color = Color.DodgerBlue;
                        ser33.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga6k_8kvaOECheckBox.Checked == false)
                    {
                        ser33.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga125_250vaOECheckBox.Checked = false;
                    liga250_500vaOECheckBox.Checked = false;
                    liga500_750vaOECheckBox.Checked = false;
                    liga750_1kvaOECheckBox.Checked = false;
                    liga1k_1_5kvaOECheckBox.Checked = false;
                    liga1_5k_2kvaOECheckBox.Checked = false;
                    liga2k_3kvaOECheckBox.Checked = false;
                    liga3k_4kvaOECheckBox.Checked = false;
                    liga4k_6kvaOECheckBox.Checked = false;
                    liga6k_8kvaOECheckBox.Checked = false;
                }

                //*********
                //********** SIMBOLOGIA DE VO OE


                string seriesName34 = "simbol 250 voOE";
                Series ser34 = chartAudioOE.Series.Add(seriesName34);

                ser34.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser34.Name = seriesName34;
                ser34.ChartType = SeriesChartType.Point;

                if (vo250oeComboBox.Text == "")
                {
                    var voOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente14vaz);
                    ser34.MarkerImage = "vazio";
                }

                else if (vo250oeComboBox.Text != "")
                {
                    int valor34;
                    valor34 = Convert.ToInt32(vo250oeComboBox.Text);
                    ser34.Points.AddXY(4, valor34);  // x, high
                }

                if ((aus250vo_OECheckBox.Checked == false) && (masc250vo_OECheckBox.Checked == false))
                {
                    var voOEpresente34p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente34p);
                    ser34.MarkerImage = "voOEpresente";
                }

                else if ((aus250vo_OECheckBox.Checked == true) && (masc250vo_OECheckBox.Checked == false))
                {
                    var voOEausente34a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente34a);
                    ser34.MarkerImage = "voOEausente";
                }

                else if ((aus250vo_OECheckBox.Checked == false) && (masc250vo_OECheckBox.Checked == true))
                {
                    var voOEpresente34m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente34m);
                    ser34.MarkerImage = "voOEmascPresente";
                }

                else if ((masc250vo_OECheckBox.Checked == true) && (aus250vo_OECheckBox.Checked == true))
                {
                    var voOEpresente34ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente34ma);
                    ser34.MarkerImage = "voOEmascAusente";
                }

                //**********

                string seriesName35 = "simbol500 voOE";
                Series ser35 = chartAudioOE.Series.Add(seriesName35);

                ser35.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser35.Name = seriesName35;
                ser35.ChartType = SeriesChartType.Point;

                if (vo500oeComboBox.Text == "")
                {
                    var voOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15vaz);
                    ser35.MarkerImage = "vazio";
                }

                else if (vo500oeComboBox.Text != "")
                {
                    int valor35;
                    valor35 = Convert.ToInt32(vo500oeComboBox.Text);
                    ser35.Points.AddXY(6, valor35);  // x, high
                }

                if ((aus500vo_OECheckBox.Checked == false) && (masc500vo_OECheckBox.Checked == false))
                {
                    var voOEpresente15p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15p);
                    ser35.MarkerImage = "voOEpresente";
                }

                else if ((aus500vo_OECheckBox.Checked == true) && (masc500vo_OECheckBox.Checked == false))
                {
                    var voOEausente15a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente15a);
                    ser35.MarkerImage = "voOEausente";
                }

                else if ((aus500vo_OECheckBox.Checked == false) && (masc500vo_OECheckBox.Checked == true))
                {
                    var voOEpresente15m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15m);
                    ser35.MarkerImage = "voOEmascPresente";
                }

                else if ((masc500vo_OECheckBox.Checked == true) && (aus500vo_OECheckBox.Checked == true))
                {
                    var voOEpresente15ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15ma);
                    ser35.MarkerImage = "voOEmascAusente";
                }

                //********

                string seriesName36 = "simbol750 voOE";
                Series ser36 = chartAudioOE.Series.Add(seriesName36);

                ser36.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser36.Name = seriesName36;
                ser36.ChartType = SeriesChartType.Point;

                if (vo750oeComboBox.Text == "")
                {
                    var voOEpresente36vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente36vaz);
                    ser36.MarkerImage = "vazio";
                }

                else if (vo750oeComboBox.Text != "")
                {
                    int valor36;
                    valor36 = Convert.ToInt32(vo750oeComboBox.Text);
                    ser36.Points.AddXY(7.25, valor36);  // x, high
                }

                if ((aus750vo_OECheckBox.Checked == false) && (masc750vo_OECheckBox.Checked == false))
                {
                    var voOEpresente36p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente36p);
                    ser36.MarkerImage = "voOEpresente";
                }

                else if ((aus750vo_OECheckBox.Checked == true) && (masc750vo_OECheckBox.Checked == false))
                {
                    var voOEausente36a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente36a);
                    ser36.MarkerImage = "voOEausente";
                }

                else if ((aus750vo_OECheckBox.Checked == false) && (masc750vo_OECheckBox.Checked == true))
                {
                    var voOEpresente36m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente36m);
                    ser36.MarkerImage = "voOEmascPresente";
                }

                else if ((masc750vo_OECheckBox.Checked == true) && (aus750vo_OECheckBox.Checked == true))
                {
                    var voOEpresente36ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente36ma);
                    ser36.MarkerImage = "voOEmascAusente";
                }

                //*********

                string seriesName37 = "simbol1k voOE";
                Series ser37 = chartAudioOE.Series.Add(seriesName37);

                ser37.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser37.Name = seriesName37;
                ser37.ChartType = SeriesChartType.Point;

                if (vo1koeComboBox.Text == "")
                {
                    var voOEpresente37vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente37vaz);
                    ser37.MarkerImage = "vazio";
                }

                else if (vo1koeComboBox.Text != "")
                {
                    int valor37;
                    valor37 = Convert.ToInt32(vo1koeComboBox.Text);
                    ser37.Points.AddXY(8, valor37);  // x, high
                }

                if ((aus1kvo_OECheckBox.Checked == false) && (masc1kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente37p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente37p);
                    ser37.MarkerImage = "voOEpresente";
                }

                else if ((aus1kvo_OECheckBox.Checked == true) && (masc1kvo_OECheckBox.Checked == false))
                {
                    var voOEausente37a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente37a);
                    ser37.MarkerImage = "voOEausente";
                }

                else if ((aus1kvo_OECheckBox.Checked == false) && (masc1kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente37m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente37m);
                    ser37.MarkerImage = "voOEmascPresente";
                }

                else if ((masc1kvo_OECheckBox.Checked == true) && (aus1kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente37ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voOEpresente37ma);
                    ser37.MarkerImage = "voOEmascAusente";
                }

                //***********

                string seriesName38 = "simbol1,5k voOE";
                Series ser38 = chartAudioOE.Series.Add(seriesName38);

                ser38.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser38.Name = seriesName38;
                ser38.ChartType = SeriesChartType.Point;

                if (vo1e5koeComboBox.Text == "")
                {
                    var voOEpresente38vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente38vaz);
                    ser38.MarkerImage = "vazio";
                }

                else if (vo1e5koeComboBox.Text != "")
                {
                    int valor38;
                    valor38 = Convert.ToInt32(vo1e5koeComboBox.Text);
                    ser38.Points.AddXY(9.25, valor38);  // x, high
                }

                if ((aus1_5kvo_OECheckBox.Checked == false) && (masc1_5kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente38p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente38p);
                    ser38.MarkerImage = "voOEpresente";
                }

                else if ((aus1_5kvo_OECheckBox.Checked == true) && (masc1_5kvo_OECheckBox.Checked == false))
                {
                    var voOEausente38a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente38a);
                    ser38.MarkerImage = "voOEausente";
                }

                else if ((aus1_5kvo_OECheckBox.Checked == false) && (masc1_5kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente38m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente38m);
                    ser38.MarkerImage = "voOEmascPresente";
                }

                else if ((masc1_5kvo_OECheckBox.Checked == true) && (aus1_5kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente38ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente38ma);
                    ser38.MarkerImage = "voOEmascAusente";
                }

                //************

                string seriesName39 = "simbol2k voOE";
                Series ser39 = chartAudioOE.Series.Add(seriesName39);

                ser39.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser39.Name = seriesName39;
                ser39.ChartType = SeriesChartType.Point;

                if (vo2koeComboBox.Text == "")
                {
                    var voOEpresente39vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39vaz);
                    ser39.MarkerImage = "vazio";
                }

                else if (vo2koeComboBox.Text != "")
                {
                    int valor39;
                    valor39 = Convert.ToInt32(vo2koeComboBox.Text);
                    ser39.Points.AddXY(10, valor39);  // x, high
                }

                if ((aus2kvo_OECheckBox.Checked == false) && (masc2kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente39p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39p);
                    ser39.MarkerImage = "voOEpresente";
                }

                else if ((aus2kvo_OECheckBox.Checked == true) && (masc2kvo_OECheckBox.Checked == false))
                {
                    var voOEausente39a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente39a);
                    ser39.MarkerImage = "voOEausente";
                }

                else if ((aus2kvo_OECheckBox.Checked == false) && (masc2kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente39m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39m);
                    ser39.MarkerImage = "voOEmascPresente";
                }

                else if ((masc2kvo_OECheckBox.Checked == true) && (aus2kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente39ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39ma);
                    ser39.MarkerImage = "voOEmascAusente";
                }

                //*********

                string seriesName40 = "simbol3k voOE";
                Series ser40 = chartAudioOE.Series.Add(seriesName40);

                ser40.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser40.Name = seriesName40;
                ser40.ChartType = SeriesChartType.Point;

                if (vo3koeComboBox.Text == "")
                {
                    var voOEpresente40vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40vaz);
                    ser40.MarkerImage = "vazio";
                }

                else if (vo3koeComboBox.Text != "")
                {
                    int valor40;
                    valor40 = Convert.ToInt32(vo3koeComboBox.Text);
                    ser40.Points.AddXY(11.25, valor40);  // x, high
                }

                if ((aus3kvo_OECheckBox.Checked == false) && (masc3kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente40p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40p);
                    ser40.MarkerImage = "voOEpresente";
                }

                else if ((aus3kvo_OECheckBox.Checked == true) && (masc3kvo_OECheckBox.Checked == false))
                {
                    var voOEausente40a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente40a);
                    ser40.MarkerImage = "voOEausente";
                }

                else if ((aus3kvo_OECheckBox.Checked == false) && (masc3kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente40m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40m);
                    ser40.MarkerImage = "voOEmascPresente";
                }

                else if ((masc3kvo_OECheckBox.Checked == true) && (aus3kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente40ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40ma);
                    ser40.MarkerImage = "voOEmascAusente";
                }

                //********

                string seriesName41 = "simbol4k voOE";
                Series ser41 = chartAudioOE.Series.Add(seriesName41);

                ser41.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser41.Name = seriesName41;
                ser41.ChartType = SeriesChartType.Point;

                if (vo4koeComboBox.Text == "")
                {
                    var voOEpresente41vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41vaz);
                    ser41.MarkerImage = "vazio";
                }

                else if (vo4koeComboBox.Text != "")
                {
                    int valor41;
                    valor41 = Convert.ToInt32(vo4koeComboBox.Text);
                    ser41.Points.AddXY(12, valor41);  // x, high
                }

                if ((aus4kvo_OECheckBox.Checked == false) && (masc4kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente41p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41p);
                    ser41.MarkerImage = "voOEpresente";
                }

                else if ((aus4kvo_OECheckBox.Checked == true) && (masc4kvo_OECheckBox.Checked == false))
                {
                    var voOEausente41a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente41a);
                    ser41.MarkerImage = "voOEausente";
                }

                else if ((aus4kvo_OECheckBox.Checked == false) && (masc4kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente41m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41m);
                    ser41.MarkerImage = "voOEmascPresente";
                }

                else if ((masc4kvo_OECheckBox.Checked == true) && (aus4kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente41ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41ma);
                    ser41.MarkerImage = "voOEmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OE (VO)

                try
                {
                    //*******

                    string seriesName42 = "liga 250_500 voOE";
                    Series ser42 = chartAudioOE.Series.Add(seriesName42);

                    ser42.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser42.Name = seriesName42;
                    ser42.ChartType = SeriesChartType.Line;

                    if (liga250_500vo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo250oeComboBox.Text);
                        valorB = Convert.ToInt32(vo500oeComboBox.Text);

                        ser42.Points.AddXY(4.25, valorA);
                        ser42.Points.AddXY(6.25, valorB);

                        ser42.BorderColor = Color.Transparent;
                        ser42.Color = Color.DodgerBlue;
                        ser42.BorderDashStyle = ChartDashStyle.Dash;
                        ser42.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vo_OECheckBox.Checked == false)
                    {
                        ser42.Points.Clear();
                    }

                    //*******

                    string seriesName43 = "liga 500_750 voOE";
                    Series ser43 = chartAudioOE.Series.Add(seriesName43);

                    ser43.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser43.Name = seriesName43;
                    ser43.ChartType = SeriesChartType.Line;

                    if (liga500_750vo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo500oeComboBox.Text);
                        valorB = Convert.ToInt32(vo750oeComboBox.Text);

                        ser43.Points.AddXY(6.25, valorA);
                        ser43.Points.AddXY(7.50, valorB);

                        ser43.BorderColor = Color.Transparent;
                        ser43.Color = Color.DodgerBlue;
                        ser43.BorderDashStyle = ChartDashStyle.Dash;
                        ser43.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga500_750vo_OECheckBox.Checked == false)
                    {
                        ser43.Points.Clear();
                    }

                    //******

                    string seriesName44 = "liga 750_1k voOE";
                    Series ser44 = chartAudioOE.Series.Add(seriesName44);

                    ser44.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser44.Name = seriesName44;
                    ser44.ChartType = SeriesChartType.Line;

                    if (liga750_1kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo750oeComboBox.Text);
                        valorB = Convert.ToInt32(vo1koeComboBox.Text);

                        ser44.Points.AddXY(7.50, valorA);
                        ser44.Points.AddXY(8.25, valorB);

                        ser44.BorderColor = Color.Transparent;
                        ser44.Color = Color.DodgerBlue;
                        ser44.BorderDashStyle = ChartDashStyle.Dash;
                        ser44.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvo_OECheckBox.Checked == false)
                    {
                        ser44.Points.Clear();
                    }

                    //******

                    string seriesName45 = "liga 1k_1,5K voOE";
                    Series ser45 = chartAudioOE.Series.Add(seriesName45);

                    ser45.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser45.Name = seriesName45;
                    ser45.ChartType = SeriesChartType.Line;

                    if (liga1k_1_5kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo1koeComboBox.Text);
                        valorB = Convert.ToInt32(vo1e5koeComboBox.Text);

                        ser45.Points.AddXY(8.25, valorA);
                        ser45.Points.AddXY(9.50, valorB);

                        ser45.BorderColor = Color.Transparent;
                        ser45.Color = Color.DodgerBlue;
                        ser45.BorderDashStyle = ChartDashStyle.Dash;
                        ser45.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1k_1_5kvo_OECheckBox.Checked == false)
                    {
                        ser45.Points.Clear();
                    }

                    //******

                    string seriesName46 = "liga 1,5k _ 2k voOE";
                    Series ser46 = chartAudioOE.Series.Add(seriesName46);

                    ser46.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser46.Name = seriesName46;
                    ser46.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo1e5koeComboBox.Text);
                        valorB = Convert.ToInt32(vo2koeComboBox.Text);

                        ser46.Points.AddXY(9.50, valorA);
                        ser46.Points.AddXY(10.25, valorB);

                        ser46.BorderColor = Color.Transparent;
                        ser46.Color = Color.DodgerBlue;
                        ser46.BorderDashStyle = ChartDashStyle.Dash;
                        ser46.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvo_OECheckBox.Checked == false)
                    {
                        ser46.Points.Clear();
                    }

                    //******

                    string seriesName47 = "liga 2k_3k voOE";
                    Series ser47 = chartAudioOE.Series.Add(seriesName47);

                    ser47.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser47.Name = seriesName47;
                    ser47.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo2koeComboBox.Text);
                        valorB = Convert.ToInt32(vo3koeComboBox.Text);

                        ser47.Points.AddXY(10.25, valorA);
                        ser47.Points.AddXY(11.50, valorB);

                        ser47.BorderColor = Color.Transparent;
                        ser47.Color = Color.DodgerBlue;
                        ser47.BorderDashStyle = ChartDashStyle.Dash;
                        ser47.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvo_OECheckBox.Checked == false)
                    {
                        ser47.Points.Clear();
                    }

                    //******

                    string seriesName48 = "liga 3k_4k voOE";
                    Series ser48 = chartAudioOE.Series.Add(seriesName48);

                    ser48.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser48.Name = seriesName48;
                    ser48.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo3koeComboBox.Text);
                        valorB = Convert.ToInt32(vo4koeComboBox.Text);

                        ser48.Points.AddXY(11.50, valorA);
                        ser48.Points.AddXY(12.25, valorB);

                        ser48.BorderColor = Color.Transparent;
                        ser48.Color = Color.DodgerBlue;
                        ser48.BorderDashStyle = ChartDashStyle.Dash;
                        ser48.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvo_OECheckBox.Checked == false)
                    {
                        ser48.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga250_500vo_OECheckBox.Checked = false;
                    liga500_750vo_OECheckBox.Checked = false;
                    liga750_1kvo_OECheckBox.Checked = false;
                    liga1k_1_5kvo_OECheckBox.Checked = false;
                    liga1_5k_2kvo_OECheckBox.Checked = false;
                    liga2k_3kvo_OECheckBox.Checked = false;
                    liga3k_4kvo_OECheckBox.Checked = false;
                }
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria clínica convencional")//AUDIOMETRIA COM AS FREQUÊNCIAS CONVENCIONAIS
            {
                va125oeComboBox.Enabled = false;
                va750oeComboBox.Enabled = false;
                va1e5koeComboBox.Enabled = false;

                masc125vaOECheckBox.Enabled = false;
                masc750vaOECheckBox.Enabled = false;
                masc1_5kvaOECheckBox.Enabled = false;

                aus125vaOECheckBox.Enabled = false;
                aus750vaOECheckBox.Enabled = false;

                liga125_250vaOECheckBox.Enabled = false;
                liga500_750vaOECheckBox.Enabled = false;
                liga1k_1_5kvaOECheckBox.Enabled = false;

                vo750oeComboBox.Enabled = false;
                vo1e5koeComboBox.Enabled = false;

                masc750vo_OECheckBox.Enabled = false;
                masc1_5kvo_OECheckBox.Enabled = false;

                aus750vo_OECheckBox.Enabled = false;
                aus1_5kvo_OECheckBox.Enabled = false;

                liga500_750vo_OECheckBox.Enabled = false;
                liga1k_1_5kvo_OECheckBox.Enabled = false;

                //***SIMBOLOGIA DE VA DA OE

                string seriesName13 = "simbol125";
                Series ser13 = chartAudioOE.Series.Add(seriesName13);

                ser13.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (va125oeComboBox.Text == "")
                {
                    var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }
             
                //*********

                string seriesName14 = "simbol250";
                Series ser14 = chartAudioOE.Series.Add(seriesName14);

                ser14.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (va250oeComboBox.Text == "")
                {
                    var vaOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (va250oeComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(va250oeComboBox.Text);
                    ser14.Points.AddXY(4, valor14);  // x, high
                }

                if ((aus250vaOECheckBox.Checked == false) && (masc250vaOECheckBox.Checked == false))
                {
                    var vaOEpresente14p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14p);
                    ser14.MarkerImage = "vaOEpresente";
                }

                else if ((aus250vaOECheckBox.Checked == true) && (masc250vaOECheckBox.Checked == false))
                {
                    var vaOEausente14a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente14a);
                    ser14.MarkerImage = "vaOEausente";
                }

                else if ((aus250vaOECheckBox.Checked == false) && (masc250vaOECheckBox.Checked == true))
                {
                    var vaOEpresente14m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14m);
                    ser14.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc250vaOECheckBox.Checked == true) && (aus250vaOECheckBox.Checked == true))
                {
                    var vaOEpresente14ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente14ma);
                    ser14.MarkerImage = "vaOEmascAusente";
                }

                //**********

                string seriesName15 = "simbol500";
                Series ser15 = chartAudioOE.Series.Add(seriesName15);

                ser15.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser15.Name = seriesName15;
                ser15.ChartType = SeriesChartType.Point;

                if (va500oeComboBox.Text == "")
                {
                    var vaOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15vaz);
                    ser15.MarkerImage = "vazio";
                }

                else if (va500oeComboBox.Text != "")
                {
                    int valor15;
                    valor15 = Convert.ToInt32(va500oeComboBox.Text);
                    ser15.Points.AddXY(6, valor15);  // x, high
                }

                if ((aus500vaOECheckBox.Checked == false) && (masc500vaOECheckBox.Checked == false))
                {
                    var vaOEpresente15p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15p);
                    ser15.MarkerImage = "vaOEpresente";
                }

                else if ((aus500vaOECheckBox.Checked == true) && (masc500vaOECheckBox.Checked == false))
                {
                    var vaOEausente15a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente15a);
                    ser15.MarkerImage = "vaOEausente";
                }

                else if ((aus500vaOECheckBox.Checked == false) && (masc500vaOECheckBox.Checked == true))
                {
                    var vaOEpresente15m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15m);
                    ser15.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc500vaOECheckBox.Checked == true) && (aus500vaOECheckBox.Checked == true))
                {
                    var vaOEpresente15ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente15ma);
                    ser15.MarkerImage = "vaOEmascAusente";
                }

                //********

                string seriesName16 = "simbol750";
                Series ser16 = chartAudioOE.Series.Add(seriesName16);

                ser16.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser16.Name = seriesName16;
                ser16.ChartType = SeriesChartType.Point;

                if (va750oeComboBox.Text == "")
                {
                    var vaOEpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente16vaz);
                    ser16.MarkerImage = "vazio";
                }
             
                //*********

                string seriesName17 = "simbol1k";
                Series ser17 = chartAudioOE.Series.Add(seriesName17);

                ser17.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser17.Name = seriesName17;
                ser17.ChartType = SeriesChartType.Point;

                if (va1koeComboBox.Text == "")
                {
                    var vaOEpresente17vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17vaz);
                    ser17.MarkerImage = "vazio";
                }

                else if (va1koeComboBox.Text != "")
                {
                    int valor17;
                    valor17 = Convert.ToInt32(va1koeComboBox.Text);
                    ser17.Points.AddXY(8, valor17);  // x, high
                }

                if ((aus1kvaOECheckBox.Checked == false) && (masc1kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente17p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17p);
                    ser17.MarkerImage = "vaOEpresente";
                }

                else if ((aus1kvaOECheckBox.Checked == true) && (masc1kvaOECheckBox.Checked == false))
                {
                    var vaOEausente17a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente17a);
                    ser17.MarkerImage = "vaOEausente";
                }

                else if ((aus1kvaOECheckBox.Checked == false) && (masc1kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente17m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17m);
                    ser17.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc1kvaOECheckBox.Checked == true) && (aus1kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente17ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente17ma);
                    ser17.MarkerImage = "vaOEmascAusente";
                }

                //***********

                string seriesName18 = "simbol1,5k";
                Series ser18 = chartAudioOE.Series.Add(seriesName18);

                ser18.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser18.Name = seriesName18;
                ser18.ChartType = SeriesChartType.Point;

                if (va1e5koeComboBox.Text == "")
                {
                    var vaOEpresente18vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente18vaz);
                    ser18.MarkerImage = "vazio";
                }
              
                //************

                string seriesName19 = "simbol2k";
                Series ser19 = chartAudioOE.Series.Add(seriesName19);

                ser19.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser19.Name = seriesName19;
                ser19.ChartType = SeriesChartType.Point;

                if (va2koeComboBox.Text == "")
                {
                    var vaOEpresente19vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19vaz);
                    ser19.MarkerImage = "vazio";
                }

                else if (va2koeComboBox.Text != "")
                {
                    int valor19;
                    valor19 = Convert.ToInt32(va2koeComboBox.Text);
                    ser19.Points.AddXY(10, valor19);  // x, high
                }

                if ((aus2kvaOECheckBox.Checked == false) && (masc2kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente19p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19p);
                    ser19.MarkerImage = "vaOEpresente";
                }

                else if ((aus2kvaOECheckBox.Checked == true) && (masc2kvaOECheckBox.Checked == false))
                {
                    var vaOEausente19a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente19a);
                    ser19.MarkerImage = "vaOEausente";
                }

                else if ((aus2kvaOECheckBox.Checked == false) && (masc2kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente19m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19m);
                    ser19.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc2kvaOECheckBox.Checked == true) && (aus2kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente19ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente19ma);
                    ser19.MarkerImage = "vaOEmascAusente";
                }

                //*********

                string seriesName20 = "simbol3k";
                Series ser20 = chartAudioOE.Series.Add(seriesName20);

                ser20.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser20.Name = seriesName20;
                ser20.ChartType = SeriesChartType.Point;

                if (va3koeComboBox.Text == "")
                {
                    var vaOEpresente20vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20vaz);
                    ser20.MarkerImage = "vazio";
                }

                else if (va3koeComboBox.Text != "")
                {
                    int valor20;
                    valor20 = Convert.ToInt32(va3koeComboBox.Text);
                    ser20.Points.AddXY(11.25, valor20);  // x, high
                }

                if ((aus3kvaOECheckBox.Checked == false) && (masc3kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente20p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20p);
                    ser20.MarkerImage = "vaOEpresente";
                }

                else if ((aus3kvaOECheckBox.Checked == true) && (masc3kvaOECheckBox.Checked == false))
                {
                    var vaOEausente20a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente20a);
                    ser20.MarkerImage = "vaOEausente";
                }

                else if ((aus3kvaOECheckBox.Checked == false) && (masc3kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente20m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20m);
                    ser20.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc3kvaOECheckBox.Checked == true) && (aus3kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente20ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente20ma);
                    ser20.MarkerImage = "vaOEmascAusente";
                }

                //********

                string seriesName21 = "simbol4k";
                Series ser21 = chartAudioOE.Series.Add(seriesName21);

                ser21.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser21.Name = seriesName21;
                ser21.ChartType = SeriesChartType.Point;

                if (va4koeComboBox.Text == "")
                {
                    var vaOEpresente21vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21vaz);
                    ser21.MarkerImage = "vazio";
                }

                else if (va4koeComboBox.Text != "")
                {
                    int valor21;
                    valor21 = Convert.ToInt32(va4koeComboBox.Text);
                    ser21.Points.AddXY(12, valor21);  // x, high
                }

                if ((aus4kvaOECheckBox.Checked == false) && (masc4kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente21p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21p);
                    ser21.MarkerImage = "vaOEpresente";
                }

                else if ((aus4kvaOECheckBox.Checked == true) && (masc4kvaOECheckBox.Checked == false))
                {
                    var vaOEausente21a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente21a);
                    ser21.MarkerImage = "vaOEausente";
                }

                else if ((aus4kvaOECheckBox.Checked == false) && (masc4kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente21m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21m);
                    ser21.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc4kvaOECheckBox.Checked == true) && (aus4kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente21ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente21ma);
                    ser21.MarkerImage = "vaOEmascAusente";
                }

                //**********

                string seriesName22 = "simbol6k";
                Series ser22 = chartAudioOE.Series.Add(seriesName22);

                ser22.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser22.Name = seriesName22;
                ser22.ChartType = SeriesChartType.Point;

                if (va6koeComboBox.Text == "")
                {
                    var vaOEpresente22vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22vaz);
                    ser22.MarkerImage = "vazio";
                }

                else if (va6koeComboBox.Text != "")
                {
                    int valor22;
                    valor22 = Convert.ToInt32(va6koeComboBox.Text);
                    ser22.Points.AddXY(13.25, valor22);  // x, high
                }

                if ((aus6kvaOECheckBox.Checked == false) && (masc6kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente22p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22p);
                    ser22.MarkerImage = "vaOEpresente";
                }

                else if ((aus6kvaOECheckBox.Checked == true) && (masc6kvaOECheckBox.Checked == false))
                {
                    var vaOEausente22a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente22a);
                    ser22.MarkerImage = "vaOEausente";
                }

                else if ((aus6kvaOECheckBox.Checked == false) && (masc6kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente22m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22m);
                    ser22.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc6kvaOECheckBox.Checked == true) && (aus6kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente22ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente22ma);
                    ser22.MarkerImage = "vaOEmascAusente";
                }

                //***********

                string seriesName23 = "simbol8k";
                Series ser23 = chartAudioOE.Series.Add(seriesName23);

                ser23.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser23.Name = seriesName23;
                ser23.ChartType = SeriesChartType.Point;

                if (va8koeComboBox.Text == "")
                {
                    var vaOEpresente23vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23vaz);
                    ser23.MarkerImage = "vazio";
                }

                else if (va8koeComboBox.Text != "")
                {
                    int valor23;
                    valor23 = Convert.ToInt32(va8koeComboBox.Text);
                    ser23.Points.AddXY(14, valor23);  // x, high
                }

                if ((aus8kvaOECheckBox.Checked == false) && (masc8kvaOECheckBox.Checked == false))
                {
                    var vaOEpresente23p = new NamedImage("vaOEpresente", Properties.Resources.vaOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23p);
                    ser23.MarkerImage = "vaOEpresente";
                }

                else if ((aus8kvaOECheckBox.Checked == true) && (masc8kvaOECheckBox.Checked == false))
                {
                    var vaOEausente23a = new NamedImage("vaOEausente", Properties.Resources.vaOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEausente23a);
                    ser23.MarkerImage = "vaOEausente";
                }

                else if ((aus8kvaOECheckBox.Checked == false) && (masc8kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente23m = new NamedImage("vaOEmascPresente", Properties.Resources.vaOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23m);
                    ser23.MarkerImage = "vaOEmascPresente";
                }

                else if ((masc8kvaOECheckBox.Checked == true) && (aus8kvaOECheckBox.Checked == true))
                {
                    var vaOEpresente23ma = new NamedImage("vaOEmascAusente", Properties.Resources.vaOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(vaOEpresente23ma);
                    ser23.MarkerImage = "vaOEmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OE

                try
                {                  
                    //*******

                    string seriesName25 = "liga 250_500 vaOE";
                    Series ser25 = chartAudioOE.Series.Add(seriesName25);

                    ser25.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser25.Name = seriesName25;
                    ser25.ChartType = SeriesChartType.Line;

                    if (liga250_500vaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va250oeComboBox.Text);
                        valorB = Convert.ToInt32(va500oeComboBox.Text);

                        ser25.Points.AddXY(4, valorA);
                        ser25.Points.AddXY(6, valorB);

                        ser25.BorderColor = Color.Transparent;
                        ser25.Color = Color.DodgerBlue;
                        ser25.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vaOECheckBox.Checked == false)
                    {
                        ser25.Points.Clear();
                    }

                    //******

                    string seriesName27 = "liga 500_1k OE";
                    Series ser27 = chartAudioOE.Series.Add(seriesName27);

                    ser27.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser27.Name = seriesName27;
                    ser27.ChartType = SeriesChartType.Line;

                    if (liga750_1kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va500oeComboBox.Text);
                        valorB = Convert.ToInt32(va1koeComboBox.Text);

                        ser27.Points.AddXY(6, valorA);
                        ser27.Points.AddXY(8, valorB);

                        ser27.BorderColor = Color.Transparent;
                        ser27.Color = Color.DodgerBlue;
                        ser27.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvaOECheckBox.Checked == false)
                    {
                        ser27.Points.Clear();
                    }

                    //******

                    string seriesName29 = "liga 1k _ 2k vaOE";
                    Series ser29 = chartAudioOE.Series.Add(seriesName29);

                    ser29.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser29.Name = seriesName29;
                    ser29.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va1koeComboBox.Text);
                        valorB = Convert.ToInt32(va2koeComboBox.Text);

                        ser29.Points.AddXY(8, valorA);
                        ser29.Points.AddXY(10, valorB);

                        ser29.BorderColor = Color.Transparent;
                        ser29.Color = Color.DodgerBlue;
                        ser29.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvaOECheckBox.Checked == false)
                    {
                        ser29.Points.Clear();
                    }

                    //******

                    string seriesName30 = "liga 2k_3k vaOE";
                    Series ser30 = chartAudioOE.Series.Add(seriesName30);

                    ser30.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser30.Name = seriesName30;
                    ser30.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va2koeComboBox.Text);
                        valorB = Convert.ToInt32(va3koeComboBox.Text);

                        ser30.Points.AddXY(10, valorA);
                        ser30.Points.AddXY(11.25, valorB);

                        ser30.BorderColor = Color.Transparent;
                        ser30.Color = Color.DodgerBlue;
                        ser30.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvaOECheckBox.Checked == false)
                    {
                        ser30.Points.Clear();
                    }

                    //******

                    string seriesName31 = "liga 3k_4k vaOE";
                    Series ser31 = chartAudioOE.Series.Add(seriesName31);

                    ser31.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser31.Name = seriesName31;
                    ser31.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va3koeComboBox.Text);
                        valorB = Convert.ToInt32(va4koeComboBox.Text);

                        ser31.Points.AddXY(11.25, valorA);
                        ser31.Points.AddXY(12, valorB);

                        ser31.BorderColor = Color.Transparent;
                        ser31.Color = Color.DodgerBlue;
                        ser31.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvaOECheckBox.Checked == false)
                    {
                        ser31.Points.Clear();
                    }

                    //******

                    string seriesName32 = "liga 4k_6k vaOE";
                    Series ser32 = chartAudioOE.Series.Add(seriesName32);

                    ser32.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser32.Name = seriesName32;
                    ser32.ChartType = SeriesChartType.Line;

                    if (liga4k_6kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va4koeComboBox.Text);
                        valorB = Convert.ToInt32(va6koeComboBox.Text);

                        ser32.Points.AddXY(12, valorA);
                        ser32.Points.AddXY(13.25, valorB);

                        ser32.BorderColor = Color.Transparent;
                        ser32.Color = Color.DodgerBlue;
                        ser32.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga4k_6kvaODCheckBox.Checked == false)
                    {
                        ser32.Points.Clear();
                    }

                    //******

                    string seriesName33 = "liga 6k-8k vaOE";
                    Series ser33 = chartAudioOE.Series.Add(seriesName33);

                    ser33.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser33.Name = seriesName33;
                    ser33.ChartType = SeriesChartType.Line;

                    if (liga6k_8kvaOECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(va6koeComboBox.Text);
                        valorB = Convert.ToInt32(va8koeComboBox.Text);

                        ser33.Points.AddXY(13.25, valorA);
                        ser33.Points.AddXY(14, valorB);

                        ser33.BorderColor = Color.Transparent;
                        ser33.Color = Color.DodgerBlue;
                        ser33.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga6k_8kvaOECheckBox.Checked == false)
                    {
                        ser33.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga125_250vaOECheckBox.Checked = false;
                    liga250_500vaOECheckBox.Checked = false;
                    liga500_750vaOECheckBox.Checked = false;
                    liga750_1kvaOECheckBox.Checked = false;
                    liga1k_1_5kvaOECheckBox.Checked = false;
                    liga1_5k_2kvaOECheckBox.Checked = false;
                    liga2k_3kvaOECheckBox.Checked = false;
                    liga3k_4kvaOECheckBox.Checked = false;
                    liga4k_6kvaOECheckBox.Checked = false;
                    liga6k_8kvaOECheckBox.Checked = false;
                }

                //*********
                //********** SIMBOLOGIA DE VO OE


                string seriesName34 = "simbol 250 voOE";
                Series ser34 = chartAudioOE.Series.Add(seriesName34);

                ser34.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser34.Name = seriesName34;
                ser34.ChartType = SeriesChartType.Point;

                if (vo250oeComboBox.Text == "")
                {
                    var voOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente14vaz);
                    ser34.MarkerImage = "vazio";
                }

                else if (vo250oeComboBox.Text != "")
                {
                    int valor34;
                    valor34 = Convert.ToInt32(vo250oeComboBox.Text);
                    ser34.Points.AddXY(4, valor34);  // x, high
                }

                if ((aus250vo_OECheckBox.Checked == false) && (masc250vo_OECheckBox.Checked == false))
                {
                    var voOEpresente34p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente34p);
                    ser34.MarkerImage = "voOEpresente";
                }

                else if ((aus250vo_OECheckBox.Checked == true) && (masc250vo_OECheckBox.Checked == false))
                {
                    var voOEausente34a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente34a);
                    ser34.MarkerImage = "voOEausente";
                }

                else if ((aus250vo_OECheckBox.Checked == false) && (masc250vo_OECheckBox.Checked == true))
                {
                    var voOEpresente34m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente34m);
                    ser34.MarkerImage = "voOEmascPresente";
                }

                else if ((masc250vo_OECheckBox.Checked == true) && (aus250vo_OECheckBox.Checked == true))
                {
                    var voOEpresente34ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente34ma);
                    ser34.MarkerImage = "voOEmascAusente";
                }

                //**********

                string seriesName35 = "simbol500 voOE";
                Series ser35 = chartAudioOE.Series.Add(seriesName35);

                ser35.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser35.Name = seriesName35;
                ser35.ChartType = SeriesChartType.Point;

                if (vo500oeComboBox.Text == "")
                {
                    var voOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15vaz);
                    ser35.MarkerImage = "vazio";
                }

                else if (vo500oeComboBox.Text != "")
                {
                    int valor35;
                    valor35 = Convert.ToInt32(vo500oeComboBox.Text);
                    ser35.Points.AddXY(6, valor35);  // x, high
                }

                if ((aus500vo_OECheckBox.Checked == false) && (masc500vo_OECheckBox.Checked == false))
                {
                    var voOEpresente15p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15p);
                    ser35.MarkerImage = "voOEpresente";
                }

                else if ((aus500vo_OECheckBox.Checked == true) && (masc500vo_OECheckBox.Checked == false))
                {
                    var voOEausente15a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente15a);
                    ser35.MarkerImage = "voOEausente";
                }

                else if ((aus500vo_OECheckBox.Checked == false) && (masc500vo_OECheckBox.Checked == true))
                {
                    var voOEpresente15m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15m);
                    ser35.MarkerImage = "voOEmascPresente";
                }

                else if ((masc500vo_OECheckBox.Checked == true) && (aus500vo_OECheckBox.Checked == true))
                {
                    var voOEpresente15ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente15ma);
                    ser35.MarkerImage = "voOEmascAusente";
                }

                //********

                string seriesName36 = "simbol750 voOE";
                Series ser36 = chartAudioOE.Series.Add(seriesName36);

                ser36.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser36.Name = seriesName36;
                ser36.ChartType = SeriesChartType.Point;

                if (vo750oeComboBox.Text == "")
                {
                    var voOEpresente36vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente36vaz);
                    ser36.MarkerImage = "vazio";
                }

                //*********

                string seriesName37 = "simbol1k voOE";
                Series ser37 = chartAudioOE.Series.Add(seriesName37);

                ser37.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser37.Name = seriesName37;
                ser37.ChartType = SeriesChartType.Point;

                if (vo1koeComboBox.Text == "")
                {
                    var voOEpresente37vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente37vaz);
                    ser37.MarkerImage = "vazio";
                }

                else if (vo1koeComboBox.Text != "")
                {
                    int valor37;
                    valor37 = Convert.ToInt32(vo1koeComboBox.Text);
                    ser37.Points.AddXY(8, valor37);  // x, high
                }

                if ((aus1kvo_OECheckBox.Checked == false) && (masc1kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente37p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente37p);
                    ser37.MarkerImage = "voOEpresente";
                }

                else if ((aus1kvo_OECheckBox.Checked == true) && (masc1kvo_OECheckBox.Checked == false))
                {
                    var voOEausente37a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente37a);
                    ser37.MarkerImage = "voOEausente";
                }

                else if ((aus1kvo_OECheckBox.Checked == false) && (masc1kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente37m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente37m);
                    ser37.MarkerImage = "voOEmascPresente";
                }

                else if ((masc1kvo_OECheckBox.Checked == true) && (aus1kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente37ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOD.Images.Clear();
                    chartAudioOD.Images.Add(voOEpresente37ma);
                    ser37.MarkerImage = "voOEmascAusente";
                }

                //***********

                string seriesName38 = "simbol1,5k voOE";
                Series ser38 = chartAudioOE.Series.Add(seriesName38);

                ser38.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser38.Name = seriesName38;
                ser38.ChartType = SeriesChartType.Point;

                if (vo1e5koeComboBox.Text == "")
                {
                    var voOEpresente38vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente38vaz);
                    ser38.MarkerImage = "vazio";
                }

                //************

                string seriesName39 = "simbol2k voOE";
                Series ser39 = chartAudioOE.Series.Add(seriesName39);

                ser39.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser39.Name = seriesName39;
                ser39.ChartType = SeriesChartType.Point;

                if (vo2koeComboBox.Text == "")
                {
                    var voOEpresente39vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39vaz);
                    ser39.MarkerImage = "vazio";
                }

                else if (vo2koeComboBox.Text != "")
                {
                    int valor39;
                    valor39 = Convert.ToInt32(vo2koeComboBox.Text);
                    ser39.Points.AddXY(10, valor39);  // x, high
                }

                if ((aus2kvo_OECheckBox.Checked == false) && (masc2kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente39p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39p);
                    ser39.MarkerImage = "voOEpresente";
                }

                else if ((aus2kvo_OECheckBox.Checked == true) && (masc2kvo_OECheckBox.Checked == false))
                {
                    var voOEausente39a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente39a);
                    ser39.MarkerImage = "voOEausente";
                }

                else if ((aus2kvo_OECheckBox.Checked == false) && (masc2kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente39m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39m);
                    ser39.MarkerImage = "voOEmascPresente";
                }

                else if ((masc2kvo_OECheckBox.Checked == true) && (aus2kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente39ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente39ma);
                    ser39.MarkerImage = "voOEmascAusente";
                }

                //*********

                string seriesName40 = "simbol3k voOE";
                Series ser40 = chartAudioOE.Series.Add(seriesName40);

                ser40.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser40.Name = seriesName40;
                ser40.ChartType = SeriesChartType.Point;

                if (vo3koeComboBox.Text == "")
                {
                    var voOEpresente40vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40vaz);
                    ser40.MarkerImage = "vazio";
                }

                else if (vo3koeComboBox.Text != "")
                {
                    int valor40;
                    valor40 = Convert.ToInt32(vo3koeComboBox.Text);
                    ser40.Points.AddXY(11.25, valor40);  // x, high
                }

                if ((aus3kvo_OECheckBox.Checked == false) && (masc3kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente40p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40p);
                    ser40.MarkerImage = "voOEpresente";
                }

                else if ((aus3kvo_OECheckBox.Checked == true) && (masc3kvo_OECheckBox.Checked == false))
                {
                    var voOEausente40a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente40a);
                    ser40.MarkerImage = "voOEausente";
                }

                else if ((aus3kvo_OECheckBox.Checked == false) && (masc3kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente40m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40m);
                    ser40.MarkerImage = "voOEmascPresente";
                }

                else if ((masc3kvo_OECheckBox.Checked == true) && (aus3kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente40ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente40ma);
                    ser40.MarkerImage = "voOEmascAusente";
                }

                //********

                string seriesName41 = "simbol4k voOE";
                Series ser41 = chartAudioOE.Series.Add(seriesName41);

                ser41.ChartArea = chartAudioOE.ChartAreas[0].Name;
                ser41.Name = seriesName41;
                ser41.ChartType = SeriesChartType.Point;

                if (vo4koeComboBox.Text == "")
                {
                    var voOEpresente41vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41vaz);
                    ser41.MarkerImage = "vazio";
                }

                else if (vo4koeComboBox.Text != "")
                {
                    int valor41;
                    valor41 = Convert.ToInt32(vo4koeComboBox.Text);
                    ser41.Points.AddXY(12, valor41);  // x, high
                }

                if ((aus4kvo_OECheckBox.Checked == false) && (masc4kvo_OECheckBox.Checked == false))
                {
                    var voOEpresente41p = new NamedImage("voOEpresente", Properties.Resources.voOEpresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41p);
                    ser41.MarkerImage = "voOEpresente";
                }

                else if ((aus4kvo_OECheckBox.Checked == true) && (masc4kvo_OECheckBox.Checked == false))
                {
                    var voOEausente41a = new NamedImage("voOEausente", Properties.Resources.voOEausente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEausente41a);
                    ser41.MarkerImage = "voOEausente";
                }

                else if ((aus4kvo_OECheckBox.Checked == false) && (masc4kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente41m = new NamedImage("voOEmascPresente", Properties.Resources.voOEmascPresente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41m);
                    ser41.MarkerImage = "voOEmascPresente";
                }

                else if ((masc4kvo_OECheckBox.Checked == true) && (aus4kvo_OECheckBox.Checked == true))
                {
                    var voOEpresente41ma = new NamedImage("voOEmascAusente", Properties.Resources.voOEmascAusente);
                    chartAudioOE.Images.Clear();
                    chartAudioOE.Images.Add(voOEpresente41ma);
                    ser41.MarkerImage = "voOEmascAusente";
                }

                //********LIGAR A SIMBOLOGIA DA OE (VO)

                try
                {
                    //*******

                    string seriesName42 = "liga 250_500 voOE";
                    Series ser42 = chartAudioOE.Series.Add(seriesName42);

                    ser42.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser42.Name = seriesName42;
                    ser42.ChartType = SeriesChartType.Line;

                    if (liga250_500vo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo250oeComboBox.Text);
                        valorB = Convert.ToInt32(vo500oeComboBox.Text);

                        ser42.Points.AddXY(4.25, valorA);
                        ser42.Points.AddXY(6.25, valorB);

                        ser42.BorderColor = Color.Transparent;
                        ser42.Color = Color.DodgerBlue;
                        ser42.BorderDashStyle = ChartDashStyle.Dash;
                        ser42.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga250_500vo_OECheckBox.Checked == false)
                    {
                        ser42.Points.Clear();
                    }
                   
                    //******

                    string seriesName44 = "liga 500_1k voOE";
                    Series ser44 = chartAudioOE.Series.Add(seriesName44);

                    ser44.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser44.Name = seriesName44;
                    ser44.ChartType = SeriesChartType.Line;

                    if (liga750_1kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo500oeComboBox.Text);
                        valorB = Convert.ToInt32(vo1koeComboBox.Text);

                        ser44.Points.AddXY(6.25, valorA);
                        ser44.Points.AddXY(8.25, valorB);

                        ser44.BorderColor = Color.Transparent;
                        ser44.Color = Color.DodgerBlue;
                        ser44.BorderDashStyle = ChartDashStyle.Dash;
                        ser44.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga750_1kvo_OECheckBox.Checked == false)
                    {
                        ser44.Points.Clear();
                    }

                    //******

                    string seriesName46 = "liga 1k _ 2k voOE";
                    Series ser46 = chartAudioOE.Series.Add(seriesName46);

                    ser46.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser46.Name = seriesName46;
                    ser46.ChartType = SeriesChartType.Line;

                    if (liga1_5k_2kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo1koeComboBox.Text);
                        valorB = Convert.ToInt32(vo2koeComboBox.Text);

                        ser46.Points.AddXY(8.25, valorA);
                        ser46.Points.AddXY(10.25, valorB);

                        ser46.BorderColor = Color.Transparent;
                        ser46.Color = Color.DodgerBlue;
                        ser46.BorderDashStyle = ChartDashStyle.Dash;
                        ser46.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga1_5k_2kvo_OECheckBox.Checked == false)
                    {
                        ser46.Points.Clear();
                    }

                    //******

                    string seriesName47 = "liga 2k_3k voOE";
                    Series ser47 = chartAudioOE.Series.Add(seriesName47);

                    ser47.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser47.Name = seriesName47;
                    ser47.ChartType = SeriesChartType.Line;

                    if (liga2k_3kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo2koeComboBox.Text);
                        valorB = Convert.ToInt32(vo3koeComboBox.Text);

                        ser47.Points.AddXY(10.25, valorA);
                        ser47.Points.AddXY(11.50, valorB);

                        ser47.BorderColor = Color.Transparent;
                        ser47.Color = Color.DodgerBlue;
                        ser47.BorderDashStyle = ChartDashStyle.Dash;
                        ser47.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga2k_3kvo_OECheckBox.Checked == false)
                    {
                        ser47.Points.Clear();
                    }

                    //******

                    string seriesName48 = "liga 3k_4k voOE";
                    Series ser48 = chartAudioOE.Series.Add(seriesName48);

                    ser48.ChartArea = chartAudioOE.ChartAreas[0].Name;
                    ser48.Name = seriesName48;
                    ser48.ChartType = SeriesChartType.Line;

                    if (liga3k_4kvo_OECheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(vo3koeComboBox.Text);
                        valorB = Convert.ToInt32(vo4koeComboBox.Text);

                        ser48.Points.AddXY(11.50, valorA);
                        ser48.Points.AddXY(12.25, valorB);

                        ser48.BorderColor = Color.Transparent;
                        ser48.Color = Color.DodgerBlue;
                        ser48.BorderDashStyle = ChartDashStyle.Dash;
                        ser48.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (liga3k_4kvo_OECheckBox.Checked == false)
                    {
                        ser48.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    liga250_500vo_OECheckBox.Checked = false;
                    liga500_750vo_OECheckBox.Checked = false;
                    liga750_1kvo_OECheckBox.Checked = false;
                    liga1k_1_5kvo_OECheckBox.Checked = false;
                    liga1_5k_2kvo_OECheckBox.Checked = false;
                    liga2k_3kvo_OECheckBox.Checked = false;
                    liga3k_4kvo_OECheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Escolha entre 'Audiometria Clínica Convencional' ou 'Audiomeria Clínica Todas as Frequências'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlotarCampoConv_Click(object sender, EventArgs e)
        {
            chartCampoConven.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartCampoConven.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartCampoConven.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string fundoChart = "fundoChartTransp";
            Series imgFundo = chartCampoConven.Series.Add(fundoChart);

            imgFundo.ChartArea = chartCampoConven.ChartAreas[0].Name;
            imgFundo.Name = fundoChart;
            imgFundo.ChartType = SeriesChartType.Point;

            if (rbExibeBananaAudioCampoConvenc.Checked == true)
            {
                var fundoAudioCampoConvenc = new NamedImage("bananaVerde", Properties.Resources.bananaVerde);
                chartCampoConven.Images.Clear();
                chartCampoConven.Images.Add(fundoAudioCampoConvenc);
                imgFundo.MarkerImage = "bananaVerde";
                imgFundo.Points.AddXY(7.50, 45);
            }
            else if (rbEscondeBananaFalaAudioCampoConvenc.Checked == true)
            {   
                chartCampoConven.Series[fundoChart].Points.Clear();
            }            

            string seriesName1 = "grade1campConv";
            Series ser1 = chartCampoConven.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2campConv";
            Series ser2 = chartCampoConven.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3campConv";
            Series ser3 = chartCampoConven.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4campConv";
            Series ser4 = chartCampoConven.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5campConv";
            Series ser5 = chartCampoConven.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6campConv";
            Series ser6 = chartCampoConven.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7campConv";
            Series ser7 = chartCampoConven.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8campConv";
            Series ser7a = chartCampoConven.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9campConv";
            Series ser9a = chartCampoConven.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10campConv";
            Series ser10a = chartCampoConven.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11campConv";
            Series ser11a = chartCampoConven.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12campConv";
            Series ser12a = chartCampoConven.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);

            //*******SIMBOLOGIA*******
            //**** ORELHA DIREITA *******

            if (string.IsNullOrEmpty(tipoAudiometriaComboBox.Text))
            {
                MessageBox.Show("Escolha 'Audiometria em campo livre convencional'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoAudiometriaComboBox.Text == "Audiometria em campo livre convencional")
            {
                string seriesName13 = "simbol_500campo";
                Series ser13 = chartCampoConven.Series.Add(seriesName13);

                ser13.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser13.Name = seriesName13;
                ser13.ChartType = SeriesChartType.Point;

                if (campo500odComboBox.Text == "")
                {
                    var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente13vaz);
                    ser13.MarkerImage = "vazio";
                }

                else if (campo500odComboBox.Text != "")
                {
                    int valor13;
                    valor13 = Convert.ToInt32(campo500odComboBox.Text);
                    ser13.Points.AddXY(6, valor13);  // x, high
                }


                if (campoVAodAus500CheckBox.Checked == true)
                {
                    var com500a = new NamedImage("campoLivreODausente", Properties.Resources.campoLivreODausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com500a);
                    ser13.MarkerImage = "campoLivreODausente";
                }

                else if (campoVAodAus500CheckBox.Checked == false)
                {
                    var com500p = new NamedImage("campoLivreODpresente", Properties.Resources.campoLivreODpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com500p);
                    ser13.MarkerImage = "campoLivreODpresente";
                }

                //*****

                string seriesName14 = "simbol_1kcampo";
                Series ser14 = chartCampoConven.Series.Add(seriesName14);

                ser14.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser14.Name = seriesName14;
                ser14.ChartType = SeriesChartType.Point;

                if (campo1kodComboBox.Text == "")
                {
                    var vaOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente14vaz);
                    ser14.MarkerImage = "vazio";
                }

                else if (campo1kodComboBox.Text != "")
                {
                    int valor14;
                    valor14 = Convert.ToInt32(campo1kodComboBox.Text);
                    ser14.Points.AddXY(8, valor14);  // x, high
                }


                if (campoVAodAus1kCheckBox.Checked == true)
                {
                    var com1ka = new NamedImage("campoLivreODausente", Properties.Resources.campoLivreODausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com1ka);
                    ser14.MarkerImage = "campoLivreODausente";
                }

                else if (campoVAodAus1kCheckBox.Checked == false)
                {
                    var com1kp = new NamedImage("campoLivreODpresente", Properties.Resources.campoLivreODpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com1kp);
                    ser14.MarkerImage = "campoLivreODpresente";
                }

                //*****

                string seriesName15 = "simbol_2kcampo";
                Series ser15 = chartCampoConven.Series.Add(seriesName15);

                ser15.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser15.Name = seriesName15;
                ser15.ChartType = SeriesChartType.Point;

                if (campo2kodComboBox.Text == "")
                {
                    var vaOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente15vaz);
                    ser15.MarkerImage = "vazio";
                }

                else if (campo2kodComboBox.Text != "")
                {
                    int valor15;
                    valor15 = Convert.ToInt32(campo2kodComboBox.Text);
                    ser15.Points.AddXY(10, valor15);  // x, high
                }


                if (campoVAodAus2kCheckBox.Checked == true)
                {
                    var com2ka = new NamedImage("campoLivreODausente", Properties.Resources.campoLivreODausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com2ka);
                    ser15.MarkerImage = "campoLivreODausente";
                }

                else if (campoVAodAus2kCheckBox.Checked == false)
                {
                    var com2kp = new NamedImage("campoLivreODpresente", Properties.Resources.campoLivreODpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com2kp);
                    ser15.MarkerImage = "campoLivreODpresente";
                }


                //*****

                string seriesName16 = "simbol_3kcampo";
                Series ser16 = chartCampoConven.Series.Add(seriesName16);

                ser16.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser16.Name = seriesName16;
                ser16.ChartType = SeriesChartType.Point;

                if (campo3kodComboBox.Text == "")
                {
                    var vaOEpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente16vaz);
                    ser16.MarkerImage = "vazio";
                }

                else if (campo3kodComboBox.Text != "")
                {
                    int valor16;
                    valor16 = Convert.ToInt32(campo3kodComboBox.Text);
                    ser16.Points.AddXY(11.25, valor16);  // x, high
                }


                if (campoVAodAus3kCheckBox.Checked == true)
                {
                    var com3ka = new NamedImage("campoLivreODausente", Properties.Resources.campoLivreODausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com3ka);
                    ser16.MarkerImage = "campoLivreODausente";
                }

                else if (campoVAodAus3kCheckBox.Checked == false)
                {
                    var com3kp = new NamedImage("campoLivreODpresente", Properties.Resources.campoLivreODpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com3kp);
                    ser16.MarkerImage = "campoLivreODpresente";
                }

                //******

                string seriesName17 = "simbol_4kcampo";
                Series ser17 = chartCampoConven.Series.Add(seriesName17);

                ser17.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser17.Name = seriesName17;
                ser17.ChartType = SeriesChartType.Point;

                if (campo4kodComboBox.Text == "")
                {
                    var vaOEpresente17vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente17vaz);
                    ser17.MarkerImage = "vazio";
                }

                else if (campo4kodComboBox.Text != "")
                {
                    int valor17;
                    valor17 = Convert.ToInt32(campo4kodComboBox.Text);
                    ser17.Points.AddXY(12, valor17);  // x, high
                }


                if (campoVAodAus4kCheckBox.Checked == true)
                {
                    var com4ka = new NamedImage("campoLivreODausente", Properties.Resources.campoLivreODausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com4ka);
                    ser17.MarkerImage = "campoLivreODausente";
                }

                else if (campoVAodAus4kCheckBox.Checked == false)
                {
                    var com4kp = new NamedImage("campoLivreODpresente", Properties.Resources.campoLivreODpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com4kp);
                    ser17.MarkerImage = "campoLivreODpresente";
                }

                //**** ORELHA ESQUERDA *******

                string seriesName18 = "simbol_500campoOE";
                Series ser18 = chartCampoConven.Series.Add(seriesName18);

                ser18.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser18.Name = seriesName18;
                ser18.ChartType = SeriesChartType.Point;

                if (campo500oeComboBox.Text == "")
                {
                    var vaOEpresente18vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente18vaz);
                    ser18.MarkerImage = "vazio";
                }

                else if (campo500oeComboBox.Text != "")
                {
                    int valor18;
                    valor18 = Convert.ToInt32(campo500oeComboBox.Text);
                    ser18.Points.AddXY(6, valor18);  // x, high
                }


                if (campoVAoeAus500CheckBox.Checked == true)
                {
                    var com500acampo = new NamedImage("campoLivreOEausente", Properties.Resources.campoLivreOEausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com500acampo);
                    ser18.MarkerImage = "campoLivreOEausente";
                }

                else if (campoVAoeAus500CheckBox.Checked == false)
                {
                    var com500pcampo = new NamedImage("campoLivreOEpresente", Properties.Resources.campoLivreOEpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com500pcampo);
                    ser18.MarkerImage = "campoLivreOEpresente";
                }

                //*****

                string seriesName19 = "simbol_1kcampoOE";
                Series ser19 = chartCampoConven.Series.Add(seriesName19);

                ser19.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser19.Name = seriesName19;
                ser19.ChartType = SeriesChartType.Point;

                if (campo1koeComboBox.Text == "")
                {
                    var vaOEpresente14vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente14vaz);
                    ser19.MarkerImage = "vazio";
                }

                else if (campo1koeComboBox.Text != "")
                {
                    int valor19;
                    valor19 = Convert.ToInt32(campo1koeComboBox.Text);
                    ser19.Points.AddXY(8, valor19);  // x, high
                }


                if (campoVAoeAus1kCheckBox.Checked == true)
                {
                    var com1kacampo = new NamedImage("campoLivreOEausente", Properties.Resources.campoLivreOEausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com1kacampo);
                    ser19.MarkerImage = "campoLivreOEausente";
                }

                else if (campoVAoeAus1kCheckBox.Checked == false)
                {
                    var com1kpcampo = new NamedImage("campoLivreOEpresente", Properties.Resources.campoLivreOEpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com1kpcampo);
                    ser19.MarkerImage = "campoLivreOEpresente";
                }

                //*****

                string seriesName20 = "simbol_2kcampoOE";
                Series ser20 = chartCampoConven.Series.Add(seriesName20);

                ser20.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser20.Name = seriesName20;
                ser20.ChartType = SeriesChartType.Point;

                if (campo2koeComboBox.Text == "")
                {
                    var vaOEpresente15vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente15vaz);
                    ser20.MarkerImage = "vazio";
                }

                else if (campo2koeComboBox.Text != "")
                {
                    int valor20;
                    valor20 = Convert.ToInt32(campo2koeComboBox.Text);
                    ser20.Points.AddXY(10, valor20);  // x, high
                }


                if (campoVAoeAus2kCheckBox.Checked == true)
                {
                    var com2kacampo = new NamedImage("campoLivreOEausente", Properties.Resources.campoLivreOEausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com2kacampo);
                    ser20.MarkerImage = "campoLivreOEausente";
                }

                else if (campoVAoeAus2kCheckBox.Checked == false)
                {
                    var com2kpcampo = new NamedImage("campoLivreOEpresente", Properties.Resources.campoLivreOEpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com2kpcampo);
                    ser20.MarkerImage = "campoLivreOEpresente";
                }


                //*****

                string seriesName21 = "simbol_3kcampoOE";
                Series ser21 = chartCampoConven.Series.Add(seriesName21);

                ser21.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser21.Name = seriesName21;
                ser21.ChartType = SeriesChartType.Point;

                if (campo3koeComboBox.Text == "")
                {
                    var vaOEpresente16vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente16vaz);
                    ser21.MarkerImage = "vazio";
                }

                else if (campo3koeComboBox.Text != "")
                {
                    int valor21;
                    valor21 = Convert.ToInt32(campo3koeComboBox.Text);
                    ser21.Points.AddXY(11.25, valor21);  // x, high
                }


                if (campoVAoeAus3kCheckBox.Checked == true)
                {
                    var com3kacampo = new NamedImage("campoLivreOEausente", Properties.Resources.campoLivreOEausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com3kacampo);
                    ser21.MarkerImage = "campoLivreOEausente";
                }

                else if (campoVAoeAus3kCheckBox.Checked == false)
                {
                    var com3kpcampo = new NamedImage("campoLivreOEpresente", Properties.Resources.campoLivreOEpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com3kpcampo);
                    ser21.MarkerImage = "campoLivreOEpresente";
                }

                //******

                string seriesName22 = "simbol_4kcampoOE";
                Series ser22 = chartCampoConven.Series.Add(seriesName22);

                ser22.ChartArea = chartCampoConven.ChartAreas[0].Name;
                ser22.Name = seriesName22;
                ser22.ChartType = SeriesChartType.Point;

                if (campo4koeComboBox.Text == "")
                {
                    var vaOEpresente22vaz = new NamedImage("vazio", Properties.Resources.vazio);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(vaOEpresente22vaz);
                    ser22.MarkerImage = "vazio";
                }

                else if (campo4koeComboBox.Text != "")
                {
                    int valor22;
                    valor22 = Convert.ToInt32(campo4koeComboBox.Text);
                    ser22.Points.AddXY(12, valor22);  // x, high
                }


                if (campoVAoeAus4kCheckBox.Checked == true)
                {
                    var com4kacampo = new NamedImage("campoLivreOEausente", Properties.Resources.campoLivreOEausente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com4kacampo);
                    ser22.MarkerImage = "campoLivreOEausente";
                }

                else if (campoVAoeAus4kCheckBox.Checked == false)
                {
                    var com4kpcampo = new NamedImage("campoLivreOEpresente", Properties.Resources.campoLivreOEpresente);
                    chartCampoConven.Images.Clear();
                    chartCampoConven.Images.Add(com4kpcampo);
                    ser22.MarkerImage = "campoLivreOEpresente";
                }

                //***SEQUÊNCIA PARA LIGAR SIMBOLOGIA CAMPO OD

                try
                {

                    string seriesName23 = "liga 500_1kCAMPOOD";
                    Series ser23 = chartCampoConven.Series.Add(seriesName23);

                    ser23.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser23.Name = seriesName23;
                    ser23.ChartType = SeriesChartType.Line;

                    if (campoLiga500_1kodCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo500odComboBox.Text);
                        valorB = Convert.ToInt32(campo1kodComboBox.Text);

                        ser23.Points.AddXY(6, valorA);
                        ser23.Points.AddXY(8, valorB);

                        ser23.BorderColor = Color.Transparent;
                        ser23.Color = Color.Red;
                        ser23.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga500_1kodCheckBox.Checked == false)
                    {
                        ser23.Points.Clear();
                    }

                    //*******

                    string seriesName24 = "liga 1k_2kCAMPOOD";
                    Series ser24 = chartCampoConven.Series.Add(seriesName24);

                    ser24.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser24.Name = seriesName24;
                    ser24.ChartType = SeriesChartType.Line;

                    if (campoLiga1k_2kodCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo1kodComboBox.Text);
                        valorB = Convert.ToInt32(campo2kodComboBox.Text);

                        ser24.Points.AddXY(8, valorA);
                        ser24.Points.AddXY(10, valorB);

                        ser24.BorderColor = Color.Transparent;
                        ser24.Color = Color.Red;
                        ser24.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga1k_2kodCheckBox.Checked == false)
                    {
                        ser24.Points.Clear();
                    }

                    //*******

                    string seriesName25 = "liga 2k_3kCAMPOOD";
                    Series ser25 = chartCampoConven.Series.Add(seriesName25);

                    ser25.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser25.Name = seriesName25;
                    ser25.ChartType = SeriesChartType.Line;

                    if (campoLiga2k_3kodCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo2kodComboBox.Text);
                        valorB = Convert.ToInt32(campo3kodComboBox.Text);

                        ser25.Points.AddXY(10, valorA);
                        ser25.Points.AddXY(11.25, valorB);

                        ser25.BorderColor = Color.Transparent;
                        ser25.Color = Color.Red;
                        ser25.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga2k_3kodCheckBox.Checked == false)
                    {
                        ser25.Points.Clear();
                    }

                    //******

                    string seriesName26 = "liga 3k_4kCAMPOOD";
                    Series ser26 = chartCampoConven.Series.Add(seriesName26);

                    ser26.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser26.Name = seriesName26;
                    ser26.ChartType = SeriesChartType.Line;

                    if (campoLiga3k_4kodCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo3kodComboBox.Text);
                        valorB = Convert.ToInt32(campo4kodComboBox.Text);

                        ser26.Points.AddXY(11.25, valorA);
                        ser26.Points.AddXY(12, valorB);

                        ser26.BorderColor = Color.Transparent;
                        ser26.Color = Color.Red;
                        ser26.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga3k_4kodCheckBox.Checked == false)
                    {
                        ser26.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    campoLiga500_1kodCheckBox.Checked = false;
                    campoLiga1k_2kodCheckBox.Checked = false;
                    campoLiga2k_3kodCheckBox.Checked = false;
                    campoLiga3k_4kodCheckBox.Checked = false;
                }

                //***SEQUÊNCIA PARA LIGAR SIMBOLOGIA ORELHA ESQUERDA

                try
                {

                    string seriesName27 = "liga 500_1kCAMPOOE";
                    Series ser27 = chartCampoConven.Series.Add(seriesName27);

                    ser27.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser27.Name = seriesName27;
                    ser27.ChartType = SeriesChartType.Line;

                    if (campoLiga500_1koeCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo500oeComboBox.Text);
                        valorB = Convert.ToInt32(campo1koeComboBox.Text);

                        ser27.Points.AddXY(6, valorA);
                        ser27.Points.AddXY(8, valorB);

                        ser27.BorderColor = Color.Transparent;
                        ser27.Color = Color.DodgerBlue;
                        ser27.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga500_1koeCheckBox.Checked == false)
                    {
                        ser27.Points.Clear();
                    }

                    //*******

                    string seriesName28 = "liga 1k_2kCAMPOOE";
                    Series ser28 = chartCampoConven.Series.Add(seriesName28);

                    ser28.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser28.Name = seriesName28;
                    ser28.ChartType = SeriesChartType.Line;

                    if (campoLiga1k_2koeCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo1koeComboBox.Text);
                        valorB = Convert.ToInt32(campo2koeComboBox.Text);

                        ser28.Points.AddXY(8, valorA);
                        ser28.Points.AddXY(10, valorB);

                        ser28.BorderColor = Color.Transparent;
                        ser28.Color = Color.DodgerBlue;
                        ser28.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga1k_2koeCheckBox.Checked == false)
                    {
                        ser28.Points.Clear();
                    }

                    //*******

                    string seriesName29 = "liga 2k_3kCAMPOOE";
                    Series ser29 = chartCampoConven.Series.Add(seriesName29);

                    ser29.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser29.Name = seriesName29;
                    ser29.ChartType = SeriesChartType.Line;

                    if (campoLiga2k_3koeCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo2koeComboBox.Text);
                        valorB = Convert.ToInt32(campo3koeComboBox.Text);

                        ser29.Points.AddXY(10, valorA);
                        ser29.Points.AddXY(11.25, valorB);

                        ser29.BorderColor = Color.Transparent;
                        ser29.Color = Color.DodgerBlue;
                        ser29.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga2k_3koeCheckBox.Checked == false)
                    {
                        ser29.Points.Clear();
                    }

                    //******

                    string seriesName30 = "liga 3k_4kCAMPOOE";
                    Series ser30 = chartCampoConven.Series.Add(seriesName30);

                    ser30.ChartArea = chartCampoConven.ChartAreas[0].Name;
                    ser30.Name = seriesName30;
                    ser30.ChartType = SeriesChartType.Line;

                    if (campoLiga3k_4koeCheckBox.Checked == true)
                    {
                        int valorA, valorB;

                        valorA = Convert.ToInt32(campo3koeComboBox.Text);
                        valorB = Convert.ToInt32(campo4koeComboBox.Text);

                        ser30.Points.AddXY(11.25, valorA);
                        ser30.Points.AddXY(12, valorB);

                        ser30.BorderColor = Color.Transparent;
                        ser30.Color = Color.DodgerBlue;
                        ser30.BorderWidth = Convert.ToInt32(1.5);
                    }

                    else if (campoLiga3k_4koeCheckBox.Checked == false)
                    {
                        ser30.Points.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Não é possível ligar a simbologia!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    campoLiga500_1koeCheckBox.Checked = false;
                    campoLiga1k_2koeCheckBox.Checked = false;
                    campoLiga2k_3koeCheckBox.Checked = false;
                    campoLiga3k_4koeCheckBox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Escolha 'Audiometria em campo livre convencional'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnMediaCampoConvOD_Click(object sender, EventArgs e)
        {
            try//no bloco de tratamento de erros
            {
                campoMEDIATconvODTextBox.Clear();//limpa o txt média tritonal com AASI

                if ((campo500odComboBox.Text == "") || (campo1kodComboBox.Text == "") || (campo2kodComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média tritonal de 500Hz, 1kHz e 2kHZ.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((campoVAodAus500CheckBox.Checked == true) || (campoVAodAus1kCheckBox.Checked == true) || (campoVAodAus2kCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        campoMEDIATconvODTextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, resultado;

                        valor1 = Convert.ToInt32(campo500odComboBox.Text);
                        valor2 = Convert.ToInt32(campo1kodComboBox.Text);
                        valor3 = Convert.ToInt32(campo2kodComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3) / 3);

                        campoMEDIATconvODTextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }     
        }

        private void btnMediaCampoConvOE_Click(object sender, EventArgs e)
        {
            try//no bloco de tratamento de erros
            {
                campoMEDIATconvOETextBox.Clear();//limpa o txt média tritonal com AASI

                if ((campo500oeComboBox.Text == "") || (campo1koeComboBox.Text == "") || (campo2koeComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média tritonal de 500Hz, 1kHz e 2kHZ.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((campoVAoeAus500CheckBox.Checked == true) || (campoVAoeAus1kCheckBox.Checked == true) || (campoVAoeAus2kCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        campoMEDIATconvOETextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, resultado;

                        valor1 = Convert.ToInt32(campo500oeComboBox.Text);
                        valor2 = Convert.ToInt32(campo1koeComboBox.Text);
                        valor3 = Convert.ToInt32(campo2koeComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3) / 3);

                        campoMEDIATconvOETextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void tabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((tabControl2.SelectedTab == tabPage8) || (tabControl2.SelectedTab == tabPage9) || (tabControl2.SelectedTab == tabPage10) || (tabControl2.SelectedTab == tabPage11))
            {
                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }

                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }

        private void tabControl3_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((tabControl3.SelectedTab == tabPage12) || (tabControl3.SelectedTab == tabPage13))
            {
                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }
             
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);    
            }
        }

        private void tabControl4_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((tabControl4.SelectedTab == tabPage15) || (tabControl4.SelectedTab == tabPage16))
            {
                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }

                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }

        private void tabControl9_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((tabControl9.SelectedTab == tabPage31) || (tabControl9.SelectedTab == tabPage32))
            {
                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }

                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }

        private void tabControl10_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((tabControl10.SelectedTab == tabPage34) || (tabControl10.SelectedTab == tabPage37))
            {
                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }

                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((tabControl1.SelectedTab == tabPage2) || (tabControl1.SelectedTab == tabPage3) || (tabControl1.SelectedTab == tabPage7))
            {
                using (frmAguarde fa = new frmAguarde(OpenData))
                {
                    fa.ShowDialog(this);
                }

                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }
        }

        private void btnCalcDifOD_Click(object sender, EventArgs e)
        {
            dif500odTextBox.Clear();
            dif1kodTextBox.Clear();
            dif2kodTextBox.Clear();
            dif4kodTextBox.Clear();

            try
            {
                   
            int va500od, va1kod, va2kod, va4kod, ref500od, ref1kod, ref2kod, ref4kod, result1, result2, result3, result4;

            va500od = Convert.ToInt32(va500odComboBox.Text);
            va1kod = Convert.ToInt32(va1kodComboBox.Text);
            va2kod = Convert.ToInt32(va2kodComboBox.Text);
            va4kod = Convert.ToInt32(va4kodComboBox.Text);

            ref500od = Convert.ToInt32(contra500odComboBox.Text);
            ref1kod = Convert.ToInt32(contra1kodComboBox.Text);
            ref2kod = Convert.ToInt32(contra2kodComboBox.Text);
            ref4kod = Convert.ToInt32(contra4kodComboBox.Text);

            if ((va500odComboBox.Text != null) && (va1kodComboBox.Text != null) && (va2kodComboBox.Text != null) && (va4kodComboBox.Text != null)
                && (contra500odComboBox.Text != null) && (contra1kodComboBox.Text != null) && (contra2kodComboBox.Text != null) && (contra4kodComboBox.Text != null))
            {
                result1 = ref500od - va500od;
                result2 = ref1kod - va1kod;
                result3 = ref2kod - va2kod;
                result4 = ref4kod - va4kod;

                dif500odTextBox.Text = Convert.ToString(result1);
                dif1kodTextBox.Text = Convert.ToString(result2);
                dif2kodTextBox.Text = Convert.ToString(result3);
                dif4kodTextBox.Text = Convert.ToString(result4); 
            }
                
            }
            catch
            {
                MessageBox.Show("Não é possível calcular a diferença com valores nulos ou ausentes!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                contra500odComboBox.Text = null;
                contra1kodComboBox.Text = null;
                contra2kodComboBox.Text = null;
                contra4kodComboBox.Text = null;
            }
            try
            {
                int gap500od, gap1kod, gap2kod, gap3kod, gap4kod, va500gapOD, va1kgapOD, va2kgapOD, va3kgapOD, va4kgapOD, vo500gapOD, vo1kgapOD, vo2kgapOD, vo3kgapOD, vo4kgapOD;

                va500gapOD = Convert.ToInt32(va500odComboBox.Text);
                vo500gapOD = Convert.ToInt32(vo500odComboBox.Text);

                va1kgapOD = Convert.ToInt32(va1kodComboBox.Text);
                vo1kgapOD = Convert.ToInt32(vo1kodComboBox.Text);

                va2kgapOD = Convert.ToInt32(va2kodComboBox.Text);
                vo2kgapOD = Convert.ToInt32(vo2kodComboBox.Text);

                va3kgapOD = Convert.ToInt32(va3kodComboBox.Text);
                vo3kgapOD = Convert.ToInt32(vo3kodComboBox.Text);

                va4kgapOD = Convert.ToInt32(va4kodComboBox.Text);
                vo4kgapOD = Convert.ToInt32(vo4kodComboBox.Text);

                gap500od = (va500gapOD - vo500gapOD);
                gap1kod = (va1kgapOD - vo1kgapOD);
                gap2kod = (va2kgapOD - vo2kgapOD);
                gap3kod = (va3kgapOD - vo3kgapOD);
                gap4kod = (va4kgapOD - vo4kgapOD);

                if ((gap500od > 10) || (gap1kod > 10) || (gap2kod > 10) || (gap3kod > 10) || (gap4kod > 10))
                {
                    contra500odComboBox.Text = null;
                    contra1kodComboBox.Text = null;
                    contra2kodComboBox.Text = null;
                    contra4kodComboBox.Text = null;

                    dif500odTextBox.Clear();
                    dif1kodTextBox.Clear();
                    dif2kodTextBox.Clear();
                    dif4kodTextBox.Clear();

                    MessageBox.Show("Não é possível calcular a diferença em curvas dos tipos condutiva ou mista!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Algum valor deve estar ausente...", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCalcularDifOE_Click(object sender, EventArgs e)
        {
            dif500oeTextBox.Clear();
            dif1koeTextBox.Clear();
            dif2koeTextBox.Clear();
            dif4koeTextBox.Clear();

            try
            {

                int va500oe, va1koe, va2koe, va4koe, ref500oe, ref1koe, ref2koe, ref4koe, result1, result2, result3, result4;

                va500oe = Convert.ToInt32(va500oeComboBox.Text);
                va1koe = Convert.ToInt32(va1koeComboBox.Text);
                va2koe = Convert.ToInt32(va2koeComboBox.Text);
                va4koe = Convert.ToInt32(va4koeComboBox.Text);

                ref500oe = Convert.ToInt32(contra500oeComboBox.Text);
                ref1koe = Convert.ToInt32(contra1koeComboBox.Text);
                ref2koe = Convert.ToInt32(contra2koeComboBox.Text);
                ref4koe = Convert.ToInt32(contra4koeComboBox.Text);

                if ((va500oeComboBox.Text != null) && (va1koeComboBox.Text != null) && (va2koeComboBox.Text != null) && (va4koeComboBox.Text != null)
                    && (contra500oeComboBox.Text != null) && (contra1koeComboBox.Text != null) && (contra2koeComboBox.Text != null) && (contra4koeComboBox.Text != null))
                {
                    result1 = ref500oe - va500oe;
                    result2 = ref1koe - va1koe;
                    result3 = ref2koe - va2koe;
                    result4 = ref4koe - va4koe;

                    dif500oeTextBox.Text = Convert.ToString(result1);
                    dif1koeTextBox.Text = Convert.ToString(result2);
                    dif2koeTextBox.Text = Convert.ToString(result3);
                    dif4koeTextBox.Text = Convert.ToString(result4);
                }

            }
            catch
            {
                MessageBox.Show("Não é possível calcular a diferença com valores nulos ou ausentes!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                contra500oeComboBox.Text = null;
                contra1koeComboBox.Text = null;
                contra2koeComboBox.Text = null;
                contra4koeComboBox.Text = null;
            }

            try
            {
                int gap500oe, gap1koe, gap2koe, gap3koe, gap4koe, va500gapOE, va1kgapOE, va2kgapOE, va3kgapOE, va4kgapOE, vo500gapOE, vo1kgapOE, vo2kgapOE, vo3kgapOE, vo4kgapOE;

                va500gapOE = Convert.ToInt32(va500oeComboBox.Text);
                vo500gapOE = Convert.ToInt32(vo500oeComboBox.Text);

                va1kgapOE = Convert.ToInt32(va1koeComboBox.Text);
                vo1kgapOE = Convert.ToInt32(vo1koeComboBox.Text);

                va2kgapOE = Convert.ToInt32(va2koeComboBox.Text);
                vo2kgapOE = Convert.ToInt32(vo2koeComboBox.Text);

                va3kgapOE = Convert.ToInt32(va3koeComboBox.Text);
                vo3kgapOE = Convert.ToInt32(vo3koeComboBox.Text);

                va4kgapOE = Convert.ToInt32(va4koeComboBox.Text);
                vo4kgapOE = Convert.ToInt32(vo4koeComboBox.Text);

                gap500oe = (va500gapOE - vo500gapOE);
                gap1koe = (va1kgapOE - vo1kgapOE);
                gap2koe = (va2kgapOE - vo2kgapOE);
                gap3koe = (va3kgapOE - vo3kgapOE);
                gap4koe = (va4kgapOE - vo4kgapOE);

                if ((gap500oe > 10) || (gap1koe > 10) || (gap2koe > 10) || (gap3koe > 10) || (gap4koe > 10))
                {
                    contra500oeComboBox.Text = null;
                    contra1koeComboBox.Text = null;
                    contra2koeComboBox.Text = null;
                    contra4koeComboBox.Text = null;

                    dif500oeTextBox.Clear();
                    dif1koeTextBox.Clear();
                    dif2koeTextBox.Clear();
                    dif4koeTextBox.Clear();

                    MessageBox.Show("Não é possível calcular a diferença em curvas dos tipos condutiva ou mista!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Algum valor deve estar ausente...", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMediaODconv_Click(object sender, EventArgs e)//Média tritonal
        {
            try//no bloco de tratamento de erros
            {
                mEDIAodTextBox.Clear();//limpa o txt média tritonal com AASI

                if ((va500odComboBox.Text == "") || (va1kodComboBox.Text == "") || (va2kodComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média tritonal de 500Hz, 1kHz e 2kHZ.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((aus500vaODCheckBox.Checked == true) || (aus1kvaODCheckBox.Checked == true) || (aus2kvaODCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        mEDIAodTextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, resultado;

                        valor1 = Convert.ToInt32(va500odComboBox.Text);
                        valor2 = Convert.ToInt32(va1kodComboBox.Text);
                        valor3 = Convert.ToInt32(va2kodComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3) / 3);

                        mEDIAodTextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }   
        }

        private void btnMediaconvenOE_Click(object sender, EventArgs e)//Média Tritonal
        {
            try//no bloco de tratamento de erros
            {
                mEDIAoeTextBox.Clear();//limpa o txt média tritonal com AASI

                if ((va500oeComboBox.Text == "") || (va1koeComboBox.Text == "") || (va2koeComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média tritonal de 500Hz, 1kHz e 2kHZ.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((aus500vaOECheckBox.Checked == true) || (aus1kvaOECheckBox.Checked == true) || (aus2kvaOECheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        mEDIAoeTextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, resultado;

                        valor1 = Convert.ToInt32(va500oeComboBox.Text);
                        valor2 = Convert.ToInt32(va1koeComboBox.Text);
                        valor3 = Convert.ToInt32(va2koeComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3) / 3);

                        mEDIAoeTextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }   
        }

        private void btnPrintAudioCampoAASI_Click(object sender, EventArgs e)
        {
            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            chartAudioEmCampo.SaveImage("C:\\users/public/documents/chartAudioCampoAASI.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string valor1 = identificacaoTextBox.Text;//atribui o txt a uma variável

            var fpcla = new frmPrintCampoLivreAASI(valor1);//instancia o frm que abrirá com a variável

            fpcla.ShowDialog();
        }

        private void btnPrintImpedancio_Click(object sender, EventArgs e)
        {
            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            chartODimp.SaveImage("C:\\users/public/documents/chartODimp.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            chartOEimp.SaveImage("C:\\users/public/documents/chartOEimp.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string valor1 = identificacaoTextBox.Text;//atribui o txt a uma variável

            var fpi = new frmPrintImpedancioODeOE(valor1);//instancia o frm que abrirá com a variável

            fpi.ShowDialog();
        }

        private void btnPrintComport_Click(object sender, EventArgs e)
        {
            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            string valor1 = identificacaoTextBox.Text;//atribui o txt a uma variável

            var fpc = new frmPrintComportamental(valor1);//instancia o frm que abrirá com a variável
            
            fpc.ShowDialog();
        }

        private void btnPrintAudioCampoConven_Click(object sender, EventArgs e)
        {
            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            chartCampoConven.SaveImage("C:\\users/public/documents/chartAudioCampoConven.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string valor1 = identificacaoTextBox.Text;//atribui o txt a uma variável

            var fpac = new frmPrintAudioCampoConven(valor1);//instancia o frm que abrirá com a variável
            
            fpac.ShowDialog();
        }

        private void btnPrintAltasFreq_Click(object sender, EventArgs e)
        {
            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            chartAltOD.SaveImage("C:\\users/public/documents/chartODAltasFreq.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            chartAltOE.SaveImage("C:\\users/public/documents/chartOEAltasFreq.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string valor1 = identificacaoTextBox.Text;//atribui o txt a uma variável

            var fpaaf = new frmPrintAudioAltasFreq(valor1);//instancia o frm que abrirá com a variável
           
            fpaaf.ShowDialog();
        }

        private void btnPrintAudioTonal_Click(object sender, EventArgs e)
        {
            using (frmAguarde fa = new frmAguarde(OpenData))
            {
                fa.ShowDialog(this);
            }

            chartAudioOD.SaveImage("C:\\users/public/documents/chartODAudioClinica.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            chartAudioOE.SaveImage("C:\\users/public/documents/chartOEAudioClinica.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string valor1 = identificacaoTextBox.Text;//atribui o txt a uma variável

            var fpacn = new frmPrintAudioClinica(valor1);//instancia o frm que abrirá com a variável

            fpacn.ShowDialog();
        }
   
        private void idadePacienteNovoTextBox_Click(object sender, EventArgs e)
        {
            idadePacienteNovoTextBox.Clear();

            DateTime DataNascimento = dataNascimentoDateTimePicker.Value;
            DateTime DataAtual = DateTime.Now;
            int Anos = new DateTime(DateTime.Now.Subtract(DataNascimento).Ticks).Year - 1;
            DateTime AnosTranscorridos = DataNascimento.AddYears(Anos);
            int Meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (AnosTranscorridos.AddMonths(i) == DataAtual)
                {
                    Meses = i;
                    break;
                }
                else if (AnosTranscorridos.AddMonths(i) >= DataAtual)
                {
                    Meses = i - 1;
                    break;
                }
            }
            int Dias = DataAtual.Subtract(AnosTranscorridos.AddMonths(Meses)).Days;

            idadePacienteNovoTextBox.Text += ((Anos.ToString()) + " anos, " + (Meses.ToString()) + " meses, " + (Dias.ToString()) + " dias.");
        }

        private void txtBuscaExames_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscaDadosGerais.Text == "")
            {
                MessageBox.Show("O campo correspondente ao tipo de busca está vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaExames.Clear();
            }
            else if (cbBuscaDadosGerais.Text == "por nome")
            {
                tabelaExamesBindingSource.Filter = $"nomePaciente like '*{txtBuscaExames.Text}*'";
            }
            else if (cbBuscaDadosGerais.Text == "por identificação")
            {
                tabelaExamesBindingSource.Filter = $"identificacao like '*{txtBuscaExames.Text}*'";
            }
            else if (cbBuscaDadosGerais.Text == "por empresa")
            {
                tabelaExamesBindingSource.Filter = $"empresa like '*{txtBuscaExames.Text}*'";
            }
        }

        private void btnPrintLaudo_Click(object sender, EventArgs e)
        {
            dados dados = new dados();

            frmPrintLaudario fpl = new frmPrintLaudario();
            dados.laudario = txtLaudario.Text;
            fpl.dados.Add(dados);
            fpl.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dataExameDateTimePicker.CustomFormat = " ";
            dataNascimentoDateTimePicker.CustomFormat = " ";
            dataCalibracaoDateTimePicker.CustomFormat = " ";
            dataCalImpDateTimePicker.CustomFormat = " ";

            gbDadosPaciente.Enabled = true;
            gbTipoAudiograma.Enabled = true;

            tsbPreencherAudio.Enabled = true;
            tsbPreencherTimpanogramas.Enabled = true;

            ((Control)tabControl1.TabPages["tabPage4"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage5"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage6"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage7"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage36"]).Enabled = true;                    
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaExamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

            MessageBox.Show("Os exames foram apagados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbDadosPaciente.Enabled = false;
            gbTipoAudiograma.Enabled = false;

            tsbPreencherAudio.Enabled = false;
            tsbPreencherTimpanogramas.Enabled = false;

            dataExameDateTimePicker.CustomFormat = " ";
            dataNascimentoDateTimePicker.CustomFormat = " ";
            dataCalibracaoDateTimePicker.CustomFormat = " ";
            dataCalImpDateTimePicker.CustomFormat = " ";

            tipoAudiometriaComboBox.SelectedIndex = -1;

            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage4"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage5"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage6"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage7"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage36"]).Enabled = false;
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            gbDadosPaciente.Enabled = true;
            gbTipoAudiograma.Enabled = true;

            tsbPreencherAudio.Enabled = true;
            tsbPreencherTimpanogramas.Enabled = true;

            ((Control)tabControl1.TabPages["tabPage4"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage5"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage6"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage7"]).Enabled = true;
            ((Control)tabControl1.TabPages["tabPage36"]).Enabled = true;
        }

        private void toolStripBloquear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(identificacaoTextBox.Text))
            {
                MessageBox.Show("O campo 'Identificação' não está preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Validate();
            this.tabelaExamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

            gbDadosPaciente.Enabled = false;
            gbTipoAudiograma.Enabled = false;

            tsbPreencherAudio.Enabled = false;
            tsbPreencherTimpanogramas.Enabled = false;

            tipoAudiometriaComboBox.SelectedIndex = -1;

            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage4"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage5"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage6"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage7"]).Enabled = false;
            ((Control)tabControl1.TabPages["tabPage36"]).Enabled = false;
        }

        private void dataExameDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataExameDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dataExameDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dataExameDateTimePicker.CustomFormat = " ";
            }
        }

        private void dataNascimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataNascimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dataNascimentoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dataNascimentoDateTimePicker.CustomFormat = " ";
            }
        }

        private void dataCalibracaoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCalibracaoDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dataCalibracaoDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dataCalibracaoDateTimePicker.CustomFormat = " ";
            }
        }

        private void dataCalImpDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataCalImpDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dataCalImpDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dataCalImpDateTimePicker.CustomFormat = " ";
            }
        }

        private void tsbPreencherAudio_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tipoAudiometriaComboBox.Text))
            {
                MessageBox.Show("Selecione o 'Tipo de Audiometria' antes de realizar este processo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ((Control)tabControl1.TabPages["tabPage2"]).Enabled = true;
            }

            desabilitaMarcacao();
        }

        private void toolStripInternet_Click(object sender, EventArgs e)
        {
            string pagina = "http://www.google.com.br";

            System.Diagnostics.Process.Start(pagina);
        }

        private void btnMedia4ODconv_Click(object sender, EventArgs e)//Média quadritonal
        {
            try//no bloco de tratamento de erros
            {
                mEDIAodTextBox.Clear();//limpa o txt média tritonal com AASI

                if ((va500odComboBox.Text == "") || (va1kodComboBox.Text == "") || (va2kodComboBox.Text == "") || (va4kodComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média quadritonal de 500Hz, 1kHz, 2kHZ e 4kHz.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((aus500vaODCheckBox.Checked == true) || (aus1kvaODCheckBox.Checked == true) || (aus2kvaODCheckBox.Checked == true) || (aus4kvaODCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        mEDIAodTextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, valor4, resultado;

                        valor1 = Convert.ToInt32(va500odComboBox.Text);
                        valor2 = Convert.ToInt32(va1kodComboBox.Text);
                        valor3 = Convert.ToInt32(va2kodComboBox.Text);
                        valor4 = Convert.ToInt32(va4kodComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3 + valor4) / 4);

                        mEDIAodTextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnMedia4ConvenOE_Click(object sender, EventArgs e)//Média quadritonal
        {
            try//no bloco de tratamento de erros
            {
                mEDIAoeTextBox.Clear();//limpa o txt média tritonal com AASI

                if ((va500oeComboBox.Text == "") || (va1koeComboBox.Text == "") || (va2koeComboBox.Text == "") || (va4koeComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz e 2kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média quadritonal de 500Hz, 1kHz, 2kHZ e 4kHz.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((aus500vaOECheckBox.Checked == true) || (aus1kvaOECheckBox.Checked == true) || (aus2kvaOECheckBox.Checked == true) ||(aus4kvaOECheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz ou 2kHz esteja com o texto AUS, de ausente
                    {
                        mEDIAoeTextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, valor4, resultado;

                        valor1 = Convert.ToInt32(va500oeComboBox.Text);
                        valor2 = Convert.ToInt32(va1koeComboBox.Text);
                        valor3 = Convert.ToInt32(va2koeComboBox.Text);
                        valor4 = Convert.ToInt32(va4koeComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3 + valor4) / 4);

                        mEDIAoeTextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnCalcularMedia4Com_Click(object sender, EventArgs e)//Média quadritonal com AASI
        {
            try//no bloco de tratamento de erros
            {
                comMEDIATextBox.Clear();//limpa o txt média tritonal com AASI

                if ((com500ComboBox.Text == "") || (com1kComboBox.Text == "") || (com2KComboBox.Text == "") || (com4kComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz, 2kHz e 4kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média quadritonal de 500Hz, 1kHz, 2kHZ e 4kHz.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((chkAusente500comCheckBox.Checked == true) || (chkAusente1kcomCheckBox.Checked == true) || (chkAusente2kcomCheckBox.Checked == true) || (chkAusente4kcomCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz, 2kHz ou 4kHz esteja com o texto AUS, de ausente
                    {
                        comMEDIATextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, valor4, media;//criam-se quatro variáveis

                        //as variáveis são atribuídas aos respectivos txt's, convertendo-os em decimais
                        valor1 = Convert.ToInt32(com500ComboBox.Text);
                        valor2 = Convert.ToInt32(com1kComboBox.Text);
                        valor3 = Convert.ToInt32(com2KComboBox.Text);
                        valor4 = Convert.ToInt32(com4kComboBox.Text);

                        media = ((valor1 + valor2 + valor3 + valor4) / 4);//cáculo da média quadritonal

                        comMEDIATextBox.Text = Convert.ToString(media);//atribui o resultado da média ao txt média com AASI, convertendo-o para string
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnCalcularMedia4SemAASI_Click(object sender, EventArgs e)//Média quadritonal sem AASI
        {
            try//no bloco de tratamento de erros
            {
                semMEDIATextBox.Clear();//limpa o txt média tritonal sem AASI

                if ((sem500ComboBox.Text == "") || (sem1kComboBox.Text == "") || (sem2KComboBox.Text == "") || (sem4kComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz, 2kHz e 4kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média quadritonal de 500Hz, 1kHz, 2kHZ e 4kHz.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((chkAusente500semCheckBox.Checked == true) || (chkAusente1ksemCheckBox.Checked == true) || (chkAusente2ksemCheckBox.Checked == true) || (chkAusente4ksemCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz, 2kHz ou 4kHz esteja com o texto AUS, de ausente
                    {
                        semMEDIATextBox.Text = "Saída máxima";//atritui a frase à txt média sem AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, valor4, media;//criam-se quatro variáveis

                        //as variáveis são atribuídas aos respectivos txt's, convertendo-os em decimais
                        valor1 = Convert.ToInt32(sem500ComboBox.Text);
                        valor2 = Convert.ToInt32(sem1kComboBox.Text);
                        valor3 = Convert.ToInt32(sem2KComboBox.Text);
                        valor4 = Convert.ToInt32(sem4kComboBox.Text);

                        media = ((valor1 + valor2 + valor3 + valor4) / 4);//cáculo da média quadritonal

                        semMEDIATextBox.Text = Convert.ToString(media);//atribui o resultado da média ao txt média sem AASI, convertendo-o para string
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnMedia4CampoConvOD_Click(object sender, EventArgs e)//Média quadritonal
        {
            try//no bloco de tratamento de erros
            {
                campoMEDIATconvODTextBox.Clear();//limpa o txt média tritonal com AASI

                if ((campo500odComboBox.Text == "") || (campo1kodComboBox.Text == "") || (campo2kodComboBox.Text == "") || (campo4kodComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz, 2kHz e 4kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média quadritonal de 500Hz, 1kHz, 2kHZ e 4kHz.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((campoVAodAus500CheckBox.Checked == true) || (campoVAodAus1kCheckBox.Checked == true) || (campoVAodAus2kCheckBox.Checked == true) || (campoVAodAus4kCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz, 2kHz e 4kHz esteja com o texto AUS, de ausente
                    {
                        campoMEDIATconvODTextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, valor4, resultado;

                        valor1 = Convert.ToInt32(campo500odComboBox.Text);
                        valor2 = Convert.ToInt32(campo1kodComboBox.Text);
                        valor3 = Convert.ToInt32(campo2kodComboBox.Text);
                        valor4 = Convert.ToInt32(campo4kodComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3 + valor4) / 4);

                        campoMEDIATconvODTextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void btnMedia4CampoConvOE_Click(object sender, EventArgs e)//Média quadritonal
        {
            try//no bloco de tratamento de erros
            {
                campoMEDIATconvOETextBox.Clear();//limpa o txt média tritonal com AASI

                if ((campo500oeComboBox.Text == "") || (campo1koeComboBox.Text == "") || (campo2koeComboBox.Text == "") || (campo4koeComboBox.Text == ""))//caso alguma das txt's de 500Hz, 1kHz, 2kHz e 4kHz estejam vazias
                {
                    MessageBox.Show("Por favor, escolha os valores para a média quadritonal de 500Hz, 1kHz, 2kHZ e 4kHz.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//msg de aviso
                }

                else//do contrário
                {
                    if ((campoVAoeAus500CheckBox.Checked == true) || (campoVAoeAus1kCheckBox.Checked == true) || (campoVAoeAus2kCheckBox.Checked == true) || (campoVAoeAus4kCheckBox.Checked == true))//caso alguma das txt's de 500Hz, 1kHz, 2kHz e 4kHz esteja com o texto AUS, de ausente
                    {
                        campoMEDIATconvOETextBox.Text = "Saída máxima";//atritui a frase à txt média com AASI
                    }

                    else//caso contrário
                    {
                        int valor1, valor2, valor3, valor4, resultado;

                        valor1 = Convert.ToInt32(campo500oeComboBox.Text);
                        valor2 = Convert.ToInt32(campo1koeComboBox.Text);
                        valor3 = Convert.ToInt32(campo2koeComboBox.Text);
                        valor4 = Convert.ToInt32(campo4koeComboBox.Text);

                        resultado = ((valor1 + valor2 + valor3 + valor4) / 4);

                        campoMEDIATconvOETextBox.Text = Convert.ToString(resultado);
                    }
                }
            }
            catch (Exception ex)//tratamento de erro
            {
                MessageBox.Show(ex.Message);//msg de erro
            }
        }

        private void desabilitaMarcacaoImpedancio()
        {
            curvaBodCheckBox.Checked = false;
            curvaBoeCheckBox.Checked = false;
        }

        private void desabilitaMarcacao()
        {
            //mascaramento VA OD
            masc125vaODCheckBox.Checked = false;
            masc250vaODCheckBox.Checked = false;
            masc500vaODCheckBox.Checked = false;
            masc750vaODCheckBox.Checked = false;
            masc1kvaODCheckBox.Checked = false;
            masc1_5kvaODCheckBox.Checked = false;
            masc2kvaODCheckBox.Checked = false;
            masc3kvaODCheckBox.Checked = false;
            masc4kvaODCheckBox.Checked = false;
            masc6kvaODCheckBox.Checked = false;
            masc8kvaODCheckBox.Checked = false;

            //mascaramento VA OD altas frequências
            chkMasc9kODCheckBox.Checked = false;
            chkMasc12_5kODCheckBox.Checked = false;
            chkMasc14kODCheckBox.Checked = false;
            chkMasc16kODCheckBox.Checked = false;
            chkMasc18kODCheckBox.Checked = false;
            chkMasc20kODCheckBox.Checked = false;

            //liga VA OD
            liga125_250vaODCheckBox.Checked = false;
            liga250_500vaODCheckBox.Checked = false;
            liga500_750vaODCheckBox.Checked = false;
            liga750_1kvaODCheckBox.Checked = false;
            liga1k_1_5kvaODCheckBox.Checked = false;
            liga1_5k_2kvaODCheckBox.Checked = false;
            liga2k_3kvaODCheckBox.Checked = false;
            liga3k_4kvaODCheckBox.Checked = false;
            liga4k_6kvaODCheckBox.Checked = false;
            liga6k_8kvaODCheckBox.Checked = false;

            //liga VA OD altas frequências
            chkliga9_10ODCheckBox.Checked = false;
            chkliga10_12_5ODCheckBox.Checked = false;
            chkliga12_5_14ODCheckBox.Checked = false;
            chkliga14_16ODCheckBox.Checked = false;
            chkliga16_18ODCheckBox.Checked = false;
            chkliga18_20ODCheckBox.Checked = false;

            //Ausência de VA OD

        }

        private void tsbPreencherTimpanogramas_Click(object sender, EventArgs e)
        {
            ((Control)tabControl1.TabPages["tabPage3"]).Enabled = true;           

            desabilitaMarcacaoImpedancio();
        }
    }   
}
