﻿// Ex08: Crie um programa que solicite ao usuário um número e imprima todos os números de 1 até o número informado usando um laço while

Console.WriteLine(" Digite um número");

int numero = int.Parse(Console.ReadLine());
int contador = 10;

while (contador >= numero) 
{
    Console.WriteLine(contador);
    contador-= 5;
}
