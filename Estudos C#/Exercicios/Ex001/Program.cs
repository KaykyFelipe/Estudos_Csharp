using System;
using System.Xml.XPath;


namespace Ex001
{

class Program
{

static void Main(string[] args){

int v1,v2;

v1 = int.Parse(Console.ReadLine());
v2 = int.Parse(Console.ReadLine());

if (v1 == v2){


Console.WriteLine($"Numero somados resultado: {v1+v2}" );

}

if(v1 != v2){

   Console.WriteLine($"Numero multiplicados resultado: {v1*v2}"); 
}

}


}

}
