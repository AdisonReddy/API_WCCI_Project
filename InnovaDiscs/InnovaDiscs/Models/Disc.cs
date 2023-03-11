using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnovaDiscs.Models
{
    public class Disc
    {

        [Key]
        public int Id { get; set; }


        [StringLength(50)]
        public string Brand { get; set; } = null!;

        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(50)]
        public string Type { get; set; } = null!;



        public int SpeedInt { get; set; }

        public int GlideInt { get; set; }

        public int TurnInt { get; set; }

        public int FadeInt { get; set; }

        
    }
}
