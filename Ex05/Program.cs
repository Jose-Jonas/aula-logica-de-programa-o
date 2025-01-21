// Calcular que recebe 2 numeros e apresenta + - * /

using System.ComponentModel.Design;

Console.Write("informe o 1° número");
double numl1 = double.Parse(Console.ReadLine());

Console.WriteLine("informe o 2°");
double numl2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("soma :" + (numl1 + numl2));
Console.WriteLine("subtração :" + (numl1 - numl2));
Console.WriteLine("multiplicação :" + (numl1 * numl2));

if (numl2 > 0) ;
{
    Console.WriteLine("divisão : " + (numl1 / numl2));

}
else
{
    Console.WriteLine("Jamais Dividirás por 0");
}

