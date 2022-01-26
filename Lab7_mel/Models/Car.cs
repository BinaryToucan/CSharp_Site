using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7_mel.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GeneratorID { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public Generator Generator { get; set; }
    }
}
