using lojaComEntity.Dao;
using lojaComEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static UsuarioDao dao = new UsuarioDao();
        static void Main(string[] args)
        {

            Alterar();
            Console.ReadKey();
        }

        static void Alterar()
        {

            /*
             * Estados das Entidades
             * Entity Framework gerencia o seguintes quatro estados: 
             * unchanged, 
             * Modified,
             * Added
             * e Deleted. 
             * Todas as entidades salvam este estados.
             */
            Console.WriteLine("Digite o Codigo do usuário:");

            var id = Int32.Parse(Console.ReadLine().ToString());
            // unchanged
            Usuario user = dao.BuscaPorId(id);

            Console.WriteLine("Novo Nome:");

            // Modified
            user.Nome = Console.ReadLine().ToString();

            // Added
            // dao.Salva(new Usuario());


            // Deleted
            //dao.remove(renan);

            dao.SaveChanges();


        }

        static void Remover()
        {
            Console.WriteLine("Digite o Codigo do usuário:");

            var id = Int32.Parse(Console.ReadLine().ToString());

            Usuario vitor = dao.BuscaPorId(id);

            dao.Remove(vitor);

            Console.WriteLine("Usuário Removido com sucesso");
        }

        static void Buscar()
        {
            Console.WriteLine("Digite o Codigo do usuário:");

            var id = Int32.Parse(Console.ReadLine().ToString());
            Usuario vitor = dao.BuscaPorId(id);

            Console.WriteLine("Resultado:");

            if (vitor != null)
                Console.WriteLine("Id:{0},nome:{1}, Senha:{2}", vitor.ID, vitor.Nome, vitor.Senha);
        }

        static void GravarUsuario()
        {
            Console.WriteLine("Nome:");

            Usuario user = new PessoaFisica()
            {
                Nome = Console.ReadLine().ToString(),
                Senha = "123"
            };

            dao.Salva(user);
            Console.WriteLine("salvou o usuario");
        }
    }
}
