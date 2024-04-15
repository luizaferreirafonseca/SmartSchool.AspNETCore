﻿namespace SmartSchool.Models
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

        public Professor(int id, string nome, int registro, string sobrenome)
        {
            Id = id;
            Nome = nome;
            Registro = Registro;
            Sobrenome = sobrenome;
        }
    }
}
