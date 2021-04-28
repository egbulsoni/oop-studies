using System;
namespace ex04
{
    public class Veiculo : IProduto
    {
        public string Marca { get; set; }
        public float Preço { get; set; }
        public string Nome { get; set; }



        public Veiculo(string nome, string marca, float preco)
        {
            Marca = marca;
            Nome = nome;
            Preco = preco;
        }
        public void Mostrar()
        {
            return $"Teu veículo é um {Nome} de marca {Marca}.\n";
        }



    }
}