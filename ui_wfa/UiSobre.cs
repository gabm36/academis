namespace ui_wfa
{
    partial class UiSobre : Form
    {
        public UiSobre()
        {
            InitializeComponent();
            this.Text = String.Format("Sobre {0}", "Academis");
            this.labelProductName.Text = "Academis";
            this.labelVersion.Text = String.Format("Versão {0}", "1.0");
            this.labelCopyright.Text = "Copyright 2023";
            this.labelCompanyName.Text = "UNIP";
            this.textBoxDescription.Text = "Software dedicado ao controle e gerenciamento de cursos, disciplinas e periodos.";
        }
    }
}
