using model;
using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalCategoria
    {
        private static String tbl = "tblCategorias";

        public static Categoria Selecionar(int id)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "SELECT * FROM " + tbl + " WHERE catId = @catId;";
            sql.Parameters.Add("@catId", SqlDbType.Int).Value = id;

            using SqlDataReader reader = sql.ExecuteReader();

            if (reader.Read() && reader.HasRows)
            {
                id = (int)reader["catId"];
                string descricao = (string)reader["catDescricao"];

                return new Categoria(id, descricao);
            }
            else
            {
                return new Categoria();
            }
        }

        public static void Inserir(Categoria c)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "INSERT INTO " + tbl + " (catId, catDescricao) VALUES (@catId, @catDescricao);";

            sql.Parameters.Add("@catId", SqlDbType.VarChar).Value = c.Id;
            sql.Parameters.Add("@catDescricao", SqlDbType.Decimal).Value = c.Descricao;

            sql.ExecuteNonQuery();
        }

        public static void Atualizar(Categoria c)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "UPDATE " + tbl + " SET catDescricao = @catDescricao WHERE catId = @catId;";

            sql.Parameters.Add("@catId", SqlDbType.Int).Value = c.Id;
            sql.Parameters.Add("@catDescricao", SqlDbType.VarChar).Value = c.Descricao;

            sql.ExecuteNonQuery();
        }

        public static void Deletar(int id)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "DELETE FROM " + tbl + " WHERE catId = @catId;";

            sql.Parameters.Add("@catId", SqlDbType.Int).Value = id;

            sql.ExecuteNonQuery();
        }

        public static DataTable Listar()
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();

            sql.CommandText = "SELECT catId, catDescricao FROM " + tbl + ";";

            DataTable tabela = new();
            SqlDataAdapter adaptador = new(sql);
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}