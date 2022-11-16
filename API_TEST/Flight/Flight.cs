using System.Dynamic;
using System.Runtime.Intrinsics.Arm;

namespace API_TEST.Flight
{
    public class IFlight
    {
        public string? ID { get; set; }
        public double AveragePrice { get; set; }
        public string CurrencySymbol { get; set; }
        public Segment[] Segments { get; set; }

        public class Segment
        {
            public double SegmentDuration { get; set; }
            public string ValidatingCarrier { get; set; }
            public FlightLeg[] Legs { get; set; }

            public Segment(dynamic seg)
            {
                SegmentDuration = seg.SegmentDuration;
                ValidatingCarrier = seg.ValidatingCarrier;


                for (int i = 0; i < seg.Legs.Count; i++)
                {
                    if (Legs != null) Legs[i] = new FlightLeg(seg.Legs[i]);

                    //Legs[i] = new FlightLeg(seg.Legs[i]);
                }

            }
        }


        public IFlight(dynamic flight)
        {
            ID = flight.ID.ToString();
            AveragePrice = flight.AveragePrice;
            CurrencySymbol = flight.CurrencySymbol;

            for (int i = 0; i < flight.Segments.Count; i++)
            {
                if (Segments != null) Segments[i] = new Segment(flight.Segments[i]);
                //Segments[i] = new Segment(flight.Segments[i]);
            }
        }

    }


}
