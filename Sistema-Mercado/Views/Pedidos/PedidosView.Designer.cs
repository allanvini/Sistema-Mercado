
namespace Sistema_Mercado.Views.Pedidos
{
    partial class PedidosView
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
            this.dtgv_pedidos = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_detalhesPedido = new System.Windows.Forms.Button();
            this.btn_excluirPedido = new System.Windows.Forms.Button();
            this.btn_adicionarPedido = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pedidoID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_pedidos
            // 
            this.dtgv_pedidos.AllowUserToAddRows = false;
            this.dtgv_pedidos.AllowUserToDeleteRows = false;
            this.dtgv_pedidos.AllowUserToOrderColumns = true;
            this.dtgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido,
            this.Vendedor,
            this.Cliente,
            this.Status,
            this.Forma_Pagamento});
            this.dtgv_pedidos.Location = new System.Drawing.Point(13, 13);
            this.dtgv_pedidos.Name = "dtgv_pedidos";
            this.dtgv_pedidos.ReadOnly = true;
            this.dtgv_pedidos.Size = new System.Drawing.Size(943, 418);
            this.dtgv_pedidos.TabIndex = 0;
            this.dtgv_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_pedidos_CellClick);
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Width = 200;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status do pedido";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // Forma_Pagamento
            // 
            this.Forma_Pagamento.HeaderText = "Forma de pagamento";
            this.Forma_Pagamento.Name = "Forma_Pagamento";
            this.Forma_Pagamento.ReadOnly = true;
            this.Forma_Pagamento.Width = 200;
            // 
            // btn_detalhesPedido
            // 
            this.btn_detalhesPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_detalhesPedido.ForeColor = System.Drawing.Color.White;
            this.btn_detalhesPedido.Location = new System.Drawing.Point(13, 498);
            this.btn_detalhesPedido.Name = "btn_detalhesPedido";
            this.btn_detalhesPedido.Size = new System.Drawing.Size(232, 62);
            this.btn_detalhesPedido.TabIndex = 1;
            this.btn_detalhesPedido.Text = "Ver de talhes do pedido";
            this.btn_detalhesPedido.UseVisualStyleBackColor = false;
            this.btn_detalhesPedido.Click += new System.EventHandler(this.btn_detalhesPedido_Click);
            // 
            // btn_excluirPedido
            // 
            this.btn_excluirPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_excluirPedido.ForeColor = System.Drawing.Color.White;
            this.btn_excluirPedido.Location = new System.Drawing.Point(251, 498);
            this.btn_excluirPedido.Name = "btn_excluirPedido";
            this.btn_excluirPedido.Size = new System.Drawing.Size(232, 62);
            this.btn_excluirPedido.TabIndex = 2;
            this.btn_excluirPedido.Text = "Excluir pedido";
            this.btn_excluirPedido.UseVisualStyleBackColor = false;
            this.btn_excluirPedido.Click += new System.EventHandler(this.btn_excluirPedido_Click);
            // 
            // btn_adicionarPedido
            // 
            this.btn_adicionarPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_adicionarPedido.ForeColor = System.Drawing.Color.White;
            this.btn_adicionarPedido.Location = new System.Drawing.Point(488, 498);
            this.btn_adicionarPedido.Name = "btn_adicionarPedido";
            this.btn_adicionarPedido.Size = new System.Drawing.Size(232, 62);
            this.btn_adicionarPedido.TabIndex = 3;
            this.btn_adicionarPedido.Text = "Cadastrar novo pedido";
            this.btn_adicionarPedido.UseVisualStyleBackColor = false;
            this.btn_adicionarPedido.Click += new System.EventHandler(this.btn_adicionarPedido_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Location = new System.Drawing.Point(726, 498);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(232, 62);
            this.btn_atualizar.TabIndex = 4;
            this.btn_atualizar.Text = "Atualizar lista";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pedido selecionado:";
            // 
            // lbl_pedidoID
            // 
            this.lbl_pedidoID.AutoSize = true;
            this.lbl_pedidoID.Location = new System.Drawing.Point(141, 447);
            this.lbl_pedidoID.Name = "lbl_pedidoID";
            this.lbl_pedidoID.Size = new System.Drawing.Size(13, 13);
            this.lbl_pedidoID.TabIndex = 6;
            this.lbl_pedidoID.Text = "_";
            // 
            // PedidosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 588);
            this.Controls.Add(this.lbl_pedidoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_adicionarPedido);
            this.Controls.Add(this.btn_excluirPedido);
            this.Controls.Add(this.btn_detalhesPedido);
            this.Controls.Add(this.dtgv_pedidos);
            this.Name = "PedidosView";
            this.Text = "PedidosView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma_Pagamento;
        private System.Windows.Forms.Button btn_detalhesPedido;
        private System.Windows.Forms.Button btn_excluirPedido;
        private System.Windows.Forms.Button btn_adicionarPedido;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pedidoID;
    }
}