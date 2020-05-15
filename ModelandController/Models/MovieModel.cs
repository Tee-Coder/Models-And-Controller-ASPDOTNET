using System;
using System.ComponentModel.DataAnnotations;

namespace model_controller_assignment.Models
{
    public class MovieModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string PremierDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string LeadActor { get; set; }

    }
}