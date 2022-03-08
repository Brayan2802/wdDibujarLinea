namespace wdDibujarLinea
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtYi = new System.Windows.Forms.TextBox();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.lblYi = new System.Windows.Forms.Label();
            this.lblYf = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(538, 57);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(100, 20);
            this.txtYi.TabIndex = 0;
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(538, 123);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 20);
            this.txtYf.TabIndex = 2;
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(283, 57);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 20);
            this.txtXi.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(607, 210);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(283, 123);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 20);
            this.txtXf.TabIndex = 8;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(234, 60);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(43, 13);
            this.lblXi.TabIndex = 9;
            this.lblXi.Text = "X inicial";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(241, 126);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(36, 13);
            this.lblXf.TabIndex = 10;
            this.lblXf.Text = "X final";
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(489, 60);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(43, 13);
            this.lblYi.TabIndex = 12;
            this.lblYi.Text = "Y inicial";
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(498, 126);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(36, 13);
            this.lblYf.TabIndex = 14;
            this.lblYf.Text = "Y final";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(618, 194);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 13);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad lineas";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(416, 194);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(80, 36);
            this.btnDibujar.TabIndex = 17;
            this.btnDibujar.Text = "DibujarLinea";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblYf);
            this.Controls.Add(this.lblYi);
            this.Controls.Add(this.lblXf);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.txtYf);
            this.Controls.Add(this.txtYi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnDibujar;
    }
}

