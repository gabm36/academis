using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalConexao : IDisposable
    {
        private SqlCommand sql;
        private readonly SqlConnection conexao;

        public DalConexao()
        {
            conexao = new SqlConnection(
                "Data Source=G15W; " +
                "Initial Catalog=ACADEMIS; " +
                "Integrated Security=true;");
            sql = new SqlCommand();
            sql.Connection = conexao; // Associa a conexão ao comando
        }

        public SqlCommand AbrirConexao()
        {
            if (conexao.State != ConnectionState.Open)
                conexao.Open();

            return sql;
        }

        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }

        public void Dispose()
        {
            FecharConexao();
        }
    }
}
