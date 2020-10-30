using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private readonly int MIN_PER_KM_COST;
        private readonly int COST_PER_TIME;
        private readonly int MIN_FARE;
        private RideType rideType;

        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            try {
                if (rideType.Equals(RideType.NORMAL)) {
                    MIN_PER_KM_COST = 10;
                    COST_PER_TIME = 1;
                    MIN_FARE = 5;

                }
            }
            catch (CabInvoiceCustomException) {
                throw new CabInvoiceCustomException("Invalid ride",CabInvoiceCustomException.Exception.INVALID_RIDE_TYPE);
            }
        }
        public double CalculateFare(double distance, int time) {
            double totalFare = 0;
            try
            {
                
                totalFare = MIN_PER_KM_COST * distance + time * COST_PER_TIME;
            }
            catch (CabInvoiceCustomException) {
                if (rideType.Equals(null)) {
                    throw new CabInvoiceCustomException("Invalid ride", CabInvoiceCustomException.Exception.INVALID_RIDE_TYPE);
                }
                if (distance == 0) {
                    throw new CabInvoiceCustomException("Invalid distance", CabInvoiceCustomException.Exception.INVALID_DISTANCE);
                }
                if (time == 0) {
                    throw new CabInvoiceCustomException("Invalid time", CabInvoiceCustomException.Exception.INVALID_TIME);
                }
            }
            return Math.Max(MIN_FARE, totalFare);

        }
    }
}
