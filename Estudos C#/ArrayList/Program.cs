using System;
using System.Collections;

namespace ArrayLista
{

    class Program
    {
       
        static void Main(string[] args)
        {
        
           ArrayList lista = new ArrayList();

           lista.Add("Kayky");
           lista.Add(30);
            lista.Add(7.5);
            lista.Add(true);

        foreach (var l in lista)
        {
          Console.WriteLine(l);  
        }
        
        
        
        
        }
    }

}