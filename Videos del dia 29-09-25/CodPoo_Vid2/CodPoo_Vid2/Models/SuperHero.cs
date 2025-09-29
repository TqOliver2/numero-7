using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodPoo_Vid2.Interface;

namespace CodPoo_Vid2.Models
{
    class SuperHero : Heroe, ISuperHero
    {

        private string _name;

        public int id { get; set; } = 1;
        //encapsulamiento de la propiedad name
        public override string name
          {
            get
            {
                return _name;
            }
            set
            {
                _name = value.Trim();
            }

        }

        //encapsulamiento de la propiedad NameAndSecretID uniendo el name y el secretId
        public string NameAndSecretID
        {
            get
            {
                return $"{name} - ({secretId})";
            }
        }

        public string secretId { get; set; }
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
                sb.AppendLine($"{NameAndSecretID} esta usando el poder de {item.name}");
            }
            return sb.ToString();
        }
        
        public override string SaveWorld()
        {
            return $"{NameAndSecretID} ha salvando el mundo";
        }
        public override string SalvarTierra()
        {
            return $"{NameAndSecretID} ha salvando la Tierra";
        }
    }

}
