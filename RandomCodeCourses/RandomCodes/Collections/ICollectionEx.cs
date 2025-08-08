using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Collections
{
    internal class ICollectionEx : ICollection<int>
    {
        private List<int> _itens = new List<int>();

        public int Count => _itens.Count;

        public bool IsReadOnly => false;

        public void Add(int item)
        {
            _itens.Add(item);
        }

        public void Clear()
        {
            _itens.Clear();
        }

        public bool Contains(int item)
        {
            return _itens.Contains(item);
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            _itens.CopyTo(array, arrayIndex);
        }

        public bool Remove(int item)
        {
            return _itens.Remove(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _itens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
