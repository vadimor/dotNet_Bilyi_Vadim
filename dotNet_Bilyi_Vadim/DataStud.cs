using System;

namespace Lab1
{
    [Serializable]
    public class DataStud
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                if (string.IsNullOrEmpty(value) 
                    && value.Length < 2)
                {
                    return;
                }

                _name = value;
            }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == null)
                    return;

                if (value.Length < 2)
                { 
                        return;
                }
                _surname = value;
            }
        }

        private string _patronimic;
        public string Patronimic
        {
            get
            {
                return _patronimic;
            }
            set
            {
                if (value == null)
                    return;

                if (value.Length < 2)
                {
                    return;
                }
                _patronimic = value;
            }
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value == null)
                    return;

                if (value > DateTime.Now)
                {
                    return;
                }
                _birthday = value;
            }
        }

        private DateTime _reciptDate;
        public DateTime ReciptDate
        {
            get
            {
                return _reciptDate;
            }
            set
            {
               

                if (value.Year <= 2000)
                {
                    return;
                }
                _reciptDate = value;
            }
        }

        private string _group;
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value == null)
                    return;

                if (value.Length > 10)
                {
                    return;
                }
                _group = value;
            }
        }
        private int _speciality;
        public int Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
               

                if (_speciality > 300)
                {
                    return;
                }
                _speciality = value;
            }
        }

        private float _academicPreformance;
        public float AcademicPreformance
        {
            get
            {
                return _academicPreformance;
            }
            set
            {

                if (_academicPreformance > 100)
                {
                    return;
                }
                _academicPreformance = value;
            }
        }
        public DataStud()
        {
            Name = "Vadim";
            Surname = "Bilyi";
            Patronimic = "Ivanovich";
            Birthday = new DateTime(2001, 12, 2);
            ReciptDate = new DateTime(2019, 9, 1);
            Group = "119a";
            Speciality = 123;
            AcademicPreformance = 85.3f;
        }
        public DataStud(string name, string surName, string patronimic, DateTime birthday,
            DateTime reciptDate, string group, int speciality, float academicPerformance)
        {
            Name = name;
            Surname = surName;
            Patronimic = patronimic;
            Birthday = birthday;
            ReciptDate = reciptDate;
            Group = group;
            Speciality = speciality;
            AcademicPreformance = academicPerformance;
        }
        public DataStud(string name, string surName, string patronimic)
        {
            Name = name;
            Surname = surName;
            Patronimic = patronimic;
            Birthday = new DateTime(2001, 12, 2);
            ReciptDate = new DateTime(2019, 9, 1);
            Group = "119a";
            Speciality = 123;
            AcademicPreformance = 85.3f;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nPatronimic: {Patronimic}\nBirthday: {Birthday.ToShortDateString()}" +
                $"\nRecipt Day: {ReciptDate.ToShortDateString()}\nGroup: {Group}\nSpeciality: {Speciality}\nAcademic Performance: {AcademicPreformance}\n";
        }
    }
}
