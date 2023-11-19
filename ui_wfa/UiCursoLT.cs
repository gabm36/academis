using bll;
using model;
using System.Data;
using System.Data.SqlClient;

namespace ui_wfa
{
    public partial class UiCursoLT : Form
    {
        private int idSelecionado = 0;

        public UiCursoLT()
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
                DataTable l = BllCurso.Listar();
                l.Columns.Add("perNome", typeof(string));

                foreach (DataRow row in l.Rows)
                {
                    Periodo periodo = BllPeriodo.Selecionar(Convert.ToInt32(row["perId"]));

                    if (periodo.Id == 0)
                        row["perNome"] = "";
                    else
                        row["perNome"] = periodo.Nome + " (" + periodo.Sigla + ")";
                }

                l.Columns.Remove("perId");

                Tabela.DataSource = l;

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
                    string filterExpression = "curNome LIKE '%" + valorPesquisa + "%' OR " +
                                              "curSigla LIKE '%" + valorPesquisa + "%' OR " +
                                              "curObservacoes LIKE '%" + valorPesquisa + "%' OR " +
                                              "perNome LIKE '%" + valorPesquisa + "%' OR " +
                                              "curDisciplinas LIKE '%" + valorPesquisa + "%' OR " +
                                              "Convert(curId, 'System.String') LIKE '%" + valorPesquisa + "%'";

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
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["curId"].Value);
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
                UiCursoNE frm = new(Id);
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
                    BllCurso.Deletar(idSelecionado);
                AtualizarTabela();
            }
            catch (SqlException)
            {
                DialogResult d = MessageBox.Show("O curso que você está tentando excluir têm vínculos com uma ou mais disciplinas. Deseja excluir TODOS esses vínculos também?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    BllDisciplinaCurso.Deletar(idSelecionado, "curId");
                    BllCurso.Deletar(idSelecionado);
                    AtualizarTabela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarRelacao(object sender, EventArgs e)
        {
            try
            {
                UiDisciplinaCurso frm = new(BllCurso.Selecionar(idSelecionado));
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AtualizarTabela();
            }
        }
    }
}
