
namespace Sistema_Mercado.Views.Clientes
{
    partial class ClientesView
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
            this.dtgv_clientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_de_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_verDetalhes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_clienteSelecionado = new System.Windows.Forms.Label();
            this.btn_excluirCliente = new System.Windows.Forms.Button();
            this.btn_cadastraCliente = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_clientes
            // 
            this.dtgv_clientes.AllowUserToAddRows = false;
            this.dtgv_clientes.AllowUserToDeleteRows = false;
            this.dtgv_clientes.AllowUserToOrderColumns = true;
            this.dtgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPF,
            this.Data_de_Nascimento,
            this.Email});
            this.dtgv_clientes.Location = new System.Drawing.Point(13, 13);
            this.dtgv_clientes.Name = "dtgv_clientes";
            this.dtgv_clientes.ReadOnly = true;
            this.dtgv_clientes.Size = new System.Drawing.Size(775, 289);
            this.dtgv_clientes.TabIndex = 0;
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
            // btn_verDetalhes
            // 
            this.btn_verDetalhes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_verDetalhes.ForeColor = System.Drawing.Color.White;
            this.btn_verDetalhes.Image = global::Sistema_Mercado.Properties.Resources.menu;
            this.btn_verDetalhes.Location = new System.Drawing.Point(13, 19);
            this.btn_verDetalhes.Name = "btn_verDetalhes";
            this.btn_verDetalhes.Size = new System.Drawing.Size(191, 48);
            this.btn_verDetalhes.TabIndex = 1;
            this.btn_verDetalhes.Text = "Ver detalhes";
            this.btn_verDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_verDetalhes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_verDetalhes.UseVisualStyleBackColor = false;
            this.btn_verDetalhes.Click += new System.EventHandler(this.btn_verDetalhes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente Seiecionado:";
            // 
            // lbl_clienteSelecionado
            // 
            this.lbl_clienteSelecionado.AutoSize = true;
            this.lbl_clienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clienteSelecionado.Location = new System.Drawing.Point(142, 314);
            this.lbl_clienteSelecionado.Name = "lbl_clienteSelecionado";
            this.lbl_clienteSelecionado.Size = new System.Drawing.Size(13, 13);
            this.lbl_clienteSelecionado.TabIndex = 3;
            this.lbl_clienteSelecionado.Text = "_";
            // 
            // btn_excluirCliente
            // 
            this.btn_excluirCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_excluirCliente.ForeColor = System.Drawing.Color.White;
            this.btn_excluirCliente.Image = global::Sistema_Mercado.Properties.Resources.cancel__2_;
            this.btn_excluirCliente.Location = new System.Drawing.Point(213, 19);
            this.btn_excluirCliente.Name = "btn_excluirCliente";
            this.btn_excluirCliente.Size = new System.Drawing.Size(191, 48);
            this.btn_excluirCliente.TabIndex = 4;
            this.btn_excluirCliente.Text = "Excluir cliente";
            this.btn_excluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_excluirCliente.UseVisualStyleBackColor = false;
            this.btn_excluirCliente.Click += new System.EventHandler(this.btn_excluirCliente_Click);
            // 
            // btn_cadastraCliente
            // 
            this.btn_cadastraCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cadastraCliente.ForeColor = System.Drawing.Color.White;
            this.btn_cadastraCliente.Image = global::Sistema_Mercado.Properties.Resources.plus;
            this.btn_cadastraCliente.Location = new System.Drawing.Point(410, 19);
            this.btn_cadastraCliente.Name = "btn_cadastraCliente";
            this.btn_cadastraCliente.Size = new System.Drawing.Size(186, 48);
            this.btn_cadastraCliente.TabIndex = 5;
            this.btn_cadastraCliente.Text = "Cadastrar novo cliente";
            this.btn_cadastraCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastraCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cadastraCliente.UseVisualStyleBackColor = false;
            this.btn_cadastraCliente.Click += new System.EventHandler(this.btn_cadastraCliente_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::Sistema_Mercado.Properties.Resources.seta_para_atualizar__1_;
            this.btn_atualizar.Location = new System.Drawing.Point(602, 19);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(186, 48);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar lista";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_cadastraCliente);
            this.panel1.Controls.Add(this.btn_excluirCliente);
            this.panel1.Controls.Add(this.btn_verDetalhes);
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 117);
            this.panel1.TabIndex = 7;
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_clienteSelecionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_clientes);
            this.Name = "ClientesView";
            this.Text = "ClientesView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_clientes;
        private System.Windows.Forms.Button btn_verDetalhes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_clienteSelecionado;
        private System.Windows.Forms.Button btn_excluirCliente;
        private System.Windows.Forms.Button btn_cadastraCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_de_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Panel panel1;
    }
}