using System;

public class Circulo : Forma2D
{
    public string Cor { get; set; }
    private float Raio { get; set; }

    // tomei a liberdade de adicionar o diametro
    // pq senão num tem como calcular o Pi
    private float Diametro { get; set; }
    
    public Circulo()
    {
        Raio = 10;
        Diametro = 10;
    }
    public Circulo(string cor, float raio, float diametro)
    {
        Cor = cor;
        Raio = raio;
        Diametro = diametro;
    }
    
    public override float calcularArea()
    {
        return (float) (Math.PI * Math.Pow(Raio, 2));
    }
    
    public override string toString()
    {
        return $"a área do círculo é {calcularArea()}";      
    }

    public float calcularPerimetro()
    {
        return (float) (2 * Math.PI * Raio);
    }
    
    
    
    
}