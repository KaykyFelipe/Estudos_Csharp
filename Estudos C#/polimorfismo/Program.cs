
namespace GetSet
{
    class Program
    {
       
        static void Main(string[] args)
        {
           Imposto estag = new Estagiario();
           estag.ValeAlimentacao(1000);
           estag.ValeTransporte(1000);
           Console.WriteLine("_________________");

           Imposto gerent = new Gerente();
           gerent.ValeAlimentacao(5000);
           gerent.ValeTransporte(5000);
           Console.WriteLine("_________________");

           Imposto atend = new Atendente();
           gerent.ValeAlimentacao(2000);
           gerent.ValeTransporte(2000);
           Console.WriteLine("_________________");
        }
    }

}