using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhuLou
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IEunmerable和IEnumerator实现迭代器
            Enumerator test = new Enumerator();
            foreach (int item in test)
            {
                Console.WriteLine(item);
            }
            foreach (int item in test)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            #endregion
            #region IEumerable和yield return实现迭代器
            Enumerator2 e2 = new Enumerator2();
            foreach (int item in e2)
            {
                Console.WriteLine(item);
            }
            foreach (int item in e2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            #endregion
            #region 实现IEnumerable和yield return的泛型迭代器
            Enumerator3<string> e3 = new Enumerator3<string>(new string[] { "三生三世", "毛驴战神", "毛驴踢击" });
            foreach (var item in e3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
