using Exercise1;
using Exercise2;
using Exercise3;
using Exercise4;
using Exercise5;
using Exercise6;
using Exercise7;
using Exercise8;
using Exercise9;

namespace Exercise10
{
    public class UserInteraction
    {
        /*
          Desenvolver um algoritmo todos os algoritmos acima de forma dinâmica
          nos valores das variáveis, ou seja, obtendo a informação digitada
          pelo teclado por um usuário e não declarando a variável com um valor fixo.
          * DICA: Pesquisar sobre Console.Readline() este método irá ajudá-los(as);
         */
        public static void Run()
        {
            Console.WriteLine("\tAverage Age: ");
            Console.WriteLine($"Result: {UIAverageAge()}");

            Console.WriteLine("\tExchange Rate: ");
            Console.WriteLine($"Result: {UIExchangeRate()}");

            Console.WriteLine("\tCommission: ");
            Console.WriteLine($"Result: {UICommission()}");

            Console.WriteLine("\tCelsius To Fahrenheit: ");
            Console.WriteLine($"Result: {UICelsiusToFahrenheit()}");

            Console.WriteLine("\tFahrenheit To Celsius: ");
            Console.WriteLine($"Result: {UIFahrenheitToCelsius()}");

            Console.WriteLine("\tIBW Male: ");
            Console.WriteLine($"Result: {UIIBWMale()}");

            Console.WriteLine("\tFinal Grade: ");
            Console.WriteLine($"Result: {string.Join(' ', UIFinalGrade())}");

            Console.WriteLine("\tSub: ");
            Console.WriteLine($"Result: {string.Join(' ', UISub())}");

            Console.WriteLine("\tDiv: ");
            Console.WriteLine($"Result: {UIDiv()}");
        }

        public static dynamic UIDiv()
        {
            Console.Write("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            return Div.Run(a, b);
        }

        public static object[] UISub()
        {
            Console.Write("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            return new object[] { Sub.Run(a, b, out string state), state };
        }

        public static object[] UIFinalGrade()
        {
            double[] grades = new double[4];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Digita a {i + 1}ª nota: ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            return new object[] { FinalGrade.Run(grades, out string status), status };
        }

        public static double UIIBWMale()
        {
            Console.Write("Digite a altura: ");
            double height = Convert.ToDouble(Console.ReadLine());

            return IBWMale.Run(height);
        }

        public static double UIFahrenheitToCelsius()
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            return FahrenheitToCelsius.Run(fahrenheit);
        }

        public static double UICelsiusToFahrenheit()
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            return CelsiusToFahrenheit.Run(celsius);
        }

        public static object UICommission()
        {
            Console.Write("Digite o total de vendas: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            return Commission.Run(amount);
        }

        public static decimal? UIExchangeRate()
        {
            Console.Write("Digite a quantide de euros: ");
            decimal value = Convert.ToDecimal(Console.ReadLine());

            Console.Write("[Digite o valor do euro]: ");
            string? tmp = Console.ReadLine();
            decimal? euro_rate = tmp != null && !tmp.Equals(String.Empty) ? Convert.ToDecimal(tmp) : null;

            var task = ExchangeRate.Run(value, euro_rate);
            task.Wait();

            return task.Result;
        }

        public static double UIAverageAge()
        {
            Console.Write("Digite a idade mais nova: ");
            int youngest = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade mais velha: ");
            int oldest = Convert.ToInt32(Console.ReadLine());

            return AverageAge.Run(youngest, oldest);
        }
    }
}
