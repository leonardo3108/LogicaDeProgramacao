﻿string[] valores = Console.ReadLine().Split(' ');
int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);
int resultado = A / B;

if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("Sao multiplos");
}
else
{
    Console.WriteLine("Nao sao multiplos");
}