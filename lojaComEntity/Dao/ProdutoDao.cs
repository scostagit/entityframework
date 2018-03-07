using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Dao
{
    public class ProdutoDao
    {
        private EntidadesContext contexto;

        public ProdutoDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public Produto BuscaPorId(Int32 id)
        {
            return this.contexto.Produtos.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }

        public IList<Produto> BuscaPorNomePrecoNomeCategoria(string nome, decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos
                        select p;

            if (!String.IsNullOrEmpty(nome))
                busca = busca.Where(p => p.Nome == nome);

            if (preco > 0.0m)
                busca = busca.Where(p => p.Preco >= preco);

            if (!String.IsNullOrEmpty(nomeCategoria))
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);

            /*
             * TO LIST()
             * Todas vez que criamos uma consulta usando LINQ ela só é executada quando chamamos o método ToList<>();
             * ou quando executamos um foreach na busca, isso nos permite editar a consulta diversas vezes antes de percorrer.
             */
            return busca.ToList();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}

