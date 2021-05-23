
namespace TrabTransporte.Views
{
    partial class FrmProduto
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
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnDeletaProduto = new System.Windows.Forms.Button();
            this.btnAlteraProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.descricao,
            this.peso});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(13, 57);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(476, 381);
            this.dataGridViewProdutos.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 200;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(383, 28);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(105, 23);
            this.btnNovoProduto.TabIndex = 1;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnDeletaProduto
            // 
            this.btnDeletaProduto.Location = new System.Drawing.Point(383, 444);
            this.btnDeletaProduto.Name = "btnDeletaProduto";
            this.btnDeletaProduto.Size = new System.Drawing.Size(105, 23);
            this.btnDeletaProduto.TabIndex = 2;
            this.btnDeletaProduto.Text = "Deletar Produto";
            this.btnDeletaProduto.UseVisualStyleBackColor = true;
            this.btnDeletaProduto.Click += new System.EventHandler(this.btnDeletaProduto_Click);
            // 
            // btnAlteraProduto
            // 
            this.btnAlteraProduto.Location = new System.Drawing.Point(272, 444);
            this.btnAlteraProduto.Name = "btnAlteraProduto";
            this.btnAlteraProduto.Size = new System.Drawing.Size(105, 23);
            this.btnAlteraProduto.TabIndex = 3;
            this.btnAlteraProduto.Text = "Alterar Produto";
            this.btnAlteraProduto.UseVisualStyleBackColor = true;
            this.btnAlteraProduto.Click += new System.EventHandler(this.btnAlteraProduto_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 500);
            this.Controls.Add(this.btnAlteraProduto);
            this.Controls.Add(this.btnDeletaProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnDeletaProduto;
        private System.Windows.Forms.Button btnAlteraProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
    }
}