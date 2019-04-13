using CalcSRV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcSRV
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISRV" in both code and config file together.
    [ServiceContract(Name = "ISRV")]
    public interface ISRV
    {
        [OperationContract(Name = "GetDis")]
        double GetDis(double sourceLng, double sourceLat, double toLng, double toLat);
    }
}
