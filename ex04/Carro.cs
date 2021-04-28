using System;
namespace ex04
{
    public class Carro : Veiculo
    {
        public int Lugares { get; set; }

        public Carro(string marca, float preço, int lugares)
        {
            Marca = marca;
            Preço = preço;
            Lugares = lugares;
        }
        
        public void Mostrar()
        {
            Console.WriteLine("Carro");
        }
        
    }
}