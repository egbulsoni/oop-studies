public class Empregado : Pessoa
{
    private float SalarioBase { get; set; }
    private float ImpostoDeRenda { get; set; }

    public Empregado(string nome, long cpf, float salarioBruto = 1200, float impostoDeRenda = 0)
    {
        SalarioBase = salarioBruto;
        ImpostoDeRenda = impostoDeRenda;
        Nome = nome;
        Cpf = cpf;
    }
    public float CalcularSalario()
    {
        return SalarioBase - ImpostoDeRenda;
    }

    public override string ToString()
    {
        var msg = base.ToString();
        return $"{msg}.\nSeu salário é: {SalarioBase}.\nSeu imposto de renda é: {ImpostoDeRenda} ";
    }
}