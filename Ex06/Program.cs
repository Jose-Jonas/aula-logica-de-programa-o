// Solicitar dois numeros ao usuário e realizar texte lógico (

Console.Write("N1");
double n1 = double.Parse(Console.ReadLine());


Console.Write("N2");
double n2  = double.Parse(Console.ReadLine());

Console.WriteLine($"N1 é maior que N2? Resposta {n1 > n2}");
Console.WriteLine($"N1 é maior ou igual que N2 Resposta; {n1 >= n2}");
Console.WriteLine($"N1 é menor ou N2? Resposta: {n1 < n2}");
Console.WriteLine($"N1 é menor ou igual que N2 Resposta: {n1 <= n2}");
Console.WriteLine($"N1 é igual que N2? Resposta: {n1 == n2}");
Console.WriteLine($"N1 é diferente que N2? Resposta: {n1 != n2}");
