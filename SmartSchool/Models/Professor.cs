namespace SmartSchool.Models
{
    public class Professor
    {
        public int Id { get; set; }

        public string Nome {  get; set; }

        public string Sobrenome { get; set; }

        public int Registro { get; set; }

        public IEnumerable<Disciplina> Disciplinas { get; set;}

        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = null;

        public bool Ativo { get; set; } = true;

        public Professor () { }

        public Professor(int id,  int registro, string nome, string sobrenome)
        {
            Id = id;
            Registro = registro;
            Nome = nome;
            
            Sobrenome = sobrenome;
        }
    }
}
