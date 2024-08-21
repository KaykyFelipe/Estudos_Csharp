using System;

namespace Ex006{

class Program{

static void Main(string[] args){

int num;

num = int.Parse(Console.ReadLine());

if(num > 0){

Console.WriteLine("POSITIVO");

}
else if(num == 0){

Console.WriteLine("NEUTRO");

}
else if(num < 0){

Console.WriteLine("NEGATIVO");

}
else {

Console.WriteLine("DIGITE APENAS NUMEROS!!");

}


}
}
}
