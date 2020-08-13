// Required	Validates whether the field has a value.	NA
// Regular Expression	Validates whether the submitted value conforms to a regex string.	A regex string.
// MinLength()	Validates that a string or array field has the specified minimum length.	An integer.
// MaxLength()	Validates that a string or array field has the specified maximum length.	An integer.
// Range()	Checks whether the value is within the range specified.	Two integers or two doubles. Must be the same type as the field.
// EmailAddress	Validates that the field is in the form of a valid email address.	NA
// Compare()	Validates that two fields contain the same value. Only needs to be applied to one of the two fields	A string corresponding to the name of the other field. A second parameter consisting of ErrorMessage = and a string to be displayed as an error may also be included.
// DataType()	Ensures that the field conforms to a specific DataType	A DataType object
// namespace YourNamespace.Models
// { //EXAMPLE
//     public class User
//     {
//         [Required]
//         [MinLength(3)]
//         public string Username { get; set; }
 
//         [Required]
//         [EmailAddress]
//         public string Email { get; set; }
 
//         [Required]
//         [DataType(DataType.Password)]
//         public string Password { get; set; }
//     }
// }
using System.ComponentModel.DataAnnotations; //add this is you wanna use Required
using System;
namespace MyCoolSite.Models
{
    public class Sandwich
    {
        [Required(ErrorMessage="A Sandwich must have a name")]
        [Display (Name=" Sandwich name comming from /Models/Sanwich.cs ")]
        //[MaxLength(10)]
        public string Name {get;set;} //get/set we gonna binding my model to my form, and we gonna use view model to do that
        
        [Required(ErrorMessage="A Sandwich must have at least one source of protein")]
        public string ProteinOne {get;set;} //so the attributes in class are readable and writable
        
        public string ProteinTwo {get;set;}
        
        [Required(ErrorMessage="A Sandwich must have a bread")]
        public string Bread {get;set;}
        
        [MaxLength(50,ErrorMessage="Make it shorter pal")]
        public string Instructions {get;set;}

        [Required(ErrorMessage="Calories are required")]
        [Range(0, Int32.MaxValue, ErrorMessage="Calories must be positive intgers")]
        public int Calories {get;set;}

    }   
}