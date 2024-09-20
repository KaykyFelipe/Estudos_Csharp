using System;
using System.Diagnostics.Contracts;

namespace Name
{

   class Program
   {
    

public static void Main(string[] args)
{

 decimal gramasBalanca = 2;   
 decimal valor_pao = 12.00m;

 decimal valor = (gramasBalanca * valor_pao) / 1000;

 Console.WriteLine(valor);  

 
 

}


   } 



}
