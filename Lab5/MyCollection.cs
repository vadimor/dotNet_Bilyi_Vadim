using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class MyCollection<T> : Lab3.MyCollection<T> where T : new()
    {   
        public delegate bool DelegateDelete(T item);
        public void Delete(DelegateDelete method)
        {
            for (var i = 0; i < this._virtualSize;)
            {
                if (method(this[i++]))
                {
                    this.Delete(--i);
                }
            }
        }
    }
}
