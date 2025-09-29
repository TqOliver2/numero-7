using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodPoo_Vid2.Models
{
    class superPower
    {
        public string name = " ";
        public string descripcion = " ";
        public levelPower level;

        public superPower()
        {

            level = levelPower.levelOne;
        }
    }

}
