namespace MyCoolSite.Models
{
    public class Sandwich
    {
        public string Name {get;set;} //get/set we gonna binding my model to my form, and we gonna use view model to do that
        public string ProteinOne {get;set;} //so the attributes in class are readable and writable
        public string ProteinTwo {get;set;}
        public string Bread {get;set;}
        public string Instructions {get;set;}
    }
}