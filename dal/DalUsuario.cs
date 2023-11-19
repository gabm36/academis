using model;
using System.Data;
using System.Data.SqlClient;

namespace dal
{
    public class DalUsuario
    {
        private static String tbl = "tblUsuarios";

        public static Usuario Selecionar(int id)
        {
            string query = "SELECT * FROM " + tbl + " WHERE usrId = @usrId;";
            SqlParameter parametro = new("@usrId", SqlDbType.Int) { Value = id };
            return Selecionar(query, parametro);
        }

        public static Usuario Selecionar(string login)
        {
            string query = "SELECT * FROM " + tbl + " WHERE usrLogin = @usrLogin;";
            SqlParameter parametro = new("@usrLogin", SqlDbType.VarChar) { Value = login };
            return Selecionar(query, parametro);
        }

        private static Usuario Selecionar(string query, SqlParameter parametro)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = query;
                sql.Parameters.Add(parametro);

                using SqlDataReader reader = sql.ExecuteReader();
                if (reader.Read() && reader.HasRows)
                {
                    int id = (int)reader["usrId"];
                    string nome = (string)reader["usrNome"];
                    string login = (string)reader["usrLogin"];
                    string senha = "********";

                    return new Usuario(id, nome, login, senha);
                }
                else
                {
                    return new Usuario();
                }
            }
        }

        public static void Inserir(Usuario u)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "INSERT INTO " + tbl + " (usrNome, usrLogin, usrSenha) VALUES (@usrNome, @usrLogin, @usrSenha);";

                sql.Parameters.Add("@usrNome", SqlDbType.VarChar).Value = u.Nome;
                sql.Parameters.Add("@usrLogin", SqlDbType.VarChar).Value = u.Login;
                sql.Parameters.Add("@usrSenha", SqlDbType.VarChar).Value = u.Senha;

                sql.ExecuteNonQuery();
            }
        }

        public static void Atualizar(Usuario u)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "UPDATE " + tbl + " SET usrNome = @usrNome, usrLogin = @usrLogin, usrSenha = @usrSenha WHERE usrId = @usrId;";

                sql.Parameters.Add("@usrId", SqlDbType.Int).Value = u.Id;
                sql.Parameters.Add("@usrNome", SqlDbType.VarChar).Value = u.Nome;
                sql.Parameters.Add("@usrLogin", SqlDbType.VarChar).Value = u.Login;
                sql.Parameters.Add("@usrSenha", SqlDbType.VarChar).Value = u.Senha;

                sql.ExecuteNonQuery();
            }
        }

        public static void Deletar(int id)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "DELETE FROM " + tbl + " WHERE usrId = @usrId;";

                sql.Parameters.Add("@usrId", SqlDbType.Int).Value = id;

                sql.ExecuteNonQuery();
            }
        }

        public static DataTable Listar()
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "Select usrId, usrNome, usrLogin FROM " + tbl + " ORDER BY usrId ASC;";

                DataTable tabela = new();
                SqlDataAdapter adaptador = new(sql);
                adaptador.Fill(tabela);

                return tabela;
            }
        }

        public static bool ConferirLogin(String login, String senha, out Usuario usuarioAtivo)
        {
            using (SqlCommand sql = new DalConexao().AbrirConexao())
            {
                sql.CommandText = "SELECT * FROM " + tbl + " WHERE usrLogin = @usrLogin AND usrSenha = @usrSenha;";
                sql.Parameters.AddWithValue("@usrLogin", login);
                sql.Parameters.AddWithValue("@usrSenha", senha);

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int usrId = (int)reader["usrId"];
                        string usrNome = (string)reader["usrNome"];
                        string usrLogin = (string)reader["usrLogin"];
                        string usrSenha = "********";

                        usuarioAtivo = new(usrId, usrNome, usrLogin, usrSenha);
                        return true;
                    }
                    else
                    {
                        usuarioAtivo = new();
                        return false;
                    }
                }
            }
        }
    }
}
