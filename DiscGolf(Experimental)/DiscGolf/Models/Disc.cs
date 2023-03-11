using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace InnovaDiscs.Models
{
    public class Disc
    {
        public ICollection<InTheBag> InTheBags { get; set; }

        [Key]
        public int DiscId { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Type { get; set; } = null!;


        public int SpeedInt { get; set; }
        
        public int GlideInt { get; set;}
        
        public int TurnInt { get; set;}
        
        public int FadeInt { get; set;}
        

    }
}
