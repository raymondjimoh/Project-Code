using jtrak_247.Models;
using System.Collections.Generic;

namespace jtrak_247.Repositories
{
    public class EquipmentRepository
    {
        public List<Equipment> GetAll()
        {
            return new List<Equipment>
            {
                new Equipment { Id = 9938, Name = "Ladder"},
                new Equipment { Id = 1882, Name = "Safety Goggles"},
                new Equipment { Id = 2349, Name = "Hand Saw"},
                new Equipment { Id = 2034, Name = "Sling"},
                new Equipment { Id = 3964, Name = "Boots"}
            };
        }
    }
}