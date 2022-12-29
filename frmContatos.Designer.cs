
namespace segmentoOtoneurologia
{
    partial class frmContatos
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
            System.Windows.Forms.Label nomeContatoLabel;
            System.Windows.Forms.Label tipoContatoLabel;
            System.Windows.Forms.Label celularContatoLabel;
            System.Windows.Forms.Label telefoneContatoLabel;
            System.Windows.Forms.Label emailContatoLabel;
            System.Windows.Forms.Label observacaoContatoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContatos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaContatosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaContatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmsaude001DataSet = new segmentoOtoneurologia.segmsaude001DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaContatosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBloquear = new System.Windows.Forms.ToolStripButton();
            this.tabelaContatosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarContatos = new System.Windows.Forms.GroupBox();
            this.txtBuscarContato = new System.Windows.Forms.TextBox();
            this.gbAdicionarContato = new System.Windows.Forms.GroupBox();
            this.observacaoContatoTextBox = new System.Windows.Forms.TextBox();
            this.emailContatoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneContatoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularContatoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tipoContatoComboBox = new System.Windows.Forms.ComboBox();
            this.nomeContatoTextBox = new System.Windows.Forms.TextBox();
            this.tabelaContatosTableAdapter = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.tabelaContatosTableAdapter();
            this.tableAdapterManager = new segmentoOtoneurologia.segmsaude001DataSetTableAdapters.TableAdapterManager();
            nomeContatoLabel = new System.Windows.Forms.Label();
            tipoContatoLabel = new System.Windows.Forms.Label();
            celularContatoLabel = new System.Windows.Forms.Label();
            telefoneContatoLabel = new System.Windows.Forms.Label();
            emailContatoLabel = new System.Windows.Forms.Label();
            observacaoContatoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaContatosBindingNavigator)).BeginInit();
            this.tabelaContatosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaContatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaContatosDataGridView)).BeginInit();
            this.gbBuscarContatos.SuspendLayout();
            this.gbAdicionarContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeContatoLabel
            // 
            nomeContatoLabel.AutoSize = true;
            nomeContatoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeContatoLabel.ForeColor = System.Drawing.Color.Sienna;
            nomeContatoLabel.Location = new System.Drawing.Point(6, 22);
            nomeContatoLabel.Name = "nomeContatoLabel";
            nomeContatoLabel.Size = new System.Drawing.Size(146, 19);
            nomeContatoLabel.TabIndex = 0;
            nomeContatoLabel.Text = "Nome do contato:";
            // 
            // tipoContatoLabel
            // 
            tipoContatoLabel.AutoSize = true;
            tipoContatoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoContatoLabel.ForeColor = System.Drawing.Color.Sienna;
            tipoContatoLabel.Location = new System.Drawing.Point(380, 22);
            tipoContatoLabel.Name = "tipoContatoLabel";
            tipoContatoLabel.Size = new System.Drawing.Size(134, 19);
            tipoContatoLabel.TabIndex = 2;
            tipoContatoLabel.Text = "Tipo de contato:";
            // 
            // celularContatoLabel
            // 
            celularContatoLabel.AutoSize = true;
            celularContatoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularContatoLabel.ForeColor = System.Drawing.Color.Sienna;
            celularContatoLabel.Location = new System.Drawing.Point(6, 72);
            celularContatoLabel.Name = "celularContatoLabel";
            celularContatoLabel.Size = new System.Drawing.Size(69, 19);
            celularContatoLabel.TabIndex = 4;
            celularContatoLabel.Text = "Celular:";
            // 
            // telefoneContatoLabel
            // 
            telefoneContatoLabel.AutoSize = true;
            telefoneContatoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneContatoLabel.ForeColor = System.Drawing.Color.Sienna;
            telefoneContatoLabel.Location = new System.Drawing.Point(144, 72);
            telefoneContatoLabel.Name = "telefoneContatoLabel";
            telefoneContatoLabel.Size = new System.Drawing.Size(80, 19);
            telefoneContatoLabel.TabIndex = 6;
            telefoneContatoLabel.Text = "Telefone:";
            // 
            // emailContatoLabel
            // 
            emailContatoLabel.AutoSize = true;
            emailContatoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailContatoLabel.ForeColor = System.Drawing.Color.Sienna;
            emailContatoLabel.Location = new System.Drawing.Point(276, 72);
            emailContatoLabel.Name = "emailContatoLabel";
            emailContatoLabel.Size = new System.Drawing.Size(62, 19);
            emailContatoLabel.TabIndex = 8;
            emailContatoLabel.Text = "E-mail:";
            // 
            // observacaoContatoLabel
            // 
            observacaoContatoLabel.AutoSize = true;
            observacaoContatoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacaoContatoLabel.ForeColor = System.Drawing.Color.Sienna;
            observacaoContatoLabel.Location = new System.Drawing.Point(6, 122);
            observacaoContatoLabel.Name = "observacaoContatoLabel";
            observacaoContatoLabel.Size = new System.Drawing.Size(107, 19);
            observacaoContatoLabel.TabIndex = 10;
            observacaoContatoLabel.Text = "Observação:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabelaContatosBindingNavigator, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tabelaContatosDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbBuscarContatos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbAdicionarContato, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.07143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.92857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabelaContatosBindingNavigator
            // 
            this.tabelaContatosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaContatosBindingNavigator.BindingSource = this.tabelaContatosBindingSource;
            this.tabelaContatosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaContatosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaContatosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaContatosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaContatosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaContatosBindingNavigatorSaveItem,
            this.toolStripButtonEditar,
            this.toolStripButtonBloquear});
            this.tabelaContatosBindingNavigator.Location = new System.Drawing.Point(1, 458);
            this.tabelaContatosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaContatosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaContatosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaContatosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaContatosBindingNavigator.Name = "tabelaContatosBindingNavigator";
            this.tabelaContatosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaContatosBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabelaContatosBindingNavigator.Size = new System.Drawing.Size(587, 77);
            this.tabelaContatosBindingNavigator.TabIndex = 1;
            this.tabelaContatosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::segmentoOtoneurologia.Properties.Resources.add;
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 74);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tabelaContatosBindingSource
            // 
            this.tabelaContatosBindingSource.DataMember = "tabelaContatos";
            this.tabelaContatosBindingSource.DataSource = this.segmsaude001DataSet;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 74);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 74);
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 74);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::segmentoOtoneurologia.Properties.Resources.volta;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 74);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 74);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::segmentoOtoneurologia.Properties.Resources.adiantar;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 74);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tabelaContatosBindingNavigatorSaveItem
            // 
            this.tabelaContatosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaContatosBindingNavigatorSaveItem.Image = global::segmentoOtoneurologia.Properties.Resources.salve2;
            this.tabelaContatosBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaContatosBindingNavigatorSaveItem.Name = "tabelaContatosBindingNavigatorSaveItem";
            this.tabelaContatosBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 74);
            this.tabelaContatosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaContatosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaContatosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = global::segmentoOtoneurologia.Properties.Resources.editar;
            this.toolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(52, 74);
            this.toolStripButtonEditar.Text = "Editar dados";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripButtonBloquear
            // 
            this.toolStripButtonBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBloquear.Image = global::segmentoOtoneurologia.Properties.Resources.bloquear;
            this.toolStripButtonBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBloquear.Name = "toolStripButtonBloquear";
            this.toolStripButtonBloquear.Size = new System.Drawing.Size(52, 74);
            this.toolStripButtonBloquear.Text = "Bloquear e salvar";
            this.toolStripButtonBloquear.Click += new System.EventHandler(this.toolStripButtonBloquear_Click);
            // 
            // tabelaContatosDataGridView
            // 
            this.tabelaContatosDataGridView.AllowUserToAddRows = false;
            this.tabelaContatosDataGridView.AllowUserToDeleteRows = false;
            this.tabelaContatosDataGridView.AutoGenerateColumns = false;
            this.tabelaContatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaContatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tabelaContatosDataGridView.DataSource = this.tabelaContatosBindingSource;
            this.tabelaContatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaContatosDataGridView.Location = new System.Drawing.Point(4, 303);
            this.tabelaContatosDataGridView.Name = "tabelaContatosDataGridView";
            this.tabelaContatosDataGridView.ReadOnly = true;
            this.tabelaContatosDataGridView.Size = new System.Drawing.Size(581, 151);
            this.tabelaContatosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeContato";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipoContato";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo de contato";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "celularContato";
            this.dataGridViewTextBoxColumn4.HeaderText = "Celular:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefoneContato";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "emailContato";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "observacaoContato";
            this.dataGridViewTextBoxColumn7.HeaderText = "Observações:";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // gbBuscarContatos
            // 
            this.gbBuscarContatos.Controls.Add(this.txtBuscarContato);
            this.gbBuscarContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBuscarContatos.Location = new System.Drawing.Point(4, 216);
            this.gbBuscarContatos.Name = "gbBuscarContatos";
            this.gbBuscarContatos.Size = new System.Drawing.Size(581, 80);
            this.gbBuscarContatos.TabIndex = 2;
            this.gbBuscarContatos.TabStop = false;
            this.gbBuscarContatos.Text = "Buscar nome do contato";
            // 
            // txtBuscarContato
            // 
            this.txtBuscarContato.Location = new System.Drawing.Point(148, 30);
            this.txtBuscarContato.Name = "txtBuscarContato";
            this.txtBuscarContato.Size = new System.Drawing.Size(270, 26);
            this.txtBuscarContato.TabIndex = 0;
            this.txtBuscarContato.TextChanged += new System.EventHandler(this.txtBuscarContato_TextChanged);
            // 
            // gbAdicionarContato
            // 
            this.gbAdicionarContato.Controls.Add(observacaoContatoLabel);
            this.gbAdicionarContato.Controls.Add(this.observacaoContatoTextBox);
            this.gbAdicionarContato.Controls.Add(emailContatoLabel);
            this.gbAdicionarContato.Controls.Add(this.emailContatoTextBox);
            this.gbAdicionarContato.Controls.Add(telefoneContatoLabel);
            this.gbAdicionarContato.Controls.Add(this.telefoneContatoMaskedTextBox);
            this.gbAdicionarContato.Controls.Add(celularContatoLabel);
            this.gbAdicionarContato.Controls.Add(this.celularContatoMaskedTextBox);
            this.gbAdicionarContato.Controls.Add(tipoContatoLabel);
            this.gbAdicionarContato.Controls.Add(this.tipoContatoComboBox);
            this.gbAdicionarContato.Controls.Add(nomeContatoLabel);
            this.gbAdicionarContato.Controls.Add(this.nomeContatoTextBox);
            this.gbAdicionarContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAdicionarContato.Location = new System.Drawing.Point(4, 4);
            this.gbAdicionarContato.Name = "gbAdicionarContato";
            this.gbAdicionarContato.Size = new System.Drawing.Size(581, 205);
            this.gbAdicionarContato.TabIndex = 3;
            this.gbAdicionarContato.TabStop = false;
            this.gbAdicionarContato.Text = "Adicionar contato";
            // 
            // observacaoContatoTextBox
            // 
            this.observacaoContatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaContatosBindingSource, "observacaoContato", true));
            this.observacaoContatoTextBox.Location = new System.Drawing.Point(6, 143);
            this.observacaoContatoTextBox.Multiline = true;
            this.observacaoContatoTextBox.Name = "observacaoContatoTextBox";
            this.observacaoContatoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaoContatoTextBox.Size = new System.Drawing.Size(567, 56);
            this.observacaoContatoTextBox.TabIndex = 11;
            // 
            // emailContatoTextBox
            // 
            this.emailContatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaContatosBindingSource, "emailContato", true));
            this.emailContatoTextBox.Location = new System.Drawing.Point(276, 93);
            this.emailContatoTextBox.Name = "emailContatoTextBox";
            this.emailContatoTextBox.Size = new System.Drawing.Size(297, 26);
            this.emailContatoTextBox.TabIndex = 9;
            // 
            // telefoneContatoMaskedTextBox
            // 
            this.telefoneContatoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaContatosBindingSource, "telefoneContato", true));
            this.telefoneContatoMaskedTextBox.Location = new System.Drawing.Point(144, 93);
            this.telefoneContatoMaskedTextBox.Mask = "(99) 9999-9999";
            this.telefoneContatoMaskedTextBox.Name = "telefoneContatoMaskedTextBox";
            this.telefoneContatoMaskedTextBox.Size = new System.Drawing.Size(126, 26);
            this.telefoneContatoMaskedTextBox.TabIndex = 7;
            this.telefoneContatoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // celularContatoMaskedTextBox
            // 
            this.celularContatoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaContatosBindingSource, "celularContato", true));
            this.celularContatoMaskedTextBox.Location = new System.Drawing.Point(6, 93);
            this.celularContatoMaskedTextBox.Mask = "(99) 99999-9999";
            this.celularContatoMaskedTextBox.Name = "celularContatoMaskedTextBox";
            this.celularContatoMaskedTextBox.Size = new System.Drawing.Size(132, 26);
            this.celularContatoMaskedTextBox.TabIndex = 5;
            this.celularContatoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipoContatoComboBox
            // 
            this.tipoContatoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaContatosBindingSource, "tipoContato", true));
            this.tipoContatoComboBox.FormattingEnabled = true;
            this.tipoContatoComboBox.Items.AddRange(new object[] {
            "",
            "Pessoal",
            "Comercial",
            "Profissional"});
            this.tipoContatoComboBox.Location = new System.Drawing.Point(383, 43);
            this.tipoContatoComboBox.Name = "tipoContatoComboBox";
            this.tipoContatoComboBox.Size = new System.Drawing.Size(190, 26);
            this.tipoContatoComboBox.TabIndex = 3;
            // 
            // nomeContatoTextBox
            // 
            this.nomeContatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaContatosBindingSource, "nomeContato", true));
            this.nomeContatoTextBox.Location = new System.Drawing.Point(6, 43);
            this.nomeContatoTextBox.Name = "nomeContatoTextBox";
            this.nomeContatoTextBox.Size = new System.Drawing.Size(371, 26);
            this.nomeContatoTextBox.TabIndex = 1;
            // 
            // tabelaContatosTableAdapter
            // 
            this.tabelaContatosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaAgendamentoTableAdapter = null;
            this.tableAdapterManager.tabelaBlocoNotasTableAdapter = null;
            this.tableAdapterManager.tabelaCadastroSenhasTableAdapter = null;
            this.tableAdapterManager.tabelaContatosTableAdapter = this.tabelaContatosTableAdapter;
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
            // frmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(589, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.frmContatos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaContatosBindingNavigator)).EndInit();
            this.tabelaContatosBindingNavigator.ResumeLayout(false);
            this.tabelaContatosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaContatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmsaude001DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaContatosDataGridView)).EndInit();
            this.gbBuscarContatos.ResumeLayout(false);
            this.gbBuscarContatos.PerformLayout();
            this.gbAdicionarContato.ResumeLayout(false);
            this.gbAdicionarContato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private segmsaude001DataSet segmsaude001DataSet;
        private System.Windows.Forms.BindingSource tabelaContatosBindingSource;
        private segmsaude001DataSetTableAdapters.tabelaContatosTableAdapter tabelaContatosTableAdapter;
        private segmsaude001DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaContatosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaContatosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaContatosDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBloquear;
        private System.Windows.Forms.GroupBox gbBuscarContatos;
        private System.Windows.Forms.TextBox txtBuscarContato;
        private System.Windows.Forms.GroupBox gbAdicionarContato;
        private System.Windows.Forms.TextBox observacaoContatoTextBox;
        private System.Windows.Forms.TextBox emailContatoTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneContatoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularContatoMaskedTextBox;
        private System.Windows.Forms.ComboBox tipoContatoComboBox;
        private System.Windows.Forms.TextBox nomeContatoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}