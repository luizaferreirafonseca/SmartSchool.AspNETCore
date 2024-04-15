namespace SmartSchool.Models
{
    public class Disciplina
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public int CargaHoraria { get; set; }

        public int? PrerequisitoId { get; set; } = null;

        public Disciplina Prerequisito { get; set; }
        public int ProfessorId { get; set; } // o entity já faz a relação

        public Professor Professor { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }

        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }

        public Disciplina() { }


        public Disciplina(int id, string nome, int professorId, int cursoId )
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            this.CursoId = cursoId;
            
        }








    }
}
