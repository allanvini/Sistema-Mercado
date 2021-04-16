
namespace Sistema_Mercado.Views
{
    partial class Dashboard
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_userPosition = new System.Windows.Forms.Label();
            this.btn_verPedidos = new System.Windows.Forms.Button();
            this.btn_verEstoque = new System.Windows.Forms.Button();
            this.btn_verServicos = new System.Windows.Forms.Button();
            this.btn_verClientes = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_relatório = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(10, 45);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 24);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "User";
            // 
            // lbl_userPosition
            // 
            this.lbl_userPosition.AutoSize = true;
            this.lbl_userPosition.ForeColor = System.Drawing.Color.White;
            this.lbl_userPosition.Location = new System.Drawing.Point(11, 69);
            this.lbl_userPosition.Name = "lbl_userPosition";
            this.lbl_userPosition.Size = new System.Drawing.Size(44, 13);
            this.lbl_userPosition.TabIndex = 2;
            this.lbl_userPosition.Text = "Position";
            // 
            // btn_verPedidos
            // 
            this.btn_verPedidos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_verPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verPedidos.ForeColor = System.Drawing.Color.White;
            this.btn_verPedidos.Location = new System.Drawing.Point(5, 8);
            this.btn_verPedidos.Name = "btn_verPedidos";
            this.btn_verPedidos.Size = new System.Drawing.Size(305, 64);
            this.btn_verPedidos.TabIndex = 3;
            this.btn_verPedidos.Text = "Ver Pedidos";
            this.btn_verPedidos.UseVisualStyleBackColor = false;
            this.btn_verPedidos.Click += new System.EventHandler(this.btn_verPedidos_Click);
            // 
            // btn_verEstoque
            // 
            this.btn_verEstoque.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_verEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verEstoque.ForeColor = System.Drawing.Color.White;
            this.btn_verEstoque.Location = new System.Drawing.Point(5, 78);
            this.btn_verEstoque.Name = "btn_verEstoque";
            this.btn_verEstoque.Size = new System.Drawing.Size(305, 64);
            this.btn_verEstoque.TabIndex = 4;
            this.btn_verEstoque.Text = "Ver Estoque";
            this.btn_verEstoque.UseVisualStyleBackColor = false;
            this.btn_verEstoque.Click += new System.EventHandler(this.btn_verEstoque_Click);
            // 
            // btn_verServicos
            // 
            this.btn_verServicos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_verServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verServicos.ForeColor = System.Drawing.Color.White;
            this.btn_verServicos.Location = new System.Drawing.Point(316, 8);
            this.btn_verServicos.Name = "btn_verServicos";
            this.btn_verServicos.Size = new System.Drawing.Size(305, 64);
            this.btn_verServicos.TabIndex = 5;
            this.btn_verServicos.Text = "Ver Serviços";
            this.btn_verServicos.UseVisualStyleBackColor = false;
            this.btn_verServicos.Click += new System.EventHandler(this.btn_verServicos_Click);
            // 
            // btn_verClientes
            // 
            this.btn_verClientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_verClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verClientes.ForeColor = System.Drawing.Color.White;
            this.btn_verClientes.Location = new System.Drawing.Point(316, 78);
            this.btn_verClientes.Name = "btn_verClientes";
            this.btn_verClientes.Size = new System.Drawing.Size(305, 64);
            this.btn_verClientes.TabIndex = 6;
            this.btn_verClientes.Text = "Ver Clientes";
            this.btn_verClientes.UseVisualStyleBackColor = false;
            this.btn_verClientes.Click += new System.EventHandler(this.btn_verClientes_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(5, 148);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(783, 64);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_userPosition);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 102);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_relatório);
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Controls.Add(this.btn_verClientes);
            this.panel2.Controls.Add(this.btn_verServicos);
            this.panel2.Controls.Add(this.btn_verEstoque);
            this.panel2.Controls.Add(this.btn_verPedidos);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 231);
            this.panel2.TabIndex = 9;
            // 
            // btn_relatório
            // 
            this.btn_relatório.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_relatório.Enabled = false;
            this.btn_relatório.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatório.ForeColor = System.Drawing.Color.White;
            this.btn_relatório.Location = new System.Drawing.Point(627, 8);
            this.btn_relatório.Name = "btn_relatório";
            this.btn_relatório.Size = new System.Drawing.Size(161, 134);
            this.btn_relatório.TabIndex = 8;
            this.btn_relatório.Text = "Ver relatório de vendas";
            this.btn_relatório.UseVisualStyleBackColor = false;
            this.btn_relatório.Click += new System.EventHandler(this.btn_relatório_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_userPosition;
        private System.Windows.Forms.Button btn_verPedidos;
        private System.Windows.Forms.Button btn_verEstoque;
        private System.Windows.Forms.Button btn_verServicos;
        private System.Windows.Forms.Button btn_verClientes;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_relatório;
    }
}