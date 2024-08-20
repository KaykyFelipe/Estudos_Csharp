using System;

namespace Ex002{

class Program{

static void Main(string[] args){

int num1, num2;

num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

Console.WriteLine((num1 + num2) / 2 >= 7 ? "APROVADO" : "REPROVADO");

}
}
}