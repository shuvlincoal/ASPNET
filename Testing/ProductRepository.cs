using Dapper;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    //Step #9
    public class ProductRepository : IProductRepository
    {

        //field
        private readonly IDbConnection _conn;

        //Constructor
        public ProductRepository(IDbConnection conn)
        {

            _conn = conn;

        }

        public Product AssignCategory()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        //Method
        public IEnumerable<Product> GetAllProducts()
        {

            return _conn.Query<Product>("SELECT * from PRODUCTS;");

        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id = id });
        }

        public void InsertProduct(Product productToInsert)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }//class
}//namespace
