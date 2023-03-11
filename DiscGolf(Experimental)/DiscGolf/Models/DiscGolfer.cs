using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace InnovaDiscs.Models
{
    public class DiscGolfer
    {
        public ICollection<InTheBag> InTheBags { get; set; }

        [Key]
        public int DiscGolferId { get; set; }

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
