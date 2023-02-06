using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class OrderRange
    {
        public List<string> build(List<int> list)
        {
            var listGrouped = new List<List<int>>();

            var listOrder = list.OrderBy(x => x).ToList();
            var even = listOrder.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            var odd =  listOrder.Where(x => x % 2 == 1).OrderBy(x => x).ToList();

            if (listOrder[0] % 2 == 0)
            {
                listGrouped.Add(even);
                listGrouped.Add(odd);
            }
            else
            {
                listGrouped.Add(odd);
                listGrouped.Add(even);
            }

            var result = new List<string>();
            foreach (var item in listGrouped)
            {
                result.Add(string.Join(",", item));
            }

            return result;
        }
    }
}
