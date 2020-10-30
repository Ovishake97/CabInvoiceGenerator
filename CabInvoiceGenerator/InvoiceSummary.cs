using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int length;
        private double totalFare;

        public InvoiceSummary(int length, double totalFare)
        {
            this.length = length;
            this.totalFare = totalFare;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary invoiceObject = (InvoiceSummary)obj;
            return this.totalFare == invoiceObject.totalFare && this.length==invoiceObject.length;
        }
        public override int GetHashCode()
        {
            var res1 = this.length.GetHashCode();
            var res2 = this.totalFare.GetHashCode();
            return res1 * res2;
        }
    }
}
