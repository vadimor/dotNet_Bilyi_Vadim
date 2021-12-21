using System;

namespace Lab3
{
    public class MyCollection<T> : Lab2.MyCollection<T> where T : new()
    {
        public void Delete(int indexOfDeleting)
        {
            if (!(-1 < indexOfDeleting & indexOfDeleting < _virtualSize))
            {
                Console.WriteLine("Index not in range of array");
                return;
            }

            var newArray = new T[_realSize];
            for (var i = 0; i < indexOfDeleting; i++)
            {
                newArray[i] = _collecton[i];
            }

            for (var i = _realSize - 1; i > indexOfDeleting; i--)
            {
                newArray[i - 1] = _collecton[i];
            }

            _virtualSize--;
            _collecton = newArray;
        }
    }
}
