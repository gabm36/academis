﻿using bll;
using System.Data;
using System.Data.SqlClient;

namespace ui_wfa
{
    public partial class UiProdutos : Form
    {
        private int idSelecionado = 0;

        public UiProdutos()
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
                Tabela.DataSource = BllProduto.Listar();

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
                    string filterExpression = "prdDescricao LIKE '%" + valorPesquisa + "%' OR " +
                        "catDescricao LIKE '%" + valorPesquisa + "%' OR " +
                        "Convert(prdId, 'System.String') LIKE '%" + valorPesquisa + "%'";

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
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["prdId"].Value);
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
                UiProdutoNE frm = new(Id);
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
                    BllProduto.Deletar(idSelecionado);
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
