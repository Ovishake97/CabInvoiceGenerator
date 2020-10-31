using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;

        public Ride(string distance, string time)
        {
            this.distance = Convert.ToDouble(distance);
            this.time = Convert.ToInt32(time);
        }
    }
}
