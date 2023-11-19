using model;
using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalPeriodo
    {
        private static String tbl = "tblPeriodos";

        public static Periodo Selecionar(int id)
        {
            string query = "SELECT * FROM " + tbl + " WHERE perId = @perId;";
            SqlParameter parameter = new("@perId", SqlDbType.Int) { Value = id };
            return Selecionar(query, parameter);
        }

        public static Periodo Selecionar(string sigla)
        {
            string query = "SELECT * FROM " + tbl + " WHERE perSigla = @perSigla;";
            SqlParameter parameter = new("@perSigla", SqlDbType.VarChar) { Value = sigla };
            return Selecionar(query, parameter);
        }

        private static Periodo Selecionar(string query, SqlParameter parameter)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = query;
                sql.Parameters.Add(parameter);

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    if (reader.Read() && reader.HasRows)
                    {
                        int id = (int)reader["perId"];
                        string nome = (string)reader["perNome"];
                        string sigla = (string)reader["perSigla"];

                        return new Periodo(id, nome, sigla);
                    }
                    else
                    {
                        return new Periodo();
                    }
                }
            }
        }

        public static void Inserir(Periodo p)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "INSERT INTO " + tbl + " (perNome, perSigla) VALUES (@perNome, @perSigla);";

                sql.Parameters.Add("@perNome", SqlDbType.VarChar).Value = p.Nome;
                sql.Parameters.Add("@perSigla", SqlDbType.VarChar).Value = p.Sigla;

                sql.ExecuteNonQuery();
            }
        }

        public static void Atualizar(Periodo p)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "UPDATE " + tbl + " SET perNome = @perNome, perSigla = @perSigla WHERE perId = @perId;";

                sql.Parameters.Add("@perId", SqlDbType.Int).Value = p.Id;
                sql.Parameters.Add("@perNome", SqlDbType.VarChar).Value = p.Nome;
                sql.Parameters.Add("@perSigla", SqlDbType.VarChar).Value = p.Sigla;

                sql.ExecuteNonQuery();
            }
        }

        public static void Deletar(int perId)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "DELETE FROM " + tbl + " WHERE perId = @perId;";

                sql.Parameters.Add("@perId", SqlDbType.Int).Value = perId;

                sql.ExecuteNonQuery();
            }
        }

        public static DataTable Listar()
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();
            sql.CommandText = "SELECT tblPeriodos.perId, perNome, perSigla, curNome FROM " + tbl + " LEFT JOIN tblCursos ON tblPeriodos.perId = tblCursos.perId;";

            DataTable tabela = new();
            SqlDataAdapter adaptador = new(sql);
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}