/**
* Fichier de la classe pour les catégorie
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuaisManager.Models
{
    public class Category
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value.GetType() != typeof(int) || value < 0)
                {
                    throw new ArgumentException("Category id must be a integer positive number");
                }
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Category name must not be empty");
                }
                _name = value;
            }
        }
    }
}
