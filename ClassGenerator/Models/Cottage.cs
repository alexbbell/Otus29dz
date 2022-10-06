using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator.Models
{
    public class Cottage : House, ICloneable
    {
        public Boolean IsParking;

        public Cottage(string name, int square, Boolean isparking ) : base (name, square)
        {
            IsParking = isparking;
        }

        public override Cottage Copy()
        {
            return new Cottage(Name, Square, IsParking);
        }
        public override object Clone()
        {
            return Copy();
        }



    }
}
