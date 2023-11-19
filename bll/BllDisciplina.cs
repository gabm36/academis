using dal;
using model;
using System.Data;

namespace bll
{
    public class BllDisciplina
    {
        public static Disciplina Selecionar(int disId)
        {
            return DalDisciplina.Selecionar(disId);
        }

        public static void Inserir(Disciplina d)
        {
            DalDisciplina.Inserir(d);
        }

        public static void Atualizar(Disciplina d)
        {
            DalDisciplina.Atualizar(d);
        }

        public static void Deletar(int disId)
        {
            DalDisciplina.Deletar(disId);
        }

        public static DataTable Listar()
        {
            return DalDisciplina.Listar();
        }
    }
}
