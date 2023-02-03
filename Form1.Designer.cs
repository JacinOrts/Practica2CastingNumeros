namespace Practica2CastingNumeros
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
            this.btnConvertirEntero = new System.Windows.Forms.Button();
            this.btnConvertirReal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBDameEntero = new System.Windows.Forms.TextBox();
            this.lblDameEntero = new System.Windows.Forms.Label();
            this.lblDameReal = new System.Windows.Forms.Label();
            this.txtBDameReal = new System.Windows.Forms.TextBox();
            this.lblResultadoDoble = new System.Windows.Forms.Label();
            this.txtBResultadoDoble = new System.Windows.Forms.TextBox();
            this.lblResultadoMitad = new System.Windows.Forms.Label();
            this.txtBResultadoMitad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertirEntero
            // 
            this.btnConvertirEntero.Location = new System.Drawing.Point(362, 64);
            this.btnConvertirEntero.Name = "btnConvertirEntero";
            this.btnConvertirEntero.Size = new System.Drawing.Size(89, 23);
            this.btnConvertirEntero.TabIndex = 0;
            this.btnConvertirEntero.Text = "Convertir";
            this.btnConvertirEntero.UseVisualStyleBackColor = true;
            this.btnConvertirEntero.Click += new System.EventHandler(this.btnConvertirEntero_Click);
            // 
            // btnConvertirReal
            // 
            this.btnConvertirReal.Location = new System.Drawing.Point(362, 112);
            this.btnConvertirReal.Name = "btnConvertirReal";
            this.btnConvertirReal.Size = new System.Drawing.Size(89, 23);
            this.btnConvertirReal.TabIndex = 1;
            this.btnConvertirReal.Text = "Convertir";
            this.btnConvertirReal.UseVisualStyleBackColor = true;
            this.btnConvertirReal.Click += new System.EventHandler(this.btnConvertirReal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(362, 224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBDameEntero
            // 
            this.txtBDameEntero.Location = new System.Drawing.Point(226, 63);
            this.txtBDameEntero.Name = "txtBDameEntero";
            this.txtBDameEntero.Size = new System.Drawing.Size(100, 22);
            this.txtBDameEntero.TabIndex = 3;
            // 
            // lblDameEntero
            // 
            this.lblDameEntero.AutoSize = true;
            this.lblDameEntero.Location = new System.Drawing.Point(48, 67);
            this.lblDameEntero.Name = "lblDameEntero";
            this.lblDameEntero.Size = new System.Drawing.Size(150, 16);
            this.lblDameEntero.TabIndex = 4;
            this.lblDameEntero.Text = "Dame un número entero";
            // 
            // lblDameReal
            // 
            this.lblDameReal.AutoSize = true;
            this.lblDameReal.Location = new System.Drawing.Point(48, 112);
            this.lblDameReal.Name = "lblDameReal";
            this.lblDameReal.Size = new System.Drawing.Size(141, 16);
            this.lblDameReal.TabIndex = 5;
            this.lblDameReal.Text = "Dame un número real: ";
            // 
            // txtBDameReal
            // 
            this.txtBDameReal.Location = new System.Drawing.Point(226, 109);
            this.txtBDameReal.Name = "txtBDameReal";
            this.txtBDameReal.Size = new System.Drawing.Size(100, 22);
            this.txtBDameReal.TabIndex = 6;
            // 
            // lblResultadoDoble
            // 
            this.lblResultadoDoble.AutoSize = true;
            this.lblResultadoDoble.Location = new System.Drawing.Point(47, 170);
            this.lblResultadoDoble.Name = "lblResultadoDoble";
            this.lblResultadoDoble.Size = new System.Drawing.Size(151, 16);
            this.lblResultadoDoble.TabIndex = 7;
            this.lblResultadoDoble.Text = "El doble del número es: ";
            // 
            // txtBResultadoDoble
            // 
            this.txtBResultadoDoble.Location = new System.Drawing.Point(226, 170);
            this.txtBResultadoDoble.Name = "txtBResultadoDoble";
            this.txtBResultadoDoble.Size = new System.Drawing.Size(100, 22);
            this.txtBResultadoDoble.TabIndex = 8;
            // 
            // lblResultadoMitad
            // 
            this.lblResultadoMitad.AutoSize = true;
            this.lblResultadoMitad.Location = new System.Drawing.Point(40, 208);
            this.lblResultadoMitad.Name = "lblResultadoMitad";
            this.lblResultadoMitad.Size = new System.Drawing.Size(149, 16);
            this.lblResultadoMitad.TabIndex = 9;
            this.lblResultadoMitad.Text = "La mitad del número es:";
            // 
            // txtBResultadoMitad
            // 
            this.txtBResultadoMitad.Location = new System.Drawing.Point(226, 205);
            this.txtBResultadoMitad.Name = "txtBResultadoMitad";
            this.txtBResultadoMitad.Size = new System.Drawing.Size(100, 22);
            this.txtBResultadoMitad.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 308);
            this.Controls.Add(this.txtBResultadoMitad);
            this.Controls.Add(this.lblResultadoMitad);
            this.Controls.Add(this.txtBResultadoDoble);
            this.Controls.Add(this.lblResultadoDoble);
            this.Controls.Add(this.txtBDameReal);
            this.Controls.Add(this.lblDameReal);
            this.Controls.Add(this.lblDameEntero);
            this.Controls.Add(this.txtBDameEntero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertirReal);
            this.Controls.Add(this.btnConvertirEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirEntero;
        private System.Windows.Forms.Button btnConvertirReal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBDameEntero;
        private System.Windows.Forms.Label lblDameEntero;
        private System.Windows.Forms.Label lblDameReal;
        private System.Windows.Forms.TextBox txtBDameReal;
        private System.Windows.Forms.Label lblResultadoDoble;
        private System.Windows.Forms.TextBox txtBResultadoDoble;
        private System.Windows.Forms.Label lblResultadoMitad;
        private System.Windows.Forms.TextBox txtBResultadoMitad;
    }
}

