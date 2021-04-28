using System;


public class Program
{
    static void Main(string[] args)
    {
        // Dados fictícios, qualquer semelhança com a realidade é mera coincidência
        Inventário i = new Inventário();
        Ferramenta f = new Ferramenta("Chave de boca", 80, "apertar arroelas no formato hexagonal");
        Carro c = new Carro("Mercedez", 100000, 0);
        Caminhão ca = new Caminhão("Possanti", "GM", 200000, 10000);
        i.Adicionar(f);
        i.Adicionar(c);
        i.Adicionar(ca);
        i.Inventario();
        // pena que não manjo de impressão 3D


    }
}

