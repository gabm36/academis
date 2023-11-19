using System.Windows.Forms;

namespace ui_wfa
{
    partial class UiCursoLT
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
            button1 = new Button();
            btCancelar = new Button();
            Tabela = new DataGridView();
            curId = new DataGridViewTextBoxColumn();
            curNome = new DataGridViewTextBoxColumn();
            curSigla = new DataGridViewTextBoxColumn();
            perNome = new DataGridViewTextBoxColumn();
            curDisciplinas = new DataGridViewTextBoxColumn();
            curObservacoes = new DataGridViewTextBoxColumn();
            txtPesquisa = new TextBox();
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
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1000F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel2, 1, 5);
            tableLayoutPanel4.Controls.Add(btCancelar, 0, 5);
            tableLayoutPanel4.Controls.Add(Tabela, 0, 3);
            tableLayoutPanel4.Controls.Add(txtPesquisa, 1, 0);
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
            tableLayoutPanel4.Size = new Size(1100, 486);
            tableLayoutPanel4.TabIndex = 14;
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
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(100, 455);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1000, 31);
            flowLayoutPanel2.TabIndex = 13;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(910, 3);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Padding = new Padding(10, 0, 10, 0);
            btCadastrar.Size = new Size(87, 25);
            btCadastrar.TabIndex = 6;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.TextChanged += Cadastrar;
            btCadastrar.Click += Cadastrar;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(817, 3);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Padding = new Padding(10, 0, 10, 0);
            btAtualizar.Size = new Size(87, 25);
            btAtualizar.TabIndex = 5;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.TextChanged += Atualizar;
            btAtualizar.Click += Atualizar;
            // 
            // btDeletar
            // 
            btDeletar.Location = new Point(724, 3);
            btDeletar.Name = "btDeletar";
            btDeletar.Padding = new Padding(10, 0, 10, 0);
            btDeletar.Size = new Size(87, 25);
            btDeletar.TabIndex = 4;
            btDeletar.Text = "Deletar";
            btDeletar.UseVisualStyleBackColor = true;
            btDeletar.TextChanged += Deletar;
            btDeletar.Click += Deletar;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(583, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 10, 0);
            button1.Size = new Size(135, 25);
            button1.TabIndex = 16;
            button1.Text = "Atribuir disciplinas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EditarRelacao;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 458);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 3;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.TextChanged += Cancelar;
            btCancelar.Click += Cancelar;
            // 
            // Tabela
            // 
            Tabela.AllowUserToAddRows = false;
            Tabela.AllowUserToDeleteRows = false;
            Tabela.AllowUserToOrderColumns = true;
            Tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabela.Columns.AddRange(new DataGridViewColumn[] { curId, curNome, curSigla, perNome, curDisciplinas, curObservacoes });
            tableLayoutPanel4.SetColumnSpan(Tabela, 2);
            Tabela.Dock = DockStyle.Fill;
            Tabela.Location = new Point(3, 45);
            Tabela.Name = "Tabela";
            Tabela.ReadOnly = true;
            Tabela.RowTemplate.Height = 25;
            Tabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabela.Size = new Size(1094, 394);
            Tabela.TabIndex = 2;
            Tabela.SelectionChanged += Selecionar;
            // 
            // curId
            // 
            curId.DataPropertyName = "curId";
            curId.HeaderText = "Código";
            curId.MinimumWidth = 100;
            curId.Name = "curId";
            curId.ReadOnly = true;
            // 
            // curNome
            // 
            curNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            curNome.DataPropertyName = "curNome";
            curNome.HeaderText = "Nome";
            curNome.MinimumWidth = 100;
            curNome.Name = "curNome";
            curNome.ReadOnly = true;
            // 
            // curSigla
            // 
            curSigla.DataPropertyName = "curSigla";
            curSigla.HeaderText = "Sigla";
            curSigla.MinimumWidth = 100;
            curSigla.Name = "curSigla";
            curSigla.ReadOnly = true;
            // 
            // perNome
            // 
            perNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            perNome.DataPropertyName = "perNome";
            perNome.HeaderText = "Periodo";
            perNome.MinimumWidth = 100;
            perNome.Name = "perNome";
            perNome.ReadOnly = true;
            // 
            // curDisciplinas
            // 
            curDisciplinas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            curDisciplinas.DataPropertyName = "curDisciplinas";
            curDisciplinas.HeaderText = "Disciplinas";
            curDisciplinas.MinimumWidth = 100;
            curDisciplinas.Name = "curDisciplinas";
            curDisciplinas.ReadOnly = true;
            // 
            // curObservacoes
            // 
            curObservacoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            curObservacoes.DataPropertyName = "curObservacoes";
            curObservacoes.HeaderText = "Observações";
            curObservacoes.MinimumWidth = 100;
            curObservacoes.Name = "curObservacoes";
            curObservacoes.ReadOnly = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(103, 3);
            txtPesquisa.MaxLength = 50;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(994, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += Pesquisar;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { TextStatusBar });
            statusStrip1.Location = new Point(0, 523);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1174, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // TextStatusBar
            // 
            TextStatusBar.Name = "TextStatusBar";
            TextStatusBar.Size = new Size(12, 17);
            TextStatusBar.Text = "-";
            // 
            // UiCursoLT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1174, 545);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UiCursoLT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cursos";
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabela).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private Button btCancelar;
        private DataGridView Tabela;
        private TextBox txtPesquisa;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TextStatusBar;
        private DataGridViewTextBoxColumn curId;
        private DataGridViewTextBoxColumn curNome;
        private DataGridViewTextBoxColumn curSigla;
        private DataGridViewTextBoxColumn perNome;
        private DataGridViewTextBoxColumn curDisciplinas;
        private DataGridViewTextBoxColumn curObservacoes;
        private Button button1;
    }
}