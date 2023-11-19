using dal;
using model;
using System.Data;

namespace bll
{
    public class BllDisciplinaCurso
    {
        public static List<DisciplinaCurso> Selecionar(int id, String seletor)
        {
            return DalDisciplinaCurso.Selecionar(id, seletor);
        }


        public static void Inserir(DisciplinaCurso dc)
        {
            DisciplinaCurso dados = DalDisciplinaCurso.Selecionar(dc.CurId, dc.DisId);

            if (dados.CurId != 0 && dados.DisId != 0)
                throw new DuplicateNameException("Conexão entre tabelas já existente.");
            else
                DalDisciplinaCurso.Inserir(dc);
        }

        public static void Atualizar(DisciplinaCurso dc)
        {
            DalDisciplinaCurso.Atualizar(dc);
        }

        public static void Deletar(DisciplinaCurso dc)
        {
            DalDisciplinaCurso.Deletar(dc.CurId, dc.DisId);
        }

        public static void Deletar(int id, String seletor)
        {
            DalDisciplinaCurso.Deletar(id, seletor);
        }
    }
}
