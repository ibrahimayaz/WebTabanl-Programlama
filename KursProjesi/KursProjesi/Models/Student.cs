namespace KursProjesi.Models
{
    public class Student
    {
        public Student()
        {
            EnrolDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Fullname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

        public string SelectedCourse { get; set; }

        public int Age { get; set; }

        public DateTime EnrolDate { get; set; }

    }
}
