using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entities
{
    public class Venda
    {
        public int ID { get; set; }
        public virtual Usuario Cliente { get; set; }
        public Int32 ClienteID { get; set; }
        public IList<ProdutoVenda> ProdutoVenda { get; set; }
    }
}
