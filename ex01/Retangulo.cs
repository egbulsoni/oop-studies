using System;
public class Retangulo
{
    // não consegui implementar sem o get nas props
    private float Base { get; set; }
    private float Altura { get; set; }
    // a propriedade cor foi deliberadamente adicionado pelo estudante
    private string Cor { get; set; }
    
    

    public Retangulo()
    {
        
    }
    public Retangulo(string cor, float baseRetangulo, float alturaRetangulo)
    {
        Cor = cor;
        Base = baseRetangulo;
        Altura = alturaRetangulo;
    }

    public string toString()
    {
        return $"o retângulo possui - base: {this.Base} e altura: {this.Altura}";      
    }

    public float calcularArea()
    {
        return Base * Altura;
    }
    
    
}