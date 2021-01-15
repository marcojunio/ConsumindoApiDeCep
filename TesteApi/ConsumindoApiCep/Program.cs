using System;
using System.Threading.Tasks;
using Refit;

namespace ConsumindoApiCep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");
                
                Console.Write("Informe o Cep que deseja consultar: ");
                var cep = Console.ReadLine();
                
                Console.WriteLine("Consultando o cep informado, por favor aguarde...\n");

                var endereco = await cepClient.GetAddressAsync(cep);
                
                Console.WriteLine("Informações\n");
                
                Console.WriteLine($"Bairro: {endereco.Bairro}");
                Console.WriteLine($"Complemento: {endereco.Complemento}");
                Console.WriteLine($"Ibge: {endereco.Ibge}");
                Console.WriteLine($"Localidade: {endereco.Localidade}");
                Console.WriteLine($"Logradouro: {endereco.Logradouro}");
                Console.WriteLine($"UF: {endereco.Uf}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta do cep: {0}", e.Message);
            }
        }
    }
}
