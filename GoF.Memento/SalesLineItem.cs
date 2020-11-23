using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Memento
{
    /// <summary>

    /// The 'Originator' class

    /// </summary>
    public class SalesLineItem
    {
        private string _name;
        private string _price;
        private int _amount;

        // Gets or sets name

        public string Name
        {
            get { return _name; }
            set

            {
                _name = value;
                Console.WriteLine("Name:  " + _name);
            }
        }

        // Gets or sets phone

        public string Price
        {
            get { return _price; }
            set

            {
                _price = value;
                Console.WriteLine("Price: " + _price + ".-");
            }
        }

        // Gets or sets budget

        public int Amount
        {
            get { return _amount; }
            set

            {
                _amount = value;
                Console.WriteLine("Amount: " + _amount);
            }
        }

        // Stores memento

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(_name, _price, _amount);
        }

        // Restores memento

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Price = memento.Price;
            this.Amount = memento.Amount;
        }
    }
}
