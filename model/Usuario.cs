namespace model
{
    public class Usuario
    {
        private int id = 0;
        private string nome = "";
        private string login = "";
        private string senha = "";

        public Usuario() { }

        public Usuario(int id, string nome, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
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

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("O login não pode ter mais de 50 caracteres.");
                else if (value.Length < 8)
                    throw new ArgumentException("O login não pode ter menos de 8 caracteres.");
                else
                    login = value;
            }
        }

        public string Senha
        {
            get { return senha; }
            set
            {
                if (value.Length < 8 || value.Length > 32)
                    throw new ArgumentException("A senha precisa ter entre 8 e 32 caracteres.");
                else
                    senha = value;
            }
        }
    }
}
