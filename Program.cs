using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Projétil --");

            Console.WriteLine("Entre com a velocidade, em m/s:");
            double velo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o ângulo, em graus:");
            double ang = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double g = 9.80665;
            
            double angEmRad = ang * (pi/180);

            double senoAng = Math.Sin(angEmRad);

            double alcance = (Math.Pow(velo, 2) * Math.Sin(2 * angEmRad)) / g;
            double altura = Math.Pow(velo * senoAng, 2) / (2 * g);
            
            Console.WriteLine($"Alcance: {alcance:N2} m");
            Console.WriteLine($"Altura máxima: {altura:N2} m");

        }
    }
}
