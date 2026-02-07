
namespace student_management_system
{
    internal class StudentManager
    {
        public List<Student> Students { get; set; } = new();
        public List<Course> Courses { get; set; } = new();
        public List<Instructor> Instructors { get; set; } = new();

        public bool AddStudent(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentId == student.StudentId)
                {
                    Console.WriteLine("the student is already exist.");
                    return false;
                }
            }
            Students.Add(student);
            return true;
        }
        public bool AddCourse(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == course.CourseId)
                {
                    Console.WriteLine("course is already exist.");
                    return false;
                }
            }
            Courses.Add(course);
            return true;
        }
        public bool AddInstructor(Instructor instructor)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorId == instructor.InstructorId)
                {
                    Console.WriteLine("Instructor is already exist.");
                    return false;
                }
            }
            Instructors.Add(instructor);
            return true;
        }
        public Student FindStudent(int Id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentId == Id)
                    return Students[i];
            }
            Console.WriteLine("the student is not exist.");
            return null;
        }
        public Course FindCourse(int CourseId)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == CourseId)
                    return Courses[i];
            }
            Console.WriteLine("the course is not exist.");
            return null;
        }
        public Instructor FindInstructor(int instructorId)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorId == instructorId)
                    return Instructors[i];
            }
            Console.WriteLine("the instructor is not exist.");
            return null;
        }
        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);
            if (student == null || course == null)
            {
                Console.WriteLine("course or student is not found");
                return false;
            }
            return student.Enroll(course);
        }
    }
}
