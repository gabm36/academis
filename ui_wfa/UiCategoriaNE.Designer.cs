namespace ui_wfa
{
    partial class UiCategoriaNE
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btCadastrar = new Button();
            btAtualizar = new Button();
            btDeletar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDescricao = new TextBox();
            label3 = new Label();
            btCancelar = new Button();
            btSalvar = new Button();
            status = new StatusStrip();
            labelId = new ToolStripStatusLabel();
            txtId = new ToolStripStatusLabel();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 800F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(btCadastrar);
            flowLayoutPanel2.Controls.Add(btAtualizar);
            flowLayoutPanel2.Controls.Add(btDeletar);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(100, 15);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 85);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(710, 3);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Padding = new Padding(10, 0, 10, 0);
            btCadastrar.Size = new Size(87, 25);
            btCadastrar.TabIndex = 6;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(617, 3);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Padding = new Padding(10, 0, 10, 0);
            btAtualizar.Size = new Size(87, 25);
            btAtualizar.TabIndex = 5;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btDeletar
            // 
            btDeletar.Location = new Point(524, 3);
            btDeletar.Name = "btDeletar";
            btDeletar.Padding = new Padding(10, 0, 10, 0);
            btDeletar.Size = new Size(87, 25);
            btDeletar.TabIndex = 4;
            btDeletar.Text = "Deletar";
            btDeletar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.Controls.Add(txtDescricao, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(btCancelar, 0, 2);
            tableLayoutPanel1.Controls.Add(btSalvar, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(420, 73);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // txtDescricao
            // 
            txtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricao.Location = new Point(103, 3);
            txtDescricao.MaxLength = 50;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(314, 23);
            txtDescricao.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(36, 7);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Descrição:";
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 45);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 2;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvar.Location = new Point(330, 45);
            btSalvar.Name = "btSalvar";
            btSalvar.Padding = new Padding(10, 0, 10, 0);
            btSalvar.Size = new Size(87, 25);
            btSalvar.TabIndex = 3;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += Salvar;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { labelId, txtId });
            status.Location = new Point(0, 167);
            status.Name = "status";
            status.Size = new Size(476, 22);
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
            // UiCategoriaNE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(476, 189);
            Controls.Add(status);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UiCategoriaNE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo registro";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btCadastrar;
        private Button btAtualizar;
        private Button btDeletar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btSalvar;
        private Button btCancelar;
        private TextBox txtDescricao;
        private Label label3;
        private StatusStrip status;
        private ToolStripStatusLabel labelId;
        private ToolStripStatusLabel txtId;
    }
}