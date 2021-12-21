using System.Collections;
using System.Collections.Generic;

namespace Lab7.Service
{
    public class CollectionService<T> : IEnumerable<T>
    {
        private readonly List<T> _collection;

        public CollectionService()
        {
            _collection = new List<T>();
        }

        public void Add(T item) => _collection.Add(item);

        public void Remove(T item) => _collection.Remove(item);

        public bool Find(T item) => _collection.Contains(item);

        public void Sort(IComparer<T> comparer)
        {
            _collection.Sort(comparer);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_collection).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_collection).GetEnumerator();
        }
    }
}
