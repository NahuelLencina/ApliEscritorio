
namespace ApliEscritorio
{
    partial class Calculo
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.lblPrimerNum = new System.Windows.Forms.Label();
            this.lblSegundoNum = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(385, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 42);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(26, 197);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(91, 42);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(141, 197);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(91, 42);
            this.btnRestar.TabIndex = 4;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(265, 197);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(91, 42);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(385, 197);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(91, 42);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(226, 29);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 7;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(226, 69);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 8;
            // 
            // txtResul
            // 
            this.txtResul.Enabled = false;
            this.txtResul.Location = new System.Drawing.Point(226, 118);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(100, 20);
            this.txtResul.TabIndex = 9;
            // 
            // lblPrimerNum
            // 
            this.lblPrimerNum.AutoSize = true;
            this.lblPrimerNum.Location = new System.Drawing.Point(138, 32);
            this.lblPrimerNum.Name = "lblPrimerNum";
            this.lblPrimerNum.Size = new System.Drawing.Size(82, 13);
            this.lblPrimerNum.TabIndex = 10;
            this.lblPrimerNum.Text = "Ingrese Número";
            // 
            // lblSegundoNum
            // 
            this.lblSegundoNum.AutoSize = true;
            this.lblSegundoNum.Location = new System.Drawing.Point(119, 72);
            this.lblSegundoNum.Name = "lblSegundoNum";
            this.lblSegundoNum.Size = new System.Drawing.Size(101, 13);
            this.lblSegundoNum.TabIndex = 11;
            this.lblSegundoNum.Text = "Ingrese otro número";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(165, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            // 
            // Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSegundoNum);
            this.Controls.Add(this.lblPrimerNum);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Label lblPrimerNum;
        private System.Windows.Forms.Label lblSegundoNum;
        private System.Windows.Forms.Label lblResultado;
    }
}