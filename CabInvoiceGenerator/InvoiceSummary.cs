using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int length;
        private double totalFare;
        private double averageFare;

        public InvoiceSummary(int length, double totalFare,double averageFare)
        {
            this.length = length;
            this.totalFare = totalFare;
            this.averageFare = averageFare;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary invoiceObject = (InvoiceSummary)obj;
            return this.totalFare == invoiceObject.totalFare && this.length==invoiceObject.length && this.averageFare==invoiceObject.averageFare;
        }
        public override int GetHashCode()
        {
            var res1 = this.length.GetHashCode();
            var res2 = this.totalFare.GetHashCode();
            var res3 = this.averageFare.GetHashCode();
            return res1 * res2*res3;
        }
    }
}
