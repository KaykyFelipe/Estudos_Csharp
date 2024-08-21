using System;

namespace Ex005{

class Program{

static void Main(string[] args){

int ano;

ano = int.Parse(Console.ReadLine());

Console.WriteLine((ano % 4 == 0 ? "ANO É BISSEXTO" : "ANO NÃO É BISSEXTO"));

}
}
}