using System;
using Microsoft.VisualBasic;

abstract class Padrao
{

//Metodos obrigatorios - Os metodos devem ser publicos e protegidos

public abstract void taxaEmprestimo(double valor);

public static void info(int valor){

    Console.WriteLine("Taxa Calculada!!");
}



}