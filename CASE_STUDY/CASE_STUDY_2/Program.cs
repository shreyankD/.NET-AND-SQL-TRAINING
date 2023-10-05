using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASE_STUDY_1;

namespace CASE_STUDY_2
{
    //    public class Enroll
    //    {
    //        public Student Student { get; set; }
    //        public Course Course { get; set; }
    //        public DateTime EnrollmentDate { get; set; }
    //        public Enroll(Student student, Course course, DateTime enrollmentDate)
    //        {
    //            this.Student = student;
    //            this.Course = course;
    //            this.EnrollmentDate = enrollmentDate;
    //        }
    //    }
    //    public class Student
    //    {
    //        public string Name { get; set; }
    //        public int StudentId { get; set; }
    //    }

    //    public class Course
    //    {
    //        public string CourseName { get; set; }
    //        public int CourseId { get; set; }
    //    }

    //    public class AppEngine
    //    {
    //        private List<Student> students = new List<Student>();
    //        private List<Course> courses = new List<Course>();
    //        private List<Enroll> enrollments = new List<Enroll>();
    //        public void Introduce(Course course)
    //        {
    //            Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
    //        }

    //        public void Register(Student student)
    //        {
    //            students.Add(student);
    //        }

    //        public Student[] ListOfStudents()

    //        {
    //            return students.ToArray();
    //        }

    //        public Course[] ListOfCourses()
    //        {
    //            return courses.ToArray();
    //        }

    //        public void Enroll(Student student, Course course, DateTime enrollmentDate)
    //        {
    //            Enroll enrollment = new Enroll(student, course, enrollmentDate);
    //            enrollments.Add(enrollment);
    //        }

    //        public Enroll[] ListOfEnrollments()
    //        {
    //            return enrollments.ToArray();
    //        }
    //    }

    //    public class Info
    //    {
    //        public static void DisplayEnrollmentDetails(Enroll[] enrollments)
    //        {
    //            foreach (Enroll enrollment in enrollments)
    //            {
    //                Console.WriteLine($"Student: {enrollment.Student.Name}, Course: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");
    //            }
    //        }
    //    }

    //    public class App
    //    {
    //        public static void Main()
    //        {

    //            AppEngine engine = new AppEngine();



    //            Console.WriteLine("Welcome to the Enrollment System!");



    //            while (true)

    //            {

    //                Console.WriteLine("\nChoose an action:");

    //                Console.WriteLine("1. Register Student");

    //                Console.WriteLine("2. Introduce Course");

    //                Console.WriteLine("3. Enroll Student in Course");

    //                Console.WriteLine("4. Display List of Students");

    //                Console.WriteLine("5. Display List of Courses");

    //                Console.WriteLine("6. Display List of Enrollments");

    //                Console.WriteLine("0. Exit");



    //                string userInput = Console.ReadLine();



    //                switch (userInput)

    //                {

    //                    case "1":

    //                        Console.Write("Enter Student Name: ");

    //                        string studentName = Console.ReadLine();

    //                        Console.Write("Enter Student ID: ");

    //                        int studentId = int.Parse(Console.ReadLine());



    //                        Student student = new Student { Name = studentName, StudentId = studentId };

    //                        engine.Register(student);

    //                        Console.WriteLine($"Student {student.Name} has been registered.");

    //                        break;



    //                    case "2":

    //                        Console.Write("Enter Course Name: ");

    //                        string courseName = Console.ReadLine();

    //                        Console.Write("Enter Course ID: ");

    //                        int courseId = int.Parse(Console.ReadLine());



    //                        Course course = new Course { CourseName = courseName, CourseId = courseId };

    //                        engine.Introduce(course);

    //                        Console.WriteLine($"Course {course.CourseName} has been introduced.");

    //                        break;



    //                    case "3":

    //                        Console.Write("Enter Student ID: ");

    //                        int studentIdForEnroll = int.Parse(Console.ReadLine());

    //                        Console.Write("Enter Course ID: ");

    //                        int courseIdForEnroll = int.Parse(Console.ReadLine());



    //                        Student studentForEnroll = engine.ListOfStudents().FirstOrDefault(s => s.StudentId == studentIdForEnroll);

    //                        Course courseForEnroll = engine.ListOfCourses().FirstOrDefault(c => c.CourseId == courseIdForEnroll);



    //                        if (studentForEnroll != null && courseForEnroll != null)

    //                        {

    //                            DateTime enrollmentDate = DateTime.Now; // You can modify this as needed

    //                            engine.Enroll(studentForEnroll, courseForEnroll, enrollmentDate);

    //                            Console.WriteLine($"Student {studentForEnroll.Name} has been enrolled in {courseForEnroll.CourseName}.");

    //                        }

    //                        else

    //                        {

    //                            Console.WriteLine("Student or Course not found.");

    //                        }

    //                        break;



    //                    case "4":

    //                        Console.WriteLine("\nList of Students:");

    //                        Student[] students = engine.ListOfStudents();

    //                        foreach (Student sudent in students)

    //                        {

    //                            Console.WriteLine($"Name: {sudent.Name}, ID: {sudent.StudentId}");

    //                        }

    //                        break;



    //                    case "5":

    //                        Console.WriteLine("\nList of Courses:");

    //                        Course[] courses = engine.ListOfCourses();

    //                        foreach (Course cours in courses)

    //                        {

    //                            Console.WriteLine($"Name: {cours.CourseName}, ID: {cours.CourseId}");

    //                        }

    //                        break;



    //                    case "6":

    //                        Console.WriteLine("\nList of Enrollments:");

    //                        Enroll[] enrollments = engine.ListOfEnrollments();

    //                        Info.DisplayEnrollmentDetails(enrollments);

    //                        break;



    //                    case "0":

    //                        return; // Exit the program



    //                    default:

    //                        Console.WriteLine("Invalid input. Please try again.");

    //                        break;

    //                }

    //            }

    //        }

    //    }


    public class Course

    {

        public int CourseId { get; set; }

        public string CourseName { get; set; }



        public Course(int courseId, string courseName)

        {

            CourseId = courseId;

            CourseName = courseName;

        }

    }



    public class Enroll

    {

        public Student Student { get; set; }

        public Course Course { get; set; }

        public DateTime EnrollmentDate { get; set; }



        public Enroll(Student student, Course course, DateTime enrollmentDate)

        {

            Student = student;

            Course = course;

            EnrollmentDate = enrollmentDate;

        }

    }



    public class AppEngine

    {

        private Student[] students;

        private Course[] courses;

        private Enroll[] enrollments;



        public AppEngine()

        {

            students = new Student[0];

            courses = new Course[0];

            enrollments = new Enroll[0];

        }



        public void Introduce(Course course)

        {

            Array.Resize(ref courses, courses.Length + 1);

            courses[courses.Length - 1] = course;

        }



        public void Register(Student student)

        {

            Array.Resize(ref students, students.Length + 1);

            students[students.Length - 1] = student;

        }



        public Student[] ListOfStudents()

        {

            return students;

        }



        public Course[] ListOfCourses()

        {

            return courses;

        }



        public void Enroll(Student student, Course course)

        {

            DateTime enrollmentDate = DateTime.Now;

            Array.Resize(ref enrollments, enrollments.Length + 1);

            enrollments[enrollments.Length - 1] = new Enroll(student, course, enrollmentDate);

        }



        public Enroll[] ListOfEnrollments()

        {

            return enrollments;

        }

    }



    public class App

    {

        public static void Main(string[] args)

        {

            AppEngine engine = new AppEngine();



            // Register students using the Student class from Case Study 1

            Student student1 = new Student(1, "Alice", new DateTime(2000, 5, 15));

            Student student2 = new Student(2, "Bob", new DateTime(1999, 8, 23));

            engine.Register(student1);

            engine.Register(student2);



            // Introduce courses

            Course course1 = new Course(101, "Mathematics");

            Course course2 = new Course(102, "Science");

            engine.Introduce(course1);

            engine.Introduce(course2);



            // Enroll students in courses

            engine.Enroll(student1, course1);

            engine.Enroll(student1, course2);

            engine.Enroll(student2, course1);



            // Display enrollment details

            Info info = new Info();

            var enrollments = engine.ListOfEnrollments();

            foreach (var enrollment in enrollments)

            {

                info.Display(enrollment.Student);

            }

        }

    }







}

