using dal;
using model;
using System.Data;

namespace bll
{
    public class BllCurso
    {
        public static Curso Selecionar(int id)
        {
            return DalCurso.Selecionar(id);
        }

        public static void Inserir(Curso c)
        {
            DalCurso.Inserir(c);
        }

        public static void Atualizar(Curso c)
        {
            DalCurso.Atualizar(c);
        }

        public static void Deletar(int id)
        {
            DalCurso.Deletar(id);
        }

        public static DataTable Listar()
        {
            return DalCurso.Listar();
        }
    }
}
