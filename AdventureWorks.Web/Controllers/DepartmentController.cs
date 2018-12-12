
using System.Web.Http;
using AdventureWorks.Services.HumanResources;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AdventureWorks.Web.Controllers
{
    [RoutePrefix("Department")]
    public class DepartmentController : ApiController
    {
        /// <summary>
        /// GET: Departments
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [Route("all")]
        public ICollection<Department> Index()
        {
            DepartmentService departmentService = new DepartmentService();
            var departmentGroups = departmentService.GetDepartments();

            return departmentGroups;
        }

        /// <summary>
        ///  GET: Departments/Employees/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [Route("Departments/Employees/{id}")]
        public ICollection<DepartmentEmployee> GetEmployees(int id)
        {
            DepartmentService departmentService = new DepartmentService();
            var departmentEmployees = departmentService.GetDepartmentEmployees(id);
            var departmentInfo = departmentService.GetDepartmentInfo(id);

           // ViewBag.Title = "Employees in " + departmentInfo.Name + " Department";

            return departmentEmployees;
        }
    }
}
