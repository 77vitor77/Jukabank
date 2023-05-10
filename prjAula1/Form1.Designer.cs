namespace prjAula1
{
    partial class Form1
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
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            btnAcessar = new Button();
            aqui = new Label();
            lblLogin = new Label();
            btnEsqueceuSenha = new Button();
            lblJukasBank = new Label();
            btnCadastrar = new Button();
            lblMensagem = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(285, 217);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(133, 33);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "senha";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(285, 173);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(133, 33);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "usuário";
            txtUsuario.TextChanged += textBox2_TextChanged;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = SystemColors.Window;
            btnAcessar.BackgroundImageLayout = ImageLayout.None;
            btnAcessar.FlatStyle = FlatStyle.Popup;
            btnAcessar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcessar.ForeColor = Color.Black;
            btnAcessar.Location = new Point(302, 293);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(91, 41);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += button1_Click;
            // 
            // aqui
            // 
            aqui.AutoSize = true;
            aqui.Location = new Point(347, 199);
            aqui.Name = "aqui";
            aqui.Size = new Size(0, 15);
            aqui.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.LavenderBlush;
            lblLogin.Location = new Point(285, 89);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(133, 40);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += label1_Click;
            // 
            // btnEsqueceuSenha
            // 
            btnEsqueceuSenha.BackColor = Color.DarkSlateGray;
            btnEsqueceuSenha.BackgroundImageLayout = ImageLayout.None;
            btnEsqueceuSenha.Cursor = Cursors.Hand;
            btnEsqueceuSenha.FlatStyle = FlatStyle.Flat;
            btnEsqueceuSenha.ForeColor = SystemColors.ButtonFace;
            btnEsqueceuSenha.Location = new Point(266, 340);
            btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            btnEsqueceuSenha.Size = new Size(178, 23);
            btnEsqueceuSenha.TabIndex = 6;
            btnEsqueceuSenha.Text = "Esqueceu a senha?";
            btnEsqueceuSenha.UseVisualStyleBackColor = false;
            btnEsqueceuSenha.Click += button2_Click;
            // 
            // lblJukasBank
            // 
            lblJukasBank.AutoSize = true;
            lblJukasBank.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblJukasBank.ForeColor = Color.Snow;
            lblJukasBank.Location = new Point(12, 25);
            lblJukasBank.Name = "lblJukasBank";
            lblJukasBank.Size = new Size(165, 45);
            lblJukasBank.TabIndex = 7;
            lblJukasBank.Text = "JUCAS BANK";
            lblJukasBank.Click += label2_Click_1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkSlateGray;
            btnCadastrar.BackgroundImageLayout = ImageLayout.None;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ButtonFace;
            btnCadastrar.Location = new Point(266, 369);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(178, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar-se";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button3_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.ForeColor = SystemColors.ControlLightLight;
            lblMensagem.Location = new Point(314, 419);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(66, 15);
            lblMensagem.TabIndex = 9;
            lblMensagem.Text = "Mensagem";
            lblMensagem.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(319, 523);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 10;
            label2.Text = "JUKAS BANK";
            label2.Click += label2_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(724, 559);
            Controls.Add(label2);
            Controls.Add(lblMensagem);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEsqueceuSenha);
            Controls.Add(lblLogin);
            Controls.Add(aqui);
            Controls.Add(btnAcessar);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(lblJukasBank);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Hello Word2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnAcessar;
        private Label aqui;
        private Label lblLogin;
        private Button btnEsqueceuSenha;
        private Label lblJukasBank;
        private Button btnCadastrar;
        private Label lblMensagem;
        private Label label2;
    }
}