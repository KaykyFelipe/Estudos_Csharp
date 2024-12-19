using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using CursoEFCore.Data;
using Microsoft.IdentityModel.Tokens;

namespace CursoEFCore.Data.Configuration
{

    public class Infraestrutura
    {
      

        public static void InserirDados()
        {

            var cliente = new Cliente
            {

                
                Nome = "Joao Silva",
                Telefone = "38462386",
                CEP = "141100",
                Estado = "SP",
                Cidade = "Bonfim",



            };

            using var db = new Data.ApplicationContext(); //iniciando obj para ação
            db.Set<Cliente>().Add(cliente); //inseririndo informações

            var registrar = db.SaveChanges();//Salvando no banco de dados
            Console.WriteLine($"Registro{registrar}");

        }


        public static void InserirDadosEmMassa()
        {

            var produto = new Produto
            {

                Descricao = "Produto TesteSegundo",
                CodigoBarras = "6467848890",
                Valor = 10m,
                TipoProduto = Objetos.TipoProduto.MercadoriaParaRevenda,


            };

            var cliente = new Cliente
            {
                Nome = "Rafael Almeida",
                CEP = "99999960",
                Cidade = "Itabaiana",
                Estado = "SE",
                Telefone = "99000691111",

            };

            using var db = new Data.ApplicationContext();

            db.AddRange(produto,cliente); // inserindo dados em Massa (2 tabelas diferentes de uma vez)

            var registrar = db.SaveChanges();
        
        }


        public static void ConsultarDados()
        {
            using var db = new Data.ApplicationContext();
            
            var consultaPorMetodo = db.Clientes
            .Where(p=>p.Id >0)
            .OrderBy(p=>p.Id)
            .ToList(); //Consulta por metodo (Recomendada)

            foreach (var item in consultaPorMetodo)
            {
                Console.WriteLine(item.Id);
                 Console.WriteLine(item.Nome);
                 Console.WriteLine(item.CEP);
                
                

                
            }
        }

        public static void AtualizarDados()
        {
            using var db = new Data.ApplicationContext();
            
            var cliente = db.Clientes.Find(1);//consultando informaçoes do cliente ID 1
            cliente.Nome = "Kayky Felipe";//coluna Nome do ID 1 recebera Kayky Felipe
            
            db.SaveChanges(); //aplicando o Update

                        

        }

        
        public static void ConsultarDadosCarregamentoAdiantado()
        {
            using var db = new Data.ApplicationContext();
            var consultaPorSintaxe =(from c in db.Clientes where c.Id>0 select c).ToList();
            var consultaPorMetodo = db.Clientes
            .Where(p=>p.Id >0)
            .OrderBy(p=>p.Id)
            .ToList(); //Consulta por metodo (Recomendada)
            

        }


        public static void  RemoverDados()
        {
            using var db = new Data.ApplicationContext();
            
            var cliente = db.Clientes.Find(3);//consultando informaçoes do cliente ID 1
            db.Clientes.Remove(cliente);
            db.SaveChanges();


                        

        }
        
    }

}





