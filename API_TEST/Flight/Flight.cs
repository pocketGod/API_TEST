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


            //segment constructor
            public Segment(dynamic seg)
            {
                SegmentDuration = seg.SegmentDuration;
                ValidatingCarrier = seg.ValidatingCarrier;

                FlightLeg[] Legs = new FlightLeg[seg.Legs.Count];

                for (int i = 0; i < seg.Legs.Count; i++)
                {
                    Legs[i] = new FlightLeg(seg.Legs[i]);
                }

            }
        }

        //IFlight constructor
        public IFlight(dynamic flight)
        {
            ID = flight.ID;
            AveragePrice = flight.AveragePrice;
            CurrencySymbol = flight.CurrencySymbol;

            Segment[] Segments = new Segment[flight.Segments.Count];
            //Segment[] Segments = new Segment[1];
            //Segments[0] = new Segment(flight.Segments[0]);

            for (int i = 0; i < flight.Segments.Count; i++)
            {
                Segments[i] = new Segment(flight.Segments[i]);
            }

        }

    }


}
