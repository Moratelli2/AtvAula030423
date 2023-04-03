namespace ProjAula030423
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcImc = new System.Windows.Forms.Button();
            this.peso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcImc
            // 
            this.calcImc.Location = new System.Drawing.Point(59, 163);
            this.calcImc.Name = "calcImc";
            this.calcImc.Size = new System.Drawing.Size(75, 23);
            this.calcImc.TabIndex = 0;
            this.calcImc.Text = "Calcular";
            this.calcImc.UseVisualStyleBackColor = true;
            this.calcImc.Click += new System.EventHandler(this.calcImc_Click);
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(55, 43);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(45, 20);
            this.peso.TabIndex = 1;
            this.peso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(59, 66);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 2;
            
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(59, 127);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(55, 104);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(51, 20);
            this.altura.TabIndex = 4;
            this.altura.Text = "Altura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 264);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.calcImc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcImc;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label altura;
    }
}

