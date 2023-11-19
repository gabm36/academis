using bll;
using model;

namespace ui_wfa
{
    public partial class UiUsuarioNE : Form
    {
        private int idSelecionado;
        Usuario usuario = new();

        public UiUsuarioNE(int idSelecionado)
        {
            InitializeComponent();

            if (idSelecionado == 0)
            {
                labelId.Visible = false;
                txtId.Visible = false;
            }
            else
            {
                this.Text = "Atualizar registro";
                usuario = BllUsuario.Selecionar(idSelecionado);

                txtNome.Text = usuario.Nome;
                txtLogin.Text = usuario.Login;
                txtId.Text = idSelecionado.ToString();
            }

            this.idSelecionado = idSelecionado;
            this.ActiveControl = txtNome;
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string login = txtLogin.Text;
                string senha = txtSenha.Text;

                usuario = new(idSelecionado, nome, login, senha);

                if (this.idSelecionado == 0)
                    BllUsuario.Inserir(usuario);
                else
                    BllUsuario.Atualizar(usuario);

                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
