using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;
using App.Services.Domain.BussinessMangers.Interfaces;
using App.Services.Domain.Models;
using Ninject;

namespace App.Services.Controllers
{
    public class DepartmentsController : ApiController
    {
        private readonly IDepartmentBussinessManger _departmentBussinessManger;
        [Inject]
        public DepartmentsController(IDepartmentBussinessManger departmentBussinessManger)
        {
            _departmentBussinessManger = departmentBussinessManger;
        }
        public DepartmentsController()
        {
       
        }
        // GET: api/Departments
        [EnableQuery]
        public IQueryable<Department> Get()
        {
            return _departmentBussinessManger.Get();
        }

        // GET: api/Departments/5
        public Department Get(int id)
        {
            return _departmentBussinessManger.GetById(id);
        }

        // POST: api/Departments
        public Department Post([FromBody]Department department)
        {
            return _departmentBussinessManger.Save(department);

        }

        // PUT: api/Departments/5
        public Department Put( [FromBody] Department department)
        {
          return _departmentBussinessManger.Update(department);
        }

        // DELETE: api/Departments/5
        public Department Delete(int id)
        {
           return _departmentBussinessManger.Delete(id);
        }
    }
}
