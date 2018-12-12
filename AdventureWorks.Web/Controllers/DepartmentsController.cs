using System.Web.Mvc;
using AdventureWorks.Services.HumanResources;

namespace AdventureWorks.Web.Controllers
{
    public class DepartmentsController : Controller
    {
        /// <summary>
        /// GET: Departments
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            DepartmentService departmentService = new DepartmentService();
            var departmentGroups = departmentService.GetDepartments();

            return View(departmentGroups);
        }

        /// <summary>
        ///  GET: Departments/Employees/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Employees(int id)
        {
            DepartmentService departmentService = new DepartmentService();
            var departmentEmployees = departmentService.GetDepartmentEmployees(id);
            var departmentInfo = departmentService.GetDepartmentInfo(id);

            ViewBag.Title = "Employees in " + departmentInfo.Name + " Department";

            return View(departmentEmployees);
        }
    }
}
