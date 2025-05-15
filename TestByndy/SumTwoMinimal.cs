using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestByndy
{
   public class SumTwoMinimal
    {
        public int SumTwoMinimalMethod(IEnumerable<int>? array)
        {
            if (array == null || array.Count() < 2)
            {
                throw new ArgumentException("Массив должен содержать минимум 2 элемента");
            }

            var sortedArray = array.OrderBy(x => x).Take(2).ToArray();


            return sortedArray[0] + sortedArray[1];

        }
    }
}
