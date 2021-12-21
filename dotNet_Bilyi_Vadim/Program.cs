using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new DataStud());
            var array = new DataStud[5];
            array[0] = new DataStud();
            array[1] = new DataStud("Vika", "Vasiliv", "Dmitrovich");
            array[2] = new DataStud("Illa", "Vasiliv", "Dmitrovich");
            array[3] = new DataStud("Kiril", "Vasiliv", "Dmitrovich");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
