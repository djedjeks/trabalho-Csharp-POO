
namespace TrabTransporte.Views
{
    partial class FrmClienteAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteAlterar));
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(197, 261);
            this.textBoxEstado.MaxLength = 2;
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(44, 23);
            this.textBoxEstado.TabIndex = 38;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(197, 243);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(42, 15);
            this.labelEstado.TabIndex = 37;
            this.labelEstado.Text = "Estado";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(12, 261);
            this.textBoxCidade.MaxLength = 40;
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(179, 23);
            this.textBoxCidade.TabIndex = 36;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(12, 243);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 15);
            this.labelCidade.TabIndex = 35;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(159, 199);
            this.textBoxSexo.MaxLength = 1;
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(27, 23);
            this.textBoxSexo.TabIndex = 34;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(159, 181);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(32, 15);
            this.labelSexo.TabIndex = 33;
            this.labelSexo.Text = "Sexo";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 181);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.labelDataNascimento.TabIndex = 32;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(13, 199);
            this.dateTimePickerDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(113, 23);
            this.dateTimePickerDataNascimento.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(25, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(154, 303);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(12, 143);
            this.textBoxNomeCompleto.MaxLength = 40;
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(250, 23);
            this.textBoxNomeCompleto.TabIndex = 28;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(12, 125);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(96, 15);
            this.labelNomeCompleto.TabIndex = 27;
            this.labelNomeCompleto.Text = "Nome Completo";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(12, 86);
            this.textBoxCpf.MaxLength = 11;
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(100, 23);
            this.textBoxCpf.TabIndex = 26;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(12, 68);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 25;
            this.labelCpf.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 43);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alterar Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmClienteAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 349);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.labelNomeCompleto);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClienteAlterar";
            this.Text = "Alterar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label label2;
    }
}