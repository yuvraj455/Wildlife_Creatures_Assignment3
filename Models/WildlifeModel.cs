using System.ComponentModel.DataAnnotations;

namespace WildlifeCreatures_Assignment3.Models
{
    // Class representing a wildlife creature
    public class WildlifeModel
    {
        // Primary key for the database
        [Key]
        public int Id { get; set; }

        // Name of the wildlife creature
        public string Name { get; set; }

        // Weight of the wildlife creature (in kilograms)
        public double Weight { get; set; }

        // URL of the photo of the wildlife creature
        public string PhotoUrl { get; set; }

        // Habitat of the wildlife creature
        public string Habitat { get; set; }

        // Current population count of the wildlife creature
        public int CurrentPopulation { get; set; }
    }
}
