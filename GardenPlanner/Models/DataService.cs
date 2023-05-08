using GardenPlanner.Views.Plant;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GardenPlanner.Models
{
    public class DataService : IDataService
    {

        private readonly ApplicationContext context;
        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public void Add(CreatePlant plant)
        {
            context.Plants.Add(new Plant
            {
                Name = plant.Name,
                Decorative = plant.Decorative,
                Eatable = plant.Eatable,
                Greenhouse = plant.Greenhouse,
                Month = plant.Month
            });
            context.SaveChanges();
        }

        public List<ListPlant> GetAll()
        {
            return context.Plants.Select(p => new ListPlant
            {
                Decorative= p.Decorative,
                Greenhouse= p.Greenhouse,
                Month= p.Month,
                Eatable= p.Eatable,
                Name= p.Name,
                Id= p.Id                     
            }).ToList();
        }

        public List<ListPlant> GetByMonth(int month)
        {
            return context.Plants.Where(p => p.Month == month).Select(p => new ListPlant
            {
                Decorative = p.Decorative,
                Greenhouse = p.Greenhouse,
                Month = p.Month,
                Eatable = p.Eatable,
                Name = p.Name,
                Id = p.Id
            }).ToList();
        }

        //Edit
        public Plant GetPlant(int id)
        {
            return context.Plants.SingleOrDefault(d => d.Id == id);
        }

        public void UpdatePlant(Plant plant)
        {
            var existing = context.Plants.FirstOrDefault(d => d.Id == plant.Id);
            existing.Name = plant.Name;
            existing.Greenhouse = plant.Greenhouse;
            existing.Month = plant.Month;
            existing.Eatable = plant.Eatable;
            existing.Decorative= plant.Decorative;
            context.SaveChanges();

        }

        //Delete
        public void DeletePlant(int id)
        {
            var q = context.Plants.SingleOrDefault(d => d.Id == id);
            context.Plants.Remove(q);
            context.SaveChanges();
        }
    }
}
