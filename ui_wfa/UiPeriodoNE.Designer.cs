namespace ui_wfa
{
    partial class UiPeriodoNE
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
            txtSigla = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btSalvar = new Button();
            btCancelar = new Button();
            status = new StatusStrip();
            labelId = new ToolStripStatusLabel();
            txtId = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            status.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(103, 3);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 23);
            txtNome.TabIndex = 1;
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
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvar.Location = new Point(330, 74);
            btSalvar.Name = "btSalvar";
            btSalvar.Padding = new Padding(10, 0, 10, 0);
            btSalvar.Size = new Size(87, 25);
            btSalvar.TabIndex = 4;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += Salvar;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(3, 74);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 3;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { labelId, txtId });
            status.Location = new Point(0, 445);
            status.Name = "status";
            status.Size = new Size(871, 22);
            status.TabIndex = 11;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.Controls.Add(btSalvar, 1, 3);
            tableLayoutPanel1.Controls.Add(btCancelar, 0, 3);
            tableLayoutPanel1.Controls.Add(txtSigla, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(420, 102);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Location = new Point(0, 58);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(100, 0);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // Periodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(871, 467);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(status);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Periodo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo registro";
            status.ResumeLayout(false);
            status.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSigla;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Button btSalvar;
        private Button btCancelar;
        private StatusStrip status;
        private ToolStripStatusLabel labelId; // tive que editar essa linha manualmente 
        private ToolStripStatusLabel txtId;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}