using MoneySaver.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace MoneySaver.Controller
{
    public class TransactionController
    {
        public BindingList<Transaction> Items = new BindingList<Transaction>();

        public TransactionController()
        {
            // Test
            for (int i = 0; i < 5; i++)
            {
                AddTransaction( new Transaction() { 
                    Name = $"Példa {i}", 
                    Details = $"Leírás {i}", 
                    Person = $"Személy_{i}", 
                    Value = Convert.ToDecimal(i) * 1200 + 1
                });
            }
            for (int i = 0; i < 2; i++)
            {
                AddTransaction(new Transaction()
                {
                    Name = $"Példa {i}",
                    Details = $"Leírás {i}",
                    Person = $"Személy_{i}",
                    Value = Convert.ToDecimal(i) * -1200 + -1
                });
            }
        }

        public BindingList<Transaction> GetItems()
        {
            return Items;
        }

        public void AddTransaction(Transaction transaction)
        {
            Items.Add(transaction);
        }

        public int GetSavings()
        {
            decimal savings = 0.0m;
            foreach (Transaction transaction in Items)
            {
                savings += transaction.Value;
            }
            return Convert.ToInt32(savings);
        }
    }
}
