
namespace Sistema_Mercado.Views.Pedidos
{
    partial class DetalhesPedido
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
            this.dtgv_pedido = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.btn_quitaPedido = new System.Windows.Forms.Button();
            this.btn_excluidPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_pedido
            // 
            this.dtgv_pedido.AllowUserToAddRows = false;
            this.dtgv_pedido.AllowUserToDeleteRows = false;
            this.dtgv_pedido.AllowUserToOrderColumns = true;
            this.dtgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido,
            this.Produto,
            this.Quantidade,
            this.Valor_Unit,
            this.Vendedor,
            this.Cliente,
            this.Status,
            this.Forma_Pagamento});
            this.dtgv_pedido.Location = new System.Drawing.Point(13, 13);
            this.dtgv_pedido.Name = "dtgv_pedido";
            this.dtgv_pedido.ReadOnly = true;
            this.dtgv_pedido.Size = new System.Drawing.Size(994, 379);
            this.dtgv_pedido.TabIndex = 0;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Width = 50;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "QTD";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // Valor_Unit
            // 
            this.Valor_Unit.HeaderText = "Valor Unitário";
            this.Valor_Unit.Name = "Valor_Unit";
            this.Valor_Unit.ReadOnly = true;
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
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Forma_Pagamento
            // 
            this.Forma_Pagamento.HeaderText = "Forma de Pagamento";
            this.Forma_Pagamento.Name = "Forma_Pagamento";
            this.Forma_Pagamento.ReadOnly = true;
            this.Forma_Pagamento.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor total do pedido:";
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorTotal.Location = new System.Drawing.Point(147, 414);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(24, 25);
            this.lbl_valorTotal.TabIndex = 2;
            this.lbl_valorTotal.Text = "_";
            // 
            // btn_quitaPedido
            // 
            this.btn_quitaPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_quitaPedido.ForeColor = System.Drawing.Color.White;
            this.btn_quitaPedido.Location = new System.Drawing.Point(20, 464);
            this.btn_quitaPedido.Name = "btn_quitaPedido";
            this.btn_quitaPedido.Size = new System.Drawing.Size(490, 51);
            this.btn_quitaPedido.TabIndex = 3;
            this.btn_quitaPedido.Text = "Marcar como quitado";
            this.btn_quitaPedido.UseVisualStyleBackColor = false;
            this.btn_quitaPedido.Click += new System.EventHandler(this.btn_quitaPedido_Click);
            // 
            // btn_excluidPedido
            // 
            this.btn_excluidPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_excluidPedido.ForeColor = System.Drawing.Color.White;
            this.btn_excluidPedido.Location = new System.Drawing.Point(516, 464);
            this.btn_excluidPedido.Name = "btn_excluidPedido";
            this.btn_excluidPedido.Size = new System.Drawing.Size(494, 51);
            this.btn_excluidPedido.TabIndex = 4;
            this.btn_excluidPedido.Text = "Excluir pedido";
            this.btn_excluidPedido.UseVisualStyleBackColor = false;
            this.btn_excluidPedido.Click += new System.EventHandler(this.btn_excluidPedido_Click);
            // 
            // DetalhesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 537);
            this.Controls.Add(this.btn_excluidPedido);
            this.Controls.Add(this.btn_quitaPedido);
            this.Controls.Add(this.lbl_valorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_pedido);
            this.Name = "DetalhesPedido";
            this.Text = "DetalhesPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Button btn_quitaPedido;
        private System.Windows.Forms.Button btn_excluidPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma_Pagamento;
    }
}