using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaAna = new ContaCorrente ("Júlia", 123, 456, 1000); //passa a existir um novo objeto do tipo conta corrente 
           Console.WriteLine("A conta é do(a): " +contaJulia.Titular+ ", a agência é: " +contaJulia.Agencia+ ", o número é: " +contaJulia.Numero+ " e o saldo é: " +contaJulia.Saldo+ "."); 
           bool sacarContaJulia = contaJulia.Sacar(500); //o tipo da variável tem que ser do mesmo que o retorno atribuído ao método
           Console.WriteLine("A conta é do(a): " +contaJulia.Titular+ ", a agência é: " +contaJulia.Agencia+ ", o número é: " +contaJulia.Numero+ " e o saldo é: " +contaJulia.Saldo+ "."); 
           bool depositarContaJulia = contajulia.Depositar(300);
           Console.WriteLine("A conta é do(a): " +contaJulia.Titular+ ", a agência é: " +contaJulia.Agencia+ ", o número é: " +contaJulia.Numero+ " e o saldo é: " +contaJulia.Saldo+ "."); 
           
           ContaCorrente contaFernanda = new ContaCorrente ("Fernanda", 123, 321, 190);  
           Console.WriteLine("A conta é do(a): " +contaFernanda.Titular+ ", a agência é: " +contaFernanda.Agencia+ ", o número é: " +contaFernanda.Numero+ " e o saldo é: " +contaFernanda.Saldo+ "."); 
           bool sacarcontaFernanda = contaFernanda.Sacar(50);
           Console.WriteLine("A conta é do(a): " +contaFernanda.Titular+ ", a agência é: " +contaFernanda.Agencia+ ", o número é: " +contaFernanda.Numero+ " e o saldo é: " +contaFernanda.Saldo+ "."); 
           bool depositarcontaFernanda = contaFernanda.Depositar(100);
           Console.WriteLine("A conta é do(a): " +contaFernanda.Titular+ ", a agência é: " +contaFernanda.Agencia+ ", o número é: " +contaFernanda.Numero+ " e o saldo é: " +contaFernanda.Saldo+ "."); 
           
           ContaCorrente contaRoberta = new ContaCorrente ("Carlos", 123, 562, 500);  
           Console.WriteLine("A conta é do(a): " +contaRoberta.Titular+ ", a agência é: " +contaRoberta.Agencia+ ", o número é: " +contaRoberta.Numero+ " e o saldo é: " +contaRoberta.Saldo+ "."); 
           bool sacarcontaRoberta = contaRoberta.Sacar(500);
           Console.WriteLine("A conta é do(a): " +contaRoberta.Titular+ ", a agência é: " +contaRoberta.Agencia+ ", o número é: " +contaRoberta.Numero+ " e o saldo é: " +contaRoberta.Saldo+ "."); 
           bool depositarcontaRoberta = contaRoberta.Depositar(90);
           Console.WriteLine("A conta é do(a): " +contaRoberta.Titular+ ", a agência é: " +contaRoberta.Agencia+ ", o número é: " +contaRoberta.Numero+ " e o saldo é: " +contaRoberta.Saldo+ ".");   