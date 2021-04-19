
namespace Sistema_Mercado.Views.Estoque
{
    partial class EstoqueView
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
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_cadastraProduto = new System.Windows.Forms.Button();
            this.btn_verDetalhes = new System.Windows.Forms.Button();
            this.dtgv_produtos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_produtoSelecionado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_produtos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Location = new System.Drawing.Point(719, 25);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(261, 48);
            this.btn_atualizar.TabIndex = 13;
            this.btn_atualizar.Text = "Atualizar lista";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cadastraProduto
            // 
            this.btn_cadastraProduto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cadastraProduto.ForeColor = System.Drawing.Color.White;
            this.btn_cadastraProduto.Location = new System.Drawing.Point(452, 25);
            this.btn_cadastraProduto.Name = "btn_cadastraProduto";
            this.btn_cadastraProduto.Size = new System.Drawing.Size(261, 48);
            this.btn_cadastraProduto.TabIndex = 12;
            this.btn_cadastraProduto.Text = "Cadastrar novo produto";
            this.btn_cadastraProduto.UseVisualStyleBackColor = false;
            this.btn_cadastraProduto.Click += new System.EventHandler(this.btn_cadastraProduto_Click);
            // 
            // btn_verDetalhes
            // 
            this.btn_verDetalhes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_verDetalhes.ForeColor = System.Drawing.Color.White;
            this.btn_verDetalhes.Location = new System.Drawing.Point(180, 25);
            this.btn_verDetalhes.Name = "btn_verDetalhes";
            this.btn_verDetalhes.Size = new System.Drawing.Size(266, 48);
            this.btn_verDetalhes.TabIndex = 8;
            this.btn_verDetalhes.Text = "Ver detalhes";
            this.btn_verDetalhes.UseVisualStyleBackColor = false;
            this.btn_verDetalhes.Click += new System.EventHandler(this.btn_verDetalhes_Click);
            // 
            // dtgv_produtos
            // 
            this.dtgv_produtos.AllowUserToAddRows = false;
            this.dtgv_produtos.AllowUserToDeleteRows = false;
            this.dtgv_produtos.AllowUserToOrderColumns = true;
            this.dtgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Empresa,
            this.Categoria,
            this.Preco_Compra,
            this.Preco_Venda,
            this.Estoque,
            this.Data_Vencimento});
            this.dtgv_produtos.Location = new System.Drawing.Point(13, 13);
            this.dtgv_produtos.Name = "dtgv_produtos";
            this.dtgv_produtos.ReadOnly = true;
            this.dtgv_produtos.Size = new System.Drawing.Size(1069, 289);
            this.dtgv_produtos.TabIndex = 7;
            this.dtgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_produtos_CellClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_cadastraProduto);
            this.panel1.Controls.Add(this.btn_verDetalhes);
            this.panel1.Location = new System.Drawing.Point(-5, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 104);
            this.panel1.TabIndex = 14;
            // 
            // lbl_produtoSelecionado
            // 
            this.lbl_produtoSelecionado.AutoSize = true;
            this.lbl_produtoSelecionado.Location = new System.Drawing.Point(126, 321);
            this.lbl_produtoSelecionado.Name = "lbl_produtoSelecionado";
            this.lbl_produtoSelecionado.Size = new System.Drawing.Size(13, 13);
            this.lbl_produtoSelecionado.TabIndex = 15;
            this.lbl_produtoSelecionado.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Produto selecionado:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = global::Sistema_Mercado.Properties.Resources.menu;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(239, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 27);
            this.panel3.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = global::Sistema_Mercado.Properties.Resources.plus;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(483, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 27);
            this.panel2.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BackgroundImage = global::Sistema_Mercado.Properties.Resources.seta_para_atualizar__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(780, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 27);
            this.panel4.TabIndex = 48;
            // 
            // EstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 459);
            this.Controls.Add(this.lbl_produtoSelecionado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_produtos);
            this.Name = "EstoqueView";
            this.Text = "EstoqueView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_produtos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_cadastraProduto;
        private System.Windows.Forms.Button btn_verDetalhes;
        private System.Windows.Forms.DataGridView dtgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_produtoSelecionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}