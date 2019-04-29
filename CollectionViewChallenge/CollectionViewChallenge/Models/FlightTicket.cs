using System;
namespace CollectionViewChallenge.Models {
    public class FlightTicket {
        public string BoardingTime { get; set; }
        public string DepartureTime { get; set; }
        public string BoardingAirport { get; set; }
        public string DepartureAirport { get; set; }
        public string FlightTime { get; set; }
        public int Stops { get; set; }
        public long Price { get; set; }
        public long PriceCoret {
            get {
                return Price + 100000;
            }
        }
        public string AirlineLogo { get; set; }
        public bool IsHeader { get; set; }
        public bool IsFooter { get; set; }
        public bool IsTicket { get; set; }
    }
}
