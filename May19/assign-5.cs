// create Product class
using System.ComponentModel;

namespace WebApplication7.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }   
    }   
}
// create controller

//initial create
//Add-Migration -Name RelationshipMigration -Context WebApplication7Context
//Update-Database -Migration RelationshipMigration -Context WebApplication7Context

// add Category
using System.ComponentModel;

namespace WebApplication7.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }   
        public Category Category{get;set;}
    }
    public class Category
    {
        public int CategoryId{get;set;}
        public string CategoryName{get;set;}
        public ICollection<product> Products {get; set;}
    } 
}
// add this commands
//Add-Migration -Name RemoveCategoryMigration -Context WebApplication7Context
//Update-Database -Migration RemoveCategoryMigration -Context WebApplication7Context
// remove category class
using System.ComponentModel;

namespace WebApplication7.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }   
    }   
}
//Add-Migration -Name RemoveCategoryMigration -Context WebApplication7Context
//Update-Database -Migration RemoveCategoryMigration -Context WebApplication7Context