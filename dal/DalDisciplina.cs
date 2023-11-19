using model;
using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalDisciplina
    {
        private static String tbl = "tblDisciplinas";

        public static Disciplina Selecionar(int id)
        {
            string query = "SELECT * FROM " + tbl + " WHERE disId = @disId;";
            SqlParameter parametro = new("@disId", SqlDbType.Int) { Value = id };
            return DalDisciplina.Selecionar(query, parametro);
        }

        public static Disciplina Selecionar(string sigla)
        {
            string query = "SELECT * FROM " + tbl + " WHERE disSigla = @disSigla;";
            SqlParameter parametro = new("@disSigla", SqlDbType.VarChar) { Value = sigla };
            return Selecionar(query, parametro);
        }

        private static Disciplina Selecionar(string query, SqlParameter parametro)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = query;
                sql.Parameters.Add(parametro);

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    if (reader.Read() && reader.HasRows)
                    {
                        int id = (int)reader["disId"];
                        string nome = (string)reader["disNome"];
                        string sigla = (string)reader["disSigla"];
                        string? observacoes = reader.IsDBNull(reader.GetOrdinal("disObservacoes")) ? null : (string?)reader["disObservacoes"];

                        List<DisciplinaCurso> disciplinas = DalDisciplinaCurso.Selecionar(id, "disId");

                        return new(id, nome, sigla, observacoes, disciplinas);
                    }
                    else
                    {
                        return new();
                    }
                }
            }
        }

        public static void Inserir(Disciplina d)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "INSERT INTO " + tbl + " (disNome, disSigla, disObservacoes) VALUES (@disNome, @disSigla, @disObservacoes)";

                sql.Parameters.Add("@disId", SqlDbType.Int).Value = d.Id;
                sql.Parameters.Add("@disNome", SqlDbType.VarChar).Value = d.Nome;
                sql.Parameters.Add("@disSigla", SqlDbType.VarChar).Value = d.Sigla;
                sql.Parameters.Add("@disObservacoes", SqlDbType.NVarChar).Value = (d.Observacoes == null) ? (object)DBNull.Value : d.Observacoes;

                sql.ExecuteNonQuery();
            }
        }

        public static void Atualizar(Disciplina d)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "UPDATE " + tbl + " SET disNome = @disNome, disSigla = @disSigla, disObservacoes = @disObservacoes WHERE disId = @disId;";

                sql.Parameters.Add("@disId", SqlDbType.Int).Value = d.Id;
                sql.Parameters.Add("@disNome", SqlDbType.VarChar).Value = d.Nome;
                sql.Parameters.Add("@disSigla", SqlDbType.VarChar).Value = d.Sigla;
                sql.Parameters.Add("@disObservacoes", SqlDbType.NVarChar).Value = (d.Observacoes == null) ? (object)DBNull.Value : d.Observacoes;

                sql.ExecuteNonQuery();
            }
        }

        public static void Deletar(int id)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "DELETE FROM " + tbl + " WHERE disId = @disId;";

                sql.Parameters.Add("@disId", SqlDbType.Int).Value = id;

                sql.ExecuteNonQuery();
            }
        }

        public static DataTable Listar()
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "SELECT c.disId, c.disNome, c.disSigla, c.disObservacoes, STRING_AGG(d.curNome + ' (' + d.curSigla + ')', '; ') AS disCursos " +
                    "FROM " + tbl + " c " +
                    "LEFT JOIN disciplinaCurso cd ON c.disId = cd.disId " +
                    "LEFT JOIN tblCursos d ON cd.curId = d.curId " +
                    "GROUP BY c.disId, c.disNome, c.disSigla, c.disObservacoes;";

                DataTable tabela = new();
                SqlDataAdapter adaptador = new(sql);
                adaptador.Fill(tabela);

                return tabela;
            }
        }
    }
}
