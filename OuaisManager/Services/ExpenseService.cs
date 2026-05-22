using MySql.Data.MySqlClient;
using OuaisManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuaisManager.Services
{
    public class ExpenseService
    {
        static public List<Expense> GetExpenses(MySqlConnection conn)
        {
            var listExpenses = new List<Expense>();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT id, amount, name, datetime, category_id FROM Expense";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listExpenses.Add(new Expense
                {
                    Id = reader.GetInt32(0),
                    Amount = reader.GetFloat(1),
                    Name = reader.GetString(2),
                    Datetime = reader.GetDateTime(3),
                    Category_id = reader.GetInt32(4)
                });
            }
            return listExpenses ?? new List<Expense>();
        }

        static public Expense? GetExpense(MySqlConnection conn, int idExpense)
        {
            Expense expenseRetourner = new Expense();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT id, amount, name, datetime, category_id FROM Expense WHERE id = @idExpense";
            command.Parameters.AddWithValue("@idExpense", idExpense);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                expenseRetourner.Id = reader.GetInt32(0);
                expenseRetourner.Amount = reader.GetFloat(1);
                expenseRetourner.Name = reader.GetString(2);
                expenseRetourner.Datetime = reader.GetDateTime(3);
                expenseRetourner.Category_id = reader.GetInt32(4);
            }
            return expenseRetourner ?? null;
        }

        static public List<Expense> GetExpensesByCategory(MySqlConnection conn, int idCategory)
        {
            var listExpenses = new List<Expense>();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT id, amount, name, datetime, category_id FROM Expense WHERE category_id = @idCategory";
            command.Parameters.AddWithValue("@idCategory", idCategory);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listExpenses.Add(new Expense
                {
                    Id = reader.GetInt32(0),
                    Amount = reader.GetFloat(1),
                    Name = reader.GetString(2),
                    Datetime = reader.GetDateTime(3),
                    Category_id = reader.GetInt32(4)
                });
            }
            return listExpenses ?? new List<Expense>();
        }

        static public void InsertExpense(MySqlConnection conn, Expense expense)
        {
            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Expense (amount, name, datetime, category_id) VALUES (@Amount, @Name, @Datetime, @CategoryId)";
            command.Parameters.AddWithValue("@Amount", expense.Amount);
            command.Parameters.AddWithValue("@Name", expense.Name);
            command.Parameters.AddWithValue("@Datetime", expense.Datetime);
            command.Parameters.AddWithValue("@CategoryId", expense.Category_id);
            command.ExecuteNonQuery();
        }

        static public void UpdateExpense(MySqlConnection conn, Expense expense)
        {
            var command = conn.CreateCommand();
            command.CommandText = "UPDATE Expense SET amount = @Amount, name = @Name, datetime = @Datetime, category_id = @CategoryId WHERE id = @Id";
            command.Parameters.AddWithValue("@Amount", expense.Amount);
            command.Parameters.AddWithValue("@Name", expense.Name);
            command.Parameters.AddWithValue("@Datetime", expense.Datetime);
            command.Parameters.AddWithValue("@CategoryId", expense.Category_id);
            command.Parameters.AddWithValue("@Id", expense.Id);
            command.ExecuteNonQuery();
        }

        static public void DeleteExpense(MySqlConnection conn, int idExpense)
        {
            var command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Expense WHERE id = @idExpense";
            command.Parameters.AddWithValue("@idExpense", idExpense);
            command.ExecuteNonQuery();
        }
    }
}
