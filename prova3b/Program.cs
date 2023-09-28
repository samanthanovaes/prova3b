using prova3b;
using System;

public class Program
{
    
    static void Main(string[] args)
    {
        List<Medico> listamedico = new List<Medico>();
        List<Adm> listaadm = new List<Adm>();

        // lembra de dar tabs para aparecer o resultado final :)
        string profissao = "";
        string nome = "";
        string cpf = "";
        string matricula = "";
        DateTime datanasc;
        string sexo = "";
        double salario = 0.0;
        string crm = "";
        double horaex = 0.0;
        string especialidade = "";
        string funcao = "";

       
        while (true)
        {
            Console.WriteLine("Caso deseje sair, digite 1; caso não queira, digite 0:");
            
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                break;
            }
            else if (opcao == 0)
            {


                {
                    Console.WriteLine("Bem-vindo! Por favor, preencha as informações a seguir por linha:");
                    Console.WriteLine(" Profissão (Médico ou administrador)\n Nome\n CPF\n Matrícula\n Data de nascimento\n Sexo\n Salário\n");

                    profissao = Console.ReadLine();
                    nome = Console.ReadLine();
                    cpf = Console.ReadLine();
                    matricula = Console.ReadLine();
                    datanasc = DateTime.Parse(Console.ReadLine());
                    sexo = Console.ReadLine();
                    salario = Convert.ToDouble(Console.ReadLine());

                    if (profissao.ToUpper() == "MÉDICO" || salario >= salario - (salario * 0.22))
                    {
                        crm = Console.ReadLine();
                        especialidade = Console.ReadLine();
                        Medico medico = new Medico(nome, cpf, matricula, datanasc, sexo, salario, crm, horaex, especialidade);
                        double salarioextra = medico.SalarioExtra(salario);
                        Console.WriteLine(salarioextra);
                        listamedico.Add(medico);
                    }


                    else if (profissao.ToUpper() == "ADM" || salario <= salario - (salario * 0.17))
                    {
                        funcao = Console.ReadLine();
                        Adm adm = new Adm(nome, cpf, matricula, datanasc, sexo, salario, funcao);
                        double salarioextra = adm.SalarioExtra(salario);
                        Console.WriteLine(salarioextra);
                        listaadm.Add(adm);
                    }
                    else
                    {
                        Console.WriteLine("Erro. Verifique o preenchimento das informações ou a quantidade de seu salário");


                    }

                    Console.WriteLine("Para sair, digite 1");
                }
            }
        }

		Console.ReadKey();
	}


}