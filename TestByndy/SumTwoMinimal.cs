using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestByndy
{
   public class SumTwoMinimal
    {
        public int SumTwoMinimalMethod(IEnumerable<int> readConsole)
        {
            var sortedArray = readConsole.OrderBy(x => x).Take(2).ToArray();
            return sortedArray[0] + sortedArray[1];

        }
    }
}
