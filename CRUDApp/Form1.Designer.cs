namespace CRUDApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label lojaCodigoLabel;
            System.Windows.Forms.Label cdMunicipioLabel;
            System.Windows.Forms.Label cPF_CNPJLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label homePageLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label municipioLabel;
            System.Windows.Forms.Label dDDLabel;
            System.Windows.Forms.Label fisicaJuridicaLabel;
            System.Windows.Forms.Label tipoEnderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label dataAberturaLabel;
            System.Windows.Forms.Label label1;
            this.cRUDAppDBDataSet = new CRUDApp.CRUDAppDBDataSet();
            this.lojasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojasTableAdapter = new CRUDApp.CRUDAppDBDataSetTableAdapters.LojasTableAdapter();
            this.tableAdapterManager = new CRUDApp.CRUDAppDBDataSetTableAdapters.TableAdapterManager();
            this.lojasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lojasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lojaCodigoTextBox = new System.Windows.Forms.TextBox();
            this.cdMunicipioTextBox = new System.Windows.Forms.TextBox();
            this.cPF_CNPJTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.homePageTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.municipioTextBox = new System.Windows.Forms.TextBox();
            this.dDDTextBox = new System.Windows.Forms.TextBox();
            this.fisicaJuridicaTextBox = new System.Windows.Forms.TextBox();
            this.tipoEnderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.dataAberturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            codigoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            lojaCodigoLabel = new System.Windows.Forms.Label();
            cdMunicipioLabel = new System.Windows.Forms.Label();
            cPF_CNPJLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            homePageLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            municipioLabel = new System.Windows.Forms.Label();
            dDDLabel = new System.Windows.Forms.Label();
            fisicaJuridicaLabel = new System.Windows.Forms.Label();
            tipoEnderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            dataAberturaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDAppDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojasBindingNavigator)).BeginInit();
            this.lojasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cRUDAppDBDataSet
            // 
            this.cRUDAppDBDataSet.DataSetName = "CRUDAppDBDataSet";
            this.cRUDAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lojasBindingSource
            // 
            this.lojasBindingSource.DataMember = "Lojas";
            this.lojasBindingSource.DataSource = this.cRUDAppDBDataSet;
            // 
            // lojasTableAdapter
            // 
            this.lojasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LojasTableAdapter = this.lojasTableAdapter;
            this.tableAdapterManager.UpdateOrder = CRUDApp.CRUDAppDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lojasBindingNavigator
            // 
            this.lojasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lojasBindingNavigator.BindingSource = this.lojasBindingSource;
            this.lojasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lojasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lojasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lojasBindingNavigatorSaveItem});
            this.lojasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lojasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lojasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lojasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lojasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lojasBindingNavigator.Name = "lojasBindingNavigator";
            this.lojasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lojasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.lojasBindingNavigator.TabIndex = 0;
            this.lojasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // lojasBindingNavigatorSaveItem
            // 
            this.lojasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lojasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lojasBindingNavigatorSaveItem.Image")));
            this.lojasBindingNavigatorSaveItem.Name = "lojasBindingNavigatorSaveItem";
            this.lojasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lojasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lojasBindingNavigatorSaveItem.Click += new System.EventHandler(this.lojasBindingNavigatorSaveItem_Click);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(27, 97);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Código:";
            codigoLabel.Click += new System.EventHandler(this.codigoLabel_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(70, 94);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(46, 20);
            this.codigoTextBox.TabIndex = 2;
            this.codigoTextBox.TextChanged += new System.EventHandler(this.codigoTextBox_TextChanged);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(310, 97);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(348, 94);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(140, 20);
            this.nomeTextBox.TabIndex = 4;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(27, 133);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "Endereço:";
            enderecoLabel.Click += new System.EventHandler(this.enderecoLabel_Click);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(83, 130);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(144, 20);
            this.enderecoTextBox.TabIndex = 6;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.enderecoTextBox_TextChanged);
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(27, 209);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 7;
            estadoLabel.Text = "Estado:";
            estadoLabel.Click += new System.EventHandler(this.estadoLabel_Click);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(70, 206);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(46, 20);
            this.estadoTextBox.TabIndex = 8;
            this.estadoTextBox.TextChanged += new System.EventHandler(this.estadoTextBox_TextChanged);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(364, 284);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(399, 281);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(165, 20);
            this.emailTextBox.TabIndex = 10;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // lojaCodigoLabel
            // 
            lojaCodigoLabel.AutoSize = true;
            lojaCodigoLabel.Location = new System.Drawing.Point(146, 97);
            lojaCodigoLabel.Name = "lojaCodigoLabel";
            lojaCodigoLabel.Size = new System.Drawing.Size(81, 13);
            lojaCodigoLabel.TabIndex = 11;
            lojaCodigoLabel.Text = "Código da Loja:";
            lojaCodigoLabel.Click += new System.EventHandler(this.lojaCodigoLabel_Click);
            // 
            // lojaCodigoTextBox
            // 
            this.lojaCodigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "LojaCodigo", true));
            this.lojaCodigoTextBox.Location = new System.Drawing.Point(227, 94);
            this.lojaCodigoTextBox.Name = "lojaCodigoTextBox";
            this.lojaCodigoTextBox.Size = new System.Drawing.Size(46, 20);
            this.lojaCodigoTextBox.TabIndex = 12;
            this.lojaCodigoTextBox.TextChanged += new System.EventHandler(this.lojaCodigoTextBox_TextChanged);
            // 
            // cdMunicipioLabel
            // 
            cdMunicipioLabel.AutoSize = true;
            cdMunicipioLabel.Location = new System.Drawing.Point(265, 173);
            cdMunicipioLabel.Name = "cdMunicipioLabel";
            cdMunicipioLabel.Size = new System.Drawing.Size(93, 13);
            cdMunicipioLabel.TabIndex = 13;
            cdMunicipioLabel.Text = "Código Município:";
            cdMunicipioLabel.Click += new System.EventHandler(this.cdMunicipioLabel_Click);
            // 
            // cdMunicipioTextBox
            // 
            this.cdMunicipioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "CdMunicipio", true));
            this.cdMunicipioTextBox.Location = new System.Drawing.Point(358, 170);
            this.cdMunicipioTextBox.Name = "cdMunicipioTextBox";
            this.cdMunicipioTextBox.Size = new System.Drawing.Size(130, 20);
            this.cdMunicipioTextBox.TabIndex = 14;
            this.cdMunicipioTextBox.TextChanged += new System.EventHandler(this.cdMunicipioTextBox_TextChanged);
            // 
            // cPF_CNPJLabel
            // 
            cPF_CNPJLabel.AutoSize = true;
            cPF_CNPJLabel.Location = new System.Drawing.Point(28, 247);
            cPF_CNPJLabel.Name = "cPF_CNPJLabel";
            cPF_CNPJLabel.Size = new System.Drawing.Size(62, 13);
            cPF_CNPJLabel.TabIndex = 15;
            cPF_CNPJLabel.Text = "CPF/CNPJ:";
            cPF_CNPJLabel.Click += new System.EventHandler(this.cPF_CNPJLabel_Click);
            // 
            // cPF_CNPJTextBox
            // 
            this.cPF_CNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "CPF_CNPJ", true));
            this.cPF_CNPJTextBox.Location = new System.Drawing.Point(90, 244);
            this.cPF_CNPJTextBox.Name = "cPF_CNPJTextBox";
            this.cPF_CNPJTextBox.Size = new System.Drawing.Size(165, 20);
            this.cPF_CNPJTextBox.TabIndex = 16;
            this.cPF_CNPJTextBox.TextChanged += new System.EventHandler(this.cPF_CNPJTextBox_TextChanged);
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(159, 209);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(32, 13);
            paisLabel.TabIndex = 17;
            paisLabel.Text = "País:";
            paisLabel.Click += new System.EventHandler(this.paisLabel_Click);
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(191, 206);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(157, 20);
            this.paisTextBox.TabIndex = 18;
            this.paisTextBox.TextChanged += new System.EventHandler(this.paisTextBox_TextChanged);
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(266, 133);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 19;
            numeroLabel.Text = "Número:";
            numeroLabel.Click += new System.EventHandler(this.numeroLabel_Click);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(313, 130);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(46, 20);
            this.numeroTextBox.TabIndex = 20;
            this.numeroTextBox.TextChanged += new System.EventHandler(this.numeroTextBox_TextChanged);
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(519, 173);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 21;
            cEPLabel.Text = "CEP:";
            cEPLabel.Click += new System.EventHandler(this.cEPLabel_Click);
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(550, 170);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(145, 20);
            this.cEPTextBox.TabIndex = 22;
            this.cEPTextBox.TextChanged += new System.EventHandler(this.cEPTextBox_TextChanged);
            // 
            // homePageLabel
            // 
            homePageLabel.AutoSize = true;
            homePageLabel.Location = new System.Drawing.Point(30, 322);
            homePageLabel.Name = "homePageLabel";
            homePageLabel.Size = new System.Drawing.Size(63, 13);
            homePageLabel.TabIndex = 23;
            homePageLabel.Text = "HomePage:";
            homePageLabel.Click += new System.EventHandler(this.homePageLabel_Click);
            // 
            // homePageTextBox
            // 
            this.homePageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "HomePage", true));
            this.homePageTextBox.Location = new System.Drawing.Point(93, 319);
            this.homePageTextBox.Name = "homePageTextBox";
            this.homePageTextBox.Size = new System.Drawing.Size(165, 20);
            this.homePageTextBox.TabIndex = 24;
            this.homePageTextBox.TextChanged += new System.EventHandler(this.homePageTextBox_TextChanged);
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(383, 133);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 25;
            bairroLabel.Text = "Bairro:";
            bairroLabel.Click += new System.EventHandler(this.bairroLabel_Click);
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(420, 130);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(144, 20);
            this.bairroTextBox.TabIndex = 26;
            this.bairroTextBox.TextChanged += new System.EventHandler(this.bairroTextBox_TextChanged);
            // 
            // municipioLabel
            // 
            municipioLabel.AutoSize = true;
            municipioLabel.Location = new System.Drawing.Point(26, 173);
            municipioLabel.Name = "municipioLabel";
            municipioLabel.Size = new System.Drawing.Size(57, 13);
            municipioLabel.TabIndex = 27;
            municipioLabel.Text = "Município:";
            municipioLabel.Click += new System.EventHandler(this.municipioLabel_Click);
            // 
            // municipioTextBox
            // 
            this.municipioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Municipio", true));
            this.municipioTextBox.Location = new System.Drawing.Point(83, 170);
            this.municipioTextBox.Name = "municipioTextBox";
            this.municipioTextBox.Size = new System.Drawing.Size(144, 20);
            this.municipioTextBox.TabIndex = 28;
            this.municipioTextBox.TextChanged += new System.EventHandler(this.municipioTextBox_TextChanged);
            // 
            // dDDLabel
            // 
            dDDLabel.AutoSize = true;
            dDDLabel.Location = new System.Drawing.Point(29, 284);
            dDDLabel.Name = "dDDLabel";
            dDDLabel.Size = new System.Drawing.Size(34, 13);
            dDDLabel.TabIndex = 29;
            dDDLabel.Text = "DDD:";
            dDDLabel.Click += new System.EventHandler(this.dDDLabel_Click);
            // 
            // dDDTextBox
            // 
            this.dDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "DDD", true));
            this.dDDTextBox.Location = new System.Drawing.Point(63, 281);
            this.dDDTextBox.Name = "dDDTextBox";
            this.dDDTextBox.Size = new System.Drawing.Size(46, 20);
            this.dDDTextBox.TabIndex = 30;
            this.dDDTextBox.TextChanged += new System.EventHandler(this.dDDTextBox_TextChanged);
            // 
            // fisicaJuridicaLabel
            // 
            fisicaJuridicaLabel.AutoSize = true;
            fisicaJuridicaLabel.Location = new System.Drawing.Point(304, 247);
            fisicaJuridicaLabel.Name = "fisicaJuridicaLabel";
            fisicaJuridicaLabel.Size = new System.Drawing.Size(82, 13);
            fisicaJuridicaLabel.TabIndex = 31;
            fisicaJuridicaLabel.Text = "Física/Jurídica:";
            fisicaJuridicaLabel.Click += new System.EventHandler(this.fisicaJuridicaLabel_Click);
            // 
            // fisicaJuridicaTextBox
            // 
            this.fisicaJuridicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "FisicaJuridica", true));
            this.fisicaJuridicaTextBox.Location = new System.Drawing.Point(386, 244);
            this.fisicaJuridicaTextBox.Name = "fisicaJuridicaTextBox";
            this.fisicaJuridicaTextBox.Size = new System.Drawing.Size(120, 20);
            this.fisicaJuridicaTextBox.TabIndex = 32;
            this.fisicaJuridicaTextBox.TextChanged += new System.EventHandler(this.fisicaJuridicaTextBox_TextChanged);
            // 
            // tipoEnderecoLabel
            // 
            tipoEnderecoLabel.AutoSize = true;
            tipoEnderecoLabel.Location = new System.Drawing.Point(586, 133);
            tipoEnderecoLabel.Name = "tipoEnderecoLabel";
            tipoEnderecoLabel.Size = new System.Drawing.Size(31, 13);
            tipoEnderecoLabel.TabIndex = 33;
            tipoEnderecoLabel.Text = "Tipo:";
            tipoEnderecoLabel.Click += new System.EventHandler(this.tipoEnderecoLabel_Click);
            // 
            // tipoEnderecoTextBox
            // 
            this.tipoEnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "TipoEndereco", true));
            this.tipoEnderecoTextBox.Location = new System.Drawing.Point(617, 130);
            this.tipoEnderecoTextBox.Name = "tipoEnderecoTextBox";
            this.tipoEnderecoTextBox.Size = new System.Drawing.Size(121, 20);
            this.tipoEnderecoTextBox.TabIndex = 34;
            this.tipoEnderecoTextBox.TextChanged += new System.EventHandler(this.tipoEnderecoTextBox_TextChanged);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(139, 284);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 35;
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Click += new System.EventHandler(this.telefoneLabel_Click);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lojasBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(191, 281);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.telefoneTextBox.TabIndex = 36;
            this.telefoneTextBox.TextChanged += new System.EventHandler(this.telefoneTextBox_TextChanged);
            // 
            // dataAberturaLabel
            // 
            dataAberturaLabel.AutoSize = true;
            dataAberturaLabel.Location = new System.Drawing.Point(30, 362);
            dataAberturaLabel.Name = "dataAberturaLabel";
            dataAberturaLabel.Size = new System.Drawing.Size(91, 13);
            dataAberturaLabel.TabIndex = 37;
            dataAberturaLabel.Text = "Data de Abertura:";
            dataAberturaLabel.Click += new System.EventHandler(this.dataAberturaLabel_Click);
            // 
            // dataAberturaDateTimePicker
            // 
            this.dataAberturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lojasBindingSource, "DataAbertura", true));
            this.dataAberturaDateTimePicker.Location = new System.Drawing.Point(121, 358);
            this.dataAberturaDateTimePicker.Name = "dataAberturaDateTimePicker";
            this.dataAberturaDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.dataAberturaDateTimePicker.TabIndex = 38;
            this.dataAberturaDateTimePicker.ValueChanged += new System.EventHandler(this.dataAberturaDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(361, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 13);
            label1.TabIndex = 39;
            label1.Text = "CRUD Loja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(label1);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(lojaCodigoLabel);
            this.Controls.Add(this.lojaCodigoTextBox);
            this.Controls.Add(cdMunicipioLabel);
            this.Controls.Add(this.cdMunicipioTextBox);
            this.Controls.Add(cPF_CNPJLabel);
            this.Controls.Add(this.cPF_CNPJTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(homePageLabel);
            this.Controls.Add(this.homePageTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(municipioLabel);
            this.Controls.Add(this.municipioTextBox);
            this.Controls.Add(dDDLabel);
            this.Controls.Add(this.dDDTextBox);
            this.Controls.Add(fisicaJuridicaLabel);
            this.Controls.Add(this.fisicaJuridicaTextBox);
            this.Controls.Add(tipoEnderecoLabel);
            this.Controls.Add(this.tipoEnderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(dataAberturaLabel);
            this.Controls.Add(this.dataAberturaDateTimePicker);
            this.Controls.Add(this.lojasBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRUDAppDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojasBindingNavigator)).EndInit();
            this.lojasBindingNavigator.ResumeLayout(false);
            this.lojasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRUDAppDBDataSet cRUDAppDBDataSet;
        private System.Windows.Forms.BindingSource lojasBindingSource;
        private CRUDAppDBDataSetTableAdapters.LojasTableAdapter lojasTableAdapter;
        private CRUDAppDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lojasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lojasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lojaCodigoTextBox;
        private System.Windows.Forms.TextBox cdMunicipioTextBox;
        private System.Windows.Forms.TextBox cPF_CNPJTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox homePageTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox municipioTextBox;
        private System.Windows.Forms.TextBox dDDTextBox;
        private System.Windows.Forms.TextBox fisicaJuridicaTextBox;
        private System.Windows.Forms.TextBox tipoEnderecoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.DateTimePicker dataAberturaDateTimePicker;
    }
}

