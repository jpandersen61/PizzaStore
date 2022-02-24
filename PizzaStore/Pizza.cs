using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza
    {
        string _name;
        int _price;

        public Pizza()
        {
            _name = "";
            _price = 0;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price}";
        }
    }
}
