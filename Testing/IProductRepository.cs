using System;
using System.Collections.Generic;
using System.ComponentModel;
using Testing.Models;


namespace Testing
{
    //Step #8
    public interface IProductRepository
    {

        //Stubbed out method
        public IEnumerable<Product> GetAllProducts();


        public Product GetProduct(int id);

        public void UpdateProduct(Product product);
        //{
        //    _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
        //     new { name = product.Name, price = product.Price, id = product.ProductID });
        //}

        public Product AssignCategory();

        public IEnumerable<Category> GetCategories();

        public void InsertProduct(Product productToInsert);


        public void DeleteProduct(Product product);



    }//Interface

    internal class _conn
    {
        internal static void Execute(string v, object value)
        {
            throw new NotImplementedException();
        }




    }
}//namespace

