﻿
namespace Sistema_Mercado.Views.Servicos
{
    partial class DetalhesServico
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvaAlteracoes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_produtoID = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Detalhes do serviço";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(12, 389);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(310, 49);
            this.btn_voltar.TabIndex = 48;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // btn_salvaAlteracoes
            // 
            this.btn_salvaAlteracoes.Location = new System.Drawing.Point(12, 334);
            this.btn_salvaAlteracoes.Name = "btn_salvaAlteracoes";
            this.btn_salvaAlteracoes.Size = new System.Drawing.Size(310, 49);
            this.btn_salvaAlteracoes.TabIndex = 47;
            this.btn_salvaAlteracoes.Text = "Salvar alterações";
            this.btn_salvaAlteracoes.UseVisualStyleBackColor = true;
            this.btn_salvaAlteracoes.Click += new System.EventHandler(this.btn_salvaAlteracoes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ID);
            this.groupBox2.Controls.Add(this.lbl_produtoID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_descricao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_preco);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 250);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição";
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(87, 96);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(211, 111);
            this.txb_descricao.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preço";
            // 
            // txb_preco
            // 
            this.txb_preco.Location = new System.Drawing.Point(87, 213);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(64, 20);
            this.txb_preco.TabIndex = 14;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(63, 36);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(20, 24);
            this.lbl_ID.TabIndex = 26;
            this.lbl_ID.Text = "_";
            // 
            // lbl_produtoID
            // 
            this.lbl_produtoID.AutoSize = true;
            this.lbl_produtoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtoID.Location = new System.Drawing.Point(24, 35);
            this.lbl_produtoID.Name = "lbl_produtoID";
            this.lbl_produtoID.Size = new System.Drawing.Size(41, 25);
            this.lbl_produtoID.TabIndex = 25;
            this.lbl_produtoID.Text = "ID:";
            // 
            // DetalhesServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_salvaAlteracoes);
            this.Controls.Add(this.groupBox2);
            this.Name = "DetalhesServico";
            this.Text = "DetalhesServico";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_salvaAlteracoes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_preco;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_produtoID;
    }
}