using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    public class inserirCategoriaEProduto
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            /*
             * INCLUDE
             * Precisamos utilizar o método include por que por padrão o entity framework na versão 7 não carrega os relacionamentos, 
             * a grande vantagem disso é que garantimos que o framework só vai carregar a categoria quando pedimos evitando carregar 
             * dados sem necessidade.
             */
            Produto p = contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.ID == 2);

            Console.WriteLine("Produto:{0}, Categoria:{1}",p.Nome, p.Categoria.Nome);


            var categoria = contexto.Categorias.FirstOrDefault(c => c.ID == 1);

            foreach (var produto in categoria.Produtos)
            {
                Console.WriteLine(produto.Nome);
            }


            Console.ReadLine();
        }

        static void Inserir()
        {
            EntidadesContext contexto = new EntidadesContext();
            //Categoria c = new Categoria()
            //{
            //    Nome = "Liv"
            //};

            //contexto.Categorias.Add(c);

            Produto p = new Produto()
            {
                Nome = "Mouse",
                Preco = 20,
                CategoriaID = 1
            };

            contexto.Produtos.Add(p);

            contexto.SaveChanges();
        }

    }
}
