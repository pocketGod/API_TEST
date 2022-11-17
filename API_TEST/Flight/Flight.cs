using System.Dynamic;
using System.Runtime.Intrinsics.Arm;

namespace API_TEST.Flight
{
    public class IFlight
    {
        public string? ID { get; set; }
        public double AveragePrice { get; set; }
        public string CurrencySymbol { get; set; }
        public List<Segment> Segments { get; set; }



        public class Segment
        {
            public double SegmentDuration { get; set; }
            public string ValidatingCarrier { get; set; }
            public List<FlightLeg> Legs { get; set; }


            //segment constructor
            public Segment(dynamic seg)
            {
                SegmentDuration = seg.SegmentDuration;
                ValidatingCarrier = seg.ValidatingCarrier;

                Legs = new List<FlightLeg>();

                for (int i = 0; i < seg.Legs.Count; i++)
                {
                    Legs.Add(new FlightLeg(seg.Legs[i]));
                }

            }
        }

        //IFlight constructor
        public IFlight(dynamic flight)
        {

            ID = flight.ID;
            AveragePrice = flight.AveragePrice;
            CurrencySymbol = flight.CurrencySymbol;

            Segments = new List<Segment>();

            for (int i = 0; i < flight.Segments.Count; i++)
            {
                Segments.Add(new Segment(flight.Segments[i]));
            }

        }

    }


}
