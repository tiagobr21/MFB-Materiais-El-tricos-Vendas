
namespace SistemaVenda.Forms
{
    partial class PainelPrincipalGerente
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
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(717, 0);
            label5.Name = "label5";
            label5.Size = new Size(248, 32);
            label5.TabIndex = 8;
            label5.Text = "Gerenciar Vendedores";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(474, 0);
            label4.Name = "label4";
            label4.Size = new Size(217, 32);
            label4.TabIndex = 7;
            label4.Text = "Gerenciar Produtos";
            label4.Click += label4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 6;
            label1.Text = "Gerenciar Clientes";
            label1.Click += label1_Click_2;
            // 
            // button1
            // 
            button1.Location = new Point(937, 500);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 12;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 0);
            label6.Name = "label6";
            label6.Size = new Size(198, 32);
            label6.TabIndex = 9;
            label6.Text = "Gerenciar Vendas";
            label6.Click += label6_Click;
            // 
            // PainelPrincipalGerente
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1043, 545);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Palatino Linotype", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            Name = "PainelPrincipalGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel Administrativo - CommerceMaster";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label1;
        private Button button1;
        private Label label6;
    }
}