namespace GraduationTracker
{
    public class Requirement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinimumMark { get; set; }
        public int Credits { get; set; }
        public int[] Courses { get; set; } 

        //Defining a constructor for Requirements
        //Minimum mark is always 50 and Credits is always 1 so setting the default values to these to 50 and 1.
        public Requirement(int Id, string Name, int[] Courses, int MinimumMark = 50, int Credits = 1)
        {
            this.Id = Id;
            this.Name = Name;
            this.MinimumMark = MinimumMark;
            this.Credits = Credits;
            this.Courses = Courses;
        }


    }




}
