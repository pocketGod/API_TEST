using System.Runtime.Intrinsics.Arm;

namespace API_TEST.Flight
{
    public class FlightLeg
    {
        public class DeparturePoint
        {
            public string AirportName;
            public string AirportCode;
            public string City;
            public string DateTime;

            public DeparturePoint(dynamic dep)
            {
                AirportCode = dep.AirportCode.ToString();
                AirportName= dep.AirportName.ToString();   
                City = dep.City.ToString();
                DateTime = dep.DateTime.ToString();
            }
        }

        public class ArrivalPoint
        {
            public string AirportName;
            public string AirportCode;
            public string City;
            public string DateTime;

            public ArrivalPoint(dynamic arrival)
            {
                AirportCode = arrival.AirportCode.ToString();
                AirportName = arrival.AirportName.ToString();
                City = arrival.City.ToString();
                DateTime = arrival.DateTime.ToString();
            }
        }

        public string FlightNumber;
        public string AirlineName;
        public string AirlineCode;

        public FlightLeg(dynamic leg)
        {
            FlightNumber = leg.FlightNumber;
            AirlineCode= leg.AirlineCode;
            AirlineName= leg.AirlineName;  
            new DeparturePoint(leg.DeparturePoint);
            new ArrivalPoint(leg.ArrivalPoint);

        }
    }
}
