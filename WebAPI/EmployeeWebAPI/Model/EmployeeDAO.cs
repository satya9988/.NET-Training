
namespace EmployeeWebAPI.Model
{
    public class EmployeeDAO : IEmployeeDAO
    {
        private readonly EmployeeDBContext ctx;

        public EmployeeDAO(EmployeeDBContext ctx)
        {
            this.ctx = ctx;
        }
    
        public void Add(Employee employee)
        {
           ctx.Employees.Add(employee);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var record=ctx.Employees.Find(id);
            if (record != null)
            {
                ctx.Employees.Remove(record);
                ctx.SaveChanges();
            }
            else
            {
                throw new Exception("NO Record Found");
            }
        }

        public List<Employee> GetAllEMployee()
        {
           return ctx.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return ctx.Employees.Find(id);
        }

        public void Update(Employee employee)
        {
            var record= ctx.Employees.Find(employee.Ecode);
            if (record != null)
            {
                record.EmpName = employee.EmpName;
                record.Salary = employee.Salary;
                record.DepId = employee.DepId;
               
                ctx.SaveChanges();
            }
            else
            {
                throw new Exception("Record not found");
            }
        }
    }
}
