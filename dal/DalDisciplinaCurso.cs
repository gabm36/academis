using model;
using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalDisciplinaCurso
    {
        private static String tbl = "disciplinaCurso";

        public static DisciplinaCurso Selecionar(int curId, int disId)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "SELECT * FROM " + tbl + " WHERE curId = @curId AND disId = @disId;";
                sql.Parameters.Add("@curId", SqlDbType.Int).Value = curId;
                sql.Parameters.Add("@disId", SqlDbType.Int).Value = disId;

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    if (reader.Read() && reader.HasRows)
                    {
                        DisciplinaCurso dc = new((int)reader["curId"], (int)reader["disId"]);
                        return dc;
                    }
                    else
                    {
                        return new();
                    }
                }
            }
        }

        public static List<DisciplinaCurso> Selecionar(int id, String seletor)
        {
            if (seletor == "curId" || seletor == "disId")
            {
                List<DisciplinaCurso> l = new();

                using (SqlCommand sql = new DalConexao().AbrirConexao())
                {
                    sql.CommandText = "SELECT * FROM " + tbl + " WHERE " + seletor + " = @id;";
                    sql.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (SqlDataReader reader = sql.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int curId = (int)reader["curId"];
                                int disId = (int)reader["disId"];

                                l.Add(new DisciplinaCurso(curId, disId));
                            }
                        }
                    }

                    return new(l);
                }

            }
            else
            {
                throw new Exception("Erro de implantação.");
            }
        }

        public static void Inserir(DisciplinaCurso disciplinaCurso)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "INSERT INTO " + tbl + " (curId, disId) VALUES (@curId, @disId);";

                sql.Parameters.Add("@curId", SqlDbType.Int).Value = disciplinaCurso.CurId;
                sql.Parameters.Add("@disId", SqlDbType.Int).Value = disciplinaCurso.DisId;

                sql.ExecuteNonQuery();
            }
        }

        public static void Atualizar(DisciplinaCurso disciplinaCurso)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "UPDATE " + tbl + " SET curId = @curId, disId = @disId WHERE curId = @curId AND disId = @disId;";

                sql.Parameters.Add("@curId", SqlDbType.Int).Value = disciplinaCurso.CurId;
                sql.Parameters.Add("@disId", SqlDbType.VarChar).Value = disciplinaCurso.DisId;

                sql.ExecuteNonQuery();
            }
        }

        public static void Deletar(int curId, int disId)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "DELETE FROM " + tbl + " WHERE curId = @curId AND disId = @disId;";

                sql.Parameters.Add("@curId", SqlDbType.Int).Value = curId;
                sql.Parameters.Add("@disId", SqlDbType.Int).Value = disId;

                sql.ExecuteNonQuery();
            }
        }
        public static void Deletar(int id, String seletor)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "DELETE FROM " + tbl + " WHERE " + seletor + " = @id;";

                sql.Parameters.Add("@id", SqlDbType.Int).Value = id;

                sql.ExecuteNonQuery();
            }
        }
    }
}