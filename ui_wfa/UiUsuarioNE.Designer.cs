namespace ui_wfa
{
    partial class UiUsuarioNE
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtLogin = new TextBox();
            senha = new Label();
            txtSenha = new TextBox();
            btCancelar = new Button();
            btSalvar = new Button();
            status = new StatusStrip();
            labelId = new ToolStripStatusLabel();
            txtId = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtLogin, 1, 1);
            tableLayoutPanel1.Controls.Add(senha, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSenha, 1, 2);
            tableLayoutPanel1.Controls.Add(btCancelar, 0, 4);
            tableLayoutPanel1.Controls.Add(btSalvar, 1, 4);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(420, 131);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(54, 7);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(103, 3);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Location = new Point(103, 32);
            txtLogin.MaxLength = 50;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(314, 23);
            txtLogin.TabIndex = 2;
            // 
            // senha
            // 
            senha.Anchor = AnchorStyles.Right;
            senha.AutoSize = true;
            senha.Location = new Point(55, 65);
            senha.Name = "senha";
            senha.Size = new Size(42, 15);
            senha.TabIndex = 0;
            senha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(103, 61);
            txtSenha.MaxLength = 32;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(314, 23);
            txtSenha.TabIndex = 3;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 103);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 4;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvar.Location = new Point(330, 103);
            btSalvar.Name = "btSalvar";
            btSalvar.Padding = new Padding(10, 0, 10, 0);
            btSalvar.Size = new Size(87, 25);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += Salvar;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { labelId, txtId });
            status.Location = new Point(0, 220);
            status.Name = "status";
            status.Size = new Size(535, 22);
            status.TabIndex = 15;
            status.Text = "statusStrip1";
            // 
            // labelId
            // 
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 17);
            labelId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 17);
            txtId.Text = "0";
            // 
            // NedUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(535, 242);
            Controls.Add(status);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NedUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo registro";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btSalvar;
        private Button btCancelar;
        private TextBox txtLogin;
        private Label senha;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtSenha;
        private Label label1;
        private StatusStrip status;
        private ToolStripStatusLabel labelId;
        private ToolStripStatusLabel txtId;
    }
}