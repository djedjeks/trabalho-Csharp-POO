
namespace TrabTransporte.Views
{
    partial class FrmPedido
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
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportadora_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.btnDeletarPedido = new System.Windows.Forms.Button();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.btnDetalharPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente_nome,
            this.transportadora_nome,
            this.data_emissao,
            this.data_entrega,
            this.valor_total});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.RowTemplate.Height = 25;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(796, 381);
            this.dataGridViewPedidos.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // cliente_nome
            // 
            this.cliente_nome.DataPropertyName = "cliente_nome";
            this.cliente_nome.HeaderText = "Nome do Cliente";
            this.cliente_nome.Name = "cliente_nome";
            this.cliente_nome.ReadOnly = true;
            this.cliente_nome.Width = 200;
            // 
            // transportadora_nome
            // 
            this.transportadora_nome.DataPropertyName = "transportadora_nome";
            this.transportadora_nome.HeaderText = "Nome da Transportadora";
            this.transportadora_nome.Name = "transportadora_nome";
            this.transportadora_nome.ReadOnly = true;
            this.transportadora_nome.Width = 200;
            // 
            // data_emissao
            // 
            this.data_emissao.DataPropertyName = "data_emissao";
            this.data_emissao.HeaderText = "Data de Emissão";
            this.data_emissao.Name = "data_emissao";
            this.data_emissao.ReadOnly = true;
            // 
            // data_entrega
            // 
            this.data_entrega.DataPropertyName = "data_entrega";
            this.data_entrega.HeaderText = "Data de Entrega";
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.ReadOnly = true;
            // 
            // valor_total
            // 
            this.valor_total.DataPropertyName = "valor_total";
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Location = new System.Drawing.Point(703, 28);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(104, 23);
            this.btnNovoPedido.TabIndex = 3;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // btnDeletarPedido
            // 
            this.btnDeletarPedido.Location = new System.Drawing.Point(704, 444);
            this.btnDeletarPedido.Name = "btnDeletarPedido";
            this.btnDeletarPedido.Size = new System.Drawing.Size(104, 23);
            this.btnDeletarPedido.TabIndex = 4;
            this.btnDeletarPedido.Text = "Deletar Pedido";
            this.btnDeletarPedido.UseVisualStyleBackColor = true;
            this.btnDeletarPedido.Click += new System.EventHandler(this.btnDeletarPedido_Click);
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.Location = new System.Drawing.Point(594, 444);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(104, 23);
            this.btnAlterarPedido.TabIndex = 5;
            this.btnAlterarPedido.Text = "AlterarPedido";
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            this.btnAlterarPedido.Click += new System.EventHandler(this.btnAlterarPedido_Click);
            // 
            // btnDetalharPedido
            // 
            this.btnDetalharPedido.Location = new System.Drawing.Point(484, 444);
            this.btnDetalharPedido.Name = "btnDetalharPedido";
            this.btnDetalharPedido.Size = new System.Drawing.Size(104, 23);
            this.btnDetalharPedido.TabIndex = 6;
            this.btnDetalharPedido.Text = "Detalhar Pedido";
            this.btnDetalharPedido.UseVisualStyleBackColor = true;
            this.btnDetalharPedido.Click += new System.EventHandler(this.btnDetalharPedido_Click);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 520);
            this.Controls.Add(this.btnDetalharPedido);
            this.Controls.Add(this.btnAlterarPedido);
            this.Controls.Add(this.btnDeletarPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportadora_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnDeletarPedido;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.Button btnDetalharPedido;
    }
}