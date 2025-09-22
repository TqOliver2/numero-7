using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodPoo_Vid2.Models
{
    class SuperHero
    {
        public int id;
        public string name;
        public string secretId;
        public string ciudad;
        public List<superPower> superPower;
        public bool puedeVolar;

        public SuperHero()
        {
            id = 1;
            superPower = new List<superPower>();
            puedeVolar = false;
        }

        public string useSuperPower()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in superPower)
            {
                sb.AppendLine($"{name} esta usando el poder de {item.name}");
            }
            return sb.ToString();
        }
    }

}
