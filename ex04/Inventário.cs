using System.Collections.Generic;
using System;

namespace ex04
{
    public class Inventário
    {
        private static int MAX_PRODUTOS { get; set; }
        public List<Produto> Produtos { get; set; }
        public void Adicionar(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void Inventario()
        {
            Produtos.ForEach(p => Console.WriteLine($"você tem o produto {p}"));
        }
        // permite instanciar o produto desejado, como uma impressora 3D
        public void Imprimir()
        {
        }

    }
}
