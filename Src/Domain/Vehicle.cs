using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonExample.Domain
{
    //"internal" = pubblica dentro il domain, ma non accessibile fuori dal domain
    public class Vehicle
    {
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public string LicensePlate { get; private set; }
        public int OdometerKm
        {
            get { return _odometerKm; }
            private set
            {
                if (value < 0) throw new ArgumentException("OdometerKm cannot be negative.");

                _odometerKm = value;
            }
        }
        public double DailyRate { get; private set; }
        public double FuelLevelPercentage { get; private set; }
        /// <summary>
        /// metodo costruttore
        /// </summary>
        /// <param name="licensePlate"></param>
        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        {

        }

        

    }
}
