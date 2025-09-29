using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodPoo_Vid2.Models
{//herencia de la clase SuperHero 
    internal class AntiHero : SuperHero
    {
        public string IlegalActivity(string accion)
        {
            return $"El antiheroe {NameAndSecretID} ha realizado: {accion}";
        }
    }
}
