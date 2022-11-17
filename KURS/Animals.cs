using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS
{
    internal class Animals
    {
        public string Type { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Development { get; set; }
        public bool Is_sick { get; set; }
        public Card card;
        Animals(string type, float weight, float height, string development)
        {
            card = new Card(type,weight,height,development);
        }
        
    }
}
