using System.ComponentModel.DataAnnotations;

namespace InnovaDiscs.Models
{
    public class DiscGolfer
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Team { get; set; } = null!;



    }
}
