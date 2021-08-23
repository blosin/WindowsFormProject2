namespace TP_PAV_3k2.Formularios.Producto
{
    partial class ActualizarStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblStockResultante = new System.Windows.Forms.Label();
            this.txtStockRemplazo = new System.Windows.Forms.TextBox();
            this.txtStockAgregado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Actual:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(91, 31);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(10, 13);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = ".";
            this.lblStock.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock a agregar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock nuevo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock resultante:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 156);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(99, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblStockResultante
            // 
            this.lblStockResultante.AutoSize = true;
            this.lblStockResultante.Location = new System.Drawing.Point(96, 125);
            this.lblStockResultante.Name = "lblStockResultante";
            this.lblStockResultante.Size = new System.Drawing.Size(10, 13);
            this.lblStockResultante.TabIndex = 7;
            this.lblStockResultante.Text = ".";
            // 
            // txtStockRemplazo
            // 
            this.txtStockRemplazo.Location = new System.Drawing.Point(99, 89);
            this.txtStockRemplazo.Name = "txtStockRemplazo";
            this.txtStockRemplazo.Size = new System.Drawing.Size(100, 20);
            this.txtStockRemplazo.TabIndex = 8;
            this.txtStockRemplazo.TextChanged += new System.EventHandler(this.txtStockRemplazo_TextChanged);
            this.txtStockRemplazo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStockRemplazo_KeyUp);
            // 
            // txtStockAgregado
            // 
            this.txtStockAgregado.Location = new System.Drawing.Point(99, 57);
            this.txtStockAgregado.Name = "txtStockAgregado";
            this.txtStockAgregado.Size = new System.Drawing.Size(100, 20);
            this.txtStockAgregado.TabIndex = 9;
            this.txtStockAgregado.TextChanged += new System.EventHandler(this.txtStockAgregado_TextChanged);
            this.txtStockAgregado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStockAgregado_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(62, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(10, 13);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = ".";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStockRemplazo);
            this.panel1.Controls.Add(this.lblProducto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.txtStockAgregado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblStockResultante);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 192);
            this.panel1.TabIndex = 12;
            // 
            // ActualizarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 215);
            this.Controls.Add(this.panel1);
            this.Name = "ActualizarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarStock";
            this.Load += new System.EventHandler(this.ActualizarStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblStockResultante;
        private System.Windows.Forms.TextBox txtStockRemplazo;
        private System.Windows.Forms.TextBox txtStockAgregado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel panel1;
    }
}