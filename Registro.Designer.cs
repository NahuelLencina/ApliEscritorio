
namespace ApliEscritorio
{
    partial class Registro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblConfiPass = new System.Windows.Forms.Label();
            this.txtConfirPass = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(186, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registrate";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(126, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(233, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(161, 114);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 14;
            this.lblPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(233, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 13;
            // 
            // lblConfiPass
            // 
            this.lblConfiPass.AutoSize = true;
            this.lblConfiPass.Location = new System.Drawing.Point(114, 154);
            this.lblConfiPass.Name = "lblConfiPass";
            this.lblConfiPass.Size = new System.Drawing.Size(108, 13);
            this.lblConfiPass.TabIndex = 16;
            this.lblConfiPass.Text = "Confirmar Contraseña";
            // 
            // txtConfirPass
            // 
            this.txtConfirPass.Location = new System.Drawing.Point(233, 151);
            this.txtConfirPass.Name = "txtConfirPass";
            this.txtConfirPass.PasswordChar = '*';
            this.txtConfirPass.Size = new System.Drawing.Size(100, 20);
            this.txtConfirPass.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(387, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 42);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(233, 177);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 42);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrarme";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Location = new System.Drawing.Point(233, 235);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(91, 42);
            this.btnInicioSesion.TabIndex = 19;
            this.btnInicioSesion.Text = "Inicio sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblConfiPass);
            this.Controls.Add(this.txtConfirPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblConfiPass;
        private System.Windows.Forms.TextBox txtConfirPass;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnInicioSesion;
    }
}