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
            var categoryList = GetCategories();
            var product = new Product();
            product.Categories = categoryList;
            return product;
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
            _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
                new { name = productToInsert.Name, price = productToInsert.Price, categoryID = productToInsert.CategoryID });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }


        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }



    }//class
}//namespace
