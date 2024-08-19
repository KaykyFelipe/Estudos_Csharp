
class PessoaFisica: Padrao
{

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Sua taxa mensal é de: " + valor * 0.25);
    
    }

   
}