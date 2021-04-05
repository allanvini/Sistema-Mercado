
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(12, 54);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 24);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "User";
            // 
            // lbl_userPosition
            // 
            this.lbl_userPosition.AutoSize = true;
            this.lbl_userPosition.Location = new System.Drawing.Point(13, 78);
            this.lbl_userPosition.Name = "lbl_userPosition";
            this.lbl_userPosition.Size = new System.Drawing.Size(44, 13);
            this.lbl_userPosition.TabIndex = 2;
            this.lbl_userPosition.Text = "Position";
            // 
            // btn_verPedidos
            // 
            this.btn_verPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verPedidos.Location = new System.Drawing.Point(5, 108);
            this.btn_verPedidos.Name = "btn_verPedidos";
            this.btn_verPedidos.Size = new System.Drawing.Size(305, 64);
            this.btn_verPedidos.TabIndex = 3;
            this.btn_verPedidos.Text = "Ver Pedidos";
            this.btn_verPedidos.UseVisualStyleBackColor = true;
            this.btn_verPedidos.Click += new System.EventHandler(this.btn_verPedidos_Click);
            // 
            // btn_verEstoque
            // 
            this.btn_verEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verEstoque.Location = new System.Drawing.Point(5, 178);
            this.btn_verEstoque.Name = "btn_verEstoque";
            this.btn_verEstoque.Size = new System.Drawing.Size(305, 64);
            this.btn_verEstoque.TabIndex = 4;
            this.btn_verEstoque.Text = "Ver Estoque";
            this.btn_verEstoque.UseVisualStyleBackColor = true;
            this.btn_verEstoque.Click += new System.EventHandler(this.btn_verEstoque_Click);
            // 
            // btn_verServicos
            // 
            this.btn_verServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verServicos.Location = new System.Drawing.Point(316, 108);
            this.btn_verServicos.Name = "btn_verServicos";
            this.btn_verServicos.Size = new System.Drawing.Size(305, 64);
            this.btn_verServicos.TabIndex = 5;
            this.btn_verServicos.Text = "Ver Serviços";
            this.btn_verServicos.UseVisualStyleBackColor = true;
            this.btn_verServicos.Click += new System.EventHandler(this.btn_verServicos_Click);
            // 
            // btn_verClientes
            // 
            this.btn_verClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verClientes.Location = new System.Drawing.Point(316, 178);
            this.btn_verClientes.Name = "btn_verClientes";
            this.btn_verClientes.Size = new System.Drawing.Size(305, 64);
            this.btn_verClientes.TabIndex = 6;
            this.btn_verClientes.Text = "Ver Clientes";
            this.btn_verClientes.UseVisualStyleBackColor = true;
            this.btn_verClientes.Click += new System.EventHandler(this.btn_verClientes_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(5, 248);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(616, 64);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 326);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_verClientes);
            this.Controls.Add(this.btn_verServicos);
            this.Controls.Add(this.btn_verEstoque);
            this.Controls.Add(this.btn_verPedidos);
            this.Controls.Add(this.lbl_userPosition);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}