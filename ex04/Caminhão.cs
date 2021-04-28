
public class Caminhão : Veiculo
{
    public int Capacidade { get; set; }
    public Caminhão(string nome, string marca, float preço, int capacidade)
    {
        Capacidade = capacidade;
        Nome = nome;
        Marca = marca;
        Preço = preço;
    }


}
