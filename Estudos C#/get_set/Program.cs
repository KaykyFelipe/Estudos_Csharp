using System;

namespace GetSet
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
           GetSetTeste gs = new GetSetTeste();
           gs.Valor = 4;
           Console.WriteLine(gs.Valor);
        }
    }

}