using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infra
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ConnectionContext _connectionContext = new ConnectionContext();

        public void Add(Employee employee)
        {
            _connectionContext.Employees.Add(employee);
            _connectionContext.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _connectionContext.Employees.ToList();
        }
    }
}
