using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3b
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }


        public Funcionario() { }
        public Funcionario( string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Matricula = matricula;
            this.DataNasc = datanasc;
            this.Sexo = sexo;
            this.Salario = salario;
        }


    }

    
}
