using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class SuppAddress
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public object postalCode { get; set; }
        public string country { get; set; }
        public object phone { get; set; }
    }

    public class Suppliers
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public SuppAddress address { get; set; }
    }
}
