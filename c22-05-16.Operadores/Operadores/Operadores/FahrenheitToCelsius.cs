namespace Exercise5
{
    public class FahrenheitToCelsius
    {
        /*
          Desenvolva um algoritmo para converter a temperatura em graus Fahrenheit
          para Celsius, a fórmula é C = (F -32) * 5 / 9
        */
        public static double Run(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
