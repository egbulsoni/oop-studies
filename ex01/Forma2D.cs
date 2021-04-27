public abstract class Forma2D
{
    private string Cor { get; set; }
    public Forma2D()
    {
    }
    public Forma2D(string cor)
    {
    }
    public abstract string toString();
    public abstract float calcularArea();

}