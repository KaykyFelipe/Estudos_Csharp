using System;
using System.Diagnostics.Contracts;

namespace Ex007{

class Program{

static void Main(string[] args){

int medida1,medida2,medida3;

medida1 = int.Parse(Console.ReadLine());
medida2 = int.Parse(Console.ReadLine());
medida3 = int.Parse(Console.ReadLine());


//PRINTS

if (medida1 == medida3 && medida3 == medida2){

Console.WriteLine("Equilatero");

}else if(medida1 == medida2 || medida1 == medida3 || medida2 == medida3){

Console.WriteLine("Isoceles");

}else
{
  Console.WriteLine("Escaleno");  
}

}






}
}
