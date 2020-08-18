using System;
using System.ComponentModel.DataAnnotations;

//pirate can have many pets, but pet can only belong to one 
namespace LizardPirates.Models
{
    public class Pet
    {
        [Key]
        public int PetId {get; set;}
        
        [Required(ErrorMessage="Pet must have a name")]
        public string Name {get; set;}

        
        [Required(ErrorMessage="What type of pet is it")]
        public string Type {get; set;}


        [Required(ErrorMessage="What color is it")]
        public string Color {get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        //FOREIGN KEY
        public int LizardId {get; set;} 
        
        //navigational prop
        public Lizard Owner {get; set;}


    }
}