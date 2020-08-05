namespace Ninjas.Models
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
        
        }

        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            this.age = age;
        }

        public Person(string fName,string lName)
        {
            FirstName = fName;
            LastName = lName;
            age = 0;
        }
        public Person()
        {
            this.FirstName = "Michael";
            this.LastName = "Choi";
            this.age = 46;
        }

        public Person Birthday()
        {
            age++;
            return this;
        }
    }
}