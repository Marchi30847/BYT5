namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employeeList = new List<Employee>();
            
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                int id = int.Parse(employeesArray[i, 0]);
                
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                
                decimal salary = decimal.Parse(employeesArray[i, 3]);

                employeeList.Add(new Employee(id, name, designation, salary));
            }
            
            _thirdPartyBillingSystem.ProcessSalary(employeeList);
        }
    }
}
