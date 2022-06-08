
using System.Collections;

namespace Iterator
{
    public class MyCollectionEnumerator : IEnumerator<int>
    {
        private MyCollection _enumrable;
        private int _current = -1;

        public MyCollectionEnumerator(MyCollection enumerable)
        {
            _enumrable = enumerable;
        }

        public bool MoveNext()
        {
            if (_current <= 2)
                _current++;

            return _current <= 2;
        }

        public int Current
        {
            get 
            {
                switch (_current)
                {   
                    case 0:
                        return _enumrable.fieldA;
                    case 1:
                        return _enumrable.fieldB;
                    case 2:
                        return _enumrable.fieldC;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        object IEnumerator.Current
        {
            get { return _current; }
        }

        public void Reset()
        {
            _current = -1;
        }

        public void Dispose()
        {
            
        }
    }
}