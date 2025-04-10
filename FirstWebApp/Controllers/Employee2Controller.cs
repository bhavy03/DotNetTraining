using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace FirstWebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Employee2Controller : ControllerBase
    {
        [HttpGet]
        //[Route("[action]")] 
        //can also use action here
        //[Route("[controller]/[action]")] or this
        public IActionResult Get()
        {
            return Ok("Returning from EmployeeController Get Method");
        }

        [HttpGet]
        public string GetEmployee()
        {
            return "Returning from EmployeeController GetEmployee Method";
        }

        //we can use this instead of common route 

        //can also work if action removed then urls are 
        //api/employee/Emp/All
        ///api/employee/Emp/ById/{Id}

        //if action present then url are
        //api/employee/GetAllEmployees/Emp/All
        //api/employee/GetEmployeeById/Emp/ById/{Id}

        //[Route("Emp/All")]
        //[HttpGet]
        //public string GetAllEmployees()
        //{
        //    return "Response from GetAllEmployees Method";
        //}

        [Route("Emp/ById/{Id}")]
        [HttpGet]
        public string GetEmployeeById(int Id)
        //public string GetEmployeeById([FromRoute(Name = "Id")] int ij) this is another way
        {
            return $"Response from GetEmployeeById Method Id: {Id}";
        }
    }
}

//GET / Emp / Search ? name = Bhavya & age = 21
//[HttpGet("Emp/Search")]
//public string SearchEmployee([FromQuery] string name, [FromQuery] int age)
//{
//    return $"Name: {name}, Age: {age}";
//} or can remove [FromQuery] from this if non ambigous names

//In the ASP.NET Core Application, we can override the Controller level Route Attribute
//at the action method level using the ~(tilde)symbol.
//So, modify the GetAllDepartment action method as follows to use the tilde symbol
//to override the route defined at the employee controller.
//[Route("~/department/all")]
//[HttpGet]
//public string GetAllDepartment()
//{
//    return "Response from GetAllDepartment Method";
//}

//this will give ambigousMatchException
//[Route("{EmployeeId}")]
//[HttpGet]
//public string GetEmployeeDetails(int EmployeeId)
//{
//    return $"Response from GetEmployeeDetails Method, EmployeeId : {EmployeeId}";
//}
//[Route("{EmployeeName}")]
//[HttpGet]
//public string GetEmployeeDetails(string EmployeeName)
//{
//    return $"Response from GetEmployeeDetails Method, EmployeeName : {EmployeeName}";
//}
//We don’t need to specify anything for the string parameter as, by default,
//all the parameters in the ASP.NET Core Web Application are string only.


//[Route("{EmployeeId:int}")] use this to remove ambiguity
//[Route(“{EmployeeName: alpha}”)]  to accept only alphabet (a to z characters) 
//[Route("{EmployeeId:int:max(1000)}")]
//[Route("{EmployeeId:int:min(100):max(1000)}")]
//[Route("{EmployeeId:int:range(100,1000)}")]
//[Route("{EmployeeName:alpha:minlength(5)}")]
//[Route("{EmployeeName:alpha:maxlength(10)}")]
//[Route("{EmployeeName:regex(a(b|c))}")]