using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v_chs = new ChangeString();
            var result_chs = v_chs.build("123 abcd*3");
            var v_or = new OrderRange();
            var result_or = v_or.build(new List<int>() { 58, 60, 55, 48, 57, 73 });
            var v_mp = new MoneyParts();
            var result_mp = v_mp.build(10.50M);

            Console.WriteLine("ChangeString resultado: "+ result_chs + "\n"+
                              "OrderRange resultado: "+ string.Join("|", result_or) + "\n"+
                              "MoneyParts resultado: "+ string.Join("|", result_mp));
            Console.ReadLine();
        }
    }
}
