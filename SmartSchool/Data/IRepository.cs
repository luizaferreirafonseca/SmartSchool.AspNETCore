using SmartSchool.Models;

namespace SmartSchool.Data
{
    public interface IRepository
    {

        void Add<T>(T entity) where T : class; // um aluno do tipo aluno tem que ser sempre uma classe. 

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        bool SaveChanges();

        Aluno[] GetAllAlunos();

        Aluno[] GetAllAlunosByDisciplinaId();

        Aluno[] GetAlunosByID();

        Aluno[] GetAllProfessores();

        Aluno[] GetAllProfessoresByDisciplinaId();

        Aluno[] GetAllProfessoresByID();
    }
}
