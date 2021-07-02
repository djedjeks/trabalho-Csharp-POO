
namespace TrabTransporte.Views
{
    partial class FrmPedidoDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoDetalhes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPedidoId = new System.Windows.Forms.Label();
            this.textBoxPedidoId = new System.Windows.Forms.TextBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.textBoxClienteEstado = new System.Windows.Forms.TextBox();
            this.lblClienteEstado = new System.Windows.Forms.Label();
            this.textBoxClienteCidade = new System.Windows.Forms.TextBox();
            this.lblClienteCidade = new System.Windows.Forms.Label();
            this.textBoxClienteSexo = new System.Windows.Forms.TextBox();
            this.lblClienteSexo = new System.Windows.Forms.Label();
            this.textBoxClienteCPF = new System.Windows.Forms.TextBox();
            this.lblClienteCPF = new System.Windows.Forms.Label();
            this.textBoxClienteNome = new System.Windows.Forms.TextBox();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.groupBoxTransportadora = new System.Windows.Forms.GroupBox();
            this.textBoxTransportadoraEstado = new System.Windows.Forms.TextBox();
            this.labelTransportadoraEstado = new System.Windows.Forms.Label();
            this.textBoxTransportadoraCidade = new System.Windows.Forms.TextBox();
            this.lblTransportadoraCidade = new System.Windows.Forms.Label();
            this.textBoxTransportadoraCNPJ = new System.Windows.Forms.TextBox();
            this.lblTransportadoraCNPJ = new System.Windows.Forms.Label();
            this.textBoxTransportadoraNome = new System.Windows.Forms.TextBox();
            this.lblNomeTransportadora = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.textBoxDataEmissao = new System.Windows.Forms.TextBox();
            this.textBoxDataEntrega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxTransportadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(138, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalhamento de Pedido";
            // 
            // lblPedidoId
            // 
            this.lblPedidoId.AutoSize = true;
            this.lblPedidoId.BackColor = System.Drawing.Color.Transparent;
            this.lblPedidoId.Location = new System.Drawing.Point(11, 68);
            this.lblPedidoId.Name = "lblPedidoId";
            this.lblPedidoId.Size = new System.Drawing.Size(69, 13);
            this.lblPedidoId.TabIndex = 1;
            this.lblPedidoId.Text = "ID do Pedido";
            // 
            // textBoxPedidoId
            // 
            this.textBoxPedidoId.Location = new System.Drawing.Point(11, 84);
            this.textBoxPedidoId.Name = "textBoxPedidoId";
            this.textBoxPedidoId.ReadOnly = true;
            this.textBoxPedidoId.Size = new System.Drawing.Size(65, 20);
            this.textBoxPedidoId.TabIndex = 2;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCliente.Controls.Add(this.textBoxClienteEstado);
            this.groupBoxCliente.Controls.Add(this.lblClienteEstado);
            this.groupBoxCliente.Controls.Add(this.textBoxClienteCidade);
            this.groupBoxCliente.Controls.Add(this.lblClienteCidade);
            this.groupBoxCliente.Controls.Add(this.textBoxClienteSexo);
            this.groupBoxCliente.Controls.Add(this.lblClienteSexo);
            this.groupBoxCliente.Controls.Add(this.textBoxClienteCPF);
            this.groupBoxCliente.Controls.Add(this.lblClienteCPF);
            this.groupBoxCliente.Controls.Add(this.textBoxClienteNome);
            this.groupBoxCliente.Controls.Add(this.lblClienteNome);
            this.groupBoxCliente.Location = new System.Drawing.Point(10, 123);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(575, 69);
            this.groupBoxCliente.TabIndex = 4;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // textBoxClienteEstado
            // 
            this.textBoxClienteEstado.Location = new System.Drawing.Point(521, 36);
            this.textBoxClienteEstado.Name = "textBoxClienteEstado";
            this.textBoxClienteEstado.ReadOnly = true;
            this.textBoxClienteEstado.Size = new System.Drawing.Size(37, 20);
            this.textBoxClienteEstado.TabIndex = 13;
            // 
            // lblClienteEstado
            // 
            this.lblClienteEstado.AutoSize = true;
            this.lblClienteEstado.Location = new System.Drawing.Point(522, 20);
            this.lblClienteEstado.Name = "lblClienteEstado";
            this.lblClienteEstado.Size = new System.Drawing.Size(40, 13);
            this.lblClienteEstado.TabIndex = 12;
            this.lblClienteEstado.Text = "Estado";
            // 
            // textBoxClienteCidade
            // 
            this.textBoxClienteCidade.Location = new System.Drawing.Point(367, 36);
            this.textBoxClienteCidade.Name = "textBoxClienteCidade";
            this.textBoxClienteCidade.ReadOnly = true;
            this.textBoxClienteCidade.Size = new System.Drawing.Size(142, 20);
            this.textBoxClienteCidade.TabIndex = 11;
            // 
            // lblClienteCidade
            // 
            this.lblClienteCidade.AutoSize = true;
            this.lblClienteCidade.Location = new System.Drawing.Point(368, 20);
            this.lblClienteCidade.Name = "lblClienteCidade";
            this.lblClienteCidade.Size = new System.Drawing.Size(40, 13);
            this.lblClienteCidade.TabIndex = 10;
            this.lblClienteCidade.Text = "Cidade";
            // 
            // textBoxClienteSexo
            // 
            this.textBoxClienteSexo.Location = new System.Drawing.Point(327, 36);
            this.textBoxClienteSexo.Name = "textBoxClienteSexo";
            this.textBoxClienteSexo.ReadOnly = true;
            this.textBoxClienteSexo.Size = new System.Drawing.Size(29, 20);
            this.textBoxClienteSexo.TabIndex = 9;
            // 
            // lblClienteSexo
            // 
            this.lblClienteSexo.AutoSize = true;
            this.lblClienteSexo.Location = new System.Drawing.Point(328, 20);
            this.lblClienteSexo.Name = "lblClienteSexo";
            this.lblClienteSexo.Size = new System.Drawing.Size(31, 13);
            this.lblClienteSexo.TabIndex = 8;
            this.lblClienteSexo.Text = "Sexo";
            // 
            // textBoxClienteCPF
            // 
            this.textBoxClienteCPF.Location = new System.Drawing.Point(193, 36);
            this.textBoxClienteCPF.Name = "textBoxClienteCPF";
            this.textBoxClienteCPF.ReadOnly = true;
            this.textBoxClienteCPF.Size = new System.Drawing.Size(122, 20);
            this.textBoxClienteCPF.TabIndex = 7;
            // 
            // lblClienteCPF
            // 
            this.lblClienteCPF.AutoSize = true;
            this.lblClienteCPF.Location = new System.Drawing.Point(194, 20);
            this.lblClienteCPF.Name = "lblClienteCPF";
            this.lblClienteCPF.Size = new System.Drawing.Size(27, 13);
            this.lblClienteCPF.TabIndex = 6;
            this.lblClienteCPF.Text = "CPF";
            // 
            // textBoxClienteNome
            // 
            this.textBoxClienteNome.Location = new System.Drawing.Point(5, 36);
            this.textBoxClienteNome.Name = "textBoxClienteNome";
            this.textBoxClienteNome.ReadOnly = true;
            this.textBoxClienteNome.Size = new System.Drawing.Size(176, 20);
            this.textBoxClienteNome.TabIndex = 5;
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Location = new System.Drawing.Point(6, 20);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(35, 13);
            this.lblClienteNome.TabIndex = 0;
            this.lblClienteNome.Text = "Nome";
            // 
            // groupBoxTransportadora
            // 
            this.groupBoxTransportadora.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTransportadora.Controls.Add(this.textBoxTransportadoraEstado);
            this.groupBoxTransportadora.Controls.Add(this.labelTransportadoraEstado);
            this.groupBoxTransportadora.Controls.Add(this.textBoxTransportadoraCidade);
            this.groupBoxTransportadora.Controls.Add(this.lblTransportadoraCidade);
            this.groupBoxTransportadora.Controls.Add(this.textBoxTransportadoraCNPJ);
            this.groupBoxTransportadora.Controls.Add(this.lblTransportadoraCNPJ);
            this.groupBoxTransportadora.Controls.Add(this.textBoxTransportadoraNome);
            this.groupBoxTransportadora.Controls.Add(this.lblNomeTransportadora);
            this.groupBoxTransportadora.Location = new System.Drawing.Point(10, 198);
            this.groupBoxTransportadora.Name = "groupBoxTransportadora";
            this.groupBoxTransportadora.Size = new System.Drawing.Size(575, 69);
            this.groupBoxTransportadora.TabIndex = 14;
            this.groupBoxTransportadora.TabStop = false;
            this.groupBoxTransportadora.Text = "Transportadora";
            // 
            // textBoxTransportadoraEstado
            // 
            this.textBoxTransportadoraEstado.Location = new System.Drawing.Point(521, 36);
            this.textBoxTransportadoraEstado.Name = "textBoxTransportadoraEstado";
            this.textBoxTransportadoraEstado.ReadOnly = true;
            this.textBoxTransportadoraEstado.Size = new System.Drawing.Size(37, 20);
            this.textBoxTransportadoraEstado.TabIndex = 13;
            // 
            // labelTransportadoraEstado
            // 
            this.labelTransportadoraEstado.AutoSize = true;
            this.labelTransportadoraEstado.Location = new System.Drawing.Point(522, 20);
            this.labelTransportadoraEstado.Name = "labelTransportadoraEstado";
            this.labelTransportadoraEstado.Size = new System.Drawing.Size(40, 13);
            this.labelTransportadoraEstado.TabIndex = 12;
            this.labelTransportadoraEstado.Text = "Estado";
            // 
            // textBoxTransportadoraCidade
            // 
            this.textBoxTransportadoraCidade.Location = new System.Drawing.Point(367, 36);
            this.textBoxTransportadoraCidade.Name = "textBoxTransportadoraCidade";
            this.textBoxTransportadoraCidade.ReadOnly = true;
            this.textBoxTransportadoraCidade.Size = new System.Drawing.Size(142, 20);
            this.textBoxTransportadoraCidade.TabIndex = 11;
            // 
            // lblTransportadoraCidade
            // 
            this.lblTransportadoraCidade.AutoSize = true;
            this.lblTransportadoraCidade.Location = new System.Drawing.Point(368, 20);
            this.lblTransportadoraCidade.Name = "lblTransportadoraCidade";
            this.lblTransportadoraCidade.Size = new System.Drawing.Size(40, 13);
            this.lblTransportadoraCidade.TabIndex = 10;
            this.lblTransportadoraCidade.Text = "Cidade";
            // 
            // textBoxTransportadoraCNPJ
            // 
            this.textBoxTransportadoraCNPJ.Location = new System.Drawing.Point(193, 36);
            this.textBoxTransportadoraCNPJ.Name = "textBoxTransportadoraCNPJ";
            this.textBoxTransportadoraCNPJ.ReadOnly = true;
            this.textBoxTransportadoraCNPJ.Size = new System.Drawing.Size(160, 20);
            this.textBoxTransportadoraCNPJ.TabIndex = 7;
            // 
            // lblTransportadoraCNPJ
            // 
            this.lblTransportadoraCNPJ.AutoSize = true;
            this.lblTransportadoraCNPJ.Location = new System.Drawing.Point(194, 20);
            this.lblTransportadoraCNPJ.Name = "lblTransportadoraCNPJ";
            this.lblTransportadoraCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblTransportadoraCNPJ.TabIndex = 6;
            this.lblTransportadoraCNPJ.Text = "CNPJ";
            // 
            // textBoxTransportadoraNome
            // 
            this.textBoxTransportadoraNome.Location = new System.Drawing.Point(5, 36);
            this.textBoxTransportadoraNome.Name = "textBoxTransportadoraNome";
            this.textBoxTransportadoraNome.ReadOnly = true;
            this.textBoxTransportadoraNome.Size = new System.Drawing.Size(176, 20);
            this.textBoxTransportadoraNome.TabIndex = 5;
            // 
            // lblNomeTransportadora
            // 
            this.lblNomeTransportadora.AutoSize = true;
            this.lblNomeTransportadora.Location = new System.Drawing.Point(6, 20);
            this.lblNomeTransportadora.Name = "lblNomeTransportadora";
            this.lblNomeTransportadora.Size = new System.Drawing.Size(35, 13);
            this.lblNomeTransportadora.TabIndex = 0;
            this.lblNomeTransportadora.Text = "Nome";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.produto_descricao,
            this.quantidade,
            this.valor_unitario,
            this.peso_unitario});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(11, 19);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(553, 218);
            this.dataGridViewProdutos.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridViewProdutos);
            this.groupBox1.Location = new System.Drawing.Point(10, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 257);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(148, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de Emissão";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(521, 84);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.ReadOnly = true;
            this.textBoxValorTotal.Size = new System.Drawing.Size(65, 20);
            this.textBoxValorTotal.TabIndex = 18;
            // 
            // textBoxDataEmissao
            // 
            this.textBoxDataEmissao.Location = new System.Drawing.Point(129, 84);
            this.textBoxDataEmissao.Name = "textBoxDataEmissao";
            this.textBoxDataEmissao.ReadOnly = true;
            this.textBoxDataEmissao.Size = new System.Drawing.Size(116, 20);
            this.textBoxDataEmissao.TabIndex = 19;
            // 
            // textBoxDataEntrega
            // 
            this.textBoxDataEntrega.Location = new System.Drawing.Point(249, 84);
            this.textBoxDataEntrega.Name = "textBoxDataEntrega";
            this.textBoxDataEntrega.ReadOnly = true;
            this.textBoxDataEntrega.Size = new System.Drawing.Size(116, 20);
            this.textBoxDataEntrega.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(264, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data de Entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(533, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor Total";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // produto_descricao
            // 
            this.produto_descricao.DataPropertyName = "produto_descricao";
            this.produto_descricao.HeaderText = "Produto";
            this.produto_descricao.Name = "produto_descricao";
            this.produto_descricao.ReadOnly = true;
            this.produto_descricao.Width = 180;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 80;
            // 
            // valor_unitario
            // 
            this.valor_unitario.HeaderText = "Valor Unitário";
            this.valor_unitario.Name = "valor_unitario";
            this.valor_unitario.ReadOnly = true;
            this.valor_unitario.Width = 80;
            // 
            // peso_unitario
            // 
            this.peso_unitario.HeaderText = "Peso Unitário";
            this.peso_unitario.Name = "peso_unitario";
            this.peso_unitario.ReadOnly = true;
            this.peso_unitario.Width = 80;
            // 
            // FrmPedidoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDataEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDataEmissao);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTransportadora);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.textBoxPedidoId);
            this.Controls.Add(this.lblPedidoId);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidoDetalhes";
            this.Text = "Detalhamento de Pedido";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxTransportadora.ResumeLayout(false);
            this.groupBoxTransportadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPedidoId;
        private System.Windows.Forms.TextBox textBoxPedidoId;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox textBoxClienteEstado;
        private System.Windows.Forms.Label lblClienteEstado;
        private System.Windows.Forms.TextBox textBoxClienteCidade;
        private System.Windows.Forms.Label lblClienteCidade;
        private System.Windows.Forms.TextBox textBoxClienteSexo;
        private System.Windows.Forms.Label lblClienteSexo;
        private System.Windows.Forms.TextBox textBoxClienteCPF;
        private System.Windows.Forms.Label lblClienteCPF;
        private System.Windows.Forms.TextBox textBoxClienteNome;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.GroupBox groupBoxTransportadora;
        private System.Windows.Forms.TextBox textBoxTransportadoraEstado;
        private System.Windows.Forms.Label labelTransportadoraEstado;
        private System.Windows.Forms.TextBox textBoxTransportadoraCidade;
        private System.Windows.Forms.Label lblTransportadoraCidade;
        private System.Windows.Forms.TextBox textBoxTransportadoraCNPJ;
        private System.Windows.Forms.Label lblTransportadoraCNPJ;
        private System.Windows.Forms.TextBox textBoxTransportadoraNome;
        private System.Windows.Forms.Label lblNomeTransportadora;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.TextBox textBoxDataEmissao;
        private System.Windows.Forms.TextBox textBoxDataEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_unitario;
    }
}