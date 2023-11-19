namespace ui_wfa
{
    partial class UiUsuarioLogin
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
            btLogar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btCancelar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btLogar
            // 
            btLogar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btLogar.Location = new Point(330, 74);
            btLogar.Name = "btLogar";
            btLogar.Padding = new Padding(10, 0, 10, 0);
            btLogar.Size = new Size(87, 25);
            btLogar.TabIndex = 11;
            btLogar.Text = "Logar";
            btLogar.UseVisualStyleBackColor = true;
            btLogar.Click += Logar;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(103, 32);
            txtSenha.MaxLength = 20;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(314, 23);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "12345678";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Location = new Point(103, 3);
            txtLogin.MaxLength = 20;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(314, 23);
            txtLogin.TabIndex = 1;
            txtLogin.Text = "admin@admin";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(55, 36);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 0;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(57, 7);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Login:";
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 74);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 13;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(txtLogin, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSenha, 1, 1);
            tableLayoutPanel2.Controls.Add(btLogar, 1, 3);
            tableLayoutPanel2.Controls.Add(btCancelar, 0, 3);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(420, 102);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(538, 300);
            Controls.Add(tableLayoutPanel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogar;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label4;
        private Label label3;
        private Button btCancelar;
        private TableLayoutPanel tableLayoutPanel2;
    }
}