public class Cliente : Pessoa
{
    private float LimiteDeCredito;
    private float SaldoDevedor;
    
    
    public Cliente(string nome, long cpf, float limiteDeCredito = 120, float saldoDevedor = 0)
    {
        LimiteDeCredito = limiteDeCredito;
        SaldoDevedor = saldoDevedor;
        Nome = nome;
        Cpf = cpf;
    }
    public float CalcularCredito()
    {
        return LimiteDeCredito - SaldoDevedor;
    }

    public override string ToString()
    {
        var msg = base.ToString();

        return $"{msg}.\nSeu limite de crédito é: {LimiteDeCredito}.\nE seu saldo devedor é: {SaldoDevedor}";
    }
}