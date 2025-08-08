using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Collections
{
    public class IenumurableEx : IEnumerable<int>
    {
        private int[] _numeros = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _numeros.Length; i++)
            {
                yield return _numeros[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Chama a versão genérica
        }
    }

}
