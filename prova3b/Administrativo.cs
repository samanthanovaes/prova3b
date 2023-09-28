using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3b
{
    public class Adm : Funcionario
    {
        public string Funcao { get; set; }

        public Adm(string nome, string cpf, string matricula, DateTime datanasc, string sexo,
        double salario, string funcao):base(nome, cpf, matricula, datanasc, sexo, salario)
        {

            this.Funcao = funcao;
        }

        public virtual double SalarioExtra (double salario)
        {
           
            salario = salario + (salario * 0.17);
            return salario + 250;
        }
    }

}
