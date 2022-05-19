namespace Exercise1
{

    public class AverageAge
    {
        /*
          Desenvolva um algoritmo que calcule a idade média dos alunos de uma classe
          da faculdade, sabendo que o aluno mais novo tem 20 anos e o mais velho tem
          50 anos, utilize a seguinte fórmula para calcular:
          MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2 
        */
        public static double Run(int youngest, int oldest)
        {
            return (youngest + oldest) / 2;
        }
    }

}