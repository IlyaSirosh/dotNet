

namespace Disciplines{
    public class Discipline{
        
        private string name;

        public Discipline(string name){
            this.name = name;
        }

        override
        public string ToString(){
            return name;
        }

    }
}