using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LizardPirates.Models
{
    public class Lizard
    {
        private List<Pet> myPets;

        //SQL
        [Key] //Primary key for your table
        public int LizardId { get; set; } //classnameID

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lizzard type os required")]
        public string LizardType { get; set; }

        [Required(ErrorMessage = "Pirate role is required")]
        public string PirateRole { get; set; }

        [Required(ErrorMessage = "Treasure chests is required")]
        [Range(1, 10, ErrorMessage = "You can have only 1-10")]
        public string TreasureChests { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //navigational prop - one pirate can have many pets
        //NOT stored in Database
        public List<Pet> MyPets { get => myPets; set => myPets = value; }
    }
}