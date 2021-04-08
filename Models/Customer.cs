using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FullNameOfCompanyContact { get; set; }
        public string CompanyContactPhone { get; set; }
        public string EmailOfCompanyContact { get; set; }
        public string CompanyDescription { get; set; }
        public string FullNameOfServiceTechnicalAuthority { get; set; }
        public string TechnicalAuthorityPhoneForService { get; set; }
        public string TechnicalManagerEmailForService { get; set; }
        public List<Building> Buildings { get; set; }
    }
}