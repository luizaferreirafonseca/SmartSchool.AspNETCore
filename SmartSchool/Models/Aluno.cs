namespace SmartSchool.Models
{
    public class Aluno
    {

        
        public int Id { get; set; }

        public int Matricula {  get; set; }

        public string Nome { get; set; }

       public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public DateTime DataNasc {  get; set; }

        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }

        public DateTime DataIni {  get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = null;

        public bool Ativo { get; set; } = true;

        public Aluno() { }

        public Aluno (int id,  string nome, string sobrenome, string telefone, int matricula, DateTime dataNasc)
        {
            Id = id;
            Matricula = matricula;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            DataNasc = dataNasc;
        }






    }
}
