using System;

namespace Ex007{

class Program{

static void Main(string[] args){

int hora,op;

Console.WriteLine("Digite a horario de Brasilia Desejado: ");
hora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Para qual estado deseja converter horario?\n1)Tokio\n2)Lisboa\n3)Paris\n");
op = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case 1: hora += 12; break;
    case 2: hora += 4; break;
    case 3: hora += 5; break;
    default: Console.WriteLine("INVALIDO"); break;
}

if(hora >24){hora = hora - 24; Console.WriteLine($"A hora é: {hora}");}
else Console.WriteLine($"A hora é: {hora}");


}
}
}