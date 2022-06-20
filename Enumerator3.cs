using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhuLou
{
    class Enumerator3<T> : IEnumerable
    {
        private T[] list;
        public Enumerator3(T[] x)
        {
            list = x;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length;i++)
            {
                yield return list[i];
            }
        }
    }
}
