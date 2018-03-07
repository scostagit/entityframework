using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entities
{
    public abstract class Usuario
    {
        public Int32 ID { get; set; }
        public String Nome { get; set; }
        public String Senha { get; set; }
    }
}
