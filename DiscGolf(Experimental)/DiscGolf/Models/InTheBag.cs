using System.ComponentModel.DataAnnotations.Schema;

namespace InnovaDiscs.Models
{
    public class InTheBag
    {
       
        [ForeignKey("DiscGolfer")]
        public int GolferId { get; set; }
        public DiscGolfer DiscGolfer { get; set; } = null!;

        
        [ForeignKey("Disc")]
        public int DiscId { get; set; }
        public Disc Disc { get; set; } = null!;
    }
}
