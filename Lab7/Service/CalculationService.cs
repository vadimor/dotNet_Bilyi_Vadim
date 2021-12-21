using System;
using Lab7.Model;

namespace Lab7.Service
{
    public class CalculationService
    {
        public string IndexGroup(Student item) =>
            item.Faculty + "-" + item.Speciality + "-" + item.ReciptDate.Year + "-" + item.Group;

        public int Semester(Student item)
        {
            var y = DateTime.Now.Year - item.ReciptDate.Year;
            var m = DateTime.Now.Month;
            if (y == 0)
            {
                if (m < 8)
                {
                    return 0;
                }
            }

            if (y > 4)
            {
                return 8;
            }

            if (m > 8)
            {
                return (y * 2) + 1;
            }

            return y * 2;
        }

        public int Course(Student item) =>
            (Semester(item) / 2) + (Semester(item) % 2);

        public string Old(Student item)
        {
            var time = DateTime.Now.Ticks - item.Birthday.Ticks;
            var old = new DateTime(time - 315360000000000);
            return old.ToString();
        }
    }
}
