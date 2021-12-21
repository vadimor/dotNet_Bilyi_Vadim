using System;
using System.Collections;
using System.Text;

namespace Lab2
{
    public class MyCollection<T> : IEnumerable where T : new()
    {
        protected T[] _collecton;
        protected int _virtualSize;
        protected int _realSize;
        protected int _step;

        public int Size
        {
            get
            {
                return _virtualSize;
            }
        }

        public MyCollection()
        {
            _virtualSize = 0;
            _step = 10;
            _realSize = 10;
            _collecton = new T[10];

        }
        public T[] ToArray()
        {
            var temp = new T[_virtualSize];
            for (var i = 0; i < _virtualSize; i++)
            {
                temp[i] = _collecton[i];
            }
            return _collecton;
        }

        public void SetArray(T[] array)
        {
            _virtualSize = array.Length;
            _realSize = array.Length;
            _collecton = array;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _virtualSize)
                {
                    return _collecton[index];
                }
                Console.WriteLine($"\nElement with index: {index} don`t exist\n");
                return new T();
            }

            set
            {
                if (index >= 0 && index < _virtualSize)
                {
                    _collecton[index] = value;
                }
                Console.WriteLine($"\nElement with index: {index} don`t exist\n");
            }
        }

        public T Find(T obj)
        {
            foreach (T item in this)
            {
                if (obj.Equals(item))
                {
                    return item;
                }
            }
            Console.WriteLine("Object don`t found");
            return new T();
        }
        public void Add(T item)
        {
            if (_realSize == _virtualSize)
            {
                var tempCollecton = _collecton;
                _realSize += _step;
                _collecton = new T[_realSize];

                for (var i = 0; i < _virtualSize; i++)
                {
                    _collecton[i] = tempCollecton[i];
                }
            }

            _collecton[_virtualSize] = item;
            _virtualSize++;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in this)
            {
                stringBuilder.Append(item + "\n");
            }
            return stringBuilder.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return new MyCollectionEnumerator<T>(_collecton, _virtualSize);
        }

    }
}
