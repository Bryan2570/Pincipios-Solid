namespace InterfaceSegregation
{
    public class RecursoHumano : IWorkTeamActivities, IRecursoActivities
    {
        public RecursoHumano()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Select() 
        {
            throw new ArgumentException();
        }
    }
}