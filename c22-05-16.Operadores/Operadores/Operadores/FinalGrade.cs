namespace Exercise7
{
    public class FinalGrade
    {
        /*
          Desenvolver um algoritmo que leia quatro notas de um aluno,
          calcular a média e imprimir.
          [OPCIONAL]: A pontuação deste exercício será maior para
          quem imprimir se o aluno for APROVADO ou REPROVADO;
          [CRITÉRIO APROVAÇÃO]: Média > 7
        */
        public static double Run(double[] grandes, out string status)
        {
            double mean = grandes.Sum() / grandes.Length;

            status = mean > 7 ? "APROVADO" : "REPROVADO";
            
            return mean;
        }
    }
}
