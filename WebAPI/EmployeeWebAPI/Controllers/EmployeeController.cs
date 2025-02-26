using System.Threading.Tasks.Dataflow;
using EmployeeWebAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDAO emp;

        public EmployeeController(IEmployeeDAO emp)
        {
            this.emp = emp;
        }

    
        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetEmployee")]
        public IEnumerable<Employee> Get()
        {
            return emp.GetAllEMployee();
        }

        // GET api/<EmployeeController>/5
        [HttpGet()]
        [Route("GetEmployeeById/{id}")]
        public Employee Get(int id)
        {
            return emp.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            emp.Add(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            emp.Update(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            emp.Delete(id);
        }
    }
}
