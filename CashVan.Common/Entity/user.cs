using System;
using System.Collections.Generic;
using System.Text;

namespace CashVan.Common.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string TelephoneNumber { get; set; }
        public string ImageProfile { get; set; }
        public string UniqueCode { get; set; }
        public string MarketingCode { get; set; }
        public string UserMarketingCode { get; set; }
        public string DeciveId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string OTPCode { get; set; }
        public bool Active { get; set; }
    }
}
