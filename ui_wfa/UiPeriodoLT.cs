using bll;
using System.Data;
using System.Data.SqlClient;

namespace ui_wfa
{
    public partial class UiPeriodoLT : Form
    {
        private int idSelecionado = 0;

        public UiPeriodoLT()
        {
            InitializeComponent();

            this.AtualizarTabela();
            this.ActiveControl = txtPesquisa;
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
                Tabela.DataSource = BllPeriodo.Listar();

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
                    string filterExpression = "perNome LIKE '%" + valorPesquisa + "%' OR " +
                                          "perSigla LIKE '%" + valorPesquisa + "%' OR " +
                                          "curNome LIKE '%" + valorPesquisa + "%' OR " +
                                          "Convert(perId, 'System.String') LIKE '%" + valorPesquisa + "%'";

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
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["perId"].Value);
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
                UiPeriodoNE frm = new(Id);
                frm.ShowDialog();
                this.AtualizarTabela();
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
                    BllPeriodo.Deletar(idSelecionado);
                    AtualizarTabela();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("O periodo está atribuído a um curso. Exclua-o antes de continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) when (ex is DuplicateNameException || ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}