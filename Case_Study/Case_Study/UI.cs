using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class UserInterface : IUserInterface
    {
        private AppEngine appEngine;
        public UserInterface(AppEngine appEngine)
        {
            this.appEngine = appEngine;
        }
 
        public void ShowFirstScreen()
        {
            Console.WriteLine("select from below: \n1. Student\n2. Admin\n3. Exit");
            Console.Write("Enter your choice");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("Exit ");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    ShowFirstScreen();
                    break;
            }
        }

     
        public void ShowStudentScreen()
        {
            Console.WriteLine("1. View All Courses");
            Console.WriteLine("2. Register for Course");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllCoursesScreen();
                    break;
                case 2:
                    ShowStudentRegistrationScreen();
                    break;
                case 3:
                    Console.WriteLine("Exit Student Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    ShowStudentScreen();
                    break;
            }
        }
       
        public void ShowAdminScreen()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Introduce New Course");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Enrollment Details");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    IntroduceNewCourseScreen();
                    break;
                case 2:
                    ShowAllStudentsScreen();
                    break;
                
                case 3:
                    ShowEnrollmentsScreen();
                    break;
                case 4:
                    Console.WriteLine("Exit Admin Menu.");
                    ShowFirstScreen();
                    break;

                default:
                    Console.WriteLine("Invalid choice. .");
                    ShowAdminScreen();
                    break;
            }
        }

       
        public void ShowAllStudentsScreen()
        {
            Console.WriteLine("List of Students:");
            foreach (Student student in appEngine.ListOfStudents())
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            }
           
            ShowAdminScreen();
        }

        public void ShowStudentRegistrationScreen()
        {
            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Student Date of Birth ");
            DateTime studentDob = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("Available Courses:");
            List<Course> courses = appEngine.ListOfCourses();
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
            }

            Console.Write("Choose the course  ");
            int courseChosen = Convert.ToInt32(Console.ReadLine());
            
            Course selectedCourse = courses[courseChosen - 1];
           
            appEngine.Register(new Student(studentId, studentName, studentDob));
            appEngine.Enroll(appEngine.ListOfStudents().Last(), selectedCourse);

            Console.WriteLine("Student enrolled successfully.");
          
            ShowStudentScreen();
            }

      
        public void IntroduceNewCourseScreen()
        {
            Console.Write("Enter Course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

         
            appEngine.Introduce(new Course(courseId, courseName));
            Console.WriteLine("Course introduced successfully.");
           
            ShowAdminScreen();
        }

        public void ShowAllCoursesScreen()
        {
            Console.WriteLine("List of Courses:");
            foreach (Course course in appEngine.ListOfCourses())
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
            }
            
            ShowStudentScreen();
        }

        public void ShowEnrollmentsScreen()
        {
            Console.WriteLine("List of Enrollments:");
            foreach (Enrollment enrollment in appEngine.ListOfEnrollments())
            {
                Console.WriteLine($"Student ID: {enrollment.Student.Id}, Student Name: {enrollment.Student.Name}, Course ID: {enrollment.Course.CourseId},Course Name: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");
            }
            
            ShowAdminScreen();
        }

    }
}
