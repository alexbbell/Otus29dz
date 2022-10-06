using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{

    public interface IMyCloneable<out T>
    {
        public T Copy();
    }

}
