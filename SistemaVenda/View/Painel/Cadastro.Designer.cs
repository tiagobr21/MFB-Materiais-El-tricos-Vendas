namespace SistemaVenda.View.Painel
{
    partial class Cadastro
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
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            tbNome = new TextBox();
            tbSenha = new TextBox();
            textBox1 = new TextBox();
            Papel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(0, 192, 0);
            btnCadastrar.ForeColor = Color.Cornsilk;
            btnCadastrar.Location = new Point(169, 248);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(120, 51);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(40, 47);
            tbNome.Margin = new Padding(3, 4, 3, 4);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(362, 27);
            tbNome.TabIndex = 2;
            tbNome.TextChanged += tbNome_TextChanged;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(40, 127);
            tbSenha.Margin = new Padding(3, 4, 3, 4);
            tbSenha.Name = "tbSenha";
            tbSenha.Size = new Size(362, 27);
            tbSenha.TabIndex = 2;
            tbSenha.UseSystemPasswordChar = true;
            tbSenha.TextChanged += tbSenha_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 200);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Papel
            // 
            Papel.AutoSize = true;
            Papel.Location = new Point(40, 176);
            Papel.Name = "Papel";
            Papel.Size = new Size(39, 20);
            Papel.TabIndex = 3;
            Papel.Text = "Role";
            // 
            // button1
            // 
            button1.Location = new Point(321, 305);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(104, 31);
            button1.TabIndex = 5;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 349);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Papel);
            Controls.Add(tbSenha);
            Controls.Add(tbNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private TextBox tbNome;
        private TextBox tbSenha;
        private TextBox textBox1;
        private Label Papel;
        private Button button1;
    }
}