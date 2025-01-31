﻿
namespace TrabTransporte.Views
{
    partial class FrmPedidoAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoAlterar));
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTransportadora = new System.Windows.Forms.ComboBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelTransportadora = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxDataEmissao = new System.Windows.Forms.TextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.dateTimePickerDataEntrega = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxValorTotal.Location = new System.Drawing.Point(9, 261);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.ReadOnly = true;
            this.textBoxValorTotal.Size = new System.Drawing.Size(214, 36);
            this.textBoxValorTotal.TabIndex = 32;
            this.textBoxValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.Location = new System.Drawing.Point(63, 232);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(123, 30);
            this.lblValorTotal.TabIndex = 31;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.valorUnitario});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(238, 67);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(505, 244);
            this.dataGridViewProdutos.TabIndex = 30;
            this.dataGridViewProdutos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellValueChanged);
            this.dataGridViewProdutos.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewProdutos_DefaultValuesNeeded);
            this.dataGridViewProdutos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewProdutos_EditingControlShowing);
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
            // comboBoxTransportadora
            // 
            this.comboBoxTransportadora.FormattingEnabled = true;
            this.comboBoxTransportadora.Location = new System.Drawing.Point(9, 195);
            this.comboBoxTransportadora.Name = "comboBoxTransportadora";
            this.comboBoxTransportadora.Size = new System.Drawing.Size(215, 21);
            this.comboBoxTransportadora.TabIndex = 29;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(10, 146);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(214, 21);
            this.comboBoxCliente.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 43);
            this.label2.TabIndex = 27;
            this.label2.Text = "Editar Pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(608, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 20);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(677, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 20);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelTransportadora
            // 
            this.labelTransportadora.AutoSize = true;
            this.labelTransportadora.BackColor = System.Drawing.Color.Transparent;
            this.labelTransportadora.Location = new System.Drawing.Point(9, 179);
            this.labelTransportadora.Name = "labelTransportadora";
            this.labelTransportadora.Size = new System.Drawing.Size(79, 13);
            this.labelTransportadora.TabIndex = 24;
            this.labelTransportadora.Text = "Transportadora";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelCliente.Location = new System.Drawing.Point(9, 130);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 23;
            this.labelCliente.Text = "Cliente";
            // 
            // textBoxDataEmissao
            // 
            this.textBoxDataEmissao.Location = new System.Drawing.Point(97, 68);
            this.textBoxDataEmissao.Name = "textBoxDataEmissao";
            this.textBoxDataEmissao.ReadOnly = true;
            this.textBoxDataEmissao.Size = new System.Drawing.Size(131, 20);
            this.textBoxDataEmissao.TabIndex = 33;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrega.Location = new System.Drawing.Point(10, 103);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(85, 13);
            this.lblDataEntrega.TabIndex = 35;
            this.lblDataEntrega.Text = "Data de Entrega";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEmissao.Location = new System.Drawing.Point(10, 75);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(87, 13);
            this.lblDataEmissao.TabIndex = 34;
            this.lblDataEmissao.Text = "Data de Emissão";
            // 
            // dateTimePickerDataEntrega
            // 
            this.dateTimePickerDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataEntrega.Location = new System.Drawing.Point(97, 98);
            this.dateTimePickerDataEntrega.Name = "dateTimePickerDataEntrega";
            this.dateTimePickerDataEntrega.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerDataEntrega.TabIndex = 36;
            // 
            // FrmPedidoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 351);
            this.Controls.Add(this.dateTimePickerDataEntrega);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.textBoxDataEmissao);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidoAlterar";
            this.Text = "Alterar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.ComboBox comboBoxTransportadora;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelTransportadora;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxDataEmissao;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntrega;
    }
}