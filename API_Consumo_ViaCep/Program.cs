using Refit;
using System;
using System.Threading.Tasks;

namespace API_Consumo_ViaCep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For <ICepApiService> ("http://viacep.com.br");
                Console.WriteLine("Infome seu CEP: ");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando Informações do CEP: " + cepInformado);

                var address = await cepClient.GetAddressAsync(cepInformado);

                Console.WriteLine($"\nLogradouro: {address.Logradouro}\nBairro: {address.Bairro}\nCidade: {address.Localidade}");
                Console.ReadKey();
            }
            catch(Exception erro)
            {
                Console.WriteLine("Erro na consulta de cep: " + erro.Message);
            }
            
        }
    }
}
