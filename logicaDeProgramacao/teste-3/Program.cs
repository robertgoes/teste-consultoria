/*
Criar um algoritmo que resolva uma equação do segundo grau,
como a segudoublee:
ax² + bx + c = 0
A fórmula para o cálculo é:
Δ = b² - 4ac
x = -b ± Δ
2a
A função deve receber os valores de a, b e c, sendo a > 0.
A função deve retornar um dos segudoublees resultados:
- que a função não possui raízes reais (quando Δ < 0);
- que a função possui 1 raiz real (quando Δ = 0). Mostrar o valor da
raiz;
- que a função possui 2 raízes reais (quando Δ > 0). Mostrar o valor
das duas raízes.
OBS: potenciação nas linguagens:
VB6: operador ^.
VB.NET: método Math.Pow().
C#: método Math.Pow().
C/C++: função pow() da biblioteca math.h.
OBS: raiz quadrada nas linguagens:
VB6: função Sqr().
VB.NET: método Math.Sqrt().
C#: método Math.Sqrt().
C/C++: função sqrt() da biblioteca math.h. 
*/

Console.WriteLine("Informe o valor de a:");
double a = double.Parse(Console.ReadLine());


Console.WriteLine("Informe o valor de b:");
double b = double.Parse(Console.ReadLine());


Console.WriteLine("Informe o valor de c:");
double c = double.Parse(Console.ReadLine());

double delta = Math.Pow(b, 2) - (4 * (a * c));

Console.WriteLine($"Valor de Delta = {delta}");

if(delta < 0)
{
    Console.WriteLine("Não possui raízes reais");
}
else if (delta == 0)
{
    Console.WriteLine("Possui uma raiz real");
    
    double x = (-b + Math.Sqrt(delta)) / 2 * a;

    Console.WriteLine($"Valor da raiz: x = {x}");
}
else
{
    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

    Console.WriteLine($"x = {x1}");
    Console.WriteLine($"x = {x2}");
}