using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet7
{
    public class Expenses

    {
        public static Random rng = new Random();
        public static string[] categories = new string[] { "travel ", "Entertainment", "Office" };

        private decimal _Amount;

        public decimal _Cost
        {
            get { return _Amount; }
            set
            {

                _Amount = value;
            }
        }

        public string Category { get; set; }
        public DateTime Date { get; set; }
        //public decimal Cost { get; set; }

        public static decimal totalexpense;

        public Expenses(string category, decimal amount,DateTime date)
        {
            Category = category;
            _Cost = amount;
            Date = date;

            totalexpense += amount;
        }

        //Method
        public override string ToString()
        {
            return $"{Category} {_Cost:C} on {Date.ToShortDateString()}";
        }

        public static Expenses GerneratorRandomExpense()
        {
            return new Expenses(categories[rng.Next(0, categories.Length)], rng.Next(1, 100), new DateTime(2019, 11, rng.Next(1, 30)));
        }
    }
}
