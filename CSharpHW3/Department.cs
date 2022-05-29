using System;
namespace DesignAndBuildClasses
{
	public class Department
	{
        public Instructor HeadInstructor { get; set; }
        public decimal Budget { get; set; }
        public Course[] ListOfCourses { get; set; }
    }
}

