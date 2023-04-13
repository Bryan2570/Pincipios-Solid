namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public  Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  
        //Metodo abstractor que se implementa en cada una de las clases
        public abstract decimal CalculateSalary();
       
    }
}