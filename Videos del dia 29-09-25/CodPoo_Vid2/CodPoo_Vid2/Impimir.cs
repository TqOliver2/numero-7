using CodPoo_Vid2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodPoo_Vid2
{
    internal class Impimir
    {
        public void ImprimirSHeroe(ISuperHero superHero)
        {
            Console.WriteLine($"Id:{superHero.id}");
            Console.WriteLine($"Name:{superHero.name}");
            Console.WriteLine($"SecretId:{superHero.secretId}");
        }
    }
}
