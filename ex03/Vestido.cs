namespace ex03
{
    public class Vestido : Vestimenta
    {
        private bool Longo { get; set; }
        
        public string ToString()
        {
            return Longo ? "O vestido é longo" : "O vestido não é longo";
        }
        
        
    }
}