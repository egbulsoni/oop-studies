using System;

public class Circulo
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
    
    public float calcularArea()
    {
        return (float) (Math.PI * Math.Pow(Raio, 2));
    }
    
    
    
    
    
}