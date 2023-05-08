

namespace GardenPlanner.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
        public int Month { get; set; }
        public bool Eatable { get; set; }
        public bool Decorative { get; set; }
        public bool Greenhouse { get; set; }
    
}
}
