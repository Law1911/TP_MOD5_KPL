using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD5_1302210106
{
    internal class HaloGeneric<T>
    {
        public void HaloUSer(T nama)
        {
            Console.WriteLine("Hallo User, " + nama);
        }
    }
}
