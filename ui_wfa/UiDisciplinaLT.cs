using bll;
using System.Data;
using System.Data.SqlClient;

namespace ui_wfa
{
    public partial class UiDisciplinaLT : Form
    {
        private int idSelecionado = 0;

        public UiDisciplinaLT()
        {
            InitializeComponent();

            AtualizarTabela();
            ActiveControl = txtPesquisa;
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            this.AbrirEditor();
        }

        private void Atualizar(object sender, EventArgs e)
        {
            this.AbrirEditor(idSelecionado);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private static bool IndagarExclusao()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }

        private void AtualizarTabela()
        {
            try
            {
                Tabela.DataSource = BllDisciplina.Listar();

                txtPesquisa.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pesquisar(object sender, EventArgs e)
        {
            try
            {
                string valorPesquisa = txtPesquisa.Text.Trim();

                if (string.IsNullOrEmpty(valorPesquisa))
                {
                    DataTable tabela = (DataTable)Tabela.DataSource;
                    tabela.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    DataTable tabela = (DataTable)Tabela.DataSource;
                    string filterExpression = "disNome LIKE '%" + valorPesquisa + "%' OR " +
                                              "disSigla LIKE '%" + valorPesquisa + "%' OR " +
                                              "disObservacoes LIKE '%" + valorPesquisa + "%' OR " +
                                              "disCursos LIKE '%" + valorPesquisa + "%' OR " +
                                              "Convert(disId, 'System.String') LIKE '%" + valorPesquisa + "%'";

                    tabela.DefaultView.RowFilter = filterExpression;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Selecionar(object sender, EventArgs e)
        {
            try
            {
                if (Tabela.SelectedRows.Count > 0)
                {
                    var linhaSelecionada = Tabela.SelectedRows[0];
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["disId"].Value);
                    TextStatusBar.Text = "Registro " + idSelecionado.ToString() + " selecionado.";

                    btAtualizar.Enabled = true;
                    btDeletar.Enabled = true;
                }
                else
                {
                    TextStatusBar.Text = "Nenhum registro selecionado.";
                    btAtualizar.Enabled = false;
                    btDeletar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void AbrirEditor(int Id = 0)
        {
            try
            {
                UiDisciplinaNE frm = new(Id);
                frm.ShowDialog();
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletar(object sender, EventArgs e)
        {
            try
            {
                if (IndagarExclusao())
                {
                    BllDisciplina.Deletar(idSelecionado);
                    AtualizarTabela();
                }
            }
            catch (SqlException)
            {
                DialogResult d = MessageBox.Show("A disciplina que você está tentando excluir têm vínculos com uma ou mais cursos. Deseja excluir TODOS esses vínculos também?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    BllDisciplinaCurso.Deletar(idSelecionado, "disId");
                    BllCurso.Deletar(idSelecionado);
                    AtualizarTabela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
