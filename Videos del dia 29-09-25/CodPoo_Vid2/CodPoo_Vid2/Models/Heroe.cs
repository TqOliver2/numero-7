using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodPoo_Vid2.Models
{
    //creacion de clase abstracta
    internal abstract class Heroe
    {
        public abstract string name { get; set; }
        public abstract string SaveWorld();
        public virtual string SalvarTierra()
        {
            return $"{name} Salvar la Tierra";
        }
    }
}
