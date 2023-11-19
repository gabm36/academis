using bll;
using model;

namespace ui_wfa
{
    public partial class UiDisciplinaNE : Form
    {
        private int idSelecionado;
        Disciplina disciplina = new();

        public UiDisciplinaNE(int idSelecionado)
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

                disciplina = BllDisciplina.Selecionar(idSelecionado);

                txtNome.Text = disciplina.Nome;
                txtSigla.Text = disciplina.Sigla;
                txtObservacoes.Text = disciplina.Observacoes;
                txtId.Text = idSelecionado.ToString();
            }

            this.ActiveControl = txtNome;
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string sigla = txtSigla.Text;
                string observacoes = txtObservacoes.Text;

                disciplina = new(idSelecionado, nome, sigla, observacoes, new());

                if (this.idSelecionado == 0)
                    BllDisciplina.Inserir(disciplina);
                else
                    BllDisciplina.Atualizar(disciplina);

                this.Close();
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
