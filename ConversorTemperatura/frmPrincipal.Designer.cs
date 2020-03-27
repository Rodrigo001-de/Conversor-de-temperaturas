namespace ConversorTemperatura
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rbCelsius1 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit1 = new System.Windows.Forms.RadioButton();
            this.rbKelvin1 = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.rbCelsius2 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit2 = new System.Windows.Forms.RadioButton();
            this.rbKelvin2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.gbEntrada.SuspendLayout();
            this.gbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "valor:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(115, 311);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(446, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // rbCelsius1
            // 
            this.rbCelsius1.AutoSize = true;
            this.rbCelsius1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius1.Location = new System.Drawing.Point(26, 19);
            this.rbCelsius1.Name = "rbCelsius1";
            this.rbCelsius1.Size = new System.Drawing.Size(82, 29);
            this.rbCelsius1.TabIndex = 2;
            this.rbCelsius1.TabStop = true;
            this.rbCelsius1.Text = "Celsius";
            this.rbCelsius1.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit1
            // 
            this.rbFahrenheit1.AutoSize = true;
            this.rbFahrenheit1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit1.Location = new System.Drawing.Point(26, 117);
            this.rbFahrenheit1.Name = "rbFahrenheit1";
            this.rbFahrenheit1.Size = new System.Drawing.Size(111, 29);
            this.rbFahrenheit1.TabIndex = 2;
            this.rbFahrenheit1.TabStop = true;
            this.rbFahrenheit1.Text = "Fahrenheit";
            this.rbFahrenheit1.UseVisualStyleBackColor = true;
            // 
            // rbKelvin1
            // 
            this.rbKelvin1.AutoSize = true;
            this.rbKelvin1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin1.Location = new System.Drawing.Point(26, 68);
            this.rbKelvin1.Name = "rbKelvin1";
            this.rbKelvin1.Size = new System.Drawing.Size(80, 29);
            this.rbKelvin1.TabIndex = 2;
            this.rbKelvin1.TabStop = true;
            this.rbKelvin1.Text = "Kelvin";
            this.rbKelvin1.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbCelsius1);
            this.gbEntrada.Controls.Add(this.rbFahrenheit1);
            this.gbEntrada.Controls.Add(this.rbKelvin1);
            this.gbEntrada.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(42, 101);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(195, 178);
            this.gbEntrada.TabIndex = 3;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rbCelsius2);
            this.gbSaida.Controls.Add(this.rbFahrenheit2);
            this.gbSaida.Controls.Add(this.rbKelvin2);
            this.gbSaida.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaida.Location = new System.Drawing.Point(366, 101);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(195, 178);
            this.gbSaida.TabIndex = 3;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            // 
            // rbCelsius2
            // 
            this.rbCelsius2.AutoSize = true;
            this.rbCelsius2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius2.Location = new System.Drawing.Point(26, 19);
            this.rbCelsius2.Name = "rbCelsius2";
            this.rbCelsius2.Size = new System.Drawing.Size(82, 29);
            this.rbCelsius2.TabIndex = 2;
            this.rbCelsius2.TabStop = true;
            this.rbCelsius2.Text = "Celsius";
            this.rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit2
            // 
            this.rbFahrenheit2.AutoSize = true;
            this.rbFahrenheit2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit2.Location = new System.Drawing.Point(26, 117);
            this.rbFahrenheit2.Name = "rbFahrenheit2";
            this.rbFahrenheit2.Size = new System.Drawing.Size(111, 29);
            this.rbFahrenheit2.TabIndex = 2;
            this.rbFahrenheit2.TabStop = true;
            this.rbFahrenheit2.Text = "Fahrenheit";
            this.rbFahrenheit2.UseVisualStyleBackColor = true;
            // 
            // rbKelvin2
            // 
            this.rbKelvin2.AutoSize = true;
            this.rbKelvin2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin2.Location = new System.Drawing.Point(26, 68);
            this.rbKelvin2.Name = "rbKelvin2";
            this.rbKelvin2.Size = new System.Drawing.Size(80, 29);
            this.rbKelvin2.TabIndex = 2;
            this.rbKelvin2.TabStop = true;
            this.rbKelvin2.Text = "Kelvin";
            this.rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(115, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(446, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(357, 349);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 47);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(126, 349);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(102, 47);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 408);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.gbEntrada);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rbCelsius1;
        private System.Windows.Forms.RadioButton rbFahrenheit1;
        private System.Windows.Forms.RadioButton rbKelvin1;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.RadioButton rbCelsius2;
        private System.Windows.Forms.RadioButton rbFahrenheit2;
        private System.Windows.Forms.RadioButton rbKelvin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConverter;
    }
}

