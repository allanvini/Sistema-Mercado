
namespace Sistema_Mercado.Views.Servicos
{
    partial class ServicosView
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
            this.btn_cadastraServico = new System.Windows.Forms.Button();
            this.lbl_servicoSelecionado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_verDetalhes = new System.Windows.Forms.Button();
            this.dtgv_servicos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_servicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(319, 354);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(136, 48);
            this.btn_atualizar.TabIndex = 19;
            this.btn_atualizar.Text = "Atualizar lista";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cadastraServico
            // 
            this.btn_cadastraServico.Location = new System.Drawing.Point(169, 354);
            this.btn_cadastraServico.Name = "btn_cadastraServico";
            this.btn_cadastraServico.Size = new System.Drawing.Size(144, 48);
            this.btn_cadastraServico.TabIndex = 18;
            this.btn_cadastraServico.Text = "Cadastrar novo serviço";
            this.btn_cadastraServico.UseVisualStyleBackColor = true;
            this.btn_cadastraServico.Click += new System.EventHandler(this.btn_cadastraServico_Click);
            // 
            // lbl_servicoSelecionado
            // 
            this.lbl_servicoSelecionado.AutoSize = true;
            this.lbl_servicoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servicoSelecionado.Location = new System.Drawing.Point(144, 313);
            this.lbl_servicoSelecionado.Name = "lbl_servicoSelecionado";
            this.lbl_servicoSelecionado.Size = new System.Drawing.Size(13, 13);
            this.lbl_servicoSelecionado.TabIndex = 17;
            this.lbl_servicoSelecionado.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Serviço selecionado:";
            // 
            // btn_verDetalhes
            // 
            this.btn_verDetalhes.Location = new System.Drawing.Point(12, 354);
            this.btn_verDetalhes.Name = "btn_verDetalhes";
            this.btn_verDetalhes.Size = new System.Drawing.Size(151, 48);
            this.btn_verDetalhes.TabIndex = 15;
            this.btn_verDetalhes.Text = "Ver detalhes";
            this.btn_verDetalhes.UseVisualStyleBackColor = true;
            this.btn_verDetalhes.Click += new System.EventHandler(this.btn_verDetalhes_Click);
            // 
            // dtgv_servicos
            // 
            this.dtgv_servicos.AllowUserToAddRows = false;
            this.dtgv_servicos.AllowUserToDeleteRows = false;
            this.dtgv_servicos.AllowUserToOrderColumns = true;
            this.dtgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_servicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descricao,
            this.Preco});
            this.dtgv_servicos.Location = new System.Drawing.Point(12, 12);
            this.dtgv_servicos.Name = "dtgv_servicos";
            this.dtgv_servicos.ReadOnly = true;
            this.dtgv_servicos.Size = new System.Drawing.Size(443, 289);
            this.dtgv_servicos.TabIndex = 14;
            this.dtgv_servicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_servicos_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
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
            // ServicosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 425);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cadastraServico);
            this.Controls.Add(this.lbl_servicoSelecionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_verDetalhes);
            this.Controls.Add(this.dtgv_servicos);
            this.Name = "ServicosView";
            this.Text = "ServicosView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_servicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_cadastraServico;
        private System.Windows.Forms.Label lbl_servicoSelecionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_verDetalhes;
        private System.Windows.Forms.DataGridView dtgv_servicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}