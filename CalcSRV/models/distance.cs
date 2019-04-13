using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalcSRV.models
{
    [DataContract]
    public class Distance
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double DistanceInMeters { get; set; }
    }
}
