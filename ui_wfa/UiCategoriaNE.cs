using bll;
using model;

namespace ui_wfa
{
    public partial class UiCategoriaNE : Form
    {
        private int idSelecionado;
        Categoria categoria = new();

        public UiCategoriaNE(int idSelecionado)
        {
            InitializeComponent();

            if (idSelecionado == 0)
            {
                labelId.Visible = false;
                txtId.Visible = false;
            }
            else
            {
                this.idSelecionado = idSelecionado;

                this.Text = "Atualizar registro";

                categoria = BllCategoria.Selecionar(idSelecionado);

                txtDescricao.Text = categoria.Descricao;
                txtId.Text = idSelecionado.ToString();
            }

            this.ActiveControl = txtDescricao;
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtDescricao.Text;

                categoria = new(idSelecionado, descricao);

                if (this.idSelecionado == 0)
                    BllCategoria.Inserir(categoria);
                else
                    BllCategoria.Atualizar(categoria);

                this.Close();
            }
            catch (ArgumentException ex)
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
