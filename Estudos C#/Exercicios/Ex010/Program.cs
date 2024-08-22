
using System;

namespace Ex010{

class Program{

static void Main(string[] args){

double valor;
int op;

Console.WriteLine("Digite um valor para Conversão:");
valor = double.Parse(Console.ReadLine());

Console.WriteLine("1)Real/USD\n2)USD/Real\n\nEscolha a conversão deseja:");
op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1: Console.WriteLine($"O valor em Dolar é: " + valor / 5.00 ); break;
    
    case 2: Console.WriteLine("O valor em Real é: " + valor * 5.20 ); break;

    default: Console.Write("erro"); break;
}


}
}
}