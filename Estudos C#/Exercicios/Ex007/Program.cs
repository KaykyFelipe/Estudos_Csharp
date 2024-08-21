using System;

namespace Ex007{

class Program{

static void Main(string[] args){

int n1,n2,n3,menor,maior;

n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());

menor = n1;

if (menor > n2)
{
 menor = n2;
}
else if(menor > n3){

 menor = n3;   
}

maior = n1;

if (maior < n2)
{
 maior = n2;
}
else if(maior < n3){

 maior = n3;   
}

Console.WriteLine($"Numero MAIOR: {maior}");
Console.WriteLine($"Numero MENOR: {menor}");

}
}
}