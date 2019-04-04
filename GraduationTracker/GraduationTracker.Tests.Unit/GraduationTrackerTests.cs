using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void TestHasCredits()
        {
            var tracker = new GraduationTracker();
            //Changed GetDiplomas and GetStudents methods in Repository to public so generating these test data only requires
            //that those methods be called from here.

            Diploma diploma = Repository.GetDiploma(1);
            var students = Repository.GetStudents();


            //tracker.HasGraduated()
       
            
            var graduated = new List<Tuple<bool, STANDING>>();

            foreach(var student in students)
            {
                graduated.Add(tracker.HasGraduated(diploma, student));      
            }

            
            Assert.IsFalse(graduated.Any());

        }


    }
}
