using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
   public  class GravandoUsuarioHeranca
    {
        static void Main(string[] args)
        {
            /*
             * DAO para cada Classe
             * 
             * Repare que como estamos usando herança podemos utilizar a classe UsuarioDAO para salvar qualquer
             * classe que seja filha de Usuario mas como que o entity framework vai salvar os dados específicos
             * como CNPJ e CPF se ele só está trabalhando com o tipo Usuario? Embora o polimorfismo permitir o 
             * entity framework não vai salvar os nossos dados corretamente, portanto o melhor é criar uma DAO
             * para cada entidade.
             */
            EntidadesContext contexto = new EntidadesContext();

            PessoaJuridica pf = new PessoaJuridica()
            {
                Nome = "IMPORT EXPRESS",
                CNPJ = "123456",
                Senha = "123"
            };

            contexto.PessoasJuridicas.Add(pf);
            contexto.SaveChanges();
        }
    }
}
