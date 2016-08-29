using System.Collections.Generic;
using System.Web.Http;
using EmpPayroll.Services.Domain.BussinessMangers;
using EmpPayroll.Services.Domain.Repos;
using EmpPayroll.Services.Domain.ViewModels;
using Microsoft.AspNet.Identity;

namespace EmpPayroll.Services.Controllers
{
     [RoutePrefix("api/Employees")]
    
    public class EmployeesController : ApiController
    {
        private readonly MangerBussinessManger _mangerBussinessManger;
        private readonly UserBussinessManger _userBussinessManger;
        private string _userId;

        public EmployeesController()
        {
            _userBussinessManger = new UserBussinessManger(new UserRepository());
            _mangerBussinessManger = new MangerBussinessManger(new MangerReposiory());
        }

        [HttpGet]
        [Route("GetPayroll")]
        [Authorize]
        // GET: api/Employees/5
        public ApplicationUserViewModel GetPayroll()
        {
            _userId = User.Identity.GetUserId();

            var emp = _userBussinessManger.GetById(_userId);
            return new ApplicationUserViewModel
            {
                DId = emp.DId,
                Salary = emp.Salary,
                UserName = emp.UserName
            };
        }

        [HttpGet]
        [Route("GetEmployeesPayroll")]
        [Authorize]

        public IEnumerable<ApplicationUserViewModel> GetEmployeesPayroll()
        {
            _userId = User.Identity.GetUserId();

            var empList = _mangerBussinessManger.GetEmployeesPayroll(_userId);
            return empList;
        }
    }
}