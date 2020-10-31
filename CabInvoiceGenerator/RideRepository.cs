using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CabInvoiceGenerator
{
   public class RideRepository
    {
        public static Dictionary<string, Ride> rideList = new Dictionary<string, Ride>();
        /// Reads the data from the exisiting ride repository and stores them in a dictionary.
        /// The method returns the dictionary
        public static Dictionary<string, Ride> GetRideList()
        {
            string filePath = @"E:\C# projects\CabInvoiceGenerator\CabInvoiceGenerator\RideRepository.txt";
            string[] repository = File.ReadAllLines(filePath);
            foreach (string data in repository.Skip(1))
            {
                string[] column = data.Split(",");
                rideList.Add(column[0], new Ride(column[1], column[2]));

            }
            return rideList.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
