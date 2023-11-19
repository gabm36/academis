namespace model
{
    public class DisciplinaCurso
    {
        private int curId = 0;
        private int disId = 0;

        public DisciplinaCurso() { }

        public DisciplinaCurso(int curId, int disId)
        {
            CurId = curId;
            DisId = disId;
        }

        public int CurId
        {
            get { return curId; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O id não pode ser menor do que 0.");
                else
                    curId = value;
            }
        }

        public int DisId
        {
            get { return disId; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O id não pode ser menor do que 0.");
                else
                    disId = value;
            }
        }
    }
}