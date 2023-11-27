namespace ui_wfa
{
    partial class UiMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiMain));
            menuStrip1 = new MenuStrip();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            periodosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            stsUsrNome = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { periodosToolStripMenuItem, cursosToolStripMenuItem, disciplinasToolStripMenuItem, categoriasToolStripMenuItem, produtosToolStripMenuItem, usuáriosToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(734, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(75, 20);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += SMdisciplinas;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(55, 20);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += SMcursos;
            // 
            // periodosToolStripMenuItem
            // 
            periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            periodosToolStripMenuItem.Size = new Size(65, 20);
            periodosToolStripMenuItem.Text = "Periodos";
            periodosToolStripMenuItem.Click += SMperiodos;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += SMcategorias;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += SMprodutos;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += SMusuarios;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(49, 20);
            ajudaToolStripMenuItem.Text = "Sobre";
            ajudaToolStripMenuItem.Click += SMsobre;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stsUsrNome, toolStripStatusLabel2, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 521);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(734, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // stsUsrNome
            // 
            stsUsrNome.Name = "stsUsrNome";
            stsUsrNome.Size = new Size(47, 17);
            stsUsrNome.Text = "Usuário";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(10, 17);
            toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(59, 17);
            toolStripStatusLabel1.Text = "Versão 1.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(734, 491);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UiMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 543);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UiMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academis | Gabriel Marques Leme N8519D4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem periodosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripStatusLabel stsUsrNome;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
    }
}