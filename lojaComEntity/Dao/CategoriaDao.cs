using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Dao
{
    public class CategoriaDao
    {
        private EntidadesContext contexto;

        public CategoriaDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public Categoria BuscaPorId(Int32 id)
        {
            return this.contexto.Categorias.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}
