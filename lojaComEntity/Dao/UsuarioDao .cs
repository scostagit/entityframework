using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Dao
{
    public class UsuarioDao 
    {
        /*
         * =====================================================================
         * -- PADRAO DAO
         * =====================================================================
         * A grande vantagem de utilizar um dao é que conseguimos separar um código de infraestrutura como salvar no 
         * banco de dados da nossa classe de modelo Usuario já que ela não deve depender do banco para cumprir a sua 
         * responsabilidade que é representar um Usuario.
         */
        private EntidadesContext contexto;

        public UsuarioDao ()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(Int32 id)
        {
           return this.contexto.Usuarios.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}

