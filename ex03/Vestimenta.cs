namespace ex03
{
    public class Vestimenta
    {
        private string Cor { get; set; }
        private string Tecido { get; set; }
        public static int Cont { get; set; }

        public static int ObterNumeroDeVestimentas()
        {
            return Cont;
        }
        public string ToString()
        {
            return $"Em tuas vestes, vejo a cor {Cor}; no tecido, o material {Tecido}.";
        }
        
    }
}