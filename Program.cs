namespace student_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            int choice;
            do
            {
                Console.WriteLine(
                    "\t\t\t\t1. Add Student (hint: start with empty list of courses) " +
                    "\n\t\t\t\t2. Add Instructor" +
                    "\n\t\t\t\t3. Add Course (hint: select the instructor by id) " +
                    "\n\t\t\t\t4. Enroll Student in Course " +
                    "\n\t\t\t\t5. Show All Students " +
                    "\n\t\t\t\t6. Show All Courses " +
                    "\n\t\t\t\t7. Show All Instructors" +
                    "\n\t\t\t\t8. Find the student by id " +
                    "\n\t\t\t\t9. Fine the course by id " +
                    "\n\t\t\t\t10. Exit ");
                Console.Write("\nenter the number : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("enter ID : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter Age : ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter Name : ");
                            string name = Console.ReadLine();
                            studentManager.AddStudent(new Student { StudentId = id, Name = name, Age = age });
                            Console.WriteLine("added successfully");
                        }
                        break;

                    case 2:
                        {
                            Console.Write("enter Specialization : ");
                            string Specialization = Console.ReadLine();
                            Console.Write("enter Name : ");
                            string name = Console.ReadLine();
                            Console.Write("enter ID : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            studentManager.AddInstructor(new Instructor { InstructorId = id, Name = name, Specialization = Specialization });
                            Console.WriteLine("added successfully");
                        }
                        break;

                    case 3:
                        {
                            if (studentManager.Instructors.Count == 0)
                            {
                                Console.WriteLine("please enter instructor first.");
                                break;
                            }
                            Console.Write("enter id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter Title : ");
                            string name = Console.ReadLine();
                            Console.Write("enter instructorId : ");
                            int instructorId = Convert.ToInt32(Console.ReadLine());
                            Instructor ins = studentManager.FindInstructor(instructorId);
                            if (ins != null)
                            {
                                studentManager.AddCourse(new Course { CourseId = id, Title = name, Instructor = ins });
                                Console.WriteLine("added successfully");
                            }
                        }
                        break;

                    case 4:
                        {
                            if (studentManager.Students.Count == 0 || studentManager.Courses.Count == 0)
                            {
                                Console.WriteLine("there are no student or no courses");
                                break;
                            }
                            Console.Write("enter StudentId : ");
                            int studentId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter CourseId : ");
                            int courseId = Convert.ToInt32(Console.ReadLine());
                            studentManager.EnrollStudentInCourse(studentId, courseId);
                        }
                        break;

                    case 5:
                        {
                            for (int i = 0; i < studentManager.Students.Count; i++)
                            {
                                Console.WriteLine(studentManager.Students[i].PrintDetails());
                            }
                        }
                        break;

                    case 6:
                        {
                            if (studentManager.Courses.Count == 0)
                            {
                                Console.WriteLine("please , enter courses first !");
                                break;
                            }
                            for (int i = 0; i < studentManager.Courses.Count; i++)
                            {
                                Console.WriteLine(studentManager.Courses[i].PrintDetails());

                            }
                        }
                        break;

                    case 7:
                        {
                            if (studentManager.Instructors.Count == 0)
                            {
                                Console.WriteLine("please , enter instructor first !");
                                break;
                            }
                            for (int i = 0; i < studentManager.Instructors.Count; i++)
                            {
                                Console.WriteLine(studentManager.Instructors[i].PrintDetails());

                            }
                            break;
                        }


                    case 8:
                        {
                            if (studentManager.Students.Count == 0)
                            {
                                Console.WriteLine("There are no students , please enter Students first !");
                                break;
                            }
                            Console.Write("enter StudentId : ");
                            int studentId = Convert.ToInt32(Console.ReadLine());
                            Student student = studentManager.FindStudent(studentId);
                            if (student != null)//لو معملتهاش واليوزر دخل id غلط هيعمل expection 
                                Console.WriteLine(student.PrintDetails());
                        }
                        break;

                    case 9:
                        {
                            if (studentManager.Courses.Count == 0)
                            {
                                Console.WriteLine("There are no Courses , please enter Courses first !");
                                break;
                            }
                            Console.Write("enter CourseId : ");
                            int courseId = Convert.ToInt32(Console.ReadLine());
                            Course course = studentManager.FindCourse(courseId);
                            if (course != null) //Defensive Programming
                                Console.WriteLine(course.PrintDetails());
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("god byeeee....");

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("enter correct letter");
                        }
                        break;
                }
            } while (choice != 10);
        }
    }
}
