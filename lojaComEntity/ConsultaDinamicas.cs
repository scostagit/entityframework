using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lojaComEntity.Dao;
using lojaComEntity.Entities;

namespace lojaComEntity
{
    public class ConsultaDinamicas
    {
        static void Main(string[] args)
        {
            ProdutoDao dao = new ProdutoDao();

            var resultado = dao.BuscaPorNomePrecoNomeCategoria(null, 18, "informatica");

            foreach (var p in resultado)
            {
                Console.WriteLine(p.Nome);
            }
            Console.ReadLine();
        }
    }
}
