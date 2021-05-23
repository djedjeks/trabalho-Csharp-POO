
namespace TrabTransporte.Views
{
    partial class FrmCliente
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnAlteraCliente = new System.Windows.Forms.Button();
            this.btnDeletaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome_completo,
            this.cpf,
            this.data_nascimento,
            this.sexo,
            this.cidade,
            this.estado});
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowTemplate.Height = 25;
            this.dataGridViewClientes.Size = new System.Drawing.Size(716, 381);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // nome_completo
            // 
            this.nome_completo.DataPropertyName = "nome_completo";
            this.nome_completo.HeaderText = "Nome Completo";
            this.nome_completo.Name = "nome_completo";
            this.nome_completo.ReadOnly = true;
            this.nome_completo.Width = 200;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // data_nascimento
            // 
            this.data_nascimento.DataPropertyName = "data_nascimento";
            this.data_nascimento.HeaderText = "Data de Nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 40;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 150;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 50;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(623, 16);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(105, 23);
            this.btnNovoCliente.TabIndex = 2;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnAlteraCliente
            // 
            this.btnAlteraCliente.Location = new System.Drawing.Point(512, 432);
            this.btnAlteraCliente.Name = "btnAlteraCliente";
            this.btnAlteraCliente.Size = new System.Drawing.Size(105, 23);
            this.btnAlteraCliente.TabIndex = 5;
            this.btnAlteraCliente.Text = "Alterar Cliente";
            this.btnAlteraCliente.UseVisualStyleBackColor = true;
            this.btnAlteraCliente.Click += new System.EventHandler(this.btnAlteraCliente_Click);
            // 
            // btnDeletaCliente
            // 
            this.btnDeletaCliente.Location = new System.Drawing.Point(623, 432);
            this.btnDeletaCliente.Name = "btnDeletaCliente";
            this.btnDeletaCliente.Size = new System.Drawing.Size(105, 23);
            this.btnDeletaCliente.TabIndex = 4;
            this.btnDeletaCliente.Text = "Deletar Cliente";
            this.btnDeletaCliente.UseVisualStyleBackColor = true;
            this.btnDeletaCliente.Click += new System.EventHandler(this.btnDeletaCliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 482);
            this.Controls.Add(this.btnAlteraCliente);
            this.Controls.Add(this.btnDeletaCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnAlteraCliente;
        private System.Windows.Forms.Button btnDeletaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}