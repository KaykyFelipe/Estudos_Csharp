using System;

namespace Ex007{

class Program{

static void Main(string[] args){

int num;

Console.WriteLine("DIGITE O NUMERO PARA EXIBIR A TABUADA");
num = int.Parse(Console.ReadLine());

for(int i = 0; i <= 10; i++)
{

Console.WriteLine($"{num}x{i}={num * i}");

}




}
}
}
