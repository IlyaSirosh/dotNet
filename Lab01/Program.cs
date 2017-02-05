using System;
using DataBases;
using Students;
using Disciplines;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {




            DataBase db = new DataBase();
            Student s1 = new Student("John");
            Student s2 = new Student("Sam");
            Student s3 = new Student("Jo");

            Discipline Physics = new Discipline("Physics");
            Discipline Math = new Discipline("Math");
            Discipline Chemistry = new Discipline("Chemistry");

            s1.addGrade(Math, 81);
            s1.addGrade(Chemistry,65);
            s1.addGrade(Physics,86);
            s2.addGrade(Math, 71);
            s2.addGrade(Chemistry,76);
            s2.addGrade(Physics,80);
            s3.addGrade(Math, 91);
            s3.addGrade(Chemistry,95);
            s3.addGrade(Physics,83);

            db.add(s1);
            db.add(s2);
            db.add(s3);



            Console.WriteLine(db.ratingToString());
        }
    }
}
