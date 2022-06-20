using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhuLou
{
    class Enumerator2:IEnumerable
    {
        private int[] list;

        public Enumerator2()
        {
            list = new int[]
            {
                1,2,3,4,5,6,7,8,9,222
            };
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }
    }
}
