using SmartSchool.Models;

namespace SmartSchool.Data
{
    public interface IRepository
    {

        void Add<T>(T entity) where T : class; // um aluno do tipo aluno tem que ser sempre uma classe. 

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        bool SaveChanges();

        Aluno[] GetAllAlunos(bool includeProfessor = false);

        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);

        Aluno GetAlunoByID(int alunoId, bool includeProfessor = false);

        //Professor
       Professor[] GetAllProfessores(bool includeAlunos = false);

        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);

        Professor GetProfessorByID(int professorId, bool includeProfessor = false);
    }
}
