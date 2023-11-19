namespace model
{
    public class Disciplina
    {
        private int id = 0;
        private string nome = "";
        private string sigla = "";
        private string? observacoes = null;
        private List<DisciplinaCurso> cursos = new();

        public Disciplina() { }

        public Disciplina(int id, string nome, string sigla, string? observacoes, List<DisciplinaCurso> cursos)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
            Observacoes = observacoes;
            Cursos = cursos;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O id não pode ser menor do que 0.");
                else
                    id = value;
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("O nome não pode ter mais de 50 caracteres.");
                else if (value.Length == 0)
                    throw new ArgumentException("O nome não pode ser vazio.");
                else
                    nome = value;
            }
        }

        public string Sigla
        {
            get { return sigla; }
            set
            {
                if (value.Length > 5)
                    throw new ArgumentException("A sigla não pode ter mais de 5 caracteres.");
                else if (value.Length == 0)
                    throw new ArgumentException("A sigla não pode ser vazia.");
                else
                    sigla = value;
            }
        }

        public string? Observacoes
        {
            get { return observacoes; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    observacoes = null;
                }
                else
                {
                    if (value.Length > 500)
                        throw new Exception("A observação não pode ter mais de 500 caracteres.");
                    else
                        observacoes = value;
                }
            }
        }

        public List<DisciplinaCurso> Cursos
        {
            get { return cursos; }
            set { cursos = value; }
        }
    }
}
