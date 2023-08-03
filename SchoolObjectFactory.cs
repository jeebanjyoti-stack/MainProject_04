namespace PracticeProject_4
{
    public class SchoolObjectFactory
    {
        public static Student CreateStudent(string name, string className, string section)
        {
            return new Student { Name = name, Class = className, Section = section };
        }

        public static Teacher CreateTeacher(string name, string className, string section)
        {
            return new Teacher { Name = name, Class = className, Section = section };
        }

        public static Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher };
        }
    }

}