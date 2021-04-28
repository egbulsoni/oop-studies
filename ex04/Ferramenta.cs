namespace ex04
{
    public class Ferramenta : IProduto
    {
        private string Nome { get; set; }
        private float Preço { get; set; }
        public string Utilidade { get; set; }
        
        public Ferramenta(string nome, float preço, string utilidade)
        {
            Nome = nome;
            Preço = preço;
            Utilidade = utilidade;
        }
        public void Mostrar()
        {
            return $"A sua ferramenta é um(a) majestoso(a) {Nome}.";
        }
        
        
        
    }
}