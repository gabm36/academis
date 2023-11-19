namespace ui_wfa
{
    partial class UiDisciplinaCurso
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
            btDesatribuir = new Button();
            label1 = new Label();
            lbAtrb = new ListBox();
            label2 = new Label();
            btAtribuir = new Button();
            lbDisp = new ListBox();
            btCancelar = new Button();
            status = new StatusStrip();
            label = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.Controls.Add(btDesatribuir, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbAtrb, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(btAtribuir, 1, 1);
            tableLayoutPanel1.Controls.Add(lbDisp, 0, 1);
            tableLayoutPanel1.Controls.Add(btCancelar, 2, 4);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(739, 490);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btDesatribuir
            // 
            btDesatribuir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btDesatribuir.AutoSize = true;
            btDesatribuir.Location = new Point(323, 418);
            btDesatribuir.Name = "btDesatribuir";
            btDesatribuir.Size = new Size(93, 25);
            btDesatribuir.TabIndex = 18;
            btDesatribuir.Text = "<< Desatribuir";
            btDesatribuir.UseVisualStyleBackColor = true;
            btDesatribuir.Click += Desatribuir;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Cursos disponíveis";
            // 
            // lbAtrb
            // 
            lbAtrb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbAtrb.FormattingEnabled = true;
            lbAtrb.ItemHeight = 15;
            lbAtrb.Location = new Point(422, 18);
            lbAtrb.Name = "lbAtrb";
            tableLayoutPanel1.SetRowSpan(lbAtrb, 2);
            lbAtrb.Size = new Size(314, 424);
            lbAtrb.TabIndex = 16;
            lbAtrb.SelectedIndexChanged += MudarSelecaoAtrb;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 17;
            label2.Text = "Cursos atribuídos";
            // 
            // btAtribuir
            // 
            btAtribuir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAtribuir.AutoSize = true;
            btAtribuir.Location = new Point(323, 387);
            btAtribuir.Name = "btAtribuir";
            btAtribuir.Size = new Size(93, 25);
            btAtribuir.TabIndex = 19;
            btAtribuir.Text = "Atribuir >>";
            btAtribuir.UseVisualStyleBackColor = true;
            btAtribuir.Click += Atribuir;
            // 
            // lbDisp
            // 
            lbDisp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDisp.FormattingEnabled = true;
            lbDisp.ItemHeight = 15;
            lbDisp.Location = new Point(3, 18);
            lbDisp.Name = "lbDisp";
            tableLayoutPanel1.SetRowSpan(lbDisp, 2);
            lbDisp.Size = new Size(314, 424);
            lbDisp.TabIndex = 15;
            lbDisp.SelectedIndexChanged += MudarSelecaoDisp;
            // 
            // btCancelar
            // 
            btCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCancelar.Location = new Point(649, 462);
            btCancelar.Name = "btCancelar";
            btCancelar.Padding = new Padding(10, 0, 10, 0);
            btCancelar.Size = new Size(87, 25);
            btCancelar.TabIndex = 14;
            btCancelar.Text = "Fechar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += Cancelar;
            // 
            // status
            // 
            status.ImageScalingSize = new Size(20, 20);
            status.Items.AddRange(new ToolStripItem[] { label });
            status.Location = new Point(0, 545);
            status.Name = "status";
            status.Size = new Size(793, 22);
            status.TabIndex = 17;
            status.Text = "statusStrip1";
            // 
            // label
            // 
            label.Name = "label";
            label.Size = new Size(20, 17);
            label.Text = "Id:";
            // 
            // UiDisciplinaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(793, 567);
            Controls.Add(status);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UiDisciplinaCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vincular dsciplinas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btCancelar;
        private ListBox lbDisp;
        private ListBox lbAtrb;
        private Label label2;
        private Button btDesatribuir;
        private Button btAtribuir;
        private StatusStrip status;
        private ToolStripStatusLabel label;
    }
}