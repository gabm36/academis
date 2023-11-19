namespace ui_wfa
{
    partial class UiPeriodoLT
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
            components = new System.ComponentModel.Container();
            txtPesquisa = new TextBox();
            Tabela = new DataGridView();
            btCadastrar = new Button();
            btCancelar = new Button();
            btDeletar = new Button();
            btAtualizar = new Button();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            statusStrip1 = new StatusStrip();
            TextStatusBar = new ToolStripStatusLabel();
            perId = new DataGridViewTextBoxColumn();
            perNome = new DataGridViewTextBoxColumn();
            perSigla = new DataGridViewTextBoxColumn();
            curNome = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Tabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(103, 3);
            txtPesquisa.MaxLength = 50;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(594, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += Pesquisar;
            // 
            // Tabela
            // 
            Tabela.AllowUserToAddRows = false;
            Tabela.AllowUserToDeleteRows = false;
            Tabela.AllowUserToOrderColumns = true;
            Tabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabela.Columns.AddRange(new DataGridViewColumn[] { perId, perNome, perSigla, curNome });
            tableLayoutPanel4.SetColumnSpan(Tabela, 2);
            Tabela.Location = new Point(3, 45);
            Tabela.Name = "Tabela";
            Tabela.ReadOnly = true;
            Tabela.RowTemplate.Height = 25;
            Tabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabela.Size = new Size(694, 394);
            Tabela.TabIndex = 3;
            Tabela.SelectionChanged += Selecionar;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(510, 3);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Padding = new Padding(10, 0, 10, 0);
            btCadastrar.Size = new Size(87, 25);
            btCadastrar.TabIndex = 5;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += Cadastrar;
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
            // btDeletar
            // 
            btDeletar.Location = new Point(324, 3);
            btDeletar.Name = "btDeletar";
            btDeletar.Padding = new Padding(10, 0, 10, 0);
            btDeletar.Size = new Size(87, 25);
            btDeletar.TabIndex = 3;
            btDeletar.Text = "Deletar";
            btDeletar.UseVisualStyleBackColor = true;
            btDeletar.Click += Deletar;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(417, 3);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Padding = new Padding(10, 0, 10, 0);
            btAtualizar.Size = new Size(87, 25);
            btAtualizar.TabIndex = 4;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += Atualizar;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
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
            tableLayoutPanel4.Size = new Size(700, 486);
            tableLayoutPanel4.TabIndex = 12;
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
            flowLayoutPanel2.Size = new Size(600, 31);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { TextStatusBar });
            statusStrip1.Location = new Point(0, 520);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(802, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // TextStatusBar
            // 
            TextStatusBar.Name = "TextStatusBar";
            TextStatusBar.Size = new Size(12, 17);
            TextStatusBar.Text = "-";
            // 
            // perId
            // 
            perId.DataPropertyName = "perId";
            perId.HeaderText = "Código";
            perId.Name = "perId";
            perId.ReadOnly = true;
            // 
            // perNome
            // 
            perNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            perNome.DataPropertyName = "perNome";
            perNome.HeaderText = "Nome";
            perNome.Name = "perNome";
            perNome.ReadOnly = true;
            // 
            // perSigla
            // 
            perSigla.DataPropertyName = "perSigla";
            perSigla.HeaderText = "Sigla";
            perSigla.Name = "perSigla";
            perSigla.ReadOnly = true;
            // 
            // curNome
            // 
            curNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            curNome.DataPropertyName = "curNome";
            curNome.HeaderText = "Curso";
            curNome.MinimumWidth = 100;
            curNome.Name = "curNome";
            curNome.ReadOnly = true;
            // 
            // UiPeriodoLT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(802, 542);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UiPeriodoLT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Periodos";
            ((System.ComponentModel.ISupportInitialize)Tabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPesquisa;
        private DataGridView Tabela;
        private Button btCadastrar;
        private Button btCancelar;
        private Button btDeletar;
        private Button btAtualizar;
        private BindingSource bindingSource1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TextStatusBar;
        private DataGridViewTextBoxColumn perId;
        private DataGridViewTextBoxColumn perNome;
        private DataGridViewTextBoxColumn perSigla;
        private DataGridViewTextBoxColumn curNome;
    }
}