using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace segmentoOtoneurologia
{
    public partial class frmProntuario : Form
    {
        public frmProntuario()
        {
            InitializeComponent();
        }

        private void tabelaProntuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaProntuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segmsaude001DataSet);

        }

        private void frmProntuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaReceituario'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaReceituarioTableAdapter.Fill(this.segmsaude001DataSet.tabelaReceituario);
            // TODO: esta linha de código carrega dados na tabela 'segmsaude001DataSet.tabelaProntuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaProntuarioTableAdapter.Fill(this.segmsaude001DataSet.tabelaProntuario);

        }

        private void tabPage5_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage5)//se a aba 5 for selecionada com o mouse
            {
                tabelaProntuarioBindingNavigator.Enabled = false;//a barra de ferramentas fica inabilitada
            }

            else//caso contrário
            {
                tabelaProntuarioBindingNavigator.Enabled = true;//a barra de ferramentas fica habilitada
            }
        }

        private void idadePacienteNovoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBuscarProntuario_TextChanged(object sender, EventArgs e)
        {
            tabelaProntuarioBindingSource.Filter = $"nomePaciente like '*{txtBuscarProntuario.Text}*'";
            tabelaProntuarioBindingSource.Filter = $"identificacao like '*{txtBuscarProntuario.Text}*'";
            tabelaProntuarioBindingSource.Filter = $"cpfPaciente like '*{txtBuscarProntuario.Text}*'";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ofd.ShowDialog() == DialogResult.OK) //se a caixa de diálogo tiver resultado como ok
            {
                this.bancoImagem1PictureBox.Image = System.Drawing.Image.FromFile(this.ofd.FileName); //pega-se a imagem e coloca no pictureBox
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ofd.ShowDialog() == DialogResult.OK) //se a caixa de diálogo tiver resultado como ok
            {
                this.bancoImagem2PictureBox.Image = System.Drawing.Image.FromFile(this.ofd.FileName); //pega-se a imagem e coloca no pictureBox
            }
        }

        private void txtBuscarReceituario_TextChanged(object sender, EventArgs e)
        {
            tabelaReceituarioBindingSource.Filter = $"nomeReceituario like '*{txtBuscarReceituario.Text}*'";
        }

        private void btnPrintReceituario_Click(object sender, EventArgs e)
        {
            dados dados = new dados();

            frmPrintReceituario fpr = new frmPrintReceituario();
            dados.receituario = txtReceituario.Text;
            fpr.dados.Add(dados);
            fpr.ShowDialog();
        }

        private void idadePacienteNovoTextBox_MouseClick(object sender, MouseEventArgs e)
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

        private void button12_Click(object sender, EventArgs e)//plota o gráfico da audiometria
        {
            chartAudio.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartAudio.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartAudio.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string seriesName1 = "grade1OD";
            Series ser1 = chartAudio.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2OD";
            Series ser2 = chartAudio.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3OD";
            Series ser3 = chartAudio.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4OD";
            Series ser4 = chartAudio.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5OD";
            Series ser5 = chartAudio.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6OD";
            Series ser6 = chartAudio.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7OD";
            Series ser7 = chartAudio.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8OD";
            Series ser7a = chartAudio.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9OD";
            Series ser9a = chartAudio.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10OD";
            Series ser10a = chartAudio.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11OD";
            Series ser11a = chartAudio.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12OD";
            Series ser12a = chartAudio.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);
        }

        private void button18_Click(object sender, EventArgs e)//plota o gráfico de "audiometria do PEATE clique"
        {
            chartPEATEclique.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartPEATEclique.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartPEATEclique.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string seriesName1 = "grade1OD";
            Series ser1 = chartPEATEclique.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2OD";
            Series ser2 = chartPEATEclique.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3OD";
            Series ser3 = chartPEATEclique.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4OD";
            Series ser4 = chartPEATEclique.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5OD";
            Series ser5 = chartPEATEclique.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6OD";
            Series ser6 = chartPEATEclique.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7OD";
            Series ser7 = chartPEATEclique.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 2;
            ser7.Color = Color.Lime;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8OD";
            Series ser7a = chartPEATEclique.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9OD";
            Series ser9a = chartPEATEclique.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 2;
            ser9a.Color = Color.Lime;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10OD";
            Series ser10a = chartPEATEclique.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11OD";
            Series ser11a = chartPEATEclique.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12OD";
            Series ser12a = chartPEATEclique.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);

            //*** PARA A SIMBOLOGIA DESTE GRÁFICO ***

            //*** PARA A PRIMEIRA DATA

            string seriesName13a = "ponto3kvaOD1";
            Series ser13a = chartPEATEclique.Series.Add(seriesName13a);

            ser13a.IsVisibleInLegend = false;
            ser13a.ChartType = SeriesChartType.Point;

            if (vaodPEATEclique1TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser13a.MarkerImage = "vazio";
            }

            else if (vaodPEATEclique1TextBox.Text != "")
            {
                ser13a.Color = Color.LightCoral;
                ser13a.MarkerStyle = MarkerStyle.Circle;
                ser13a.MarkerBorderColor = Color.Black;
                ser13a.MarkerSize = 24;

                int valor13;
                valor13 = Convert.ToInt32(vaodPEATEclique1TextBox.Text);
                ser13a.Points.AddXY(11.25, valor13);  // x, high
            }

            string seriesName14a = "ponto3kvaOE1";
            Series ser14a = chartPEATEclique.Series.Add(seriesName14a);

            ser14a.IsVisibleInLegend = false;
            ser14a.ChartType = SeriesChartType.Point;

            if (vaoePEATEclique1TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser14a.MarkerImage = "vazio";
            }

            else if (vaoePEATEclique1TextBox.Text != "")
            {
                ser14a.Color = Color.LightCoral;
                ser14a.MarkerStyle = MarkerStyle.Square;
                ser14a.MarkerBorderColor = Color.Black;
                ser14a.MarkerSize = 24;

                int valor14;
                valor14 = Convert.ToInt32(vaoePEATEclique1TextBox.Text);
                ser14a.Points.AddXY(11.25, valor14);  // x, high
            }

            string seriesName15a = "ponto3kvoOD1";
            Series ser15a = chartPEATEclique.Series.Add(seriesName15a);

            ser15a.IsVisibleInLegend = false;
            ser15a.ChartType = SeriesChartType.Point;

            if (voodPEATEclique1TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser15a.MarkerImage = "vazio";
            }

            else if (voodPEATEclique1TextBox.Text != "")
            {
                ser15a.Color = Color.LightCoral;
                ser15a.MarkerStyle = MarkerStyle.Triangle;
                ser15a.MarkerBorderColor = Color.Black;
                ser15a.MarkerSize = 24;

                int valor15;
                valor15 = Convert.ToInt32(voodPEATEclique1TextBox.Text);
                ser15a.Points.AddXY(11.25, valor15);  // x, high
            }

            string seriesName16a = "ponto3kvoOE1";
            Series ser16a = chartPEATEclique.Series.Add(seriesName16a);

            ser16a.IsVisibleInLegend = false;
            ser16a.ChartType = SeriesChartType.Point;

            if (vooePEATEclique1TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser16a.MarkerImage = "vazio";
            }

            else if (vooePEATEclique1TextBox.Text != "")
            {
                ser16a.Color = Color.LightCoral;
                ser16a.MarkerStyle = MarkerStyle.Diamond;
                ser16a.MarkerBorderColor = Color.Black;
                ser16a.MarkerSize = 24;

                int valor16;
                valor16 = Convert.ToInt32(vooePEATEclique1TextBox.Text);
                ser16a.Points.AddXY(11.25, valor16);  // x, high
            }

            //*** PARA A SEGUNDA DATA

            string seriesName17a = "ponto3kvaOD2";
            Series ser17a = chartPEATEclique.Series.Add(seriesName17a);

            ser17a.IsVisibleInLegend = false;
            ser17a.ChartType = SeriesChartType.Point;

            if (vaodPEATEclique2TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser17a.MarkerImage = "vazio";
            }

            else if (vaodPEATEclique2TextBox.Text != "")
            {
                ser17a.Color = Color.DarkOrange;
                ser17a.MarkerStyle = MarkerStyle.Circle;
                ser17a.MarkerBorderColor = Color.Black;
                ser17a.MarkerSize = 24;

                int valor17;
                valor17 = Convert.ToInt32(vaodPEATEclique2TextBox.Text);
                ser17a.Points.AddXY(11.25, valor17);  // x, high
            }

            string seriesName18a = "ponto3kvaOE2";
            Series ser18a = chartPEATEclique.Series.Add(seriesName18a);

            ser18a.IsVisibleInLegend = false;
            ser18a.ChartType = SeriesChartType.Point;

            if (vaoePEATEclique2TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser18a.MarkerImage = "vazio";
            }

            else if (vaoePEATEclique2TextBox.Text != "")
            {
                ser18a.Color = Color.DarkOrange;
                ser18a.MarkerStyle = MarkerStyle.Square;
                ser18a.MarkerBorderColor = Color.Black;
                ser18a.MarkerSize = 24;

                int valor18;
                valor18 = Convert.ToInt32(vaoePEATEclique2TextBox.Text);
                ser18a.Points.AddXY(11.25, valor18);  // x, high
            }

            string seriesName19a = "ponto3kvoOD2";
            Series ser19a = chartPEATEclique.Series.Add(seriesName19a);

            ser19a.IsVisibleInLegend = false;
            ser19a.ChartType = SeriesChartType.Point;

            if (voodPEATEclique2TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser19a.MarkerImage = "vazio";
            }

            else if (voodPEATEclique2TextBox.Text != "")
            {
                ser19a.Color = Color.DarkOrange;
                ser19a.MarkerStyle = MarkerStyle.Triangle;
                ser19a.MarkerBorderColor = Color.Black;
                ser19a.MarkerSize = 24;

                int valor19;
                valor19 = Convert.ToInt32(voodPEATEclique2TextBox.Text);
                ser19a.Points.AddXY(11.25, valor19);  // x, high
            }

            string seriesName20a = "ponto3kvoOE2";
            Series ser20a = chartPEATEclique.Series.Add(seriesName20a);

            ser20a.IsVisibleInLegend = false;
            ser20a.ChartType = SeriesChartType.Point;

            if (vooePEATEclique2TextBox.Text == "")
            {
                var vaOEpresente13vaz = new NamedImage("vazio", Properties.Resources.vazio);
                chartPEATEclique.Images.Clear();
                chartPEATEclique.Images.Add(vaOEpresente13vaz);
                ser20a.MarkerImage = "vazio";
            }

            else if (vooePEATEclique2TextBox.Text != "")
            {
                ser20a.Color = Color.DarkOrange;
                ser20a.MarkerStyle = MarkerStyle.Diamond;
                ser20a.MarkerBorderColor = Color.Black;
                ser20a.MarkerSize = 24;

                int valor20;
                valor20 = Convert.ToInt32(vooePEATEclique2TextBox.Text);
                ser20a.Points.AddXY(11.25, valor20);  // x, high
            }

            //*** PARA A TERCEIRA DATA


        }

        private void button21_Click(object sender, EventArgs e)//plota o gráfico de "audiometria por PEATE tone burst"
        {
            chartPEATEtoneBurst.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartPEATEtoneBurst.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartPEATEtoneBurst.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string seriesName1 = "grade1OD";
            Series ser1 = chartPEATEtoneBurst.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2OD";
            Series ser2 = chartPEATEtoneBurst.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3OD";
            Series ser3 = chartPEATEtoneBurst.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4OD";
            Series ser4 = chartPEATEtoneBurst.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5OD";
            Series ser5 = chartPEATEtoneBurst.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6OD";
            Series ser6 = chartPEATEtoneBurst.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7OD";
            Series ser7 = chartPEATEtoneBurst.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8OD";
            Series ser7a = chartPEATEtoneBurst.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9OD";
            Series ser9a = chartPEATEtoneBurst.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10OD";
            Series ser10a = chartPEATEtoneBurst.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11OD";
            Series ser11a = chartPEATEtoneBurst.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12OD";
            Series ser12a = chartPEATEtoneBurst.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);
        }

        private void button24_Click(object sender, EventArgs e)//plota o audiograma da "audiometria de PEAEE"
        {
            chartPEAEE.Series.Clear();// limpa o chart

            //***PARA MONTAR O GRÁFICO***

            int iniciar = 1;
            int finalizar = 15;

            chartPEAEE.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartPEAEE.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;

            string seriesName1 = "grade1OD";
            Series ser1 = chartPEAEE.Series.Add(seriesName1);

            ser1.IsVisibleInLegend = false;
            ser1.ChartType = SeriesChartType.Line;

            ser1.BorderWidth = 1;
            ser1.Color = Color.Black;
            ser1.MarkerStyle = MarkerStyle.None;
            ser1.Points.AddXY(2, -10);  // x, high
            ser1.Points.AddXY(2, 120);


            string seriesName2 = "grade2OD";
            Series ser2 = chartPEAEE.Series.Add(seriesName2);

            ser2.IsVisibleInLegend = false;
            ser2.ChartType = SeriesChartType.Line;

            ser2.BorderWidth = 1;
            ser2.Color = Color.Black;
            ser2.MarkerStyle = MarkerStyle.None;
            ser2.Points.AddXY(4, -10);  // x, high
            ser2.Points.AddXY(4, 120);

            string seriesName3 = "grade3OD";
            Series ser3 = chartPEAEE.Series.Add(seriesName3);

            ser3.IsVisibleInLegend = false;
            ser3.ChartType = SeriesChartType.Line;

            ser3.BorderWidth = 1;
            ser3.Color = Color.Black;
            ser3.MarkerStyle = MarkerStyle.None;
            ser3.Points.AddXY(6, -10);  // x, high
            ser3.Points.AddXY(6, 120);

            string seriesName4 = "grade4OD";
            Series ser4 = chartPEAEE.Series.Add(seriesName4);

            ser4.IsVisibleInLegend = false;
            ser4.ChartType = SeriesChartType.Line;

            ser4.BorderWidth = 1;
            ser4.Color = Color.Black;
            ser4.MarkerStyle = MarkerStyle.None;
            ser4.BorderDashStyle = ChartDashStyle.Dash;
            ser4.Points.AddXY(7.25, -10);  // x, high
            ser4.Points.AddXY(7.25, 120);

            string seriesName5 = "grade5OD";
            Series ser5 = chartPEAEE.Series.Add(seriesName5);

            ser5.IsVisibleInLegend = false;
            ser5.ChartType = SeriesChartType.Line;

            ser5.BorderWidth = 1;
            ser5.Color = Color.Black;
            ser5.MarkerStyle = MarkerStyle.None;
            ser5.Points.AddXY(8, -10);  // x, high
            ser5.Points.AddXY(8, 120);

            string seriesName6 = "grade6OD";
            Series ser6 = chartPEAEE.Series.Add(seriesName6);

            ser6.IsVisibleInLegend = false;
            ser6.ChartType = SeriesChartType.Line;

            ser6.BorderWidth = 1;
            ser6.Color = Color.Black;
            ser6.MarkerStyle = MarkerStyle.None;
            ser6.BorderDashStyle = ChartDashStyle.Dash;
            ser6.Points.AddXY(9.25, -10);  // x, high
            ser6.Points.AddXY(9.25, 120);

            string seriesName7 = "grade7OD";
            Series ser7 = chartPEAEE.Series.Add(seriesName7);

            ser7.IsVisibleInLegend = false;
            ser7.ChartType = SeriesChartType.Line;

            ser7.BorderWidth = 1;
            ser7.Color = Color.Black;
            ser7.MarkerStyle = MarkerStyle.None;
            ser7.Points.AddXY(10, -10);  // x, high
            ser7.Points.AddXY(10, 120);

            string seriesName7a = "grade8OD";
            Series ser7a = chartPEAEE.Series.Add(seriesName7a);

            ser7a.IsVisibleInLegend = false;
            ser7a.ChartType = SeriesChartType.Line;

            ser7a.BorderDashStyle = ChartDashStyle.Dash;
            ser7a.BorderWidth = 1;
            ser7a.Color = Color.Black;
            ser7a.MarkerStyle = MarkerStyle.None;
            ser7a.Points.AddXY(11.25, -10);  // x, high
            ser7a.Points.AddXY(11.25, 120);

            string seriesName9a = "grade9OD";
            Series ser9a = chartPEAEE.Series.Add(seriesName9a);

            ser9a.IsVisibleInLegend = false;
            ser9a.ChartType = SeriesChartType.Line;

            ser9a.BorderWidth = 1;
            ser9a.Color = Color.Black;
            ser9a.MarkerStyle = MarkerStyle.None;
            ser9a.Points.AddXY(12, -10);  // x, high
            ser9a.Points.AddXY(12, 120);

            string seriesName10a = "grade10OD";
            Series ser10a = chartPEAEE.Series.Add(seriesName10a);

            ser10a.IsVisibleInLegend = false;
            ser10a.ChartType = SeriesChartType.Line;

            ser10a.BorderDashStyle = ChartDashStyle.Dash;
            ser10a.BorderWidth = 1;
            ser10a.Color = Color.Black;
            ser10a.MarkerStyle = MarkerStyle.None;
            ser10a.Points.AddXY(13.25, -10);  // x, high
            ser10a.Points.AddXY(13.25, 120);

            string seriesName11a = "grade11OD";
            Series ser11a = chartPEAEE.Series.Add(seriesName11a);

            ser11a.IsVisibleInLegend = false;
            ser11a.ChartType = SeriesChartType.Line;

            ser11a.BorderWidth = 1;
            ser11a.Color = Color.Black;
            ser11a.MarkerStyle = MarkerStyle.None;
            ser11a.Points.AddXY(14, -10);  // x, high
            ser11a.Points.AddXY(14, 120);

            string seriesName12a = "grade12OD";
            Series ser12a = chartPEAEE.Series.Add(seriesName12a);

            ser12a.IsVisibleInLegend = false;
            ser12a.ChartType = SeriesChartType.Line;

            ser12a.BorderWidth = 1;
            ser12a.Color = Color.Black;
            ser12a.MarkerStyle = MarkerStyle.None;
            ser12a.Points.AddXY(15, -10);  // x, high
            ser12a.Points.AddXY(15, 120);
        }
    }
}
