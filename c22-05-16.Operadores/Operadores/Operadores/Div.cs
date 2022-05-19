namespace Exercise9
{
    public class Div
    {
        /*
          Desenvolver um algoritmo que leia dois valores, A e B,
          utilizar operador aritmético de divisão e modularização, ou seja,
          imprimir apenas o resto da divisão;
          [OPCIONAL]: Tratar divisão por 0
         */
        public static dynamic Run(int a, int b)
        {
            return b != 0 ? a % b : "Não é possível dividir por 0";
        }
    }
}
