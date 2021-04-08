using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Battery
    {
        public int Id { get; set; }
        public string CertificateOfOperations { get; set; }
        public string Information { get; set; }
        public int BuildingId { get; set; }
        public string Status { get; set; }
        public List<Column> Columns { get; set; }
    }
}