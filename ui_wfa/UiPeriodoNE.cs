using bll;
using model;

namespace ui_wfa
{
    public partial class UiPeriodoNE : Form
    {
        private int idSelecionado;
        Periodo periodo = new();

        public UiPeriodoNE(int idSelecionado)
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

                periodo = BllPeriodo.Selecionar(idSelecionado);

                txtNome.Text = periodo.Nome;
                txtSigla.Text = periodo.Sigla;
                txtId.Text = idSelecionado.ToString();
            }

            this.ActiveControl = txtNome;
        }

        private void Salvar(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sigla = txtSigla.Text;

            periodo = new(idSelecionado, nome, sigla);

            if (this.idSelecionado == 0)
                BllPeriodo.Inserir(periodo);
            else
                BllPeriodo.Atualizar(periodo);

            this.Close();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
