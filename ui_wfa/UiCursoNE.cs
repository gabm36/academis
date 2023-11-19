using bll;
using model;

namespace ui_wfa
{
    public partial class UiCursoNE : Form
    {
        private int idSelecionado;
        Curso curso = new();

        public UiCursoNE(int idSelecionado)
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
                curso = BllCurso.Selecionar(idSelecionado);

                this.Text = "Atualizar registro";

                txtNome.Text = curso.Nome;
                txtSigla.Text = curso.Sigla;
                txtObservacoes.Text = curso.Observacoes;
                txtId.Text = idSelecionado.ToString();
            }

            CarregarPeriodos();

            this.ActiveControl = txtNome;
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string sigla = txtSigla.Text;
                string observacoes = txtObservacoes.Text;
                int periodo = Convert.ToInt32(selPeriodos.SelectedValue);

                curso = new(idSelecionado, nome, sigla, observacoes, periodo, new());

                if (this.idSelecionado == 0)
                    BllCurso.Inserir(curso);
                else
                    BllCurso.Atualizar(curso);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarPeriodos()
        {
            try
            {
                selPeriodos.DataSource = BllPeriodo.Listar();
                selPeriodos.DisplayMember = "perNome";
                selPeriodos.ValueMember = "perId";

                if (idSelecionado != 0)
                    selPeriodos.SelectedValue = curso.Periodo;
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