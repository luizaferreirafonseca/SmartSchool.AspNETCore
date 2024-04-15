using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    public class ProfessorController : Controller
    {


        
        private readonly IRepository _repo;


        public ProfessorController(IRepository repo) {
          
            _repo = repo;

        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = _repo.GetAllProfessores(true);
            return Ok(result);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var Professor = _repo.GetProfessorByID(id, false);
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
            var prof = _repo.GetProfessorByID(id, false);
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
            var prof = _repo.GetProfessorByID(id, false);
            if (prof == null) return BadRequest("Professor não foi encontrado");

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
            var prof = _repo.GetProfessorByID(id, false);
            if (prof == null) return BadRequest("Professor não foi encontrado");

            _repo.Update(prof);

            if (_repo.SaveChanges())
            {
                return Ok("professor deletado");

            }

            return BadRequest("Professor não foi deletado");
        }



    }
}
