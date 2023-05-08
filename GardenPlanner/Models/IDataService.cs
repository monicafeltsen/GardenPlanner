using GardenPlanner.Views.Plant;

namespace GardenPlanner.Models
{
    public interface IDataService
    {
        void Add(CreatePlant plant);
        void DeletePlant(int id);
        List<ListPlant> GetAll();
        List<ListPlant> GetByMonth(int month);

        Plant GetPlant(int id);
        void UpdatePlant(Plant plant);
    }
}
