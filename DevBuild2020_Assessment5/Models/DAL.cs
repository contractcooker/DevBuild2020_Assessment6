using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuild2020_Assessment5.Models
{
    public class DAL
    {
        SqlConnection connection;

        public DAL (string connectionString)
        {
            connection = new SqlConnection(connectionString);
            //TODO: close the connection!!!
        }
        //TODO: Use try/catches around these!
        /*public IEnumerable<RsvpForm> GetProductCategories()
        {
            string queryString = "SELECT DISTINCT Category FROM Products";
            IEnumerable<RsvpForm> Products = connection.Query<RsvpForm>(queryString);

            return Products;
        }
        
        public IEnumerable<RsvpForm> GetProductsAll()
        {
            string queryString = "SELECT * FROM Party";
            IEnumerable<RsvpForm> rsvpForms = connection.Query<RsvpForm>(queryString);

            return rsvpForms;
        }
        
        public Product GetProductById (int id)
        {
            string queryString = "SELECT * FROM Products WHERE Id = @val";
            Product prod = connection.QueryFirstOrDefault<Product>(queryString, new { val = id });

            return prod;
        }

        public IEnumerable<Product> GetProductsInCategory(string cat)
        {
            string queryString = "SELECT * FROM Products WHERE Category = @val";
            IEnumerable<Product> Products = connection.Query<Product>(queryString, new { val = cat });

            return Products;
        }
        */
        public int CreateProduct(RsvpForm prod)
        {
            
            string addString = "INSERT INTO Guest (FirstName, LastName, AttendanceDate, EmailAddress, Guest) ";
            addString += "VALUES (@FirstName, @LastName, @AttendanceDate, @EmailAddress, @Guest)";
            return connection.Execute(addString, prod);
        }

        public IEnumerable<DishForm> GetAllDishes()
        {
            string queryString = "SELECT * FROM Dish";
            IEnumerable<DishForm> Products = connection.Query<DishForm>(queryString);

            return Products;
        }

        public int CreateProduct(DishForm prod)
        {

            string addString = "INSERT INTO Dish (PersonName, PhoneNumber, DishName, DishDescription, Selection) ";
            addString += "VALUES (@PersonName, @PhoneNumber, @DishName, @DishDescription, @Selection)";
            return connection.Execute(addString, prod);
        }
        /*
        public int DeleteProductById(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
        }

        public int UpdateProductById(Product prod)
        {
            string editString = "UPDATE Products SET Name = @Name, Description = @Description, ";
            editString += "Category = @Category, Price = @Price WHERE Id = @Id";
            return connection.Execute(editString, prod);
        }
        */
    }
}
