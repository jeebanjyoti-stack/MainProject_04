using System.Collections.Generic;
namespace PracticeProject_4
{
    public class TeacherWithSubjects
    {
        public Teacher Teacher { get; set; }
        public List<Subject> Subjects { get; set; }

        public TeacherWithSubjects()
        {
            Subjects = new List<Subject>();
        }
    }

}
