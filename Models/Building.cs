using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Building
    {
        public int id { get; set; }
        public string FullNameOfTheBuildingAdministrator { get; set; }
        public string EmailOfTheAdministratorOfTheBuilding { get; set; }
        public string PhoneNumberOfTheBuildingAdministrator { get; set; }
        public string FullNameOfTheTechnicalContactForTheBuilding { get; set; }
        public string TechnicalContactEmailForTheBuilding { get; set; }
        public string TechnicalContactPhoneForTheBuilding { get; set; }
        public int CustomerId { get; set; }
        public string AddressId { get; set; }
        public List<Battery> Batteries { get; set; }

        //public Customer customer { get; set; }
    }
}