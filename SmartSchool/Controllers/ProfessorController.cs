using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{
    public class ProfessorController : Controller
    {


      
        public ProfessorController() { }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Professores: Marta, Paula, Lucas, Rafa");
        }
    }
}
