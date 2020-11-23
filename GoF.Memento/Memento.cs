using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Memento
{
    public class Memento
    {
        private string _name;
        private string _price;
        private int _amount;

        public Memento(string name, string price, int amount)
        {
            this._name = name;
            this._price = price;
            this._amount = amount;

        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Price
        {
            get => _price;
            set => _price = value;
        }

        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }
    }
}
