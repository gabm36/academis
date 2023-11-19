using bll;
using model;

namespace ui_wfa
{
    public partial class UiUsuarioLogin : Form
    {
        public Usuario usuarioAtivo = new();

        public UiUsuarioLogin()
        {
            InitializeComponent();
        }

        private void Logar(object sender, EventArgs e)
        {
            if (VerificarCredenciais(out Usuario usuarioAtivo))
            {
                this.usuarioAtivo = usuarioAtivo;
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

            this.Close();
        }

        private bool VerificarCredenciais(out Usuario usuarioAtivo)
        {
            return BllUsuario.ConferirLogin(txtLogin.Text, txtSenha.Text, out usuarioAtivo);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
