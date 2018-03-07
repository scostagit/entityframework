using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entities
{
    public class ProdutoVenda
    {      
        public int VendaID { get; set; }
        public virtual Venda Venda { get; set; }
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
