using System.Collections.Generic;
using System;
namespace ex03
{
    public class GuardaRoupa
    {
        public List<Vestimenta> Vestimentas { get; set; }
        public int Max { get; set; }        
        public GuardaRoupas(int max)
        {
            Max = max;
        }
        public void Guardar(Vestimenta v)
        {
            Vestimentas.Add(v);
        }
        public void Listar()
        {
            Vestimentas.ForEach(v => System.Console.WriteLine(v.ToString()));
        }

        
        
    }
}