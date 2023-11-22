namespace model
{
    public class Categoria
    {
        private int id = 0;
        private string descricao = "";

        public Categoria() { }

        public Categoria(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O id não pode ser menor do que 0.");
                else
                    id = value;
            }
        }

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("A descrição não pode ter um valor vazio.");
                else if (value.Length > 50)
                    throw new ArgumentException("A descrição não pode ter mais de 50 caracteres.");
                else
                    descricao = value;
            }
        }
    }
}
