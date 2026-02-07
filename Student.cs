
namespace student_management_system
{
    internal class Student
    {
        public int StudentId { get; init; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } = new();

        public bool Enroll(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == course.CourseId)
                {
                    Console.WriteLine("this course is already exist.");
                    return false;
                }
            }
            Courses.Add(course);
            Console.WriteLine("successful add");
            return true;
        }

        public string PrintDetails()
        {
            string students = $"ID: {StudentId}, Name: {Name}, Age: {Age} , ";
            students += "Courses : ";

            if (Courses.Count == 0)
            {
                students += "No enrolled courses";
            }
            else
            {
                for (int i = 0; i < Courses.Count; i++)
                {
                    students += $"{Courses[i].Title} , ";
                }
            }
            return students;
        }
    }

}
