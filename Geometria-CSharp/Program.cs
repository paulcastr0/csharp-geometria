// See https://aka.ms/new-console-template for more information
using Geometria_CSharp;

Rettangolo rettangolo1 = new Rettangolo();

Console.Write("La base del rettangolo è: ");
rettangolo1.basee = Convert.ToInt32(Console.ReadLine());

Console.Write("L'altezza del rettangolo è: ");
rettangolo1.altezza = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Rettangolo 1:");
rettangolo1.infoRettangolo();

