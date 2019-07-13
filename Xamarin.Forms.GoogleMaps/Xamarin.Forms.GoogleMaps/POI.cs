using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.GoogleMaps {
    public class POI {
        public Position Position { get; set; }
        public string Name { get; set; }
        public string PlaceId { get; set; }
        public POI(Position point, string placeId, string name) {
            this.Position = point;
            this.PlaceId = placeId;
            this.Name = name;
        }
    }
}
