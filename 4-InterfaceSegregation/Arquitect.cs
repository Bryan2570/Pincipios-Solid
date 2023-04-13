
namespace InterfaceSegregation
{ 
    //otra forma
// public class Arquitect : IWorkTeamActivities, IDesignActivities, IDevelopActivities, ITestActivities

    public class Arquitect : IActivities
    {
        public void Plan() 
        {
            throw new NotImplementedException();
        }

        public void Comunicate() 
        {
            throw new NotImplementedException();
        }

        public void Design() 
        {
            throw new NotImplementedException();
        }

        public void Develop() 
        {
            throw new NotImplementedException();
        }

        public void Test() 
        {
            throw new NotImplementedException();
        }

        public void Select() 
        {
            throw new NotImplementedException();
        }


    }

}