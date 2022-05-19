namespace Exercise6
{
    public class IBWMale
    {
        /*
          Desenvolver um algoritmo que leia a altura de um homem e
          calcule o seu peso ideal, utilize a seguinte fórmula:
          PESO IDEAL = (72.7 * H) –58, onde H = altura
        */
        public static double Run(double heigh)
        {
            return (72 * heigh) - 58;
        }
    }
}
