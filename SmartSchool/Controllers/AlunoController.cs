using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {

        public AlunoController() { }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Alunos: Marta, Paula, Lucas, Rafa");
        }


        [HttpGet("byId/{id}")]

        public ActionResult Get(int id)
        {
                        
            return Ok();
        }

        [HttpGet("ByName")]

        public ActionResult Get(string nome)
        {

            return Ok();
        }


        [HttpPost]

        public ActionResult Post(Aluno aluno)
        {

            return Ok();
        }


        [HttpPut("{id}")]

        public ActionResult Put(int id, Aluno aluno)
        {

            return Ok();
        }

        [HttpPatch("{id}")]

        public ActionResult Patch(int id, Aluno aluno)
        {

            return Ok();
        }



        [HttpDelete("{id}")]

        public ActionResult Delete(int id, Aluno aluno)
        {

            return Ok();
        }








        // GET: Aluno/Details/5
        /*public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aluno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
