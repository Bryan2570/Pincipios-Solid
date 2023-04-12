namespace OpenClose
{
    public class EmployeContractor : Employe
    {
        public EmployeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;        
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}