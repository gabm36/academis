using model;
using dal;
using System.Data;

namespace bll
{
    public class BllCategoria
    {
        public static Categoria Selecionar(int id)
        {
            return DalCategoria.Selecionar(id);
        }

        public static void Inserir(Categoria c)
        {
            DalCategoria.Inserir(c);
        }

        public static void Atualizar(Categoria c)
        {
            DalCategoria.Atualizar(c);
        }

        public static void Deletar(int id)
        {
            DalCategoria.Deletar(id);
        }

        public static DataTable Listar()
        {
            return DalCategoria.Listar();
        }
    }
}