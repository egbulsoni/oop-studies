namespace ex03
{
    public class Camisa : Vestimenta
    {
        private string Tipo { get; set; }
        private int Numero { get; set; }
        
        public string ToString()
        {
            return $"A calça de tipo {Tipo} possui numero(tamanho) {Numero}";
        }
        
        
        
        
    }
}