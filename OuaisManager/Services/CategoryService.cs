using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using OuaisManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OuaisManager.Services
{
    public class CategoryService
    {
        static public List<Category> GetCategories(MySqlConnection conn)
        {
            var listCategories = new List<Category>();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT id, name FROM Category";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listCategories.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1) 
                });
            }
            return listCategories ?? new List<Category>();
        }

        static public Category? GetCategory(MySqlConnection conn, int idCategory) 
        {
            Category categoryRetourner = new Category();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT id, name FROM Category WHERE id = @idCategory";
            command.Parameters.AddWithValue("@idCategory", idCategory);
            var reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                categoryRetourner.Id = reader.GetInt32(0);
                categoryRetourner.Name = reader.GetString(1);
            }
            return categoryRetourner ?? null;
        }

        static public void InsertCategory(MySqlConnection conn, Category category)
        {
            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Category (name) VALUES (@Name)";
            command.Parameters.AddWithValue("@Name", category.Name);
            command.ExecuteNonQuery();
        }

        static public void DeleteCategory(MySqlConnection conn, int idCategory) 
        {
            var command = conn.CreateCommand();
            command.CommandText = "DELETE Category WHERE id = @idCategory";
            command.Parameters.AddWithValue("@idCategory", idCategory);
            command.ExecuteNonQuery();
        }
    }
}
