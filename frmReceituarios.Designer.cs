
namespace segmentoOtoneurologia
{
    partial class frmReceituarios
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
            System.Windows.Forms.Label nomeReceituarioLabel;
            System.Windows.Forms.Label descricaoReceituarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceituarios));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaReceituarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaReceituarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaReceituarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBloquear = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaReceituarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbReceituários = new System.Windows.Forms.GroupBox();
            this.descricaoReceituarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeReceituarioTextBox = new System.Windows.Forms.TextBox();
            this.gbNomeReceituario = new System.Windows.Forms.GroupBox();
            this.txtBuscarReceituario = new System.Windows.Forms.TextBox();
            this.tabelaReceituarioTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaReceituarioTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            nomeReceituarioLabel = new System.Windows.Forms.Label();
            descricaoReceituarioLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReceituarioBindingNavigator)).BeginInit();
            this.tabelaReceituarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReceituarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReceituarioDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbReceituários.SuspendLayout();
            this.gbNomeReceituario.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeReceituarioLabel
            // 
            nomeReceituarioLabel.AutoSize = true;
            nomeReceituarioLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeReceituarioLabel.ForeColor = System.Drawing.Color.Green;
            nomeReceituarioLabel.Location = new System.Drawing.Point(6, 22);
            nomeReceituarioLabel.Name = "nomeReceituarioLabel";
            nomeReceituarioLabel.Size = new System.Drawing.Size(173, 19);
            nomeReceituarioLabel.TabIndex = 0;
            nomeReceituarioLabel.Text = "Nome  do receituário:";
            // 
            // descricaoReceituarioLabel
            // 
            descricaoReceituarioLabel.AutoSize = true;
            descricaoReceituarioLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoReceituarioLabel.ForeColor = System.Drawing.Color.Green;
            descricaoReceituarioLabel.Location = new System.Drawing.Point(6, 72);
            descricaoReceituarioLabel.Name = "descricaoReceituarioLabel";
            descricaoReceituarioLabel.Size = new System.Drawing.Size(92, 19);
            descricaoReceituarioLabel.TabIndex = 2;
            descricaoReceituarioLabel.Text = "Descrição:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaReceituarioBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.60073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.39927F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelaReceituarioBindingNavigator
            // 
            this.tabelaReceituarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaReceituarioBindingNavigator.BindingSource = this.tabelaReceituarioBindingSource;
            this.tabelaReceituarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaReceituarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaReceituarioBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaReceituarioBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaReceituarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaReceituarioBindingNavigatorSaveItem,
            this.toolStripButtonEditar,
            this.toolStripButtonBloquear});
            this.tabelaReceituarioBindingNavigator.Location = new System.Drawing.Point(1, 405);
            this.tabelaReceituarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaReceituarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaReceituarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaReceituarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaReceituarioBindingNavigator.Name = "tabelaReceituarioBindingNavigator";
            this.tabelaReceituarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaReceituarioBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabelaReceituarioBindingNavigator.Size = new System.Drawing.Size(711, 86);
            this.tabelaReceituarioBindingNavigator.TabIndex = 1;
            this.tabelaReceituarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::segmentoOtoneurologia.Properties.Resources.add;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 83);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // tabelaReceituarioBindingSource
            // 
            this.tabelaReceituarioBindingSource.DataMember = "tabelaReceituario";
            this.tabelaReceituarioBindingSource.DataSource = this.segmsaude001DataSet;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 83);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 83);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::segmentoOtoneurologia.Properties.Resources.retroceder;
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 83);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::segmentoOtoneurologia.Properties.Resources.volta;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 83);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 26);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 83);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::segmentoOtoneurologia.Properties.Resources.adiantar;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 83);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tabelaReceituarioBindingNavigatorSaveItem
            // 
            this.tabelaReceituarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaReceituarioBindingNavigatorSaveItem.Image = global::segmentoOtoneurologia.Properties.Resources.salve2;
            this.tabelaReceituarioBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaReceituarioBindingNavigatorSaveItem.Name = "tabelaReceituarioBindingNavigatorSaveItem";
            this.tabelaReceituarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 83);
            this.tabelaReceituarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaReceituarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaReceituarioBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = global::segmentoOtoneurologia.Properties.Resources.editar;
            this.toolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(52, 83);
            this.toolStripButtonEditar.Text = "Editar dados";
            // 
            // toolStripButtonBloquear
            // 
            this.toolStripButtonBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBloquear.Image = global::segmentoOtoneurologia.Properties.Resources.bloquear;
            this.toolStripButtonBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBloquear.Name = "toolStripButtonBloquear";
            this.toolStripButtonBloquear.Size = new System.Drawing.Size(52, 83);
            this.toolStripButtonBloquear.Text = "Bloquear e salvar ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.4F));
            this.tableLayoutPanel2.Controls.Add(this.tabelaReceituarioDataGridView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 397);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabelaReceituarioDataGridView
            // 
            this.tabelaReceituarioDataGridView.AllowUserToAddRows = false;
            this.tabelaReceituarioDataGridView.AllowUserToDeleteRows = false;
            this.tabelaReceituarioDataGridView.AutoGenerateColumns = false;
            this.tabelaReceituarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaReceituarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tabelaReceituarioDataGridView.DataSource = this.tabelaReceituarioBindingSource;
            this.tabelaReceituarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaReceituarioDataGridView.Location = new System.Drawing.Point(409, 4);
            this.tabelaReceituarioDataGridView.Name = "tabelaReceituarioDataGridView";
            this.tabelaReceituarioDataGridView.ReadOnly = true;
            this.tabelaReceituarioDataGridView.Size = new System.Drawing.Size(292, 389);
            this.tabelaReceituarioDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeReceituario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do receituário:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descricaoReceituario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gbReceituários, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbNomeReceituario, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.38145F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.61856F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 389);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // gbReceituários
            // 
            this.gbReceituários.Controls.Add(descricaoReceituarioLabel);
            this.gbReceituários.Controls.Add(this.descricaoReceituarioTextBox);
            this.gbReceituários.Controls.Add(nomeReceituarioLabel);
            this.gbReceituários.Controls.Add(this.nomeReceituarioTextBox);
            this.gbReceituários.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReceituários.Location = new System.Drawing.Point(4, 4);
            this.gbReceituários.Name = "gbReceituários";
            this.gbReceituários.Size = new System.Drawing.Size(390, 300);
            this.gbReceituários.TabIndex = 0;
            this.gbReceituários.TabStop = false;
            this.gbReceituários.Text = "Receituários";
            // 
            // descricaoReceituarioTextBox
            // 
            this.descricaoReceituarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaReceituarioBindingSource, "descricaoReceituario", true));
            this.descricaoReceituarioTextBox.Location = new System.Drawing.Point(9, 93);
            this.descricaoReceituarioTextBox.Multiline = true;
            this.descricaoReceituarioTextBox.Name = "descricaoReceituarioTextBox";
            this.descricaoReceituarioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoReceituarioTextBox.Size = new System.Drawing.Size(375, 201);
            this.descricaoReceituarioTextBox.TabIndex = 3;
            // 
            // nomeReceituarioTextBox
            // 
            this.nomeReceituarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaReceituarioBindingSource, "nomeReceituario", true));
            this.nomeReceituarioTextBox.Location = new System.Drawing.Point(9, 43);
            this.nomeReceituarioTextBox.Name = "nomeReceituarioTextBox";
            this.nomeReceituarioTextBox.Size = new System.Drawing.Size(375, 26);
            this.nomeReceituarioTextBox.TabIndex = 1;
            // 
            // gbNomeReceituario
            // 
            this.gbNomeReceituario.Controls.Add(this.txtBuscarReceituario);
            this.gbNomeReceituario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNomeReceituario.Location = new System.Drawing.Point(4, 311);
            this.gbNomeReceituario.Name = "gbNomeReceituario";
            this.gbNomeReceituario.Size = new System.Drawing.Size(390, 74);
            this.gbNomeReceituario.TabIndex = 1;
            this.gbNomeReceituario.TabStop = false;
            this.gbNomeReceituario.Text = "Buscar por nome do receituário";
            // 
            // txtBuscarReceituario
            // 
            this.txtBuscarReceituario.Location = new System.Drawing.Point(10, 31);
            this.txtBuscarReceituario.Name = "txtBuscarReceituario";
            this.txtBuscarReceituario.Size = new System.Drawing.Size(374, 26);
            this.txtBuscarReceituario.TabIndex = 0;
            this.txtBuscarReceituario.TextChanged += new System.EventHandler(this.txtBuscarReceituario_TextChanged);
            // 
            // tabelaReceituarioTableAdapter
            // 
            this.tabelaReceituarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tabelaOtoneuroTableAdapter = null;
            this.tableAdapterManager.tabelaPacienteTableAdapter = null;
            this.tableAdapterManager.tabelaProntuarioTableAdapter = null;
            this.tableAdapterManager.tabelaReceituarioTableAdapter = this.tabelaReceituarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmReceituarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(713, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReceituarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receituários";
            this.Load += new System.EventHandler(this.frmReceituarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReceituarioBindingNavigator)).EndInit();
            this.tabelaReceituarioBindingNavigator.ResumeLayout(false);
            this.tabelaReceituarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReceituarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReceituarioDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gbReceituários.ResumeLayout(false);
            this.gbReceituários.PerformLayout();
            this.gbNomeReceituario.ResumeLayout(false);
            this.gbNomeReceituario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaReceituarioBindingSource;
        private segmsaude001DataSetTableAdapters.tabelaReceituarioTableAdapter tabelaReceituarioTableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaReceituarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaReceituarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaReceituarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gbReceituários;
        private System.Windows.Forms.TextBox descricaoReceituarioTextBox;
        private System.Windows.Forms.TextBox nomeReceituarioTextBox;
        private System.Windows.Forms.GroupBox gbNomeReceituario;
        private System.Windows.Forms.TextBox txtBuscarReceituario;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBloquear;
    }
}