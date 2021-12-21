using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DataStudLab4();
            a.Faculty = "kit";
            Console.WriteLine(new DateTime());
            Console.WriteLine(new DateTime().Ticks);
            Console.WriteLine((a.Semester));
            Console.WriteLine((a.Course));
            Console.WriteLine((a.Old));
        }
    }
}
