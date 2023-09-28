using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3b
{
    public class Medico : Funcionario
    {
        public string Crm { get; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico() { }
        public Medico(string nome, string cpf, string matricula, DateTime datanasc, string sexo, 
        double salario, string crm, double horaextra, string especialidade):base(nome, cpf, matricula, datanasc, sexo, salario)
        {
            this.Crm = crm;
            this.HoraExtra = horaextra;
            this.Especialidade = especialidade;
        }

        public virtual double SalarioExtra(double salario)
        {
            
            salario = salario + (salario * 0.22);
            return salario;
        }
    }
}
