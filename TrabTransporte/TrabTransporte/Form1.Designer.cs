
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.produtos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnTransportadoras = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtos
            // 
            this.produtos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.produtos.Location = new System.Drawing.Point(12, 12);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(113, 23);
            this.produtos.TabIndex = 0;
            this.produtos.Text = "Produtos";
            this.produtos.UseVisualStyleBackColor = false;
            this.produtos.Click += new System.EventHandler(this.produtos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Location = new System.Drawing.Point(12, 41);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(113, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTransportadoras
            // 
            this.btnTransportadoras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransportadoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransportadoras.Location = new System.Drawing.Point(12, 70);
            this.btnTransportadoras.Name = "btnTransportadoras";
            this.btnTransportadoras.Size = new System.Drawing.Size(113, 23);
            this.btnTransportadoras.TabIndex = 2;
            this.btnTransportadoras.Text = "Transportadoras";
            this.btnTransportadoras.UseVisualStyleBackColor = false;
            this.btnTransportadoras.Click += new System.EventHandler(this.btnTransportadoras_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPedidos.Location = new System.Drawing.Point(461, 12);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(327, 126);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnTransportadoras);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "DT Transportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button produtos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnTransportadoras;
        private System.Windows.Forms.Button btnPedidos;
    }
}

