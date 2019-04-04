using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Credits { get; }

        //Constructor for Course
        public Course(int Id, string Name, int Mark = 0, int Credits = 1)
        {
            this.Id = Id;
            this.Name = Name;
            this.Mark = Mark;
            this.Credits = Credits;
        }

    }




}
