
namespace segmentoOtoneurologia
{
    partial class frmCadastroOtoneurologia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomePacienteLabel;
            System.Windows.Forms.Label identificacaoLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label dataExameLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label exameRealizadoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroOtoneurologia));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaOtoneuroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaOtoneuroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaOtoneuroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtomEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBloquear = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExames = new System.Windows.Forms.Button();
            this.tabelaOtoneuroDataGridView = new System.Windows.Forms.DataGridView();
            this.gbCadastrarOtoneuro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBuscarCadastrado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCadastrado = new System.Windows.Forms.Button();
            this.rbEntre = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbIdentificacao = new System.Windows.Forms.RadioButton();
            this.rbBuscarNome = new System.Windows.Forms.RadioButton();
            this.idadePacienteNovoTextBox = new System.Windows.Forms.TextBox();
            this.exameRealizadoComboBox = new System.Windows.Forms.ComboBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.dataExameDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.identificacaoTextBox = new System.Windows.Forms.TextBox();
            this.nomePacienteTextBox = new System.Windows.Forms.TextBox();
            this.tabelaOtoneuroTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaOtoneuroTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            this.txtBuscarOtoneuro = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadePacienteNovo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomePacienteLabel = new System.Windows.Forms.Label();
            identificacaoLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            dataExameLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            exameRealizadoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOtoneuroBindingNavigator)).BeginInit();
            this.tabelaOtoneuroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOtoneuroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOtoneuroDataGridView)).BeginInit();
            this.gbCadastrarOtoneuro.SuspendLayout();
            this.gbBuscarCadastrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomePacienteLabel
            // 
            nomePacienteLabel.AutoSize = true;
            nomePacienteLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomePacienteLabel.Location = new System.Drawing.Point(6, 22);
            nomePacienteLabel.Name = "nomePacienteLabel";
            nomePacienteLabel.Size = new System.Drawing.Size(153, 19);
            nomePacienteLabel.TabIndex = 0;
            nomePacienteLabel.Text = "Nome do paciente:";
            // 
            // identificacaoLabel
            // 
            identificacaoLabel.AutoSize = true;
            identificacaoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identificacaoLabel.Location = new System.Drawing.Point(207, 72);
            identificacaoLabel.Name = "identificacaoLabel";
            identificacaoLabel.Size = new System.Drawing.Size(112, 19);
            identificacaoLabel.TabIndex = 2;
            identificacaoLabel.Text = "Identificação:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataNascimentoLabel.Location = new System.Drawing.Point(427, 22);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(39, 19);
            dataNascimentoLabel.TabIndex = 4;
            dataNascimentoLabel.Text = "DN:";
            // 
            // dataExameLabel
            // 
            dataExameLabel.AutoSize = true;
            dataExameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataExameLabel.Location = new System.Drawing.Point(426, 72);
            dataExameLabel.Name = "dataExameLabel";
            dataExameLabel.Size = new System.Drawing.Size(128, 19);
            dataExameLabel.TabIndex = 8;
            dataExameLabel.Text = "Data do exame:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empresaLabel.Location = new System.Drawing.Point(6, 122);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(83, 19);
            empresaLabel.TabIndex = 10;
            empresaLabel.Text = "Empresa:";
            // 
            // exameRealizadoLabel
            // 
            exameRealizadoLabel.AutoSize = true;
            exameRealizadoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exameRealizadoLabel.Location = new System.Drawing.Point(224, 122);
            exameRealizadoLabel.Name = "exameRealizadoLabel";
            exameRealizadoLabel.Size = new System.Drawing.Size(141, 19);
            exameRealizadoLabel.TabIndex = 12;
            exameRealizadoLabel.Text = "Exame realizado:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.56757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaOtoneuroBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabelaOtoneuroDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbCadastrarOtoneuro, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.59184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelaOtoneuroBindingNavigator
            // 
            this.tabelaOtoneuroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaOtoneuroBindingNavigator.BindingSource = this.tabelaOtoneuroBindingSource;
            this.tabelaOtoneuroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaOtoneuroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaOtoneuroBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaOtoneuroBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaOtoneuroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaOtoneuroBindingNavigatorSaveItem,
            this.toolStripButtomEditar,
            this.toolStripButtonBloquear});
            this.tabelaOtoneuroBindingNavigator.Location = new System.Drawing.Point(1, 389);
            this.tabelaOtoneuroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaOtoneuroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaOtoneuroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaOtoneuroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaOtoneuroBindingNavigator.Name = "tabelaOtoneuroBindingNavigator";
            this.tabelaOtoneuroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaOtoneuroBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabelaOtoneuroBindingNavigator.Size = new System.Drawing.Size(598, 100);
            this.tabelaOtoneuroBindingNavigator.TabIndex = 1;
            this.tabelaOtoneuroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::segmentoOtoneurologia.Properties.Resources.add;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 97);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // tabelaOtoneuroBindingSource
            // 
            this.tabelaOtoneuroBindingSource.DataMember = "tabelaOtoneuro";
            this.tabelaOtoneuroBindingSource.DataSource = this.segmsaude001DataSet;
            // 
            // segmsaude001DataSet
            // 
            this.segmsaude001DataSet.DataSetName = "segmsaude001DataSet";
            this.segmsaude001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 97);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::segmentoOtoneurologia.Properties.Resources.apagar;
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 97);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::segmentoOtoneurologia.Properties.Resources.retroceder;
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 97);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::segmentoOtoneurologia.Properties.Resources.volta;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 97);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::segmentoOtoneurologia.Properties.Resources.vai;
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 97);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::segmentoOtoneurologia.Properties.Resources.adiantar;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 97);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tabelaOtoneuroBindingNavigatorSaveItem
            // 
            this.tabelaOtoneuroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaOtoneuroBindingNavigatorSaveItem.Image = global::segmentoOtoneurologia.Properties.Resources.salve2;
            this.tabelaOtoneuroBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaOtoneuroBindingNavigatorSaveItem.Name = "tabelaOtoneuroBindingNavigatorSaveItem";
            this.tabelaOtoneuroBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 97);
            this.tabelaOtoneuroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaOtoneuroBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaOtoneuroBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtomEditar
            // 
            this.toolStripButtomEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtomEditar.Image = global::segmentoOtoneurologia.Properties.Resources.editar;
            this.toolStripButtomEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtomEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtomEditar.Name = "toolStripButtomEditar";
            this.toolStripButtomEditar.Size = new System.Drawing.Size(52, 97);
            this.toolStripButtomEditar.Text = "Editar dados";
            // 
            // toolStripButtonBloquear
            // 
            this.toolStripButtonBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBloquear.Image = global::segmentoOtoneurologia.Properties.Resources.bloquear;
            this.toolStripButtonBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBloquear.Name = "toolStripButtonBloquear";
            this.toolStripButtonBloquear.Size = new System.Drawing.Size(52, 97);
            this.toolStripButtonBloquear.Text = "Salvar e bloquear";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnExames, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(603, 392);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnExames
            // 
            this.btnExames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExames.Image = global::segmentoOtoneurologia.Properties.Resources.fonesMenores;
            this.btnExames.Location = new System.Drawing.Point(97, 3);
            this.btnExames.Name = "btnExames";
            this.btnExames.Size = new System.Drawing.Size(88, 88);
            this.btnExames.TabIndex = 0;
            this.btnExames.UseVisualStyleBackColor = true;
            this.btnExames.Click += new System.EventHandler(this.btnExames_Click);
            // 
            // tabelaOtoneuroDataGridView
            // 
            this.tabelaOtoneuroDataGridView.AllowUserToAddRows = false;
            this.tabelaOtoneuroDataGridView.AllowUserToDeleteRows = false;
            this.tabelaOtoneuroDataGridView.AutoGenerateColumns = false;
            this.tabelaOtoneuroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaOtoneuroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.idadePacienteNovo,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tabelaOtoneuroDataGridView.DataSource = this.tabelaOtoneuroBindingSource;
            this.tabelaOtoneuroDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaOtoneuroDataGridView.Location = new System.Drawing.Point(603, 4);
            this.tabelaOtoneuroDataGridView.Name = "tabelaOtoneuroDataGridView";
            this.tabelaOtoneuroDataGridView.ReadOnly = true;
            this.tabelaOtoneuroDataGridView.Size = new System.Drawing.Size(282, 381);
            this.tabelaOtoneuroDataGridView.TabIndex = 1;
            // 
            // gbCadastrarOtoneuro
            // 
            this.gbCadastrarOtoneuro.Controls.Add(this.label2);
            this.gbCadastrarOtoneuro.Controls.Add(this.gbBuscarCadastrado);
            this.gbCadastrarOtoneuro.Controls.Add(this.idadePacienteNovoTextBox);
            this.gbCadastrarOtoneuro.Controls.Add(exameRealizadoLabel);
            this.gbCadastrarOtoneuro.Controls.Add(this.exameRealizadoComboBox);
            this.gbCadastrarOtoneuro.Controls.Add(empresaLabel);
            this.gbCadastrarOtoneuro.Controls.Add(this.empresaTextBox);
            this.gbCadastrarOtoneuro.Controls.Add(dataExameLabel);
            this.gbCadastrarOtoneuro.Controls.Add(this.dataExameDateTimePicker);
            this.gbCadastrarOtoneuro.Controls.Add(dataNascimentoLabel);
            this.gbCadastrarOtoneuro.Controls.Add(this.dataNascimentoDateTimePicker);
            this.gbCadastrarOtoneuro.Controls.Add(identificacaoLabel);
            this.gbCadastrarOtoneuro.Controls.Add(this.identificacaoTextBox);
            this.gbCadastrarOtoneuro.Controls.Add(nomePacienteLabel);
            this.gbCadastrarOtoneuro.Controls.Add(this.nomePacienteTextBox);
            this.gbCadastrarOtoneuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCadastrarOtoneuro.Location = new System.Drawing.Point(4, 4);
            this.gbCadastrarOtoneuro.Name = "gbCadastrarOtoneuro";
            this.gbCadastrarOtoneuro.Size = new System.Drawing.Size(592, 381);
            this.gbCadastrarOtoneuro.TabIndex = 2;
            this.gbCadastrarOtoneuro.TabStop = false;
            this.gbCadastrarOtoneuro.Text = "Cadastrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Idade:";
            // 
            // gbBuscarCadastrado
            // 
            this.gbBuscarCadastrado.Controls.Add(this.txtBuscarOtoneuro);
            this.gbBuscarCadastrado.Controls.Add(this.label1);
            this.gbBuscarCadastrado.Controls.Add(this.maskedTextBox3);
            this.gbBuscarCadastrado.Controls.Add(this.maskedTextBox1);
            this.gbBuscarCadastrado.Controls.Add(this.btnBuscarCadastrado);
            this.gbBuscarCadastrado.Controls.Add(this.rbEntre);
            this.gbBuscarCadastrado.Controls.Add(this.rbEmpresa);
            this.gbBuscarCadastrado.Controls.Add(this.rbIdentificacao);
            this.gbBuscarCadastrado.Controls.Add(this.rbBuscarNome);
            this.gbBuscarCadastrado.Location = new System.Drawing.Point(6, 175);
            this.gbBuscarCadastrado.Name = "gbBuscarCadastrado";
            this.gbBuscarCadastrado.Size = new System.Drawing.Size(580, 200);
            this.gbBuscarCadastrado.TabIndex = 14;
            this.gbBuscarCadastrado.TabStop = false;
            this.gbBuscarCadastrado.Text = "Buscar cadastrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "e";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(305, 133);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox3.TabIndex = 8;
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(161, 133);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btnBuscarCadastrado
            // 
            this.btnBuscarCadastrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCadastrado.Image = global::segmentoOtoneurologia.Properties.Resources.buscarusuario;
            this.btnBuscarCadastrado.Location = new System.Drawing.Point(440, 64);
            this.btnBuscarCadastrado.Name = "btnBuscarCadastrado";
            this.btnBuscarCadastrado.Size = new System.Drawing.Size(85, 67);
            this.btnBuscarCadastrado.TabIndex = 5;
            this.btnBuscarCadastrado.UseVisualStyleBackColor = true;
            // 
            // rbEntre
            // 
            this.rbEntre.AutoSize = true;
            this.rbEntre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEntre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntre.Location = new System.Drawing.Point(21, 134);
            this.rbEntre.Name = "rbEntre";
            this.rbEntre.Size = new System.Drawing.Size(134, 23);
            this.rbEntre.TabIndex = 4;
            this.rbEntre.TabStop = true;
            this.rbEntre.Text = "entre as datas";
            this.rbEntre.UseVisualStyleBackColor = true;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.Location = new System.Drawing.Point(21, 105);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(123, 23);
            this.rbEmpresa.TabIndex = 2;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "por empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbIdentificacao
            // 
            this.rbIdentificacao.AutoSize = true;
            this.rbIdentificacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbIdentificacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdentificacao.Location = new System.Drawing.Point(21, 76);
            this.rbIdentificacao.Name = "rbIdentificacao";
            this.rbIdentificacao.Size = new System.Drawing.Size(154, 23);
            this.rbIdentificacao.TabIndex = 1;
            this.rbIdentificacao.TabStop = true;
            this.rbIdentificacao.Text = "por identificação";
            this.rbIdentificacao.UseVisualStyleBackColor = true;
            // 
            // rbBuscarNome
            // 
            this.rbBuscarNome.AutoSize = true;
            this.rbBuscarNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBuscarNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBuscarNome.Location = new System.Drawing.Point(21, 47);
            this.rbBuscarNome.Name = "rbBuscarNome";
            this.rbBuscarNome.Size = new System.Drawing.Size(100, 23);
            this.rbBuscarNome.TabIndex = 0;
            this.rbBuscarNome.TabStop = true;
            this.rbBuscarNome.Text = "por nome";
            this.rbBuscarNome.UseVisualStyleBackColor = true;
            // 
            // idadePacienteNovoTextBox
            // 
            this.idadePacienteNovoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaOtoneuroBindingSource, "idadePacienteNovo", true));
            this.idadePacienteNovoTextBox.Location = new System.Drawing.Point(9, 93);
            this.idadePacienteNovoTextBox.Name = "idadePacienteNovoTextBox";
            this.idadePacienteNovoTextBox.Size = new System.Drawing.Size(196, 26);
            this.idadePacienteNovoTextBox.TabIndex = 15;
            this.idadePacienteNovoTextBox.Click += new System.EventHandler(this.idadePacienteNovoTextBox_Click);
            // 
            // exameRealizadoComboBox
            // 
            this.exameRealizadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaOtoneuroBindingSource, "exameRealizado", true));
            this.exameRealizadoComboBox.FormattingEnabled = true;
            this.exameRealizadoComboBox.Items.AddRange(new object[] {
            "",
            "Audiometria tonal",
            "Audiometria tonal e vocal",
            "Audiometria em campo livre",
            "Audiometria em campo livre (AASI)",
            "Audiometria de Altas frequências",
            "Impedanciometria",
            "Outro (s)"});
            this.exameRealizadoComboBox.Location = new System.Drawing.Point(224, 143);
            this.exameRealizadoComboBox.Name = "exameRealizadoComboBox";
            this.exameRealizadoComboBox.Size = new System.Drawing.Size(362, 26);
            this.exameRealizadoComboBox.TabIndex = 13;
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaOtoneuroBindingSource, "empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(6, 143);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(212, 26);
            this.empresaTextBox.TabIndex = 11;
            // 
            // dataExameDateTimePicker
            // 
            this.dataExameDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabelaOtoneuroBindingSource, "dataExame", true));
            this.dataExameDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataExameDateTimePicker.Location = new System.Drawing.Point(427, 93);
            this.dataExameDateTimePicker.Name = "dataExameDateTimePicker";
            this.dataExameDateTimePicker.Size = new System.Drawing.Size(159, 26);
            this.dataExameDateTimePicker.TabIndex = 9;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabelaOtoneuroBindingSource, "dataNascimento", true));
            this.dataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(427, 43);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(159, 26);
            this.dataNascimentoDateTimePicker.TabIndex = 5;
            // 
            // identificacaoTextBox
            // 
            this.identificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaOtoneuroBindingSource, "identificacao", true));
            this.identificacaoTextBox.Location = new System.Drawing.Point(211, 93);
            this.identificacaoTextBox.Name = "identificacaoTextBox";
            this.identificacaoTextBox.Size = new System.Drawing.Size(210, 26);
            this.identificacaoTextBox.TabIndex = 3;
            // 
            // nomePacienteTextBox
            // 
            this.nomePacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaOtoneuroBindingSource, "nomePaciente", true));
            this.nomePacienteTextBox.Location = new System.Drawing.Point(9, 43);
            this.nomePacienteTextBox.Name = "nomePacienteTextBox";
            this.nomePacienteTextBox.Size = new System.Drawing.Size(412, 26);
            this.nomePacienteTextBox.TabIndex = 1;
            // 
            // tabelaOtoneuroTableAdapter
            // 
            this.tabelaOtoneuroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaAgendamentoTableAdapter = null;
            this.tableAdapterManager.tabelaBlocoNotasTableAdapter = null;
            this.tableAdapterManager.tabelaCadastroSenhasTableAdapter = null;
            this.tableAdapterManager.tabelaContatosTableAdapter = null;
            this.tableAdapterManager.tabelaExamesTableAdapter = null;
            this.tableAdapterManager.tabelaLaudario1TableAdapter = null;
            this.tableAdapterManager.tabelaLaudarioTableAdapter = null;
            this.tableAdapterManager.tabelaOcupacionalTableAdapter = null;
            this.tableAdapterManager.tabelaOtoneuroTableAdapter = this.tabelaOtoneuroTableAdapter;
            this.tableAdapterManager.tabelaPacienteTableAdapter = null;
            this.tableAdapterManager.tabelaProntuarioTableAdapter = null;
            this.tableAdapterManager.tabelaReceituarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBuscarOtoneuro
            // 
            this.txtBuscarOtoneuro.Location = new System.Drawing.Point(190, 46);
            this.txtBuscarOtoneuro.Name = "txtBuscarOtoneuro";
            this.txtBuscarOtoneuro.Size = new System.Drawing.Size(215, 26);
            this.txtBuscarOtoneuro.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "identificacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identificação";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomePaciente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataNascimento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Data nascimento:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // idadePacienteNovo
            // 
            this.idadePacienteNovo.DataPropertyName = "idadePacienteNovo";
            this.idadePacienteNovo.HeaderText = "Idade:";
            this.idadePacienteNovo.Name = "idadePacienteNovo";
            this.idadePacienteNovo.ReadOnly = true;
            this.idadePacienteNovo.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataExame";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data exame:";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "empresa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Empresa:";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "exameRealizado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Exame realizado:";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 300;
            // 
            // frmCadastroOtoneurologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(889, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroOtoneurologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otoneurologia - cadastro";
            this.Load += new System.EventHandler(this.frmCadastroOtoneurologia_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOtoneuroBindingNavigator)).EndInit();
            this.tabelaOtoneuroBindingNavigator.ResumeLayout(false);
            this.tabelaOtoneuroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOtoneuroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOtoneuroDataGridView)).EndInit();
            this.gbCadastrarOtoneuro.ResumeLayout(false);
            this.gbCadastrarOtoneuro.PerformLayout();
            this.gbBuscarCadastrado.ResumeLayout(false);
            this.gbBuscarCadastrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnExames;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaOtoneuroBindingSource;
        private segmsaude001DataSetTableAdapters.tabelaOtoneuroTableAdapter tabelaOtoneuroTableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaOtoneuroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaOtoneuroBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaOtoneuroDataGridView;
        private System.Windows.Forms.GroupBox gbCadastrarOtoneuro;
        private System.Windows.Forms.GroupBox gbBuscarCadastrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnBuscarCadastrado;
        private System.Windows.Forms.RadioButton rbEntre;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbIdentificacao;
        private System.Windows.Forms.RadioButton rbBuscarNome;
        private System.Windows.Forms.ComboBox exameRealizadoComboBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.DateTimePicker dataExameDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox identificacaoTextBox;
        private System.Windows.Forms.TextBox nomePacienteTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtomEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBloquear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idadePacienteNovoTextBox;
        private System.Windows.Forms.TextBox txtBuscarOtoneuro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadePacienteNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}