using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    
   
    public class ProdAddress
    {
     
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public int postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
    }

    public class Supplier
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public ProdAddress address { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Products
    {
       
        public int id { get; set; }
        public string name { get; set; }

        //  public int supplierId { get; set; }
        //  public int categoryId { get; set; }
        public string quantityPerUnit { get; set; }
        public double unitPrice { get; set; }
        public int unitsInStock { get; set; }
        public int unitsOnOrder { get; set; }
        public int reorderLevel { get; set; }
        public bool discontinued { get; set; }
        
      //  public Supplier supplier { get; set; }
      //  public Category category { get; set; }
    }


}
