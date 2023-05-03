using System;

namespace exemplo_heranca;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
       FuncionarioN2 n2 = new FuncionarioN2();
       FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "fulano";
        n2.Nome = "ciclano";
        n3.Nome = "zezinho";
    

        Console.WriteLine("nome: " + n1.Nome + " lucro: " + n1.Lucro());
        Console.WriteLine("nome: " + n2.Nome + " lucro: " + n2.Lucro());
        Console.WriteLine("nome: " + n3.Nome + " lucro: " + n3.Lucro());
    }
}
