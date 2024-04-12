using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {

        private readonly SmartContext _context;
        private readonly IRepository _repo;

        public AlunoController (SmartContext context, IRepository repo
            )
        {
            _context = context;
            _repo = repo;
        }

        


        [HttpGet("byId/{id}")]

        public ActionResult Get(int id)
        {
                        
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpGet("ByName")]

        public ActionResult Get(string nome, string Sobrenome)
        {

            var aluno = _context.Alunos.FirstOrDefault(a =>
                a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome)
            );

            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }


        [HttpPost]

        public ActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);

            if (_repo.SaveChanges())
            {
                return Ok(aluno);

            }

            return BadRequest("ALuno não foi cadastrado");
        }


        [HttpPut("{id}")]

        public ActionResult Put(int id, Aluno aluno)
        {
            var alu = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("Aluno não encontrado");
            _repo.Update(aluno);

            if (_repo.SaveChanges())
            {
                return Ok(aluno);

            }

            return BadRequest("ALuno não foi atualizado");
        }

        [HttpPatch("{id}")]

        public ActionResult Patch(int id, Aluno aluno)
        {
            var alu = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("Aluno não encontrado");

            _repo.Update(aluno);

            if (_repo.SaveChanges())
            {
                return Ok(aluno);

            }

            return BadRequest("ALuno não foi atualizado");
        }



        [HttpDelete("{id}")]

        public ActionResult Delete(int id, Aluno aluno)
        {
            var alu = _context.Alunos.FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("Aluno não encontrado");
            _repo.Delete(aluno);

            if (_repo.SaveChanges())
            {
                return Ok(aluno);

            }

            return BadRequest("ALuno não foi deletado");
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
