using System.Collections.Generic;
using System;

public class Loja
{
    public int NumPessoas { get; set; }
    public List<Pessoa> Pessoas { get; set; }
    public Loja()
    {
        Pessoas = new List<Pessoa>();   
    }
    public void CadastrarPessoa(Pessoa p)
    {
        Pessoas.Add(p);
        NumPessoas++;
    }
    
    public void Listar()
    {
        Pessoas.ForEach(p => Console.WriteLine(p.ToString()));
        Console.ReadKey();
    }



}