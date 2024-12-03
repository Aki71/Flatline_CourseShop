using System.ComponentModel.DataAnnotations;

namespace Flatline_CourseShop.Models
{
    public class Predavac
    {
        [Key]
        public Guid PrdavacId { get; set; }

        public string ImePredavaca { get; set; }

        public ICollection<Predavac> Predavaci { get; set; }
    }
}
