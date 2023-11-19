namespace model
{
    public class Periodo
    {
        private int id = 0;
        private string nome = "";
        private string sigla = "";

        public Periodo() { }

        public Periodo(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
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
    }
}
