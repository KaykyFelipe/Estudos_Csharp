using System;

class Imposto
{

//metodos

public virtual void ValeAlimentacao(double salario)
{

Console.WriteLine("Desconto Padrao do vale alimentação R$" +(salario * 0.1));

}

public void ValeTransporte(double salario)
{

    Console.WriteLine("Desconto Padrao do vale transporte R$" +(salario * 0.6));

}

}