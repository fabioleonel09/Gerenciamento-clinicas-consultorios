
namespace segmentoOtoneurologia
{
    partial class frmBlocoNotas
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
            System.Windows.Forms.Label nomeNotaLabel;
            System.Windows.Forms.Label dataNotaLabel;
            System.Windows.Forms.Label anotacoesLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlocoNotas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaBlocoNotasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaBlocoNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaBlocoNotasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBloquear = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaBlocoNotasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarNotas = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gbAnotações = new System.Windows.Forms.GroupBox();
            this.anotacoesTextBox = new System.Windows.Forms.TextBox();
            this.dataNotaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeNotaTextBox = new System.Windows.Forms.TextBox();
            this.tabelaBlocoNotasTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaBlocoNotasTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            nomeNotaLabel = new System.Windows.Forms.Label();
            dataNotaLabel = new System.Windows.Forms.Label();
            anotacoesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBlocoNotasBindingNavigator)).BeginInit();
            this.tabelaBlocoNotasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBlocoNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBlocoNotasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbAnotações.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeNotaLabel
            // 
            nomeNotaLabel.AutoSize = true;
            nomeNotaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeNotaLabel.ForeColor = System.Drawing.Color.DarkOrange;
            nomeNotaLabel.Location = new System.Drawing.Point(4, 22);
            nomeNotaLabel.Name = "nomeNotaLabel";
            nomeNotaLabel.Size = new System.Drawing.Size(121, 19);
            nomeNotaLabel.TabIndex = 0;
            nomeNotaLabel.Text = "Nome da nota:";
            // 
            // dataNotaLabel
            // 
            dataNotaLabel.AutoSize = true;
            dataNotaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataNotaLabel.ForeColor = System.Drawing.Color.DarkOrange;
            dataNotaLabel.Location = new System.Drawing.Point(206, 22);
            dataNotaLabel.Name = "dataNotaLabel";
            dataNotaLabel.Size = new System.Drawing.Size(111, 19);
            dataNotaLabel.TabIndex = 2;
            dataNotaLabel.Text = "Data da nota:";
            // 
            // anotacoesLabel
            // 
            anotacoesLabel.AutoSize = true;
            anotacoesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anotacoesLabel.ForeColor = System.Drawing.Color.DarkOrange;
            anotacoesLabel.Location = new System.Drawing.Point(4, 72);
            anotacoesLabel.Name = "anotacoesLabel";
            anotacoesLabel.Size = new System.Drawing.Size(97, 19);
            anotacoesLabel.TabIndex = 4;
            anotacoesLabel.Text = "Anotações:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaBlocoNotasBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.86487F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.13514F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelaBlocoNotasBindingNavigator
            // 
            this.tabelaBlocoNotasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaBlocoNotasBindingNavigator.BindingSource = this.tabelaBlocoNotasBindingSource;
            this.tabelaBlocoNotasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaBlocoNotasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaBlocoNotasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaBlocoNotasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaBlocoNotasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaBlocoNotasBindingNavigatorSaveItem,
            this.toolStripButtonEditar,
            this.toolStripButtonBloquear});
            this.tabelaBlocoNotasBindingNavigator.Location = new System.Drawing.Point(1, 277);
            this.tabelaBlocoNotasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaBlocoNotasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaBlocoNotasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaBlocoNotasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaBlocoNotasBindingNavigator.Name = "tabelaBlocoNotasBindingNavigator";
            this.tabelaBlocoNotasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaBlocoNotasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabelaBlocoNotasBindingNavigator.Size = new System.Drawing.Size(648, 93);
            this.tabelaBlocoNotasBindingNavigator.TabIndex = 1;
            this.tabelaBlocoNotasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::segmentoOtoneurologia.Properties.Resources.add;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tabelaBlocoNotasBindingSource
            // 
            this.tabelaBlocoNotasBindingSource.DataMember = "tabelaBlocoNotas";
            this.tabelaBlocoNotasBindingSource.DataSource = this.segmsaude001DataSet;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 90);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 90);
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::segmentoOtoneurologia.Properties.Resources.volta;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 90);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::segmentoOtoneurologia.Properties.Resources.adiantar;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tabelaBlocoNotasBindingNavigatorSaveItem
            // 
            this.tabelaBlocoNotasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaBlocoNotasBindingNavigatorSaveItem.Image = global::segmentoOtoneurologia.Properties.Resources.salve2;
            this.tabelaBlocoNotasBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaBlocoNotasBindingNavigatorSaveItem.Name = "tabelaBlocoNotasBindingNavigatorSaveItem";
            this.tabelaBlocoNotasBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 90);
            this.tabelaBlocoNotasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaBlocoNotasBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaBlocoNotasBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = global::segmentoOtoneurologia.Properties.Resources.editar;
            this.toolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(52, 90);
            this.toolStripButtonEditar.Text = "Editar conteúdo";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripButtonBloquear
            // 
            this.toolStripButtonBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBloquear.Image = global::segmentoOtoneurologia.Properties.Resources.bloquear;
            this.toolStripButtonBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBloquear.Name = "toolStripButtonBloquear";
            this.toolStripButtonBloquear.Size = new System.Drawing.Size(52, 90);
            this.toolStripButtonBloquear.Text = "Salvar e bloquear";
            this.toolStripButtonBloquear.Click += new System.EventHandler(this.toolStripButtonBloquear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.35413F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.64587F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbAnotações, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 269);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tabelaBlocoNotasDataGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(345, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15385F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84615F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(293, 261);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tabelaBlocoNotasDataGridView
            // 
            this.tabelaBlocoNotasDataGridView.AllowUserToAddRows = false;
            this.tabelaBlocoNotasDataGridView.AllowUserToDeleteRows = false;
            this.tabelaBlocoNotasDataGridView.AutoGenerateColumns = false;
            this.tabelaBlocoNotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaBlocoNotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabelaBlocoNotasDataGridView.DataSource = this.tabelaBlocoNotasBindingSource;
            this.tabelaBlocoNotasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaBlocoNotasDataGridView.Location = new System.Drawing.Point(4, 4);
            this.tabelaBlocoNotasDataGridView.Name = "tabelaBlocoNotasDataGridView";
            this.tabelaBlocoNotasDataGridView.ReadOnly = true;
            this.tabelaBlocoNotasDataGridView.Size = new System.Drawing.Size(285, 151);
            this.tabelaBlocoNotasDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeNota";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataNota";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "anotacoes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Anotações:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisarNotas);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(160, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "e";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entre:";
            // 
            // btnPesquisarNotas
            // 
            this.btnPesquisarNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarNotas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarNotas.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPesquisarNotas.Location = new System.Drawing.Point(179, 58);
            this.btnPesquisarNotas.Name = "btnPesquisarNotas";
            this.btnPesquisarNotas.Size = new System.Drawing.Size(100, 31);
            this.btnPesquisarNotas.TabIndex = 2;
            this.btnPesquisarNotas.Text = "Pesquisar";
            this.btnPesquisarNotas.UseVisualStyleBackColor = true;
            this.btnPesquisarNotas.Click += new System.EventHandler(this.btnPesquisarNotas_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(179, 25);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(59, 25);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // gbAnotações
            // 
            this.gbAnotações.Controls.Add(anotacoesLabel);
            this.gbAnotações.Controls.Add(this.anotacoesTextBox);
            this.gbAnotações.Controls.Add(dataNotaLabel);
            this.gbAnotações.Controls.Add(this.dataNotaDateTimePicker);
            this.gbAnotações.Controls.Add(nomeNotaLabel);
            this.gbAnotações.Controls.Add(this.nomeNotaTextBox);
            this.gbAnotações.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnotações.Location = new System.Drawing.Point(4, 4);
            this.gbAnotações.Name = "gbAnotações";
            this.gbAnotações.Size = new System.Drawing.Size(334, 261);
            this.gbAnotações.TabIndex = 1;
            this.gbAnotações.TabStop = false;
            this.gbAnotações.Text = "Anotações";
            // 
            // anotacoesTextBox
            // 
            this.anotacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBlocoNotasBindingSource, "anotacoes", true));
            this.anotacoesTextBox.Location = new System.Drawing.Point(6, 93);
            this.anotacoesTextBox.Multiline = true;
            this.anotacoesTextBox.Name = "anotacoesTextBox";
            this.anotacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.anotacoesTextBox.Size = new System.Drawing.Size(322, 162);
            this.anotacoesTextBox.TabIndex = 5;
            // 
            // dataNotaDateTimePicker
            // 
            this.dataNotaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabelaBlocoNotasBindingSource, "dataNota", true));
            this.dataNotaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNotaDateTimePicker.Location = new System.Drawing.Point(209, 43);
            this.dataNotaDateTimePicker.Name = "dataNotaDateTimePicker";
            this.dataNotaDateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.dataNotaDateTimePicker.TabIndex = 3;
            // 
            // nomeNotaTextBox
            // 
            this.nomeNotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaBlocoNotasBindingSource, "nomeNota", true));
            this.nomeNotaTextBox.Location = new System.Drawing.Point(6, 43);
            this.nomeNotaTextBox.Name = "nomeNotaTextBox";
            this.nomeNotaTextBox.Size = new System.Drawing.Size(197, 26);
            this.nomeNotaTextBox.TabIndex = 1;
            // 
            // tabelaBlocoNotasTableAdapter
            // 
            this.tabelaBlocoNotasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaAgendamentoTableAdapter = null;
            this.tableAdapterManager.tabelaBlocoNotasTableAdapter = this.tabelaBlocoNotasTableAdapter;
            this.tableAdapterManager.tabelaCadastroSenhasTableAdapter = null;
            this.tableAdapterManager.tabelaContatosTableAdapter = null;
            this.tableAdapterManager.tabelaEstoqueTableAdapter = null;
            this.tableAdapterManager.tabelaExamesTableAdapter = null;
            this.tableAdapterManager.tabelaLaudario1TableAdapter = null;
            this.tableAdapterManager.tabelaLaudarioTableAdapter = null;
            this.tableAdapterManager.tabelaOcupacionalTableAdapter = null;
            this.tableAdapterManager.tabelaOtoneuroTableAdapter = null;
            this.tableAdapterManager.tabelaPacienteTableAdapter = null;
            this.tableAdapterManager.tabelaProntuarioTableAdapter = null;
            this.tableAdapterManager.tabelaReceituarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmBlocoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(650, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBlocoNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloco de notas";
            this.Load += new System.EventHandler(this.frmBlocoNotas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBlocoNotasBindingNavigator)).EndInit();
            this.tabelaBlocoNotasBindingNavigator.ResumeLayout(false);
            this.tabelaBlocoNotasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBlocoNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBlocoNotasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAnotações.ResumeLayout(false);
            this.gbAnotações.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaBlocoNotasBindingSource;
        private segmsaude001DataSetTableAdapters.tabelaBlocoNotasTableAdapter tabelaBlocoNotasTableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaBlocoNotasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaBlocoNotasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaBlocoNotasDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAnotações;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBloquear;
        private System.Windows.Forms.TextBox anotacoesTextBox;
        private System.Windows.Forms.DateTimePicker dataNotaDateTimePicker;
        private System.Windows.Forms.TextBox nomeNotaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnPesquisarNotas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}