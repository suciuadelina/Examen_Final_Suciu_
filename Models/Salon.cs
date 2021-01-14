using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final_Suciu_.Models
{
    public class Salon
    {
        public int ID { get; set; }
        public string Serviciu { get; set; }
        public decimal Pret { get; set; }
        public string Durata { get; set; }
        public string Hairstylist { get; set; }
    }
}