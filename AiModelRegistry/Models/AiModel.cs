using System.ComponentModel.DataAnnotations;

namespace AiModelRegistry.Models
{
    public class AiModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Model Name")]
        public string ModelName { get; set; }

        [Required]
        public string Version { get; set; }

        [Required]
        public string Algorithm { get; set; }

        [Display(Name = "Accuracy (%)")]
        [Range(0, 100)]
        public double Accuracy { get; set; }

        [Required]
        public string Status { get; set; }

        public string Description { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
