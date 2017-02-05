
using Disciplines;
using System.Collections.Generic;


namespace Students{
    public class Student{


        private string name;
        private Dictionary<Discipline,int> grades;

        public Student(string name){
            this.name = name;
            this.grades = new Dictionary<Discipline,int>();
        }

        public string getName(){
            return name;
        }

        public Dictionary<Discipline,int> getGrades(){
            return grades;
        }

        public void addGrade(Discipline d, int grade){
            grades.Add(d,grade);
        }

        public double getAverageGrade(){
            double res=0.0;

            foreach(var d in grades){
                res+=(int)d.Value;
            }

            res/=grades.Count;

            return res;    
        }

        override
        public string ToString(){
            string res="";

            res+=name+"\n";

            foreach(var d in grades){
                res+= d.Key.ToString() + ": "+ d.Value + "\n"; 
            }

            res+="Avg: "+ getAverageGrade()+"\n";


            return res;
        }

    }
}