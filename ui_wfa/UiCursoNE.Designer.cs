namespace ui_wfa
{
    partial class UiCursoNE
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
            selPeriodos = new ComboBox();
            labelObservações = new Label();
            txtSigla = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtObservacoes = new TextBox();
            label1 = new Label();
            btSalvar = new Button();
            btCancelar = new Button();
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
            tableLayoutPanel1.Controls.Add(selPeriodos, 1, 3);
            tableLayoutPanel1.Controls.Add(labelObservações, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSigla, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtObservacoes, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(btSalvar, 1, 5);
            tableLayoutPanel1.Controls.Add(btCancelar, 0, 5);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(420, 160);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // selPeriodos
            // 
            selPeriodos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selPeriodos.DropDownStyle = ComboBoxStyle.DropDownList;
            selPeriodos.FormattingEnabled = true;
            selPeriodos.Location = new Point(103, 90);
            selPeriodos.Name = "selPeriodos";
            selPeriodos.Size = new Size(314, 23);
            selPeriodos.TabIndex = 17;
            // 
            // labelObservações
            // 
            labelObservações.Anchor = AnchorStyles.Right;
            labelObservações.AutoSize = true;
            labelObservações.Location = new Point(20, 65);
            labelObservações.Name = "labelObservações";
            labelObservações.Size = new Size(77, 15);
            labelObservações.TabIndex = 16;
            labelObservações.Text = "Observações:";
            // 
            // txtSigla
            // 
            txtSigla.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSigla.Location = new Point(103, 32);
            txtSigla.MaxLength = 5;
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(314, 23);
            txtSigla.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(62, 36);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "Sigla:";
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
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.Location = new Point(103, 61);
            txtObservacoes.MaxLength = 500;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(314, 23);
            txtObservacoes.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(46, 94);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Periodo:";
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvar.Location = new Point(330, 132);
            btSalvar.Name = "btSalvar";
            btSalvar.Padding = new Padding(10, 0, 10, 0);
            btSalvar.Size = new Size(87, 25);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += Salvar;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 132);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 4;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // status
            // 
            status.ImageScalingSize = new Size(20, 20);
            status.Items.AddRange(new ToolStripItem[] { labelId, txtId });
            status.Location = new Point(0, 356);
            status.Name = "status";
            status.Size = new Size(454, 22);
            status.TabIndex = 16;
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
            // CursoNE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(454, 378);
            Controls.Add(status);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CursoNE";
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
        private Label labelObservações;
        private TextBox txtSigla;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private Button btCancelar;
        private Button btSalvar;
        private TextBox txtObservacoes;
        private StatusStrip status;
        private ToolStripStatusLabel labelId;
        private ToolStripStatusLabel txtId;
        private ComboBox selPeriodos;
        private Label label1;
    }
}