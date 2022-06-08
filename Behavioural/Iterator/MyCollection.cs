using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MyCollection: IEnumerable<int>
    {
        internal int fieldA = 0;
        internal int fieldB = 0;
        internal int fieldC = 0;
        public MyCollection(int a, int b, int c)
        {
            fieldA = a;
            fieldB = b;
            fieldC = c;
        }

        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new MyCollectionEnumerator(this);
        }
    }
}
