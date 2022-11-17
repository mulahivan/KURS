using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS
{
    class Card
    {
        public string Type { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Development { get; set; }
        public Card (string type, float weight, float height, string development)
        {
            Type = type;
            Weight = weight;
            Height = height;
            Development = development;
        }
    }
}
