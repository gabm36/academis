using System.Windows.Forms;

namespace ui_wfa
{
    partial class UiDisciplinaLT
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
            btCancelar = new Button();
            Tabela = new DataGridView();
            disId = new DataGridViewTextBoxColumn();
            disNome = new DataGridViewTextBoxColumn();
            disSigla = new DataGridViewTextBoxColumn();
            disObservacoes = new DataGridViewTextBoxColumn();
            disCursos = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 800F));
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
            tableLayoutPanel4.Size = new Size(900, 486);
            tableLayoutPanel4.TabIndex = 13;
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
            flowLayoutPanel2.Size = new Size(800, 31);
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
            btCadastrar.Click += Cadastrar;
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
            btAtualizar.Click += Atualizar;
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
            btDeletar.Click += Deletar;
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
            btCancelar.Click += Cancelar;
            // 
            // Tabela
            // 
            Tabela.AllowUserToAddRows = false;
            Tabela.AllowUserToDeleteRows = false;
            Tabela.AllowUserToOrderColumns = true;
            Tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Tabela.Columns.AddRange(new DataGridViewColumn[] { disId, disNome, disSigla, disObservacoes, disCursos });
            tableLayoutPanel4.SetColumnSpan(Tabela, 2);
            Tabela.Location = new Point(3, 45);
            Tabela.Name = "Tabela";
            Tabela.ReadOnly = true;
            Tabela.RowTemplate.Height = 25;
            Tabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabela.Size = new Size(894, 394);
            Tabela.TabIndex = 2;
            Tabela.SelectionChanged += Selecionar;
            // 
            // disId
            // 
            disId.DataPropertyName = "disId";
            disId.FillWeight = 58.7544174F;
            disId.HeaderText = "Código";
            disId.MinimumWidth = 100;
            disId.Name = "disId";
            disId.ReadOnly = true;
            // 
            // disNome
            // 
            disNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            disNome.DataPropertyName = "disNome";
            disNome.FillWeight = 136.057632F;
            disNome.HeaderText = "Nome";
            disNome.MinimumWidth = 100;
            disNome.Name = "disNome";
            disNome.ReadOnly = true;
            // 
            // disSigla
            // 
            disSigla.DataPropertyName = "disSigla";
            disSigla.FillWeight = 55.2107239F;
            disSigla.HeaderText = "Sigla";
            disSigla.MinimumWidth = 100;
            disSigla.Name = "disSigla";
            disSigla.ReadOnly = true;
            // 
            // disObservacoes
            // 
            disObservacoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            disObservacoes.DataPropertyName = "disObservacoes";
            disObservacoes.FillWeight = 129.271423F;
            disObservacoes.HeaderText = "Observações";
            disObservacoes.MinimumWidth = 100;
            disObservacoes.Name = "disObservacoes";
            disObservacoes.ReadOnly = true;
            // 
            // disCursos
            // 
            disCursos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            disCursos.DataPropertyName = "disCursos";
            disCursos.FillWeight = 120.705849F;
            disCursos.HeaderText = "Cursos";
            disCursos.MinimumWidth = 100;
            disCursos.Name = "disCursos";
            disCursos.ReadOnly = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(103, 3);
            txtPesquisa.MaxLength = 50;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(794, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += Pesquisar;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { TextStatusBar });
            statusStrip1.Location = new Point(0, 599);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1036, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // TextStatusBar
            // 
            TextStatusBar.Name = "TextStatusBar";
            TextStatusBar.Size = new Size(12, 17);
            TextStatusBar.Text = "-";
            // 
            // UiDisciplinaLT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1036, 621);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UiDisciplinaLT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disciplinas";
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
        private DataGridViewTextBoxColumn disId;
        private DataGridViewTextBoxColumn disNome;
        private DataGridViewTextBoxColumn disSigla;
        private DataGridViewTextBoxColumn disObservacoes;
        private DataGridViewTextBoxColumn disCursos;
    }
}