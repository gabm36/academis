namespace ui_wfa
{
    partial class UiProdutoNE
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
            label2 = new Label();
            selCategoria = new ComboBox();
            labelObservações = new Label();
            txtPrcCusto = new TextBox();
            label4 = new Label();
            txtQuantidade = new TextBox();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtPrcVenda = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            label1 = new Label();
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
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(selCategoria, 1, 4);
            tableLayoutPanel1.Controls.Add(labelObservações, 0, 2);
            tableLayoutPanel1.Controls.Add(txtPrcCusto, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtQuantidade, 1, 3);
            tableLayoutPanel1.Controls.Add(txtDescricao, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtPrcVenda, 1, 2);
            tableLayoutPanel1.Controls.Add(btSalvar, 1, 6);
            tableLayoutPanel1.Controls.Add(btCancelar, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(420, 189);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(36, 123);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 19;
            label2.Text = "Categoria:";
            // 
            // selCategoria
            // 
            selCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            selCategoria.FormattingEnabled = true;
            selCategoria.Location = new Point(103, 119);
            selCategoria.Name = "selCategoria";
            selCategoria.Size = new Size(314, 23);
            selCategoria.TabIndex = 5;
            // 
            // labelObservações
            // 
            labelObservações.Anchor = AnchorStyles.Right;
            labelObservações.AutoSize = true;
            labelObservações.Location = new Point(6, 65);
            labelObservações.Name = "labelObservações";
            labelObservações.Size = new Size(91, 15);
            labelObservações.TabIndex = 16;
            labelObservações.Text = "Preço de venda:";
            // 
            // txtPrcCusto
            // 
            txtPrcCusto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrcCusto.Location = new Point(103, 32);
            txtPrcCusto.MaxLength = 10;
            txtPrcCusto.Name = "txtPrcCusto";
            txtPrcCusto.Size = new Size(314, 23);
            txtPrcCusto.TabIndex = 2;
            txtPrcCusto.Validating += ValidarPrc;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(9, 36);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Preço de custo:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantidade.Location = new Point(103, 90);
            txtQuantidade.MaxLength = 9;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(314, 23);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.Validating += ValidarQuant;
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
            // txtPrcVenda
            // 
            txtPrcVenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrcVenda.Location = new Point(103, 61);
            txtPrcVenda.MaxLength = 10;
            txtPrcVenda.Name = "txtPrcVenda";
            txtPrcVenda.Size = new Size(314, 23);
            txtPrcVenda.TabIndex = 3;
            txtPrcVenda.Validating += ValidarPrc;
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvar.Location = new Point(330, 161);
            btSalvar.Name = "btSalvar";
            btSalvar.Padding = new Padding(10, 0, 10, 0);
            btSalvar.Size = new Size(87, 25);
            btSalvar.TabIndex = 7;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += Salvar;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 161);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 6;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(25, 94);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 18;
            label1.Text = "Quantidade:";
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { labelId, txtId });
            status.Location = new Point(0, 319);
            status.Name = "status";
            status.Size = new Size(633, 22);
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
            // UiProdutoNE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btCancelar;
            ClientSize = new Size(633, 341);
            Controls.Add(status);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UiProdutoNE";
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
        private TextBox txtPrcCusto;
        private Label label4;
        private TextBox txtDescricao;
        private Label label3;
        private Button btCancelar;
        private Button btSalvar;
        private TextBox txtPrcVenda;
        private StatusStrip status;
        private ToolStripStatusLabel labelId;
        private ToolStripStatusLabel txtId;
        private TextBox txtQuantidade;
        private Label label1;
        private Label label2;
        private ComboBox selCategoria;
    }
}