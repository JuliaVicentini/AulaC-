using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaJulia = new ContaCorrente  ("Júlia", 12345, 678, 100);
            ContaCorrente contaDaFernanda = new ContaCorrente  ("Fernanda", 12345, 123, 10);
            ContaCorrente contaDaRoberta = new ContaCorrente  ("Roberta", 12345, 790, 1000);
            
            Console.WriteLine("A conta é do (a) " + contaDaJulia.Titular + 
            ", a agência é " + contaDaJulia.Agencia + " e o número é " 
            + contaDaJulia.Numero + ".");

            Console.WriteLine("A conta é do (a) " + contaDaFernanda.Titular + 
            ", a agência é " + contaDaFernanda.Agencia + " e o número é " 
            + contaDaFernanda.Numero + ".");

            Console.WriteLine("A conta é do (a) " + contaDaRoberta.Titular + 
            ", a agência é " + contaDaRoberta.Agencia + " e o número é " 
            + contaDaRoberta.Numero + ".");
        }
    }
}