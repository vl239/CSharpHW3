using System;
namespace DesignAndBuildClasses
{
    // base class
    public abstract class Person
	{
        // props
        public int Id { get; set; }
        public int Age { get; set; }

        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative number.");
                }
            }
        }

        public string[] Addresses { get; set; }
    }

    // derived class
    public class Instructor : Person
    {
        // props
        public Department InstructorDepartment { get; set; }
        public DateTime JoinDate { get; set; }

        private decimal bonus;
        public decimal Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                int years = YearsOfExp();
                bonus = years * (Salary/10);
            }
        }

        // methods
        public int YearsOfExp()
        {
            int YearsOfExp = DateTime.Today.Year - JoinDate.Year;
            return YearsOfExp;
        }
    } 

    // derived class
    public class Student : Person
    {
        // props
        public Course[] EnrolledCourses { get; set; }
        public string[] Grades { get; set; }

        // methods
        public double CalculateGPA()
        {
            double total = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                if (Grades[i] == "A")
                {
                    total += 4.0;
                }
                if (Grades[i] == "A-")
                {
                    total += 3.67;
                }
                if (Grades[i] == "B+")
                {
                    total += 3.33;
                }
                if (Grades[i] == "B")
                {
                    total += 3.0;
                }
                if (Grades[i] == "B-")
                {
                    total += 2.67;
                }
                if (Grades[i] == "C+")
                {
                    total += 2.33;
                }
                if (Grades[i] == "C")
                {
                    total += 2.0;
                }
                if (Grades[i] == "C-")
                {
                    total += 1.67;
                }
                if (Grades[i] == "D")
                {
                    total += 1.0;
                }
                if (Grades[i] == "F")
                {
                    total += 0;
                }
            }
            double gpa = total / Grades.Length;
            return gpa;
        }
    }
}

