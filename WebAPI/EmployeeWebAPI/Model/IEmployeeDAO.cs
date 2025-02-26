namespace EmployeeWebAPI.Model
{
    public interface IEmployeeDAO
    {

        void Add(Employee employee);

        void Delete(int id);

        void Update(Employee employee);

        Employee GetById(int id);

        List<Employee> GetAllEMployee();
    }
}
