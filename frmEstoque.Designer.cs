
namespace segmentoOtoneurologia
{
    partial class frmEstoque
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
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label quantidadeProdutoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaEstoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaEstoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.tabelaEstoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.codigoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.gbRetirar = new System.Windows.Forms.GroupBox();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.gbBuscarProduto = new System.Windows.Forms.GroupBox();
            this.txtBuscarProduto = new System.Windows.Forms.TextBox();
            this.tabelaEstoqueTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaEstoqueTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            quantidadeProdutoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEstoqueBindingNavigator)).BeginInit();
            this.tabelaEstoqueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEstoqueDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbCadastrarProduto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRetirar.SuspendLayout();
            this.gbBuscarProduto.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoProdutoLabel.Location = new System.Drawing.Point(6, 57);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(160, 19);
            codigoProdutoLabel.TabIndex = 2;
            codigoProdutoLabel.Text = "Código do produto:";
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeProdutoLabel.Location = new System.Drawing.Point(6, 89);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(149, 19);
            nomeProdutoLabel.TabIndex = 4;
            nomeProdutoLabel.Text = "Nome do produto:";
            // 
            // quantidadeProdutoLabel
            // 
            quantidadeProdutoLabel.AutoSize = true;
            quantidadeProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeProdutoLabel.Location = new System.Drawing.Point(6, 121);
            quantidadeProdutoLabel.Name = "quantidadeProdutoLabel";
            quantidadeProdutoLabel.Size = new System.Drawing.Size(196, 19);
            quantidadeProdutoLabel.TabIndex = 6;
            quantidadeProdutoLabel.Text = "Quantidade em estoque:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.31956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.68044F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaEstoqueBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabelaEstoqueDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbBuscarProduto, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.52291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47709F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 742);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelaEstoqueBindingNavigator
            // 
            this.tabelaEstoqueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaEstoqueBindingNavigator.BindingSource = this.tabelaEstoqueBindingSource;
            this.tabelaEstoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaEstoqueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaEstoqueBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaEstoqueBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaEstoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaEstoqueBindingNavigatorSaveItem,
            this.toolStripButtonEditar});
            this.tabelaEstoqueBindingNavigator.Location = new System.Drawing.Point(1, 641);
            this.tabelaEstoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaEstoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaEstoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaEstoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaEstoqueBindingNavigator.Name = "tabelaEstoqueBindingNavigator";
            this.tabelaEstoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaEstoqueBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabelaEstoqueBindingNavigator.Size = new System.Drawing.Size(741, 100);
            this.tabelaEstoqueBindingNavigator.TabIndex = 1;
            this.tabelaEstoqueBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tabelaEstoqueBindingSource
            // 
            this.tabelaEstoqueBindingSource.DataMember = "tabelaEstoque";
            this.tabelaEstoqueBindingSource.DataSource = this.segmsaude001DataSet;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // tabelaEstoqueBindingNavigatorSaveItem
            // 
            this.tabelaEstoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaEstoqueBindingNavigatorSaveItem.Image = global::segmentoOtoneurologia.Properties.Resources.salve2;
            this.tabelaEstoqueBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaEstoqueBindingNavigatorSaveItem.Name = "tabelaEstoqueBindingNavigatorSaveItem";
            this.tabelaEstoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 97);
            this.tabelaEstoqueBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaEstoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaEstoqueBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = global::segmentoOtoneurologia.Properties.Resources.editar;
            this.toolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(52, 97);
            this.toolStripButtonEditar.Text = "Editar cadastro";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // tabelaEstoqueDataGridView
            // 
            this.tabelaEstoqueDataGridView.AllowUserToAddRows = false;
            this.tabelaEstoqueDataGridView.AllowUserToDeleteRows = false;
            this.tabelaEstoqueDataGridView.AutoGenerateColumns = false;
            this.tabelaEstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaEstoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabelaEstoqueDataGridView.DataSource = this.tabelaEstoqueBindingSource;
            this.tabelaEstoqueDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaEstoqueDataGridView.Location = new System.Drawing.Point(4, 4);
            this.tabelaEstoqueDataGridView.Name = "tabelaEstoqueDataGridView";
            this.tabelaEstoqueDataGridView.ReadOnly = true;
            this.tabelaEstoqueDataGridView.Size = new System.Drawing.Size(735, 633);
            this.tabelaEstoqueDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código do produto:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomeProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome/descrição do produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 415;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantidadeProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade em estoque:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gbRetirar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRetirar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(746, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.06329F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.42405F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.82911F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 633);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbCadastrarProduto
            // 
            this.gbCadastrarProduto.Controls.Add(codigoProdutoLabel);
            this.gbCadastrarProduto.Controls.Add(this.codigoProdutoTextBox);
            this.gbCadastrarProduto.Controls.Add(nomeProdutoLabel);
            this.gbCadastrarProduto.Controls.Add(this.nomeProdutoTextBox);
            this.gbCadastrarProduto.Controls.Add(quantidadeProdutoLabel);
            this.gbCadastrarProduto.Controls.Add(this.quantidadeProdutoTextBox);
            this.gbCadastrarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCadastrarProduto.Location = new System.Drawing.Point(3, 3);
            this.gbCadastrarProduto.Name = "gbCadastrarProduto";
            this.gbCadastrarProduto.Size = new System.Drawing.Size(325, 163);
            this.gbCadastrarProduto.TabIndex = 0;
            this.gbCadastrarProduto.TabStop = false;
            this.gbCadastrarProduto.Text = "Cadastrar produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legenda de cores";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(174, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "estoque vazio";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(174, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Estoque esgotando";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Estoque reduzindo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Em estoque";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // codigoProdutoTextBox
            // 
            this.codigoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaEstoqueBindingSource, "codigoProduto", true));
            this.codigoProdutoTextBox.Location = new System.Drawing.Point(172, 54);
            this.codigoProdutoTextBox.Name = "codigoProdutoTextBox";
            this.codigoProdutoTextBox.Size = new System.Drawing.Size(147, 26);
            this.codigoProdutoTextBox.TabIndex = 3;
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaEstoqueBindingSource, "nomeProduto", true));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(172, 86);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(147, 26);
            this.nomeProdutoTextBox.TabIndex = 5;
            // 
            // quantidadeProdutoTextBox
            // 
            this.quantidadeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaEstoqueBindingSource, "quantidadeProduto", true));
            this.quantidadeProdutoTextBox.Location = new System.Drawing.Point(210, 118);
            this.quantidadeProdutoTextBox.Name = "quantidadeProdutoTextBox";
            this.quantidadeProdutoTextBox.Size = new System.Drawing.Size(109, 26);
            this.quantidadeProdutoTextBox.TabIndex = 7;
            this.quantidadeProdutoTextBox.TextChanged += new System.EventHandler(this.quantidadeProdutoTextBox_TextChanged);
            // 
            // gbRetirar
            // 
            this.gbRetirar.Controls.Add(this.txtRetirar);
            this.gbRetirar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRetirar.Location = new System.Drawing.Point(4, 350);
            this.gbRetirar.Name = "gbRetirar";
            this.gbRetirar.Size = new System.Drawing.Size(331, 159);
            this.gbRetirar.TabIndex = 1;
            this.gbRetirar.TabStop = false;
            this.gbRetirar.Text = "Quantos retirar?";
            // 
            // txtRetirar
            // 
            this.txtRetirar.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetirar.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtRetirar.Location = new System.Drawing.Point(90, 29);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(168, 118);
            this.txtRetirar.TabIndex = 0;
            this.txtRetirar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.MistyRose;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.Color.Red;
            this.btnRetirar.Image = global::segmentoOtoneurologia.Properties.Resources.remove;
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetirar.Location = new System.Drawing.Point(4, 516);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(331, 113);
            this.btnRetirar.TabIndex = 2;
            this.btnRetirar.Text = "Retira";
            this.btnRetirar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // gbBuscarProduto
            // 
            this.gbBuscarProduto.Controls.Add(this.txtBuscarProduto);
            this.gbBuscarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBuscarProduto.Location = new System.Drawing.Point(746, 644);
            this.gbBuscarProduto.Name = "gbBuscarProduto";
            this.gbBuscarProduto.Size = new System.Drawing.Size(339, 94);
            this.gbBuscarProduto.TabIndex = 2;
            this.gbBuscarProduto.TabStop = false;
            this.gbBuscarProduto.Text = "Buscar produto por nome";
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Location = new System.Drawing.Point(34, 41);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Size = new System.Drawing.Size(279, 26);
            this.txtBuscarProduto.TabIndex = 0;
            this.txtBuscarProduto.TextChanged += new System.EventHandler(this.txtBuscarProduto_TextChanged);
            // 
            // tabelaEstoqueTableAdapter
            // 
            this.tabelaEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaAgendamentoTableAdapter = null;
            this.tableAdapterManager.tabelaBlocoNotasTableAdapter = null;
            this.tableAdapterManager.tabelaCadastroSenhasTableAdapter = null;
            this.tableAdapterManager.tabelaContatosTableAdapter = null;
            this.tableAdapterManager.tabelaEstoqueTableAdapter = this.tabelaEstoqueTableAdapter;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gbCadastrarProduto, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 339);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1089, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEstoqueBindingNavigator)).EndInit();
            this.tabelaEstoqueBindingNavigator.ResumeLayout(false);
            this.tabelaEstoqueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEstoqueDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbCadastrarProduto.ResumeLayout(false);
            this.gbCadastrarProduto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbRetirar.ResumeLayout(false);
            this.gbRetirar.PerformLayout();
            this.gbBuscarProduto.ResumeLayout(false);
            this.gbBuscarProduto.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaEstoqueBindingSource;
        private segmsaude001DataSetTableAdapters.tabelaEstoqueTableAdapter tabelaEstoqueTableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaEstoqueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaEstoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaEstoqueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox gbCadastrarProduto;
        private System.Windows.Forms.GroupBox gbRetirar;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.GroupBox gbBuscarProduto;
        private System.Windows.Forms.TextBox txtBuscarProduto;
        private System.Windows.Forms.TextBox codigoProdutoTextBox;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox quantidadeProdutoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}