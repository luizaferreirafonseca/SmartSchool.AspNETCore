using Microsoft.EntityFrameworkCore;
using SmartSchool.Models;

namespace SmartSchool.Data
{
    public class Repository : IRepository

    {
        private readonly SmartContext _context;

        public Repository(SmartContext context)
        {
            _context = context;
        }


        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity); // o meu add não contém um tipo específico. ele tem um entity que vai reconhecer quem é que é que está.
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Aluno[] GetAllAlunos(bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas) 
                    .ThenInclude(ad => ad.Disciplina)
                    .ThenInclude(d => d.Professor);
            }

            query = query.AsNoTracking().OrderBy(a => a.Id);

            return query.ToArray();
        }

        public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                    .ThenInclude(ad => ad.Disciplina)
                    .ThenInclude(d => d.Professor);
            }

            query = query.AsNoTracking().OrderBy(a => a.Id)
                .Where(aluno => aluno.AlunoDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId));

            return query.ToArray();


        }

        public Aluno GetAlunosByID( int alunoId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _context.Alunos;

            if (includeProfessor)
            {
                query = query.Include(a => a.AlunoDisciplinas)
                    .ThenInclude(ad => ad.Disciplina)
                    .ThenInclude(d => d.Professor);
            }

            query = query.AsNoTracking().OrderBy(a => a.Id)
                .Where(aluno => aluno.Id == alunoId);

            return query.FirstOrDefault();
        }

        public Aluno[] GetAllProfessores()
        {
            throw new NotImplementedException();
        }

        public Aluno[] GetAllProfessoresByDisciplinaId()
        {
            throw new NotImplementedException();
        }

        public Aluno[] GetAllProfessoresByID()
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
