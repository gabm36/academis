using bll;
using model;
using System.Data;

namespace ui_wfa
{
    public partial class UiDisciplinaCurso : Form
    {
        Curso curso;
        int idSel = 0;
        private bool CarregandoListBox = false;

        public UiDisciplinaCurso(Curso c)
        {
            InitializeComponent();

            this.curso = c;

            label.Text = "Modificando as disciplinas no curso " + c.Nome + " (" + c.Sigla + ").";
            btAtribuir.Enabled = false;
            btDesatribuir.Enabled = false;

            CarregarCheckBoxs();

            lbDisp.DisplayMember = "Nome";
            lbDisp.ValueMember = "Id";
            lbAtrb.DisplayMember = "Nome";
            lbAtrb.ValueMember = "Id";
        }

        private void CarregarCheckBoxs()
        {
            CarregandoListBox = true;

            List<Disciplina> disciplinasDisp = new();
            List<Disciplina> disciplinasAtrb = new();

            curso = BllCurso.Selecionar(curso.Id);

            foreach (DataRow row in BllDisciplina.Listar().Rows)
            {
                int id = Convert.ToInt32(row["disId"]);
                String nome = (string)row["disNome"];
                String sigla = (string)row["disSigla"];

                Disciplina disciplina = new(id, nome, sigla, "", new());

                if (curso.Disciplinas.Exists(i => i.DisId == disciplina.Id))
                    disciplinasAtrb.Add(disciplina);
                else
                    disciplinasDisp.Add(disciplina);
            }

            lbDisp.DataSource = disciplinasDisp;
            lbAtrb.DataSource = disciplinasAtrb;

            CarregandoListBox = false;
        }

        private void MudarSelecaoDisp(object sender, EventArgs e)
        {
            MudarSelecao(lbDisp, true);
        }

        private void MudarSelecaoAtrb(object sender, EventArgs e)
        {
            MudarSelecao(lbAtrb, false);
        }

        private void MudarSelecao(ListBox listBox, bool atribuir)
        {
            if (CarregandoListBox)
                return;

            if (listBox.SelectedItem != null)
            {
                Disciplina disciplina = (Disciplina)listBox.SelectedItem;
                idSel = disciplina.Id;
                label.Text = "A disciplina " + disciplina.Nome + " (" + disciplina.Sigla + ") está selecionada.";
                btAtribuir.Enabled = atribuir;
                btDesatribuir.Enabled = !atribuir;
            }
            else
            {
                btAtribuir.Enabled = false;
                btDesatribuir.Enabled = false;
            }
        }

        private void Atribuir(object sender, EventArgs e)
        {
            try
            {
                BllDisciplinaCurso.Inserir(new(curso.Id, idSel));
                label.Text = "Nenhuma disciplina selecionada.";
                CarregarCheckBoxs();
            }
            catch (DuplicateNameException)
            {
                MessageBox.Show("Atribuição já feita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Desatribuir(object sender, EventArgs e)
        {
            BllDisciplinaCurso.Deletar(new(curso.Id, idSel));
            label.Text = "Nenhuma disciplina selecionada.";
            CarregarCheckBoxs();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

