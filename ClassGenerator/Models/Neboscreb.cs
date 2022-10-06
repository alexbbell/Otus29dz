using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator.Models
{
    public class Neboscreb : Cottage, ICloneable
    {

        public int Floors;
        public Neboscreb(string name, int square, Boolean isparking, int floors ) : base(name, square, isparking)
        {
            Floors = floors;
        }

        public object Clone()
        {
            return Copy();
        }

        public House Copy()
        {
            return new Neboscreb(Name, Square, IsParking, Floors);
        }
    }
}
