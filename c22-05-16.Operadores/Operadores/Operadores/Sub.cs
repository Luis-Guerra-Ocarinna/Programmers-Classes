namespace Exercise8
{
    public class Sub
    {
        /*
          Desenvolver um algoritmo que leia dois valores, A e B,
          utilizar operador aritmético de subtração e imprimir o total;
          [OPCIONAL]: Se o valor for negativo, imprimir
          TOTAL NEGATIVO senão TOTAL POSITIVO;
         */
        public static int Run(int a, int b, out string state)
        {
            int result = a - b;

            state = result < 0 ? "TOTAL NEGATIVO" : "TOTAL POSITIVO";
            
            return result;
        }
    }
}
