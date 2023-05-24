namespace prjAula1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtUsuario = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(191, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 244);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(298, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(156, 45);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "CADASTRAR";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.ScrollBar;
            txtUsuario.Location = new Point(264, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 33);
            txtUsuario.TabIndex = 17;
            txtUsuario.Text = "nome completo";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(264, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 33);
            textBox2.TabIndex = 19;
            textBox2.Text = "senha(6 digitos)";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(264, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(217, 33);
            textBox5.TabIndex = 22;
            textBox5.Text = "cpf";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(264, 233);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(217, 33);
            textBox6.TabIndex = 23;
            textBox6.Text = "data de nascimento";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = SystemColors.ScrollBar;
            textBox7.Location = new Point(264, 272);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(217, 33);
            textBox7.TabIndex = 24;
            textBox7.Text = "email";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.DeepPink;
            radioButton3.Location = new Point(422, 339);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 29);
            radioButton3.TabIndex = 27;
            radioButton3.TabStop = true;
            radioButton3.Text = "outro";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.DeepPink;
            radioButton4.Location = new Point(248, 339);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(105, 29);
            radioButton4.TabIndex = 28;
            radioButton4.TabStop = true;
            radioButton4.Text = "feminino";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton5.ForeColor = Color.DeepPink;
            radioButton5.Location = new Point(248, 374);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(116, 29);
            radioButton5.TabIndex = 29;
            radioButton5.TabStop = true;
            radioButton5.Text = "masculino";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(289, 420);
            button2.Name = "button2";
            button2.Size = new Size(165, 36);
            button2.TabIndex = 30;
            button2.Text = "Criar Conta";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(536, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(725, 516);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(txtUsuario);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtUsuario;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button button2;
        internal protected PictureBox pictureBox2;
    }
}