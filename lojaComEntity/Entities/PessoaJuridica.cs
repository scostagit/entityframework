using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entities
{
    /*
     * COLUNA DISCRIMINATOR
     * Quando utilizamos herança na tabela da classe mãe, é criado um novo atributo chamado Discriminator,
     * que possui exatamente o nome de cada classe. Com isto, o Entity Framework utilizará o reflection para 
     * devolver a instância correta para cada registro.
     */
    public class PessoaJuridica : Usuario
    {
        public string CNPJ { get; set; }
    }
}
