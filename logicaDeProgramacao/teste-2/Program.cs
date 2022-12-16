using System;
/*
2. Fazer um algoritmo que receba as medidas de 3 lados de um
triângulo e verifique se é um triângulo verdadeiro.
(Para que o triângulo seja verdadeiro, nenhum dos lados pode ser maior do que a
soma dos outros dois. Exemplo: um triângulo de lados 3, 4 e 9 não é um triângulo
de verdade, pois 9 > 3 + 4)
Se não for um triângulo verdadeiro, mostrar uma mensagem.
Se for um triângulo verdadeiro, informar se é:
- equilátero (3 lados iguais)
- isósceles (2 lados iguais)
- escaleno (todos os lados diferentes)
*/

Console.WriteLine("Informe o primeiro lado:");
double primeiroLado = double.Parse(Console.ReadLine());


Console.WriteLine("Informe o segundo lado:");
double segundoLado = double.Parse(Console.ReadLine());


Console.WriteLine("Informe o terceiro lado:");
double terceiroLado = double.Parse(Console.ReadLine());

if (primeiroLado + segundoLado > terceiroLado && primeiroLado + terceiroLado > segundoLado && segundoLado + terceiroLado > primeiroLado)
{
    if (primeiroLado == segundoLado && primeiroLado == terceiroLado)
    {
        Console.WriteLine("É um triângulo equilátero");
    }
    else if (primeiroLado == segundoLado || primeiroLado == segundoLado || segundoLado == terceiroLado)
    {
        Console.WriteLine("É um triângulo isósceles");
    }
    else
    {
        Console.WriteLine("É um triângulo escaleno");
    }
}
else
{
    Console.WriteLine("Não forma um triângulo");
}