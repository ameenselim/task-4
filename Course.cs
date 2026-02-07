

namespace student_management_system
{
    internal class Course
    {
        public int CourseId { get; init; }
        public string Title { get; set; }
        public Instructor Instructor { get; set; }

        public string PrintDetails()
        {
            return $"CourseId = {CourseId} , \nNameCourse = {Title} , \nInstructor = {Instructor.Name}";
        }
    }
}
