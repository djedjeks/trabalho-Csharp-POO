
namespace TrabTransporte.Views
{
    partial class FrmPedidoNovo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelTransportadora = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxTransportadora = new System.Windows.Forms.ComboBox();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Novo Pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(626, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(707, 364);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelTransportadora
            // 
            this.labelTransportadora.AutoSize = true;
            this.labelTransportadora.Location = new System.Drawing.Point(12, 134);
            this.labelTransportadora.Name = "labelTransportadora";
            this.labelTransportadora.Size = new System.Drawing.Size(86, 15);
            this.labelTransportadora.TabIndex = 11;
            this.labelTransportadora.Text = "Transportadora";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 77);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(44, 15);
            this.labelCliente.TabIndex = 9;
            this.labelCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(13, 96);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(249, 23);
            this.comboBoxCliente.TabIndex = 18;
            // 
            // comboBoxTransportadora
            // 
            this.comboBoxTransportadora.FormattingEnabled = true;
            this.comboBoxTransportadora.Location = new System.Drawing.Point(12, 152);
            this.comboBoxTransportadora.Name = "comboBoxTransportadora";
            this.comboBoxTransportadora.Size = new System.Drawing.Size(250, 23);
            this.comboBoxTransportadora.TabIndex = 19;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.valorUnitario});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(268, 77);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(514, 281);
            this.dataGridViewProdutos.TabIndex = 20;
            this.dataGridViewProdutos.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewProdutos_DefaultValuesNeeded);
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.MaxDropDownItems = 10;
            this.produto.Name = "produto";
            this.produto.Sorted = true;
            this.produto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.produto.Width = 250;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // valorUnitario
            // 
            this.valorUnitario.DataPropertyName = "valorUnitario";
            this.valorUnitario.HeaderText = "Valor Unitário";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.Width = 120;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(75, 268);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(123, 30);
            this.lblValorTotal.TabIndex = 21;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxValorTotal.Location = new System.Drawing.Point(13, 301);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.ReadOnly = true;
            this.textBoxValorTotal.Size = new System.Drawing.Size(249, 36);
            this.textBoxValorTotal.TabIndex = 22;
            this.textBoxValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 397);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.comboBoxTransportadora);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelTransportadora);
            this.Controls.Add(this.labelCliente);
            this.Name = "FrmPedidoNovo";
            this.Text = "FrmPedidoNovo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelTransportadora;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxTransportadora;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.DataGridViewComboBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
    }
}