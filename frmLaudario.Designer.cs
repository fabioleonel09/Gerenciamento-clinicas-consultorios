
namespace segmentoOtoneurologia
{
    partial class frmLaudario
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
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label nomeLaudoLabel;
            System.Windows.Forms.Label descricaoLaudoLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaLaudario1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaLaudario1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaLaudario1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBloquear = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaLaudario1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNovoLaudo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarLaudo = new System.Windows.Forms.TextBox();
            this.descricaoLaudoTextBox = new System.Windows.Forms.TextBox();
            this.nomeLaudoTextBox = new System.Windows.Forms.TextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.tabelaLaudario1TableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaLaudario1TableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            categoriaLabel = new System.Windows.Forms.Label();
            nomeLaudoLabel = new System.Windows.Forms.Label();
            descricaoLaudoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLaudario1BindingNavigator)).BeginInit();
            this.tabelaLaudario1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLaudario1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLaudario1DataGridView)).BeginInit();
            this.gbNovoLaudo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.ForeColor = System.Drawing.Color.Green;
            categoriaLabel.Location = new System.Drawing.Point(6, 22);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(89, 19);
            categoriaLabel.TabIndex = 0;
            categoriaLabel.Text = "Categoria:";
            // 
            // nomeLaudoLabel
            // 
            nomeLaudoLabel.AutoSize = true;
            nomeLaudoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLaudoLabel.ForeColor = System.Drawing.Color.Green;
            nomeLaudoLabel.Location = new System.Drawing.Point(144, 22);
            nomeLaudoLabel.Name = "nomeLaudoLabel";
            nomeLaudoLabel.Size = new System.Drawing.Size(131, 19);
            nomeLaudoLabel.TabIndex = 2;
            nomeLaudoLabel.Text = "Nome do laudo:";
            // 
            // descricaoLaudoLabel
            // 
            descricaoLaudoLabel.AutoSize = true;
            descricaoLaudoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLaudoLabel.ForeColor = System.Drawing.Color.Green;
            descricaoLaudoLabel.Location = new System.Drawing.Point(7, 72);
            descricaoLaudoLabel.Name = "descricaoLaudoLabel";
            descricaoLaudoLabel.Size = new System.Drawing.Size(92, 19);
            descricaoLaudoLabel.TabIndex = 4;
            descricaoLaudoLabel.Text = "Descrição:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaLaudario1BindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.99818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelaLaudario1BindingNavigator
            // 
            this.tabelaLaudario1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaLaudario1BindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.tabelaLaudario1BindingNavigator.BindingSource = this.tabelaLaudario1BindingSource;
            this.tabelaLaudario1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaLaudario1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaLaudario1BindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaLaudario1BindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaLaudario1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaLaudario1BindingNavigatorSaveItem,
            this.toolStripEditar,
            this.toolStripBloquear});
            this.tabelaLaudario1BindingNavigator.Location = new System.Drawing.Point(1, 465);
            this.tabelaLaudario1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaLaudario1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaLaudario1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaLaudario1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaLaudario1BindingNavigator.Name = "tabelaLaudario1BindingNavigator";
            this.tabelaLaudario1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaLaudario1BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabelaLaudario1BindingNavigator.Size = new System.Drawing.Size(754, 84);
            this.tabelaLaudario1BindingNavigator.TabIndex = 1;
            this.tabelaLaudario1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::segmentoOtoneurologia.Properties.Resources.add;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 81);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tabelaLaudario1BindingSource
            // 
            this.tabelaLaudario1BindingSource.DataMember = "tabelaLaudario1";
            this.tabelaLaudario1BindingSource.DataSource = this.segmsaude001DataSet;
            // 
            // segmsaude001DataSet
            // 
            this.segmsaude001DataSet.DataSetName = "segmsaude001DataSet";
            this.segmsaude001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 81);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 81);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::segmentoOtoneurologia.Properties.Resources.retroceder;
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 81);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::segmentoOtoneurologia.Properties.Resources.volta;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 81);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 81);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::segmentoOtoneurologia.Properties.Resources.adiantar;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 81);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tabelaLaudario1BindingNavigatorSaveItem
            // 
            this.tabelaLaudario1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaLaudario1BindingNavigatorSaveItem.Image = global::segmentoOtoneurologia.Properties.Resources.salve2;
            this.tabelaLaudario1BindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaLaudario1BindingNavigatorSaveItem.Name = "tabelaLaudario1BindingNavigatorSaveItem";
            this.tabelaLaudario1BindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 81);
            this.tabelaLaudario1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaLaudario1BindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaLaudario1BindingNavigatorSaveItem_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditar.Image = global::segmentoOtoneurologia.Properties.Resources.editar;
            this.toolStripEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(52, 81);
            this.toolStripEditar.Text = "Editar dados";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripBloquear
            // 
            this.toolStripBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBloquear.Image = global::segmentoOtoneurologia.Properties.Resources.bloquear;
            this.toolStripBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBloquear.Name = "toolStripBloquear";
            this.toolStripBloquear.Size = new System.Drawing.Size(52, 81);
            this.toolStripBloquear.Text = "Salvar e bloquear";
            this.toolStripBloquear.ToolTipText = "Salvar e bloquear";
            this.toolStripBloquear.Click += new System.EventHandler(this.toolStripBloquear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabelaLaudario1DataGridView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbNovoLaudo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(748, 457);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabelaLaudario1DataGridView
            // 
            this.tabelaLaudario1DataGridView.AllowUserToAddRows = false;
            this.tabelaLaudario1DataGridView.AllowUserToDeleteRows = false;
            this.tabelaLaudario1DataGridView.AutoGenerateColumns = false;
            this.tabelaLaudario1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaLaudario1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabelaLaudario1DataGridView.DataSource = this.tabelaLaudario1BindingSource;
            this.tabelaLaudario1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaLaudario1DataGridView.Location = new System.Drawing.Point(377, 4);
            this.tabelaLaudario1DataGridView.Name = "tabelaLaudario1DataGridView";
            this.tabelaLaudario1DataGridView.ReadOnly = true;
            this.tabelaLaudario1DataGridView.Size = new System.Drawing.Size(367, 449);
            this.tabelaLaudario1DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomeLaudo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do laudo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descricaoLaudo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição do laudo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // gbNovoLaudo
            // 
            this.gbNovoLaudo.Controls.Add(this.groupBox1);
            this.gbNovoLaudo.Controls.Add(descricaoLaudoLabel);
            this.gbNovoLaudo.Controls.Add(this.descricaoLaudoTextBox);
            this.gbNovoLaudo.Controls.Add(nomeLaudoLabel);
            this.gbNovoLaudo.Controls.Add(this.nomeLaudoTextBox);
            this.gbNovoLaudo.Controls.Add(categoriaLabel);
            this.gbNovoLaudo.Controls.Add(this.categoriaComboBox);
            this.gbNovoLaudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNovoLaudo.Location = new System.Drawing.Point(4, 4);
            this.gbNovoLaudo.Name = "gbNovoLaudo";
            this.gbNovoLaudo.Size = new System.Drawing.Size(366, 449);
            this.gbNovoLaudo.TabIndex = 1;
            this.gbNovoLaudo.TabStop = false;
            this.gbNovoLaudo.Text = "Novo laudo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarLaudo);
            this.groupBox1.Location = new System.Drawing.Point(9, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar laudo";
            // 
            // txtBuscarLaudo
            // 
            this.txtBuscarLaudo.Location = new System.Drawing.Point(6, 40);
            this.txtBuscarLaudo.Name = "txtBuscarLaudo";
            this.txtBuscarLaudo.Size = new System.Drawing.Size(339, 26);
            this.txtBuscarLaudo.TabIndex = 0;
            this.txtBuscarLaudo.TextChanged += new System.EventHandler(this.txtBuscarLaudo_TextChanged);
            // 
            // descricaoLaudoTextBox
            // 
            this.descricaoLaudoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaLaudario1BindingSource, "descricaoLaudo", true));
            this.descricaoLaudoTextBox.Location = new System.Drawing.Point(9, 93);
            this.descricaoLaudoTextBox.Multiline = true;
            this.descricaoLaudoTextBox.Name = "descricaoLaudoTextBox";
            this.descricaoLaudoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoLaudoTextBox.Size = new System.Drawing.Size(351, 249);
            this.descricaoLaudoTextBox.TabIndex = 5;
            // 
            // nomeLaudoTextBox
            // 
            this.nomeLaudoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaLaudario1BindingSource, "nomeLaudo", true));
            this.nomeLaudoTextBox.Location = new System.Drawing.Point(147, 43);
            this.nomeLaudoTextBox.Name = "nomeLaudoTextBox";
            this.nomeLaudoTextBox.Size = new System.Drawing.Size(213, 26);
            this.nomeLaudoTextBox.TabIndex = 3;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaLaudario1BindingSource, "categoria", true));
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "",
            "Exames",
            "Médico",
            "Terapêutico",
            "Parecer"});
            this.categoriaComboBox.Location = new System.Drawing.Point(9, 43);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(132, 26);
            this.categoriaComboBox.TabIndex = 1;
            // 
            // tabelaLaudario1TableAdapter
            // 
            this.tabelaLaudario1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaAgendamentoTableAdapter = null;
            this.tableAdapterManager.tabelaBlocoNotasTableAdapter = null;
            this.tableAdapterManager.tabelaCadastroSenhasTableAdapter = null;
            this.tableAdapterManager.tabelaContatosTableAdapter = null;
            this.tableAdapterManager.tabelaEstoqueTableAdapter = null;
            this.tableAdapterManager.tabelaExamesTableAdapter = null;
            this.tableAdapterManager.tabelaLaudario1TableAdapter = this.tabelaLaudario1TableAdapter;
            this.tableAdapterManager.tabelaLaudarioTableAdapter = null;
            this.tableAdapterManager.tabelaOcupacionalTableAdapter = null;
            this.tableAdapterManager.tabelaOtoneuroTableAdapter = null;
            this.tableAdapterManager.tabelaPacienteTableAdapter = null;
            this.tableAdapterManager.tabelaProntuarioTableAdapter = null;
            this.tableAdapterManager.tabelaReceituarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLaudario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(756, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLaudario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laudário";
            this.Load += new System.EventHandler(this.frmLaudario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLaudario1BindingNavigator)).EndInit();
            this.tabelaLaudario1BindingNavigator.ResumeLayout(false);
            this.tabelaLaudario1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLaudario1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLaudario1DataGridView)).EndInit();
            this.gbNovoLaudo.ResumeLayout(false);
            this.gbNovoLaudo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaLaudario1BindingSource;
        private segmsaude001DataSetTableAdapters.tabelaLaudario1TableAdapter tabelaLaudario1TableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaLaudario1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaLaudario1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaLaudario1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripBloquear;
        private System.Windows.Forms.GroupBox gbNovoLaudo;
        private System.Windows.Forms.TextBox descricaoLaudoTextBox;
        private System.Windows.Forms.TextBox nomeLaudoTextBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarLaudo;
    }
}