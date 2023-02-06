using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    public class MoneyParts
    {
        /*public List<string> build(Decimal quantity)
        {
            var denominations = new Decimal[] { 0.05M, 0.1M, 0.2M, 0.5M, 1, 2, 5, 10, 20, 50, 100, 200 };
            var resultList = new List<List<Decimal>>();

            foreach (var item in denominations)
            {
                var posibilities = new List<Decimal>();
                if (quantity >= item)
                {
                    if (quantity % item == 0)
                    {
                        var times = quantity / item;
                        for (int i = 0; i < times; i++)
                        {
                            posibilities.Add(item);
                        }
                    }
                    resultList.Add(posibilities);
                }
            }
            var result = new List<string>();
            foreach (var item in resultList)
            {
                result.Add(string.Join(",", item));
            }

            return result;
        }*/


        public List<string> build(Decimal quantity)
        {
            var denominations = new Decimal[] { 0.05M, 0.1M, 0.2M, 0.5M, 1, 2, 5, 10, 20, 50, 100, 200 };
            var resultList = new List<List<string>>();

            foreach (var item in denominations)
            {
                var posibilities = new List<string>();
                if (quantity >= item)
                {

                    var times = quantity / item;
                    var intPart = (int)times;
                    var decPartFromTime = times % 1.0M;
                    for (int i = 0; i < intPart; i++)
                    {
                        if (item % 1.0M != 0)
                        {
                            posibilities.Add(item.ToString());
                        }
                        else
                        {
                            posibilities.Add(item.ToString("0.0"));
                        }
                    }
                    if (decPartFromTime != 0)
                    {
                        decimal tot = 0;
                        foreach (var dec in posibilities)
                        {
                            tot = tot + Decimal.Parse(dec);
                        }
                        var substract = quantity - tot;
                        posibilities.Add(substract.ToString("0.0"));
                    }
                    resultList.Add(posibilities);
                }
            }
            var result = new List<string>();
            foreach (var item in resultList)
            {
                result.Add(string.Join(",", item));
            }

            return result;
        }
    }
}
