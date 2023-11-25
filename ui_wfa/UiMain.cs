using model;

namespace ui_wfa
{
    public partial class UiMain : Form
    {
        public static Usuario usuarioAtivo = new();

        public UiMain()
        {
            do
            {
                UiUsuarioLogin frm = new();

                switch (frm.ShowDialog())
                {
                    case DialogResult.Yes:
                        usuarioAtivo = frm.usuarioAtivo;
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Credenciais inv�lidas.", "Login inv�lido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        return;
                }

            } while (usuarioAtivo == null || usuarioAtivo.Id == 0);

            InitializeComponent();

            stsUsrNome.Text = usuarioAtivo.Nome.ToString();
        }

        private void SMcursos(object sender, EventArgs e)
        {
            UiCursoLT frm = new();
            frm.ShowDialog();
        }

        private void SMdisciplinas(object sender, EventArgs e)
        {
            UiDisciplinaLT frm = new();
            frm.ShowDialog();
        }

        private void SMperiodos(object sender, EventArgs e)
        {
            UiPeriodoLT frm = new();
            frm.ShowDialog();
        }

        private void SMusuarios(object sender, EventArgs e)
        {
            UiUsuarioLT frm = new();
            frm.ShowDialog();
        }

        private void SMsobre(object sender, EventArgs e)
        {
            UiSobre frm = new();
            frm.ShowDialog();
        }

        private void SMprodutos(object sender, EventArgs e)
        {
            UiProdutos frm = new();
            frm.ShowDialog();
        }

        private void SMcategorias(object sender, EventArgs e)
        {
            UiCategoriaLT frm = new();
            frm.ShowDialog();
        }
    }
}