namespace Exercise3
{
    public class Commission
    {
        /*	
          Desenvolva um algoritmo de comissão de vendas, um vendedor de carro vendeu
          500 mil no mês de Maio, sabendo que a comissão dele é de 5% ao mês, qual
          será o valor que este vendedor receberá de comissão, calcule e imprima
        */
        public static decimal Run(decimal amount)
        {
            const double PERCENT = 0.05;

            return amount * (decimal)PERCENT;
        }
    }
}
