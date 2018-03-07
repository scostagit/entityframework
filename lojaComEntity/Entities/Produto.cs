using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entities
{
    public class Produto
    {
        /*
         * Relacionameto com o Enttiy Framework
         * 
         * Para o entity framework conhecer esse relacionamento precisamos apenas fazer a composição que faríamos no mundo 
         * orientado a objetos a classe Produto deve ter um atributo do tipo Categoria e a classe Categoria deve ter uma 
         * lista de produtos, a principal diferença é que o entity exige além da composição um atributo que representa a 
         * chave estrangeira desse relacionamento que deve seguir a convenção NomeDaClasseID portanto as nossas classes
         * Produto e Categoria fica da seguinte forma:
         */


        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        /*
         * NAVATIONS PROPERTIES
         * Navigation properties são todas as propriedades de uma entidade que representa um relacionamento no caso da entidade
         * produto a propriedade Categoria é uma navigation property para o relacionamento entre a entidade Produto e a entidade
         * Categoria é importante lembrar que toda navigation property precisa ser marcada como virtual.
         */
        public virtual Categoria Categoria { get; set; }
        public int CategoriaID { get; set; }

        public virtual IList<ProdutoVenda> ProdutoVenda { get; set; }
    }
}
