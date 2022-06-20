using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhuLou
{
    class Enumerator : IEnumerable, IEnumerator
    {
        private int[] list;
        public Enumerator()
        {
            list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 111
            };
        }
        //首先我们要给出一个光标位置
        private int cursor = -1;
        #region 这是IEnumerable的接口方法
        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }
        #endregion
        #region 这是IEnumerator的接口方法
        public object Current
        {
            get
            {
                return list[cursor];
            }
        }
        /// <summary>
        /// 这个是循环优先级0的
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            ++cursor;
            return cursor < list.Length;
        }

        public void Reset()
        {
            cursor = -1;
        }
        #endregion
    }
}
