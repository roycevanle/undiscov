using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class accInfo
    {
        public string emailAddress { get; set; }
        public string password { get; set; }
        public string birthDay { get; set; }
        public string birthMonth { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string addressLine1 { get; set; }
        public string city { get; set; }
        public string countrySubdivision { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
    }
}