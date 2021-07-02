
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtos
            // 
            this.produtos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.produtos.Location = new System.Drawing.Point(10, 10);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(97, 20);
            this.produtos.TabIndex = 0;
            this.produtos.Text = "Produtos";
            this.produtos.UseVisualStyleBackColor = false;
            this.produtos.Click += new System.EventHandler(this.produtos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Location = new System.Drawing.Point(10, 36);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(97, 20);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTransportadoras
            // 
            this.btnTransportadoras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransportadoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransportadoras.Location = new System.Drawing.Point(10, 61);
            this.btnTransportadoras.Name = "btnTransportadoras";
            this.btnTransportadoras.Size = new System.Drawing.Size(97, 20);
            this.btnTransportadoras.TabIndex = 2;
            this.btnTransportadoras.Text = "Transportadoras";
            this.btnTransportadoras.UseVisualStyleBackColor = false;
            this.btnTransportadoras.Click += new System.EventHandler(this.btnTransportadoras_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.btnPedidos.Location = new System.Drawing.Point(395, 10);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(280, 109);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(113, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Produtos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(113, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(113, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 20);
            this.button3.TabIndex = 6;
            this.button3.Text = "Transportadoras";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

