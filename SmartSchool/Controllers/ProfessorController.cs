using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    public class ProfessorController : Controller
    {


        private readonly SmartContext _context;
        private readonly IRepository _repo;


        public ProfessorController(SmartContext context, IRepository repo) {
            _context = context;
            _repo = repo;

        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var Professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (Professor == null) return BadRequest("O professor não foi encontrado");
            return Ok(Professor);
        }


        [HttpGet("ByName")]

        public IActionResult GetByName(string nome) {

            var Professor = _context.Professores.FirstOrDefault(a =>
            a.Nome.Contains(nome));

            if (Professor == null) return BadRequest("O professor não foi encontrado");
            return Ok(Professor);
        
        }

        [HttpPost]

        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);

            if (_repo.SaveChanges())
            {
                return Ok(professor);

            }

            return BadRequest("Professor não foi cadastrado");
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não foi encontrado");

            _repo.Update(professor);

            if (_repo.SaveChanges())
            {
                return Ok(professor);

            }

            return BadRequest("Professor não foi atualizado");
        }

        [HttpPatch("{id}")]

        public IActionResult Patch(int id, Professor professor)
        {
            var alu = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("Professor não foi encontrado");

            _repo.Update(professor);

            if (_repo.SaveChanges())
            {
                return Ok(professor);

            }

            return BadRequest("Professor não foi atualizado");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var Professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (Professor == null) return BadRequest("Professor não foi encontrado");

            _repo.Update(professor);

            if (_repo.SaveChanges())
            {
                return Ok(professor);

            }

            return BadRequest("Professor não foi atualizado");
        }



    }
}
