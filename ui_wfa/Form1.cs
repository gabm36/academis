using dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_wfa
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Carregar(object sender, EventArgs e)
        {
            this.AtualizarTabela();

            btAtualizar.Enabled = false;
            btDeletar.Enabled = false;

            this.ActiveControl = txtPesquisa;
        }

        private void AtualizarTabela()
        {
            PeriodoDal periodoDal = new();
            Tabela.DataSource = periodoDal.ListarTodos();
            txtPesquisa.Text = "";

            TextStatusBar.Text = "Nenhum registro selecionado. Selecione um item na lista para editar ou deletar.";
        }
    }
}
