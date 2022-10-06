using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator.Models
{
    public class House  : IMyCloneable<House>, ICloneable
    {
        public string Name { get; set; }  
        public int Square { get; set; }

        public House(string name, int square)
        {
            Square = square; 
            Name = name; 
        }
        public virtual House Copy()
        {
            return new House(Name, Square);
        }

        public virtual object Clone()
        {
            return Copy();
        }

    }
}
