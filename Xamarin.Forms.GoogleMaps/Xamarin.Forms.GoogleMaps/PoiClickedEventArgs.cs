using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.GoogleMaps {
    public sealed class PoiClickedEventArgs : EventArgs {
        public POI Poi { get; }

        internal PoiClickedEventArgs(POI poi) {
            this.Poi = poi;
        }
    }
}