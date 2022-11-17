using System.Runtime.Intrinsics.Arm;
using static API_TEST.Flight.FlightLeg;

namespace API_TEST.Flight
{
    public class FlightLeg
    {
        public Station DeparturePoint { get; set; }
        public Station ArrivalPoint { get; set; }

        public string FlightNumber { get; set; }
        public string AirlineName { get; set; }
        public string AirlineCode { get; set; }

        //FlightLeg constructor
        public FlightLeg(dynamic leg)
        {
            FlightNumber = leg.FlightNumber;
            AirlineName = leg.AirlineName;
            AirlineCode = leg.AirlineCode;
            DeparturePoint = new Station(leg.DeparturePoint);
            ArrivalPoint = new Station(leg.ArrivalPoint);
        }
    }

    public class Station
    {
        public string AirportName { get; set; }
        public string AirportCode { get; set; }
        public string City { get; set; }
        public string DateTime { get; set; }

        public Station(dynamic station)
        {
            AirportCode = station.AirportCode;
            AirportName = station.AirportName;
            City = station.City;
            DateTime = station.DateTime;
        }
    }
}
