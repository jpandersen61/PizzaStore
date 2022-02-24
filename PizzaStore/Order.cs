using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order
    {
        double _taxPct;
        double _deliveryCosts;
        Pizza p;

        public Order()
        {
            p = new Pizza();
            TaxPct = 0.0;
            DeliveryCosts = 0.0;
        }

        double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }

        double DeliveryCosts
        {
            get { return _deliveryCosts; }
            set { _deliveryCosts = value; }
        }

        public override string ToString()
        {
            return $"Pizza: {p.Name} - TaxPct: {TaxPct} - Delivery cost: {DeliveryCosts} - Total: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return p.Price * (1 + TaxPct / 100) + DeliveryCosts;
        }
    }
}
