using System.Collections;


namespace Lab2
{
    class MyCollectionEnumerator<T> : IEnumerator where T : new()
    {
        private T[] _collecton;
        private int _position;
        private int _size;

        public MyCollectionEnumerator(T[] Collection, int size) {
            _collecton = Collection;
            _position = -1;
            _size = size;
        }
        public object Current => _collecton[_position];

        public bool MoveNext()
        {
            _position++;
            return (_position < _size);
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
