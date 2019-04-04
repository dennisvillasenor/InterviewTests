using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Diploma
    {
        public int Id { get; set; }
        public int Credits { get; set; }
        public int[] Requirements { get; set; }

        //constructor to Diplomas
        public Diploma(int Id, int Credits, int[] Requirements)
        {
            this.Id = Id;
            this.Credits = Credits;
            this.Requirements = Requirements;
        }

    }



}
