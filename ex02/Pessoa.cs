public class Pessoa
{
    public string Nome { get; set; }
    public long Cpf { get; set; }
    public Pessoa()
    {
    }
    public static Pessoa MockarPessoa()
    {
        return new Pessoa
        {
            Nome = "João das Couves",
            Cpf = 00000000000
        };
    }
    public Pessoa(string nome, long cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public override string ToString()
    {
        return $"Meu nome é: {Nome}, possuo o cpf de numero {Cpf.ToString()}";
    }

}