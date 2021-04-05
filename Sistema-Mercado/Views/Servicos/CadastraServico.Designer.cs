
namespace Sistema_Mercado.Views.Servicos
{
    partial class CadastraServico
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
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_finalizaCadastro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Cadastro de novo serviço";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(12, 310);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(310, 49);
            this.btn_cancelar.TabIndex = 44;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_finalizaCadastro
            // 
            this.btn_finalizaCadastro.Location = new System.Drawing.Point(12, 255);
            this.btn_finalizaCadastro.Name = "btn_finalizaCadastro";
            this.btn_finalizaCadastro.Size = new System.Drawing.Size(310, 49);
            this.btn_finalizaCadastro.TabIndex = 43;
            this.btn_finalizaCadastro.Text = "Cadastrar serviço";
            this.btn_finalizaCadastro.UseVisualStyleBackColor = true;
            this.btn_finalizaCadastro.Click += new System.EventHandler(this.btn_finalizaCadastro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_descricao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_preco);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 201);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição";
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(87, 34);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(211, 111);
            this.txb_descricao.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preço";
            // 
            // txb_preco
            // 
            this.txb_preco.Location = new System.Drawing.Point(87, 151);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(64, 20);
            this.txb_preco.TabIndex = 14;
            // 
            // CadastraServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 376);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_finalizaCadastro);
            this.Controls.Add(this.groupBox2);
            this.Name = "CadastraServico";
            this.Text = "CadastraServico";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_finalizaCadastro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_preco;
    }
}