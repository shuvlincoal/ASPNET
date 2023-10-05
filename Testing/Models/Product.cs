using System.Security.Cryptography.X509Certificates;

namespace Testing.Models
{
    public class Product
    {
        //Step #5
        public Product()
        {

        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }





    }//class
}//namespace

