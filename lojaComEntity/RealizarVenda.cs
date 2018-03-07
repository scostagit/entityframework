using lojaComEntity.Dao;
using lojaComEntity.Entities;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    public class RealizarVenda
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            //ThenInclude para subCategoria
            Venda venda = contexto.Vendas.Include(v => v.ProdutoVenda).ThenInclude(pv => pv.Produto).FirstOrDefault(v => v.ID == 2);        

            foreach (var pv in venda.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }

            Console.ReadLine();
        }

        static void GravarVenda()
        {
            EntidadesContext contexto = new EntidadesContext();
            UsuarioDao dao = new UsuarioDao();
            Usuario renan = dao.BuscaPorId(1004);


            Venda v = new Venda()
            {
                Cliente = renan
            };

            Produto p = contexto.Produtos.FirstOrDefault(prod => prod.ID == 1);
            Produto p2 = contexto.Produtos.FirstOrDefault(prod => prod.ID == 2);



            //Associação produto x vendas
            ProdutoVenda pv = new ProdutoVenda()
            {
                Venda = v,
                Produto = p
            };

            ProdutoVenda pv2 = new ProdutoVenda()
            {
                Venda = v,
                Produto = p2
            };


            //Colocamos venda no contexto com status Added.
            contexto.Vendas.Add(v);
            //Coloca venda 1
            contexto.ProdutoVenda.Add(pv);
            //Coloca a sengunda venda no contexto
            contexto.ProdutoVenda.Add(pv2);

            //Grava no banco.
            contexto.SaveChanges();


            Console.WriteLine("Venda realizada com sucesso!");
        }
    }
}
