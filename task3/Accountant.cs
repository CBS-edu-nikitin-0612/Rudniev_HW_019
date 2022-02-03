using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    static class Accountant
    {
        public static bool AskForBonus(Positions worker, ushort hours)
        {
            if (hours > (ushort)worker)
                return true;
            return false;
        }
    }
}
