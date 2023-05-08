using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GardenPlanner.Views.Plant
{
    public class CreatePlant
    {
        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Skriv in ett namn")]
        public string Name { get; set; }

        [Display(Name = "Välj en månad")]
        [Range(1, 12, ErrorMessage = "Ogiltig månad")]
        public int Month { get; set; }
        public bool Eatable { get; set; }
        public bool Decorative { get; set; }
        public bool Greenhouse { get; set; }
    }
}
