//Class members
//methods, properties, field

namespace Ninjas.Models
{
    public class Person
    {
        //field
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
        //end of field

        // method
        public Person(string fName, string lName, int age)
        {
            //this.FirstName = fName;
            FirstName = fName;
            LastNameName = lName;
            this.age = age;
        }
        // end of method
        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            this.age = 0;
        }

    }
}