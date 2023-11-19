using dal;
using model;
using System.Data;

namespace bll
{
    public class BllUsuario
    {
        public static Usuario Selecionar(int usrId)
        {
            return DalUsuario.Selecionar(usrId);
        }

        public static void Inserir(Usuario u)
        {
            DalUsuario.Inserir(u);
        }

        public static void Atualizar(Usuario u)
        {
            DalUsuario.Atualizar(u);
        }

        public static void Deletar(int usrId, Usuario usuarioAtivo)
        {
            Usuario usuario = Selecionar(usrId);

            if (usuario.Id == usuarioAtivo.Id)
                throw new InvalidOperationException("Impossível excluir usuário ativo.");
            else
                DalUsuario.Deletar(usrId);
        }

        public static DataTable Listar()
        {
            return DalUsuario.Listar();
        }

        public static bool ConferirLogin(string login, string senha, out Usuario usuarioAtivo)
        {
            return DalUsuario.ConferirLogin(login, senha, out usuarioAtivo);
        }
    }
}
