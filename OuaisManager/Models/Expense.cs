using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuaisManager.Models
{
    public class Expense
    {
        private int _id;
        private float _amount;
        private string _name;
        private DateTime _datetime;
        private int _category_id;

        public int Id { get => _id; 
            set {
                if (value.GetType() != typeof(int) || value < 0)
                {
                    throw new ArgumentException("Expense id must be integer positive number");
                }
                _id = value;
            } 
        }
        public float Amount { get => _amount; 
            set { 
                if (value.GetType() != typeof(float) || value < 0)
                {
                    throw new ArgumentException("Expense amount must be a positive number");
                }
                _amount = value;
            }
        }
        public string Name { get => _name; 
            set  { 
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Expense name must not be empty");
                }
                _name = value; 
            } 
        }
        public DateTime Datetime {
            get => _datetime;
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException("Expense date cannot be in the future");
                _datetime = value;
            }
        }

        public int Category_id
        {
            get => _category_id;
            set
            {
                if (value.GetType() != typeof(int) || value < 0)
                    throw new ArgumentException("Category id must be a positive number");
                _category_id = value;
            }
        }
    }
}
