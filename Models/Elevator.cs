using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Elevator
    {
        public int Id { get; set; }
        public int ColumnId { get; set; }
        public string Status { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string BuildingType { get; set; }
    }
}