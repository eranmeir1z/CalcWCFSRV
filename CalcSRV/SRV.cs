using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalcSRV.models;

namespace CalcSRV
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SRV" in both code and config file together.
    public class SRV : ISRV
    {
        public double GetDis(double sourceLng, double sourceLat, double toLng, double toLat)
        {
            List<Distance> distances = new List<Distance>();

            GeoCoordinate source = new GeoCoordinate(sourceLng, sourceLat);
            GeoCoordinate to = new GeoCoordinate(toLng, toLat);

            // calculate the distance between
            // return result in meters
            double distanceBetween = source.GetDistanceTo(to);

            return distanceBetween;
        }
    }
}
