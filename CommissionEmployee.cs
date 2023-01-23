using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)CommissionPercentaje * Sales;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentaje:...{$"{CommissionPercentaje:P2}",18}"+
                $"\n\tSales:...................{$"{Sales:C2}",18}"+
                $"\n\tValue to pay:............{$"{GetValueToPay():C2}",18}";
        }
    }
}
