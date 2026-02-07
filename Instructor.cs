

namespace student_management_system
{
    internal class Instructor
    {
        public int InstructorId { get; init; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public string PrintDetails()
        {
            return $"ID = {InstructorId} , \nName = {Name} , \nSpecialization = {Specialization}";
        }
    }
}


