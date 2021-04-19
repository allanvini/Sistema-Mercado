
namespace Sistema_Mercado.Views.Pedidos
{
    partial class CadastraPedido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_quantidadeProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_produtoID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_adicionaProduto = new System.Windows.Forms.Button();
            this.dtgv_produtos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_servicoID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_adicionaServico = new System.Windows.Forms.Button();
            this.dtgv_servicos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_clienteID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_selecionaCliente = new System.Windows.Forms.Button();
            this.dtgv_clientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_de_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_fechaPedido = new System.Windows.Forms.Button();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb_credito = new System.Windows.Forms.RadioButton();
            this.rdb_dinheiro = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_produtos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_servicos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.txb_quantidadeProduto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_produtoID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_adicionaProduto);
            this.groupBox1.Controls.Add(this.dtgv_produtos);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // txb_quantidadeProduto
            // 
            this.txb_quantidadeProduto.Location = new System.Drawing.Point(1195, 91);
            this.txb_quantidadeProduto.Name = "txb_quantidadeProduto";
            this.txb_quantidadeProduto.Size = new System.Drawing.Size(64, 20);
            this.txb_quantidadeProduto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1081, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1081, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // lbl_produtoID
            // 
            this.lbl_produtoID.AutoSize = true;
            this.lbl_produtoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtoID.Location = new System.Drawing.Point(1120, 44);
            this.lbl_produtoID.Name = "lbl_produtoID";
            this.lbl_produtoID.Size = new System.Drawing.Size(25, 25);
            this.lbl_produtoID.TabIndex = 10;
            this.lbl_produtoID.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1081, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produto selecionado:";
            // 
            // btn_adicionaProduto
            // 
            this.btn_adicionaProduto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_adicionaProduto.ForeColor = System.Drawing.Color.White;
            this.btn_adicionaProduto.Location = new System.Drawing.Point(1081, 127);
            this.btn_adicionaProduto.Name = "btn_adicionaProduto";
            this.btn_adicionaProduto.Size = new System.Drawing.Size(179, 50);
            this.btn_adicionaProduto.TabIndex = 6;
            this.btn_adicionaProduto.Text = "Adicionar Produto";
            this.btn_adicionaProduto.UseVisualStyleBackColor = false;
            this.btn_adicionaProduto.Click += new System.EventHandler(this.btn_adicionaProduto_Click);
            // 
            // dtgv_produtos
            // 
            this.dtgv_produtos.AllowUserToAddRows = false;
            this.dtgv_produtos.AllowUserToDeleteRows = false;
            this.dtgv_produtos.AllowUserToOrderColumns = true;
            this.dtgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Empresa,
            this.Categoria,
            this.Preco_Compra,
            this.Preco_Venda,
            this.Estoque,
            this.Data_Vencimento});
            this.dtgv_produtos.Location = new System.Drawing.Point(6, 19);
            this.dtgv_produtos.Name = "dtgv_produtos";
            this.dtgv_produtos.ReadOnly = true;
            this.dtgv_produtos.Size = new System.Drawing.Size(1069, 158);
            this.dtgv_produtos.TabIndex = 8;
            this.dtgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_produtos_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 175;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Preco_Compra
            // 
            this.Preco_Compra.HeaderText = "Preço de compra";
            this.Preco_Compra.Name = "Preco_Compra";
            this.Preco_Compra.ReadOnly = true;
            this.Preco_Compra.Width = 175;
            // 
            // Preco_Venda
            // 
            this.Preco_Venda.HeaderText = "Preço de venda";
            this.Preco_Venda.Name = "Preco_Venda";
            this.Preco_Venda.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // Data_Vencimento
            // 
            this.Data_Vencimento.HeaderText = "Data de vencimento";
            this.Data_Vencimento.Name = "Data_Vencimento";
            this.Data_Vencimento.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_servicoID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_adicionaServico);
            this.groupBox2.Controls.Add(this.dtgv_servicos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID:";
            // 
            // lbl_servicoID
            // 
            this.lbl_servicoID.AutoSize = true;
            this.lbl_servicoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servicoID.Location = new System.Drawing.Point(494, 47);
            this.lbl_servicoID.Name = "lbl_servicoID";
            this.lbl_servicoID.Size = new System.Drawing.Size(25, 25);
            this.lbl_servicoID.TabIndex = 18;
            this.lbl_servicoID.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Serviço selecionado:";
            // 
            // btn_adicionaServico
            // 
            this.btn_adicionaServico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_adicionaServico.Location = new System.Drawing.Point(455, 129);
            this.btn_adicionaServico.Name = "btn_adicionaServico";
            this.btn_adicionaServico.Size = new System.Drawing.Size(235, 50);
            this.btn_adicionaServico.TabIndex = 16;
            this.btn_adicionaServico.Text = "Adicionar Serviço";
            this.btn_adicionaServico.UseVisualStyleBackColor = false;
            this.btn_adicionaServico.Click += new System.EventHandler(this.btn_adicionaServico_Click);
            // 
            // dtgv_servicos
            // 
            this.dtgv_servicos.AllowUserToAddRows = false;
            this.dtgv_servicos.AllowUserToDeleteRows = false;
            this.dtgv_servicos.AllowUserToOrderColumns = true;
            this.dtgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_servicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Descricao,
            this.Preco});
            this.dtgv_servicos.Location = new System.Drawing.Point(6, 19);
            this.dtgv_servicos.Name = "dtgv_servicos";
            this.dtgv_servicos.ReadOnly = true;
            this.dtgv_servicos.Size = new System.Drawing.Size(443, 160);
            this.dtgv_servicos.TabIndex = 15;
            this.dtgv_servicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_servicos_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 25;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de novo pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_clienteID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_selecionaCliente);
            this.groupBox3.Controls.Add(this.dtgv_clientes);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1015, 184);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // lbl_clienteID
            // 
            this.lbl_clienteID.AutoSize = true;
            this.lbl_clienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clienteID.Location = new System.Drawing.Point(826, 47);
            this.lbl_clienteID.Name = "lbl_clienteID";
            this.lbl_clienteID.Size = new System.Drawing.Size(25, 25);
            this.lbl_clienteID.TabIndex = 7;
            this.lbl_clienteID.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(787, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente selecionado:";
            // 
            // btn_selecionaCliente
            // 
            this.btn_selecionaCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_selecionaCliente.Location = new System.Drawing.Point(787, 119);
            this.btn_selecionaCliente.Name = "btn_selecionaCliente";
            this.btn_selecionaCliente.Size = new System.Drawing.Size(222, 50);
            this.btn_selecionaCliente.TabIndex = 5;
            this.btn_selecionaCliente.Text = "Seleciona Cliente";
            this.btn_selecionaCliente.UseVisualStyleBackColor = false;
            this.btn_selecionaCliente.Click += new System.EventHandler(this.btn_selecionaCliente_Click);
            // 
            // dtgv_clientes
            // 
            this.dtgv_clientes.AllowUserToAddRows = false;
            this.dtgv_clientes.AllowUserToDeleteRows = false;
            this.dtgv_clientes.AllowUserToOrderColumns = true;
            this.dtgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Data_de_Nascimento,
            this.Email});
            this.dtgv_clientes.Location = new System.Drawing.Point(6, 19);
            this.dtgv_clientes.Name = "dtgv_clientes";
            this.dtgv_clientes.ReadOnly = true;
            this.dtgv_clientes.Size = new System.Drawing.Size(775, 150);
            this.dtgv_clientes.TabIndex = 1;
            this.dtgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_clientes_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 175;
            // 
            // Data_de_Nascimento
            // 
            this.Data_de_Nascimento.HeaderText = "Data de Nascimento";
            this.Data_de_Nascimento.Name = "Data_de_Nascimento";
            this.Data_de_Nascimento.ReadOnly = true;
            this.Data_de_Nascimento.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 175;
            // 
            // btn_fechaPedido
            // 
            this.btn_fechaPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_fechaPedido.ForeColor = System.Drawing.Color.White;
            this.btn_fechaPedido.Location = new System.Drawing.Point(1017, 489);
            this.btn_fechaPedido.Name = "btn_fechaPedido";
            this.btn_fechaPedido.Size = new System.Drawing.Size(215, 50);
            this.btn_fechaPedido.TabIndex = 4;
            this.btn_fechaPedido.Text = "Finaliza Pedido";
            this.btn_fechaPedido.UseVisualStyleBackColor = false;
            this.btn_fechaPedido.Click += new System.EventHandler(this.btn_fechaPedido_Click);
            // 
            // btn_cancela
            // 
            this.btn_cancela.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancela.ForeColor = System.Drawing.Color.White;
            this.btn_cancela.Location = new System.Drawing.Point(1017, 545);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(215, 50);
            this.btn_cancela.TabIndex = 5;
            this.btn_cancela.Text = "Cancela";
            this.btn_cancela.UseVisualStyleBackColor = false;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox4.Controls.Add(this.rdb_credito);
            this.groupBox4.Controls.Add(this.rdb_dinheiro);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(715, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 195);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forma de pagamento";
            // 
            // rdb_credito
            // 
            this.rdb_credito.AutoSize = true;
            this.rdb_credito.Location = new System.Drawing.Point(61, 129);
            this.rdb_credito.Name = "rdb_credito";
            this.rdb_credito.Size = new System.Drawing.Size(117, 17);
            this.rdb_credito.TabIndex = 12;
            this.rdb_credito.TabStop = true;
            this.rdb_credito.Text = "Parcelado / Crédito";
            this.rdb_credito.UseVisualStyleBackColor = true;
            this.rdb_credito.CheckedChanged += new System.EventHandler(this.rdb_credito_CheckedChanged);
            // 
            // rdb_dinheiro
            // 
            this.rdb_dinheiro.AutoSize = true;
            this.rdb_dinheiro.Location = new System.Drawing.Point(61, 106);
            this.rdb_dinheiro.Name = "rdb_dinheiro";
            this.rdb_dinheiro.Size = new System.Drawing.Size(106, 17);
            this.rdb_dinheiro.TabIndex = 11;
            this.rdb_dinheiro.TabStop = true;
            this.rdb_dinheiro.Text = "Dinheiro / Débito";
            this.rdb_dinheiro.UseVisualStyleBackColor = true;
            this.rdb_dinheiro.CheckedChanged += new System.EventHandler(this.rdb_dinheiro_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Selecione uma forma de pagamento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = global::Sistema_Mercado.Properties.Resources.carrinho;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(1051, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 40);
            this.panel2.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = global::Sistema_Mercado.Properties.Resources.cancel__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(1051, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 40);
            this.panel1.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = global::Sistema_Mercado.Properties.Resources.plus;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(483, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 27);
            this.panel3.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BackgroundImage = global::Sistema_Mercado.Properties.Resources.plus;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(1098, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 27);
            this.panel4.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.BackgroundImage = global::Sistema_Mercado.Properties.Resources.customer__2_;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(815, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(36, 27);
            this.panel5.TabIndex = 49;
            // 
            // CadastraPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_fechaPedido);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastraPedido";
            this.Text = "CadastraPedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_produtos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_servicos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_fechaPedido;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.DataGridView dtgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_de_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridView dtgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
        private System.Windows.Forms.DataGridView dtgv_servicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_clienteID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_selecionaCliente;
        private System.Windows.Forms.TextBox txb_quantidadeProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_produtoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_adicionaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_servicoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_adicionaServico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb_credito;
        private System.Windows.Forms.RadioButton rdb_dinheiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}