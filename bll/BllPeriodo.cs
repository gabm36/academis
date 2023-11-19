using dal;
using model;
using System.Data;

namespace bll
{
    public class BllPeriodo
    {
        public static Periodo Selecionar(int perId)
        {
            return DalPeriodo.Selecionar(perId);
        }

        public static void Inserir(Periodo p)
        {
            DalPeriodo.Inserir(p);
        }

        public static void Atualizar(Periodo p)
        {
            DalPeriodo.Atualizar(p);
        }

        public static void Deletar(int perId)
        {
            DalPeriodo.Deletar(perId);
        }

        public static DataTable Listar()
        {
            return DalPeriodo.Listar();
        }
    }
}