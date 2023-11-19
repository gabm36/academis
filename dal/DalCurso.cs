using model;
using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalCurso
    {
        private static String tbl = "tblCursos";

        public static Curso Selecionar(int id)
        {
            string query = "SELECT * FROM " + tbl + " WHERE curId = @curId;";
            SqlParameter parametro = new("@curId", SqlDbType.Int) { Value = id };
            return Selecionar(query, parametro);
        }

        public static Curso Selecionar(string sigla)
        {
            string query = "SELECT * FROM " + tbl + " WHERE curSigla = @curSigla;";
            SqlParameter parametro = new("@curSigla", SqlDbType.VarChar) { Value = sigla };
            return Selecionar(query, parametro);
        }

        private static Curso Selecionar(string query, SqlParameter parametro)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();
            sql.CommandText = query;
            sql.Parameters.Add(parametro);

            using SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read() && reader.HasRows)
            {
                int id = (int)reader["curId"];
                string nome = (string)reader["curNome"];
                string sigla = (string)reader["curSigla"];
                string? observacoes = reader.IsDBNull(reader.GetOrdinal("curObservacoes")) ? null : (string?)reader["curObservacoes"];
                int periodo = (int)reader["perId"];

                List<DisciplinaCurso> cursos = DalDisciplinaCurso.Selecionar(id, "curId");

                return new Curso(id, nome, sigla, observacoes, periodo, cursos);
            }
            else
            {
                return new Curso();
            }
        }

        public static void Inserir(Curso c)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();
            sql.CommandText = "INSERT INTO " + tbl + " (curNome, curSigla, curObservacoes, perId) VALUES (@curNome, @curSigla, @curObservacoes, @perId)";

            sql.Parameters.Add("@curId", SqlDbType.Int).Value = c.Id;
            sql.Parameters.Add("@curNome", SqlDbType.VarChar).Value = c.Nome;
            sql.Parameters.Add("@curSigla", SqlDbType.VarChar).Value = c.Sigla;
            sql.Parameters.Add("@curObservacoes", SqlDbType.NVarChar).Value = (c.Observacoes == null) ? (object)DBNull.Value : c.Observacoes;
            sql.Parameters.Add("@perId", SqlDbType.Int).Value = c.Periodo;

            sql.ExecuteNonQuery();
        }

        public static void Atualizar(Curso c)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();
            sql.CommandText = "UPDATE " + tbl + " SET curNome = @curNome, curSigla = @curSigla, curObservacoes = @curObservacoes, perId = @perId WHERE curId = @curId;";

            sql.Parameters.Add("@curId", SqlDbType.Int).Value = c.Id;
            sql.Parameters.Add("@curNome", SqlDbType.VarChar).Value = c.Nome;
            sql.Parameters.Add("@curSigla", SqlDbType.VarChar).Value = c.Sigla;
            sql.Parameters.Add("@curObservacoes", SqlDbType.NVarChar).Value = (c.Observacoes == null) ? (object)DBNull.Value : c.Observacoes;
            sql.Parameters.Add("@perId", SqlDbType.Int).Value = c.Periodo;

            sql.ExecuteNonQuery();
        }

        public static void Deletar(int id)
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();
            sql.CommandText = "DELETE FROM " + tbl + " WHERE curId = @curId;";

            sql.Parameters.Add("@curId", SqlDbType.Int).Value = id;

            sql.ExecuteNonQuery();
        }

        public static DataTable Listar()
        {
            using SqlCommand sql = new DalConexao().AbrirConexao();
            sql.CommandText = "SELECT c.curId, c.curNome, c.curSigla, c.curObservacoes, c.perId, STRING_AGG(d.disNome + ' (' + d.disSigla + ')', '; ') AS curDisciplinas " +
                "FROM " + tbl + " c " +
                "LEFT JOIN disciplinaCurso cd ON c.curId = cd.curId " +
                "LEFT JOIN tblDisciplinas d ON cd.disId = d.disId " +
                "GROUP BY c.curId, c.curNome, c.curSigla, c.curObservacoes, c.perId;";

            DataTable tabela = new();
            SqlDataAdapter adaptador = new(sql);
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}