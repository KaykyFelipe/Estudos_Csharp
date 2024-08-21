using System;

namespace Ex004{

class Program{

static void Main(string[] args){

int dia;

dia = int.Parse(Console.ReadLine());

if (dia == 4 || dia == 11 || dia == 18 || dia == 25) Console.WriteLine("DOMINGO");
if (dia == 5 || dia == 12 || dia == 19 || dia == 26) Console.WriteLine("SEGUNDA");
if (dia == 6 || dia == 13 || dia == 20 || dia == 27) Console.WriteLine("TERÇA");
if (dia == 7 || dia == 14 || dia == 21 || dia == 28) Console.WriteLine("QUARTA");
if (dia == 1 || dia == 8 || dia == 15 || dia == 22 || dia == 29) Console.WriteLine("QUINTA");
if (dia == 2 || dia == 9 || dia == 16 || dia == 23 || dia == 30) Console.WriteLine("SEXTA");
if (dia == 3 || dia == 10 || dia == 17 || dia == 24 || dia == 31) Console.WriteLine("SABADO");


}
}
}