using System;  

/*1. Fazer um algoritmo que receba um número inteiro positivo e
informe se é um número primo.*/

Console.WriteLine("Informe um número:");
int numero = int.Parse(Console.ReadLine());
int divisores = 0;

for (int i = 1; i <= numero; i++)
{
    if(numero % 1 == 0)
    {
        divisores++;
    }
}

if (divisores == 2)
{
    Console.WriteLine($"{numero} é primo!");
}
else
{
    Console.WriteLine($"{numero} não é primo!");
}