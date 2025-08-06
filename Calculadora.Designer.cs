namespace Calculadora
{
    partial class Calculadora
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
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            lblNumero2 = new Label();
            txtNumero2 = new TextBox();
            lblResultados = new Label();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(32, 32);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(60, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(32, 48);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(104, 23);
            txtNumero1.TabIndex = 1;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(168, 32);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(60, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(168, 48);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(96, 23);
            txtNumero2.TabIndex = 3;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultados.Location = new Point(392, 40);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(28, 32);
            lblResultados.TabIndex = 4;
            lblResultados.Text = "0";
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(16, 128);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(104, 32);
            btnSomar.TabIndex = 5;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(136, 128);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(104, 32);
            btnSubtrair.TabIndex = 6;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(256, 128);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(104, 32);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(376, 128);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(104, 32);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 218);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(lblResultados);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private TextBox txtNumero1;
        private Label lblNumero2;
        private TextBox txtNumero2;
        private Label lblResultados;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
    }
}
