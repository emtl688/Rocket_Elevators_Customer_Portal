namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Intervention
    {

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CustomerId { get; set; }
        public int BuildingId { get; set; }
        public int BatteryId { get; set; }
        public int ColumnId { get; set; }
        public int ElevatorId { get; set; }
        public int EmployeeId { get; set; }
        public string Report { get; set; }

    }
}
