using System;

namespace ex02new
{
    class Program
    {
        static void Main(string[] args)
        {
            Loja l = new Loja();
            Pessoa Rene = new Empregado("René", 11111111111,20000, 1000);
            Pessoa Luis = new Cliente("Luis", 22222222222,200000000, 5000);
            Pessoa Eduardo = new Cliente("Eduardo", 33333333333,10000, 700);
            Pessoa Matheus = new Empregado("Matheus", 44444444444,3000, 800);

            l.CadastrarPessoa(Rene);
            l.CadastrarPessoa(Luis);
            l.CadastrarPessoa(Eduardo);
            l.CadastrarPessoa(Matheus);
            l.Listar();

            // todos os trabalhadores e clientes
            // considerem-se encaixados.
        }
    }
}
