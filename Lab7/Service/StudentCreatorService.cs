using System.Collections.Generic;
using Lab7.Model;
using Lab7.Provider;

namespace Lab7.Service
{
    public class StudentCreatorService
    {
        private readonly StudentCreatorProvider _studentCreatorProvider;

        public StudentCreatorService(StudentCreatorProvider studentCreatorProvider)
        {
            _studentCreatorProvider = studentCreatorProvider;
        }

        public List<Student> GetStudent()
        {
            var list = _studentCreatorProvider.GetStudents();
            Validation(list);
            return list;
        }

        private void Validation(List<Student> list)
        {
            foreach (var item in list)
            {
                if (string.IsNullOrEmpty(item.FirstName) && item.FirstName.Length < 2)
                {
                    item.FirstName = "N/D";
                }

                if (string.IsNullOrEmpty(item.SecondName) && item.SecondName.Length < 2)
                {
                    item.SecondName = "N/D";
                }

                if (item.Speciality > 300)
                {
                    item.Speciality = 0;
                }

                if (item.AcademicPreformance > 100)
                {
                    item.AcademicPreformance = 0;
                }
            }
        }
    }
}