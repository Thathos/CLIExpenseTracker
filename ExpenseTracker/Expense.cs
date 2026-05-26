using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class Expense
    {
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }

        public int Id { get; set; }

        public Expense(string name, decimal amount, int id)
        {
            Name = name;
            Amount = amount;
            Id = id;
        }
    }
}
