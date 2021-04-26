using System;
public class Retangulo : Forma2D
{
    // não consegui implementar sem o get nas props
    private float Base { get; set; }
    private float Altura { get; set; }
    // a propriedade cor foi deliberadamente adicionado pelo estudante
    private string Cor { get; set; }
    // tomei a liberdade de settar os atributos aqui
    public Retangulo()
    {
        Altura = 10;
        Base = 10;
        Cor = "dourado++";
    }
    public Retangulo(string cor, float baseRetangulo, float alturaRetangulo)
    {
        Cor = cor;
        Base = baseRetangulo;
        Altura = alturaRetangulo;
    }

    public override string toString()
    {
        return $"o retângulo possui - base: {this.Base} e altura: {this.Altura}";      
    }

    public override float calcularArea()
    {
        return Base * Altura;
    }
    
    
}