using Entityes;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
namespace ReparcityPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogicLayer _ilogicLayer;

        public EmployeeController(ILogicLayer ilogicLayer)
        {
            _ilogicLayer = ilogicLayer;
        }

        [HttpGet("getEmployeeDetails")]

        public IActionResult getall()
        {
            var data = _ilogicLayer.GetLogic();
            return Ok(data);
        }

        [HttpPost("addEmployeeDetails")]

        public IActionResult AddEmployee(DbModel postData)
        {
            var datas = _ilogicLayer.AddUpdateEmployee(postData);
            return Ok(datas);
        }

        [HttpPut("editEmployeeDetails")]

        public IActionResult EditEmployee(DbModel postData)
        {
            var editData = _ilogicLayer.editEmployeeDetail(postData);
            return Ok(editData);
        }

        [HttpDelete("deleteData")]
        public IActionResult DeleteEmployee(int id)
        {
            var deleteData = _ilogicLayer.deletEmployeeDetail(id);
            return Ok(deleteData);
        }
    }
}
