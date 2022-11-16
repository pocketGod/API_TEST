using System.Dynamic;
using System.Runtime.Intrinsics.Arm;

namespace API_TEST.Flight
{
    public class IFlight
    {
        public string? ID;
        public double AveragePrice;
        public string CurrencySymbol;
        public List<Segment> Segments;

        public class Segment
        {
            public double SegmentDuration;
            public string ValidatingCarrier;
            public List<FlightLeg> Legs;

            public Segment(dynamic seg)
            {
                SegmentDuration = seg.SegmentDuration;
                ValidatingCarrier = seg.ValidatingCarrier;
                

                foreach (var leg in seg.Legs)
                {
                    Legs.Add(new FlightLeg(leg));
                }
            }
        }


        public IFlight(dynamic flight)
        {
            ID = flight.ID.ToString();
            AveragePrice = flight.AveragePrice;
            CurrencySymbol = flight.CurrencySymbol;

            foreach (var seg in flight.Segments)
            {
                Segments.Add(new Segment(seg));
            }
        }

        public static implicit operator Flight1(List<Flight1> v)
        {
            throw new NotImplementedException();
        }
    }


}
