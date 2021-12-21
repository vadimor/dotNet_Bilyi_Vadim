using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class StudentModels
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime ReciptDate { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public int Speciality { get; set; }
        public float AcademicPreformance { get; set; }
    }
}