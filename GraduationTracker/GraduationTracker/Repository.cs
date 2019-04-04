using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Repository
    {

        //removed bulky for loop for the following Get statements.
        public static Student GetStudent(int id)
        {
            var students = GetStudents();
            return students.Single(x => x.Id == id);
        }

        public static Diploma GetDiploma(int id)
        {
            var diplomas = GetDiplomas();
            return diplomas.Single(x => x.Id == id);
        }

        public static Requirement GetRequirement(int id)
        {
            var requirements = GetRequirements();
            return requirements.Single(x=>x.Id == id);
        }


        //Simplified this by making constructor call to Diploma's constructor.
        public static Diploma[] GetDiplomas()
        {
            return new[]
            {
                new Diploma(1, 4, new int[]{100,102,103,104})
            };
        }

        //Added in a Get Courses Method that generates all 4 courses in a single call which will be used by Get Requirements and
        //Get Students so their course list remains consistent.

        public static Course[] GetCourses()
        {
            return new[]
                {
                    new Course(1, "Math"),
                    new Course(2, "Science"),
                    new Course(3, "Literature"),
                    new Course(4, "Physichal Education")
                };
        }

        //Changed to construction calls to Requirement class.  Min mark and credits are all 50 and 1 for all of these
        //so ommitted them as constructor arguments but any new requirements that use different min mark and credits can add those
        //in as arguments.

        public static Requirement[] GetRequirements()
        {
            Course[] CourseList = GetCourses();
            List<Requirement> Requirements = new List<Requirement>();

            for (int i = 0; i < CourseList.Length; i++)
            {
                //assumes that courselist is a list of course Id's relevant to this requirement.
                Requirements.Add(new Requirement(100 + i + 1, CourseList[i].Name, new int[] { CourseList[i].Id }));
            }

            return Requirements.ToArray();
        }

        public static Student[] GetStudents()
        {

            //Simllified by calling student constructor and passing list of courses using Get Courses method
            Student[] StudentList =  new[]
            {
               new Student(1, GetCourses()),
               new Student(2, GetCourses()),
               new Student(3, GetCourses()),
               new Student(4, GetCourses())
            };

            int[][] StudentMarks = new int[][]
            {
                new int[] { 95, 95, 95, 95 },
                new int[] { 80, 80, 80, 80 },
                new int[] { 50, 50, 50, 50 },
                new int[] { 40, 40, 40, 40 }
            };


            for (int i = 0; i < StudentList.Length; i++)
            {
                StudentList[i].Courses = SetMarks(StudentList[i].Courses, StudentMarks[i]);
            }

            return StudentList;
        }


        private static Course[] SetMarks(Course[] Courses, int[] Marks)
        {
            if (Marks.Length == Courses.Length)
            {
                for (int i = 0; i < Courses.Length; i++)
                {
                    Courses[i].Mark = Marks[i];
                }
            }

            return Courses;
        }


    }


}
