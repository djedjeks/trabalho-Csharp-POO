
namespace TrabTransporte
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.produtos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnTransportadoras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtos
            // 
            this.produtos.Location = new System.Drawing.Point(12, 12);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(113, 23);
            this.produtos.TabIndex = 0;
            this.produtos.Text = "Produtos";
            this.produtos.UseVisualStyleBackColor = true;
            this.produtos.Click += new System.EventHandler(this.produtos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 41);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(113, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTransportadoras
            // 
            this.btnTransportadoras.Location = new System.Drawing.Point(12, 70);
            this.btnTransportadoras.Name = "btnTransportadoras";
            this.btnTransportadoras.Size = new System.Drawing.Size(113, 23);
            this.btnTransportadoras.TabIndex = 2;
            this.btnTransportadoras.Text = "Transportadoras";
            this.btnTransportadoras.UseVisualStyleBackColor = true;
            this.btnTransportadoras.Click += new System.EventHandler(this.btnTransportadoras_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransportadoras);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.produtos);
            this.Name = "FrmPrincipal";
            this.Text = "DT Transportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button produtos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnTransportadoras;
    }
}

