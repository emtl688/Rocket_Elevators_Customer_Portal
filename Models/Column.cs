using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Column
    {
        public int Id { get; set; }
        public int BatteryId { get; set; }
        public string Status { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfFloorsServed { get; set; }
        public List<Elevator> Elevators { get; set; }
    }
}