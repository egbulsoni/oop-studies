using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafica g = new Grafica();

            // Console.WriteLine("Digite 'c' para Circulo ou 'r' para Retângulo");
            // var forma = Console.ReadLine();

            Retangulo retangulo = new Retangulo();
            Circulo circulo = new Circulo();
            g.show(retangulo);
            g.show(circulo);
        }
    }
}
