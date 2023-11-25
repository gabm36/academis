namespace ui_wfa
{
    partial class UiCategoriaLT
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
            txtPesquisa = new TextBox();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btCadastrar = new Button();
            btAtualizar = new Button();
            btDeletar = new Button();
            btCancelar = new Button();
            Tabela = new DataGridView();
            catId = new DataGridViewTextBoxColumn();
            catDescricao = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            TextStatusBar = new ToolStripStatusLabel();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabela).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel4.Controls.Add(txtPesquisa, 1, 0);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel2, 1, 5);
            tableLayoutPanel4.Controls.Add(btCancelar, 0, 5);
            tableLayoutPanel4.Controls.Add(Tabela, 0, 3);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(500, 486);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(103, 3);
            txtPesquisa.MaxLength = 50;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(394, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += Pesquisar;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(37, 7);
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
            flowLayoutPanel2.Location = new Point(100, 455);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(400, 31);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(310, 3);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Padding = new Padding(10, 0, 10, 0);
            btCadastrar.Size = new Size(87, 25);
            btCadastrar.TabIndex = 5;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += Cadastrar;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(217, 3);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Padding = new Padding(10, 0, 10, 0);
            btAtualizar.Size = new Size(87, 25);
            btAtualizar.TabIndex = 4;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += Atualizar;
            // 
            // btDeletar
            // 
            btDeletar.Location = new Point(124, 3);
            btDeletar.Name = "btDeletar";
            btDeletar.Padding = new Padding(10, 0, 10, 0);
            btDeletar.Size = new Size(87, 25);
            btDeletar.TabIndex = 3;
            btDeletar.Text = "Deletar";
            btDeletar.UseVisualStyleBackColor = true;
            btDeletar.Click += Deletar;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 458);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 2;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // Tabela
            // 
            Tabela.AllowUserToAddRows = false;
            Tabela.AllowUserToDeleteRows = false;
            Tabela.AllowUserToOrderColumns = true;
            Tabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabela.Columns.AddRange(new DataGridViewColumn[] { catId, catDescricao });
            tableLayoutPanel4.SetColumnSpan(Tabela, 2);
            Tabela.Location = new Point(3, 45);
            Tabela.Name = "Tabela";
            Tabela.ReadOnly = true;
            Tabela.RowTemplate.Height = 25;
            Tabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabela.Size = new Size(494, 394);
            Tabela.TabIndex = 3;
            Tabela.SelectionChanged += Selecionar;
            // 
            // catId
            // 
            catId.DataPropertyName = "catId";
            catId.HeaderText = "Código";
            catId.Name = "catId";
            catId.ReadOnly = true;
            // 
            // catDescricao
            // 
            catDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            catDescricao.DataPropertyName = "catDescricao";
            catDescricao.HeaderText = "Descrição";
            catDescricao.Name = "catDescricao";
            catDescricao.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { TextStatusBar });
            statusStrip1.Location = new Point(0, 521);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(588, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // TextStatusBar
            // 
            TextStatusBar.Name = "TextStatusBar";
            TextStatusBar.Size = new Size(12, 17);
            TextStatusBar.Text = "-";
            // 
            // UiCategoriaLT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(588, 543);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UiCategoriaLT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabela).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtPesquisa;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btCadastrar;
        private Button btAtualizar;
        private Button btDeletar;
        private Button btCancelar;
        private DataGridView Tabela;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TextStatusBar;
        private DataGridViewTextBoxColumn catId;
        private DataGridViewTextBoxColumn catDescricao;
    }
}