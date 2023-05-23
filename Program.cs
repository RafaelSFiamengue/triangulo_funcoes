//Biblioteca geral
using System;
//Biblioteca geral global
using System.Globalization;

namespace Courses
{
    //Cria a classe do programa
    public class Program
    {
        //Programa Principal
        public static void Main(string[] args)
        {
            //Faz a leitura e declaração das medidas de cada lado do triangulo X
            double[] medidasX = LerMedidasTriangulo("X");
            //Faz a leitura e declaração das medidas de cada lado do triangulo Y
            double[] medidasY = LerMedidasTriangulo("Y");

            //Calcula a area do triangulo X
            double areaX = CalcularAreaTriangulo(medidasX);
            //Calcula a area do triangulo Y
            double areaY = CalcularAreaTriangulo(medidasY);

            //Imprime para o usuário a área do triangulo X
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Imprime para o usuário a área do triangulo Y
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Condicional para a área de X ser maior que a área de Y
            if(areaX > areaY)
            {
                //Imprime para o usuário que a área de X é maior que a de Y
                Console.WriteLine("A maior área é a de X");
            }
            //Condicional restante
            else
            {
                //Imprime para o usuário que a área de Y é maior que a de X
                Console.WriteLine("A maior área é a de Y");
            }
        }
        //Cria a função que vai ler as medidas dos triangulos
        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            //
            double[] medidas = new double[3];

            //Pede para o usuário colocar 3 medidas para cada triangulo
            Console.WriteLine(" Entre com as medidas do triangulo " + nomeTriangulo + ":");
            //Condicional de repetição para o i ser menor que 3 e para parar quando o contador chegar no 3
            for (int i = 0; i < 3; i++)
            {
                //Fará a leitura dos arary até chegar no terceiro array
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //retorna para as medidas para o programa funcionar
            return medidas;
        }

        //Cria a função para calcular a área dos triangulos
        public static double CalcularAreaTriangulo(double[] medidas)
        {
            //O primeiro array será estabelecido o valor de a
            double a = medidas[0];
            //O segundo array será estabelecido o valor de b
            double b = medidas[1];
            //O terceiro array será estabelecido o valor de c
            double c = medidas[2];

            //Calculo da área do triângulo
            double p = (a + b + c) / 2.0;
            //Calculo da área do triângulo
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            //retorna para a area para o programa rodar
            return area;
        }

    }
}
