using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ReDpett_API.Modal;
using ReDpett_API.Service;

namespace ReDpett_API.Controllers
{
    public class ProjectsController : ControllerBase
    {
        private IDBService _db;
        private string? _guid;

        public ProjectsController(IDBService dBService)
        {
            _db = dBService;
        }

        [Route("/Projects/Insert")]
        [HttpPost]
        public IActionResult PostProjects([FromBody] Projects prj)
        {
            try
            {
                _guid = Guid.NewGuid().ToString();
                _db.InserTransaction(prj, _guid);
                 return Ok("Data Updated..");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
