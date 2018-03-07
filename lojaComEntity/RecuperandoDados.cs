using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
   public class RecuperandoDados
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();
            
            var busca = from p in contexto.Produtos
                        where p.Preco > 18
                        select p;
            IList<Produto> resultado = busca.ToList();
            foreach (var produto in resultado)
            {
                Console.WriteLine(produto.Nome);
            }
            Console.ReadLine();
          
        }
    }
}
