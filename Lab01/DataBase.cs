using Students;
using System.Linq;
using System.Collections.Generic;

namespace DataBases{
    class DataBase{


        private List<Student> students;

        public DataBase(){
            this.students = new List<Student>();
        }

        public void add(Student student){
        students.Add(student);
        }

        public List<Student> getRating(){

            return students.OrderByDescending( i => i.getAverageGrade()).ToList();

        }


        public string ratingToString(){
            string res ="";
            int i = 1;
            foreach( var s in getRating()){
                res+=i+". "+ s.ToString();
                i++;
            }
            return res;
        }

    }
}