
namespace Sistema_Mercado.Views.Relatorio
{
    partial class RelatorioVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_totalVendido = new System.Windows.Forms.Label();
            this.lbl_totalPedidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total vendido";
            // 
            // lbl_totalVendido
            // 
            this.lbl_totalVendido.AutoSize = true;
            this.lbl_totalVendido.ForeColor = System.Drawing.Color.White;
            this.lbl_totalVendido.Location = new System.Drawing.Point(100, 40);
            this.lbl_totalVendido.Name = "lbl_totalVendido";
            this.lbl_totalVendido.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalVendido.TabIndex = 1;
            this.lbl_totalVendido.Text = "_";
            // 
            // lbl_totalPedidos
            // 
            this.lbl_totalPedidos.AutoSize = true;
            this.lbl_totalPedidos.ForeColor = System.Drawing.Color.White;
            this.lbl_totalPedidos.Location = new System.Drawing.Point(102, 64);
            this.lbl_totalPedidos.Name = "lbl_totalPedidos";
            this.lbl_totalPedidos.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalPedidos.TabIndex = 3;
            this.lbl_totalPedidos.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pedidos feitos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.lbl_totalPedidos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_totalVendido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 191);
            this.panel1.TabIndex = 6;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::Sistema_Mercado.Properties.Resources.seta_para_atualizar__1_;
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atualizar.Location = new System.Drawing.Point(3, 128);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(153, 42);
            this.btn_atualizar.TabIndex = 5;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Image = global::Sistema_Mercado.Properties.Resources.botao_de_retorno;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(162, 128);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(144, 42);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 184);
            this.Controls.Add(this.panel1);
            this.Name = "RelatorioVendas";
            this.Text = "Relatório de vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_totalVendido;
        private System.Windows.Forms.Label lbl_totalPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Panel panel1;
    }
}