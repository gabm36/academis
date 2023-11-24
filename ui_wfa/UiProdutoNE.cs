using bll;
using model;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ui_wfa
{
    public partial class UiProdutoNE : Form
    {
        private int idSelecionado;
        Produto produto = new();

        public UiProdutoNE(int idSelecionado)
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

                produto = BllProduto.Selecionar(idSelecionado);

                txtDescricao.Text = produto.Descricao;
                txtPrcCusto.Text = produto.PrcCusto.ToString();
                txtPrcVenda.Text = produto.PrcVenda.ToString();
                txtQuantidade.Text = produto.Quantidade.ToString();
                txtId.Text = idSelecionado.ToString();
            }

            CarregarCategorias();

            this.ActiveControl = txtDescricao;
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtDescricao.Text;
                decimal prcCusto = (txtPrcCusto.Text.Length != 0) ? decimal.Parse(txtPrcCusto.Text) : throw new InvalidDataException("O preço de custo não pode ser vazio.");
                decimal prcVenda = (txtPrcVenda.Text.Length != 0) ? decimal.Parse(txtPrcVenda.Text) : throw new InvalidDataException("O preço de venda não pode ser vazio.");
                int quantidade = (txtQuantidade.Text.Length != 0) ? Int32.Parse(txtQuantidade.Text) : throw new InvalidDataException("A quantidade não pode estar vazia.");
                int categoria = Convert.ToInt32(selCategoria.SelectedValue);

                produto = new(idSelecionado, descricao, prcCusto, prcVenda, quantidade, categoria);

                if (this.idSelecionado == 0)
                    BllProduto.Inserir(produto);
                else
                    BllProduto.Atualizar(produto);

                this.Close();
            }
            catch (InvalidDataException ex)
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

        private void CarregarCategorias()
        {
            try
            {
                selCategoria.DataSource = BllCategoria.Listar();
                selCategoria.DisplayMember = "catDescricao";
                selCategoria.ValueMember = "catId";

                if (idSelecionado != 0)
                    selCategoria.SelectedValue = produto.Categoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarPrc(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (sender is System.Windows.Forms.TextBox textBox)
                    if (Regex.IsMatch(textBox.Text, @"^\d{1,}([.,]\d{1,2})?$") || textBox.Text.Length == 0)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                        throw new InvalidDataException("\"" + textBox.Text + "\" é um valor inválido. Use números inteiros ou decimais, separados por vírgula.");
                    }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidarQuant(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (sender is System.Windows.Forms.TextBox textBox)
                    if (Regex.IsMatch(textBox.Text, @"^-?\d+$") || textBox.Text.Length == 0)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                        throw new InvalidDataException("\"" + textBox.Text + "\" é um valor inválido. Use apenas números inteiros.");
                    }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
