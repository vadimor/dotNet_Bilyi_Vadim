using System;
using System.Collections.Generic;
using Lab7.Model;

namespace Lab7.Provider
{
    public class StudentCreatorProvider
    {
        public List<Student> GetStudents()
        {
            var list = new List<Student>();
            list.Add(new Student
            {
                FirstName = "Vadim",
                SecondName = "Bilyi",
                Birthday = new DateTime(2001, 12, 2),
                ReciptDate = new DateTime(2019, 9, 1),
                Group = "119a",
                Faculty = "KIT",
                Speciality = 123,
                AcademicPreformance = 84.4f
            });
            list.Add(new Student
            {
                FirstName = "Dima",
                SecondName = "Yampolskiy",
                Birthday = new DateTime(2001, 12, 12),
                ReciptDate = new DateTime(2019, 9, 1),
                Group = "119a",
                Faculty = "KIT",
                Speciality = 123,
                AcademicPreformance = 91.2f
            });
            list.Add(new Student
            {
                FirstName = "Dima",
                SecondName = "Menshakov",
                Birthday = new DateTime(2000, 11, 18),
                ReciptDate = new DateTime(2019, 9, 1),
                Group = "119a",
                Faculty = "KIT",
                Speciality = 123,
                AcademicPreformance = 94.8f
            });
            list.Add(new Student
            {
                FirstName = "Roma",
                SecondName = "Momot",
                Birthday = new DateTime(2001, 6, 22),
                ReciptDate = new DateTime(2019, 9, 1),
                Group = "119a",
                Faculty = "KIT",
                Speciality = 123,
                AcademicPreformance = 93.1f
            });
            return list;
        }
    }
}