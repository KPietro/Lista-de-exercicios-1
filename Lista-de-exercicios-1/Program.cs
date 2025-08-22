// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo da area de uma circunferencia");
double r, a, pi;
pi = 3.14;
Console.WriteLine("digite o valor de raio");
r = Double.Parse(Console.ReadLine());
a = pi * (r*r);
Console.WriteLine("A area da sua circunferencia é igual a:"+a);