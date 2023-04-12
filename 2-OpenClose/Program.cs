using OpenClose;

CalculateSalaryMonthly(new List<Employe>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeContractor("Brayan Rojas", 200),
});


void CalculateSalaryMonthly(List<Employe> employees) 
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }

}