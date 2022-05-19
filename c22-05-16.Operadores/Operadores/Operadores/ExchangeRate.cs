using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercise2
{

    public class ExchangeRate
    {
        /*
          Desenvolva um algoritmo que leia a cotação do euro converta para o
          Real imprima o resultado
        */
        public static async Task<decimal?> Run(decimal value, decimal? euro_rate = null)
        {
            if (euro_rate == null)
            {
                try
                {
                    string api = "https://economia.awesomeapi.com.br/last/EUR-BRL";
                    string response = await (new HttpClient()).GetStringAsync(api);

                    euro_rate = Convert.ToDecimal(Regex.Matches(
                    response,
                    @"""ask"":""([0-9]*\.?[0-9]*)""")[0].Groups[1].Value,
                    new CultureInfo("en-US"));
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
            
            return value * euro_rate;
        }
    }

}